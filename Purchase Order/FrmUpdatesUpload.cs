using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Production.Purchase_Order
{
    public partial class FrmUpdatesUpload : DevExpress.XtraEditors.XtraForm
    {
        private string logFilePath;
        public FrmUpdatesUpload()
        {
            InitializeComponent();
        }

       

        private void UploadDatedataToDatabaseWithError()
        {
            progressBarControl1.Show();
            // Check if there is a selected worksheet in the spreadsheet control
            if (spreadsheetControl1.Document.Worksheets.Count == 0)
            {
                MessageBox.Show("No worksheet selected. Please select a worksheet before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBarControl1.Hide();
                return;

            }

            // Access the first worksheet
            Worksheet worksheet = spreadsheetControl1.Document.Worksheets[0];

            // Additional validation: Check if the worksheet is empty or has no data
            if (worksheet.Rows.LastUsedIndex < 0)
            {
                MessageBox.Show("The selected worksheet is empty. Please select a worksheet with data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBarControl1.Hide();
                return;

            }

            // Initialize variables to hold the last processed values
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string errorFolderPath = Path.Combine(desktopPath, "Error");

            // Create the Error folder if it doesn't exist
            if (!Directory.Exists(errorFolderPath))
            {
                Directory.CreateDirectory(errorFolderPath);
            }

            // Define the log file name with date and time
            string logFileName = $"MissingDataLog_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            string logFilePath = Path.Combine(errorFolderPath, logFileName);

            // Initialize the progress bar
            progressBarControl1.Properties.Minimum = 0;
            progressBarControl1.Properties.Maximum = worksheet.Rows.LastUsedIndex + 1; // +1 to include the header row
            progressBarControl1.Properties.Step = 1;
            progressBarControl1.EditValue = 0;
            progressBarControl1.Update();

            // Iterate over the rows to read data
            for (int row = 1; row <= worksheet.Rows.LastUsedIndex; row++) // assuming first row is headers
            {
                string PoCode = worksheet.Cells[row, 0].Value.IsEmpty ? "" : worksheet.Cells[row, 0].Value.ToString();
                string POLineAggregator = worksheet.Cells[row, 1].Value.IsEmpty ? "" : worksheet.Cells[row, 1].Value.ToString();

                DateTime.TryParse(worksheet.Cells[row, 2].Value?.ToString(), out DateTime PODD);
                DateTime.TryParse(worksheet.Cells[row, 3].Value?.ToString(), out DateTime LPD);

                // Step 1: Get the corresponding PO from Tbl_Multi_PO_H
                int? poId = GetPOFromPoCode(PoCode);

                if (poId != null)
                {
                    // Step 2: Get the corresponding POLineAggregator from Tbl_Multi_PO_M
                    bool recordExists = CheckPOLineAggregatorExists((int)poId, POLineAggregator);

                    if (recordExists)
                    {
                        // Step 3: Update LPD and PODD in Tbl_Multi_PO_M
                        UpdateLPDAndPODD((int)poId, POLineAggregator, LPD, PODD);
                    }
                    else
                    {
                        // Handle missing POLineAggregator
                        LogMissingData(row, PoCode, POLineAggregator, logFilePath);
                    }
                }
                else
                {
                    // Handle missing PoCode
                    LogMissingData(row, PoCode, POLineAggregator, logFilePath);
                }

                // Update progress bar
                progressBarControl1.EditValue = row;
                progressBarControl1.Update();
            }

            // Complete the progress bar
            progressBarControl1.EditValue = worksheet.Rows.LastUsedIndex + 1;
            progressBarControl1.Update();

            MessageBox.Show($"Data processing completed. Check the log file at: {logFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBarControl1.Hide();

            // Complete the progress bar
            progressBarControl1.EditValue = worksheet.Rows.LastUsedIndex + 1; // To set the progress bar to the end
            progressBarControl1.Update();

            MessageBox.Show($"Data processing completed. Check the log file at: {logFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBarControl1.Hide();

        }
        private void UpdateLPDAndPODD(int poId, string poLineAggregator, DateTime lpd, DateTime podd)
        {
            try
            {
                int rowsAffected = this.tbl_Multi_PO_MTableAdapter.UpdatePODDLPD(podd, lpd, poId, poLineAggregator);

                if (rowsAffected > 0)
                {
                    // Success message if needed
                }
                else
                {
                    LogDatabaseError("tbl_Multi_PO_MTableAdapter.UpdateLPDAndPODD", poId, poLineAggregator, logFilePath);
                }
            }
            catch (Exception ex)
            {
                LogDatabaseError("tbl_Multi_PO_MTableAdapter.UpdateLPDAndPODD", poId, poLineAggregator, logFilePath, ex);
            }
        }

        

        private int? GetPOFromPoCode(string poCode)
        {
            try
            {
                int? poId = (int?)this.tbl_Multi_PO_HTableAdapter.ScalarQuery(poCode);
                return poId;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving PO for PoCode: {poCode}. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private bool CheckPOLineAggregatorExists(int poId, string poLineAggregator)
        {
            try
            {
                int count = (int)this.tbl_Multi_PO_MTableAdapter.CheckExistence(this.dSPurchaseOrderNew.tbl_Multi_PO_M, poId, poLineAggregator);
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking POLineAggregator: {poLineAggregator}. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void LogMissingData(int row, string poCode, string poLineAggregator, string logFilePath)
        {
            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                sw.WriteLine($"Row {row}: Missing or invalid data.");
                sw.WriteLine($"PoCode: {poCode}, POLineAggregator: {poLineAggregator}");
                sw.WriteLine("---------------------------");
            }
        }

        private void LogDatabaseError(string methodName, int poId, string poLineAggregator, string logFilePath, Exception ex = null)
        {
            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                sw.WriteLine($"Error in method {methodName} for PoId {poId} and POLineAggregator {poLineAggregator}");
                if (ex != null)
                {
                    sw.WriteLine($"Exception Message: {ex.Message}");
                }
                sw.WriteLine("---------------------------");
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UploadDatedataToDatabaseWithError();
        }

        private void tbl_Multi_PO_HBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_Multi_PO_HBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPurchaseOrderNew);

        }

        private void FrmUpdatesUpload_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.tbl_Multi_PO_M' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_MTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Multi_PO_M);
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.tbl_Multi_PO_H' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_HTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Multi_PO_H);

        }
    }
}