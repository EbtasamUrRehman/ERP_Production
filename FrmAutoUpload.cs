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

namespace ERP_Production
{
    public partial class FrmAutoUpload : DevExpress.XtraEditors.XtraForm
    {
        public int? Poid { get; private set; }
        public int? PO { get; private set; }
        public int? POH_UPLOAD { get; private set; }
        public int? Po_MUpload  { get; private set; }
        public int? PO_sUpload { get; private set; }


        private int? artSize;
        private string logFilePath;

        public FrmAutoUpload()
        {
            InitializeComponent();
        }
        //private void UploadDataToDatabase()
        //{
        //    // Check if there is a selected worksheet in the spreadsheet control
        //    if (spreadsheetControl1.Document.Worksheets.Count == 0)
        //    {
        //        MessageBox.Show("No worksheet selected. Please select a worksheet before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Access the first worksheet (or handle differently if you want to check for a specifically named or selected worksheet)
        //    Worksheet worksheet = spreadsheetControl1.Document.Worksheets[0];

        //    // Additional validation: Check if the worksheet is empty or has no data
        //    if (worksheet.Rows.LastUsedIndex < 0)
        //    {
        //        MessageBox.Show("The selected worksheet is empty. Please select a worksheet with data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    // Access the first worksheet
        //    //Worksheet worksheet = spreadsheetControl1.Document.Worksheets[0];

        //    // Initialize variables to hold the last processed values
        //    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        //    string errorFolderPath = Path.Combine(desktopPath, "Error");

        //    // Create the Error folder if it doesn't exist
        //    if (!Directory.Exists(errorFolderPath))
        //    {
        //        Directory.CreateDirectory(errorFolderPath);
        //    }

        //    // Define the log file name with date and time
        //    string logFileName = $"MissingDataLog_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
        //    string logFilePath = Path.Combine(errorFolderPath, logFileName);
        //    // Iterate over the rows to read data
        //    for (int row = 1; row <= worksheet.Rows.LastUsedIndex; row++) // assuming first row is headers
        //    {
        //        // MarketPO

        //        // Read data from columns A, B, and C
        //        string ForAccountOf = worksheet.Cells[row, 0].Value.IsEmpty ? "" : worksheet.Cells[row, 0].Value.ToString(); // Column A
        //        string Seller = worksheet.Cells[row, 1].Value.IsEmpty ? "" : worksheet.Cells[row, 1].Value.ToString(); // Column B
        //        string AssignedFactory = worksheet.Cells[row, 2].Value.IsEmpty ? "" : worksheet.Cells[row, 2].Value.ToString(); // Column C
        //        string FectoryCode = worksheet.Cells[row, 3].Value.IsEmpty ? "" : worksheet.Cells[row, 3].Value.ToString();

        //        string PoCode = worksheet.Cells[row, 4].Value.IsEmpty ? "" : worksheet.Cells[row, 4].Value.ToString();
        //        string POLineAggregator = worksheet.Cells[row, 5].Value.IsEmpty ? "" : worksheet.Cells[row, 5].Value.ToString();
        //        int POLineItem = Convert.ToInt32(worksheet.Cells[row, 6].Value?.ToString() ?? "0");
        //        string ArtCode = worksheet.Cells[row, 30].Value.IsEmpty ? "" : worksheet.Cells[row, 30].Value.ToString();
        //        string MarketPO = worksheet.Cells[row, 16].Value.IsEmpty ? "" : worksheet.Cells[row, 16].Value.ToString();
        //        string PlantCode = worksheet.Cells[row, 11].Value.IsEmpty ? "" : worksheet.Cells[row, 11].Value.ToString();
        //        string OrderType = worksheet.Cells[row, 18].Value.IsEmpty ? "" : worksheet.Cells[row, 18].Value.ToString();
        //        string size = worksheet.Cells[row, 48].Value.IsEmpty ? "" : worksheet.Cells[row, 48].Value.ToString();

        //        int TotalQty = Convert.ToInt32(worksheet.Cells[row, 50].Value?.ToString() ?? "0");

        //        string ShipMode = worksheet.Cells[row, 15].Value.IsEmpty ? "" : worksheet.Cells[row, 15].Value.ToString();

        //        DateTime.TryParse(worksheet.Cells[row, 22].Value?.ToString(), out DateTime LastProductionDate);
        //        DateTime.TryParse(worksheet.Cells[row, 23].Value?.ToString(), out DateTime CRD);
        //        DateTime.TryParse(worksheet.Cells[row, 24].Value?.ToString(), out DateTime PlanDate);
        //        DateTime.TryParse(worksheet.Cells[row, 25].Value?.ToString(), out DateTime BatchDate);
        //        DateTime.TryParse(worksheet.Cells[row, 33].Value?.ToString(), out DateTime PSDD);
        //        DateTime.TryParse(worksheet.Cells[row, 34].Value?.ToString(), out DateTime PODD);
        //        DateTime.TryParse(worksheet.Cells[row, 35].Value?.ToString(), out DateTime FPDD);
        //        DateTime.TryParse(worksheet.Cells[row, 36].Value?.ToString(), out DateTime LPD);

        //        // Update the last processed values
        //        if (string.IsNullOrEmpty(ArtCode) || string.IsNullOrEmpty(PoCode) || string.IsNullOrEmpty(OrderType))
        //        {
        //            // Log missing data details to a text file
        //            LogMissingData(row, FectoryCode, PoCode, POLineAggregator, POLineItem, ArtCode, MarketPO, PlantCode, OrderType, size, TotalQty, ShipMode, LastProductionDate, CRD, PlanDate, BatchDate, PSDD, PODD, FPDD, LPD, logFilePath);
        //            continue; // Skip this row and move to the next one
        //        }

        //        if (this.tbl_pro_Article_NNTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_pro_Article_NN, ArtCode) > 0)
        //        {

        //            // Ensure that there is at least one row in the DataTable
        //            if (this.dSPurchaseOrderNew.tbl_pro_Article_NN.Rows.Count > 0)
        //            {
        //                // Access the first row in the DataTable
        //                DataRow firstRow = this.dSPurchaseOrderNew.tbl_pro_Article_NN.Rows[0];

        //                // Access specific columns in the first row and handle potential type conversions
        //                int modelId = Convert.ToInt32(firstRow["ModelID"]);
        //                int artId = Convert.ToInt32(firstRow["ArtID"]);
        //                int Client = Convert.ToInt32(firstRow["ClientID"]);

        //                try
        //                {
        //                    int rowsAffected = this.tbl_Multi_PO_HTableAdapter.Insert(
        //                                           Client, modelId, artId, 0, PoCode, FectoryCode,
        //                                           null, null, null, null, ArtCode, MarketPO
        //                                       );

        //                    // Check if the insert was successful
        //                    if (rowsAffected > 0)
        //                    {
        //                        PO = this.tbl_Multi_PO_HTableAdapter.ScalarQuery(PoCode);
        //                        //MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    }
        //                    else
        //                    {
        //                        //MessageBox.Show("No data was inserted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    }
        //                }

        //                catch (Exception ex)
        //                {
        //                    // Log the exception or handle it as required

        //                    //MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    PO = this.tbl_Multi_PO_HTableAdapter.ScalarQuery(PoCode);

        //                }


        //                // save to Multi_PO_M
        //                ;
        //                bool recordExists = this.tbl_Multi_PO_MTableAdapter.CheckExistence(this.dSPurchaseOrderNew.tbl_Multi_PO_M, (int)PO, POLineAggregator) > 0;

        //                if (!recordExists)
        //                {
        //                    try
        //                    {
        //                        int rowsAffected = this.tbl_Multi_PO_MTableAdapter.Insert(
        //                                               (int)PO, Client, modelId, artId, POLineAggregator, OrderType,
        //                                               null, null, PlantCode, POLineItem, ShipMode, DateTime.Now.Date, CRD,
        //                                               null, LPD, null, LPD, null, null, null, null, null, null,
        //                                               PlanDate, null, null, PSDD, FPDD, PODD, BatchDate
        //                                           );

        //                        // Check if the insert was successful
        //                        if (rowsAffected > 0)
        //                        {
        //                            //Poid = this.tbl_Multi_PO_HTableAdapter.ScalarQuery(PoCode);
        //                            //MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        }
        //                        else
        //                        {
        //                            //MessageBox.Show("No data was inserted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                        }
        //                    }
        //                    catch (Exception ex)
        //                    {
        //                        // Log the exception or handle it as required
        //                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    }
        //                }

        //                {
        //                  var  pom = this.tbl_Multi_PO_MTableAdapter.ScalarQuery((int)PO);
        //                    var artSizeResult = this.tbl_Pro_Article_DTableAdapter.ScalarQuery(size, Client, modelId, artId);

        //                    // Convert the result to string
        //                    string artSize = artSizeResult != null ? artSizeResult.ToString() : null;
        //                    // insert into multi PRO POs
        //                    // Optionally, notify that the record already exists
        //                    bool recordExists1 = this.tbl_Multi_PO_STableAdapter.CheckExistence(this.dSPurchaseOrderNew.tbl_Multi_PO_S, (int)PO, artSize, POLineAggregator) > 0;

        //                    if (!recordExists1)
        //                    {
        //                        try
        //                        {


        //                            int rowsAffected = this.tbl_Multi_PO_STableAdapter.Insert((int)PO, (int)pom,Client,modelId,artId,POLineAggregator, artSize, TotalQty,POLineItem,null,DateTime.Now,null, "Original Order", null,0, OrderType);

        //                            // Check if the insert was successful


        //                            if (rowsAffected > 0)
        //                            {
        //                                //Poid = this.tbl_Multi_PO_HTableAdapter.ScalarQuery(PoCode);
        //                                //MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                            }
        //                            else
        //                            {
        //                                //MessageBox.Show("No data was inserted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                            }
        //                        }
        //                        catch (Exception ex)
        //                        {
        //                            // Log the exception or handle it as required
        //                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                        }

        //                    }



        //                        //MessageBox.Show("The record already exists.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    }

        //            }
        //        }

        //        // Show a message box with the last processed values

        //    }
        //    MessageBox.Show($"Data processing completed. Check the log file at: {logFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //}
        //private void LogMissingData(int row, string factoryCode, string poCode, string poLineAggregator, int poLineItem, string artCode, string marketPO, string plantCode, string orderType, string size, int totalQty, string shipMode, DateTime lastProductionDate, DateTime crd, DateTime planDate, DateTime batchDate, DateTime psdd, DateTime podd, DateTime fpdd, DateTime lpd, string logFilePath)
        //{
        //    using (StreamWriter sw = File.AppendText(logFilePath))
        //    {
        //        sw.WriteLine($"Row {row}: Missing or invalid data detected.");
        //        sw.WriteLine("----");
        //        sw.WriteLine($"FactoryCode: {factoryCode}, PoCode: {poCode}, POLineAggregator: {poLineAggregator}, POLineItem: {poLineItem}");
        //        sw.WriteLine($"ArtCode: {artCode}, MarketPO: {marketPO}, PlantCode: {plantCode}, OrderType: {orderType}, Size: {size}");
        //        sw.WriteLine($"TotalQty: {totalQty}, ShipMode: {shipMode}");
        //        sw.WriteLine($"LastProductionDate: {lastProductionDate}, CRD: {crd}, PlanDate: {planDate}, BatchDate: {batchDate}");
        //        sw.WriteLine($"PSDD: {psdd}, PODD: {podd}, FPDD: {fpdd}, LPD: {lpd}");
        //        sw.WriteLine("---------------------------");
        //    }
        //}

        private void UploadDataToDatabaseWithError()
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
                // Read data from columns A, B, and C
                string ForAccountOf = worksheet.Cells[row, 0].Value.IsEmpty ? "" : worksheet.Cells[row, 0].Value.ToString(); // Column A
                string Seller = worksheet.Cells[row, 1].Value.IsEmpty ? "" : worksheet.Cells[row, 1].Value.ToString(); // Column B
                string AssignedFactory = worksheet.Cells[row, 2].Value.IsEmpty ? "" : worksheet.Cells[row, 2].Value.ToString(); // Column C
                string FectoryCode = worksheet.Cells[row, 3].Value.IsEmpty ? "" : worksheet.Cells[row, 3].Value.ToString();

                string PoCode = worksheet.Cells[row, 4].Value.IsEmpty ? "" : worksheet.Cells[row, 4].Value.ToString();
                string POLineAggregator = worksheet.Cells[row, 5].Value.IsEmpty ? "" : worksheet.Cells[row, 5].Value.ToString();
                int POLineItem = Convert.ToInt32(worksheet.Cells[row, 6].Value?.ToString() ?? "0");
              

                string MarketPO = worksheet.Cells[row, 17].Value.IsEmpty ? "" : worksheet.Cells[row, 17].Value.ToString();
                string PlantCode = worksheet.Cells[row, 12].Value.IsEmpty ? "" : worksheet.Cells[row, 12].Value.ToString();
                string CustomerCode = worksheet.Cells[row, 13].Value.IsEmpty ? "" : worksheet.Cells[row, 13].Value.ToString();
                string GPSCustomer = worksheet.Cells[row, 10].Value.IsEmpty ? "" : worksheet.Cells[row, 10].Value.ToString();
                string CustomerPO = worksheet.Cells[row, 18].Value.IsEmpty ? "" : worksheet.Cells[row, 18].Value.ToString();
                string OrderType = worksheet.Cells[row, 20].Value.IsEmpty ? "" : worksheet.Cells[row, 20].Value.ToString();
                string ShipMode = worksheet.Cells[row, 16].Value.IsEmpty ? "" : worksheet.Cells[row, 16].Value.ToString();

                int TotalQty = Convert.ToInt32(worksheet.Cells[row, 52].Value?.ToString() ?? "0");
                string ArtCode = worksheet.Cells[row, 32].Value.IsEmpty ? "" : worksheet.Cells[row, 32].Value.ToString();
                
                string size = worksheet.Cells[row, 50].Value.IsEmpty ? "" : worksheet.Cells[row, 50].Value.ToString();

                //DateTime.TryParse(worksheet.Cells[row, 38].Value?.ToString(), out DateTime LastProductionDate);
                DateTime.TryParse(worksheet.Cells[row, 25].Value?.ToString(), out DateTime CRD);
                DateTime.TryParse(worksheet.Cells[row, 26].Value?.ToString(), out DateTime PlanDate);
                DateTime.TryParse(worksheet.Cells[row, 27].Value?.ToString(), out DateTime BatchDate);
                DateTime.TryParse(worksheet.Cells[row, 35].Value?.ToString(), out DateTime PSDD);
                DateTime.TryParse(worksheet.Cells[row, 36].Value?.ToString(), out DateTime PODD);
                DateTime.TryParse(worksheet.Cells[row, 37].Value?.ToString(), out DateTime FPDD);
                DateTime.TryParse(worksheet.Cells[row, 38].Value?.ToString(), out DateTime LPD);
                  int UnitPrice;
                if (!int.TryParse(worksheet.Cells[row, 43].Value?.ToString(), out UnitPrice))
                {
                    UnitPrice = 0;  // Default value if the conversion fails
                }
                // Update the last processed values
                if (string.IsNullOrEmpty(ArtCode) || string.IsNullOrEmpty(PoCode) || string.IsNullOrEmpty(OrderType))
                {
                    // Log missing data details to a text file
                    LogMissingData(row, PoCode, POLineAggregator, POLineItem, ArtCode, MarketPO, PlantCode, OrderType, size, TotalQty, ShipMode, CRD, PlanDate, BatchDate, CRD, CRD, FPDD, LPD, logFilePath);
                    continue; // Skip this row and move to the next one
                }

                // Process ArtCode
                try
                {
                    if (this.tbl_pro_Article_NNTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_pro_Article_NN, ArtCode) > 0)
                    {
                        // Ensure that there is at least one row in the DataTable
                        if (this.dSPurchaseOrderNew.tbl_pro_Article_NN.Rows.Count > 0)
                        {
                            // Access the first row in the DataTable
                            DataRow firstRow = this.dSPurchaseOrderNew.tbl_pro_Article_NN.Rows[0];

                            // Access specific columns in the first row and handle potential type conversions
                            int modelId = Convert.ToInt32(firstRow["ModelID"]);
                            int artId = Convert.ToInt32(firstRow["ArtID"]);
                            int Client = Convert.ToInt32(firstRow["ClientID"]);
                            FectoryCode = firstRow["FactoryCode"].ToString();
                            try
                            {
                                int rowsAffected = this.tbl_Multi_PO_HTableAdapter.Insert(
                                                       Client, modelId, artId, 0, PoCode, FectoryCode,
                                                       null, null, null, null, ArtCode, MarketPO
                                                   );

                                // Check if the insert was successful
                                if (rowsAffected > 0)
                                {
                                    PO = this.tbl_Multi_PO_HTableAdapter.ScalarQuery(PoCode);
                                }
                                else
                                {
                                    LogDatabaseError("tbl_Multi_PO_HTableAdapter.Insert", row, PoCode, logFilePath);
                                }
                            }
                            catch (Exception ex)
                            {
                                // Log the exception or handle it as required
                                LogDatabaseError("tbl_Multi_PO_HTableAdapter.Insert", row, PoCode, logFilePath, ex);
                                PO = this.tbl_Multi_PO_HTableAdapter.ScalarQuery(PoCode); // You might want to handle this differently
                            }

                            // Process Multi_PO_M
                            bool recordExists = this.tbl_Multi_PO_MTableAdapter.CheckExistence(this.dSPurchaseOrderNew.tbl_Multi_PO_M, (int)PO, POLineAggregator) > 0;

                            if (!recordExists)
                            {
                                try
                                {
                                    int rowsAffected = this.tbl_Multi_PO_MTableAdapter.Insert(
                                                       (int)PO, Client, modelId, artId, POLineAggregator, OrderType,
                                                       null, null, PlantCode, POLineItem, ShipMode, DateTime.Now.Date, CRD,
                                                       null, LPD, null, LPD, null, null, null, null, null, null,
                                                       PlanDate, null, null, PSDD, FPDD, PODD, BatchDate,CustomerCode,CustomerPO,GPSCustomer
                                                   );

                                    // Check if the insert was successful
                                    if (rowsAffected > 0)
                                    {
                                        // Record inserted successfully
                                    }
                                    else
                                    {
                                        LogDatabaseError("tbl_Multi_PO_MTableAdapter.Insert", row, PoCode, logFilePath);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    // Log the exception or handle it as required
                                    LogDatabaseError("tbl_Multi_PO_MTableAdapter.Insert", row, PoCode, logFilePath, ex);
                                }
                            }

                            // Process Multi_PO_S
                            try
                            {
                                var pom = this.tbl_Multi_PO_MTableAdapter.ScalarQuery((int)PO);
                                var artSizeResult = this.tbl_Pro_Article_DTableAdapter.ScalarQuery(size, Client, modelId, artId);

                                // Convert the result to string
                                string artSize = artSizeResult != null ? artSizeResult.ToString() : null;

                                bool recordExists1 = this.tbl_Multi_PO_STableAdapter.CheckExistence(this.dSPurchaseOrderNew.tbl_Multi_PO_S, (int)PO, artSize, POLineAggregator) > 0;

                                if (!recordExists1)
                                {
                                    int rowsAffected = this.tbl_Multi_PO_STableAdapter.Insert(
                                                       (int)PO, (int)pom, Client, modelId, artId, POLineAggregator, artSize, TotalQty, POLineItem,
                                                       null, DateTime.Now.Date, null, "Original Order", null, 0, OrderType,UnitPrice
                                                   );

                                    // Check if the insert was successful
                                    if (rowsAffected <= 0)
                                    {
                                        LogDatabaseError("tbl_Multi_PO_STableAdapter.Insert", row, PoCode, logFilePath);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                // Log the exception or handle it as required
                                LogDatabaseError("tbl_Multi_PO_STableAdapter.Insert", row, PoCode, logFilePath, ex);
                            }
                        }
                    }
                    else
                    {
                        LogDatabaseError($"An error occurred while processing ArtCode {ArtCode}", row, PoCode, logFilePath);
                    }
                }
                catch (Exception ex)
                {
                    LogDatabaseError($"An error occurred while processing ArtCode {ArtCode}", row, PoCode, logFilePath, ex);
                    // Log the exception or handle it as required
                    //MessageBox.Show($"An error occurred while processing ArtCode {ArtCode}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Update progress bar
                progressBarControl1.EditValue = row;
                progressBarControl1.Update();
            }

            // Complete the progress bar
            progressBarControl1.EditValue = worksheet.Rows.LastUsedIndex + 1; // To set the progress bar to the end
            progressBarControl1.Update();

            MessageBox.Show($"Data processing completed. Check the log file at: {logFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBarControl1.Hide();

        }


        private void LogMissingData(int row, string poCode, string poLineAggregator, int poLineItem, string artCode, string marketPO, string plantCode, string orderType, string size, int totalQty, string shipMode, DateTime crd, DateTime planDate, DateTime batchDate, DateTime psdd, DateTime podd, DateTime fpdd, DateTime lpd, string logFilePath)
        {
            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                sw.WriteLine($"Row {row}: Missing or invalid data detected.");
                sw.WriteLine("----");
                sw.WriteLine($"PoCode: {poCode}, POLineAggregator: {poLineAggregator}, POLineItem: {poLineItem}");
                sw.WriteLine($"ArtCode: {artCode}, MarketPO: {marketPO}, PlantCode: {plantCode}, OrderType: {orderType}, Size: {size}");
                sw.WriteLine($"TotalQty: {totalQty}, ShipMode: {shipMode}");
                sw.WriteLine($" CRD: {crd}, PlanDate: {planDate}, BatchDate: {batchDate}");
                sw.WriteLine($"PSDD: {psdd}, PODD: {podd}, FPDD: {fpdd}, LPD: {lpd}");
                sw.WriteLine("---------------------------");
            }
        }

        private void LogDatabaseError(string methodName, int row, string poCode, string logFilePath, Exception ex = null)
        {
            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                sw.WriteLine($"Error in row {row} PoCode {poCode} with that error'");
                sw.WriteLine($"{methodName}'");
                //sw.WriteLine($" Record is not inserted Error in row {row} with PoCode {poCode}:");
                if (ex != null)
                {
                    //sw.WriteLine($"This Record may b duplicatd or field error ");
                    sw.WriteLine($"{DateTime.Now}: This record may be duplicated or there is a field error.");
                    //sw.WriteLine($"Exception Message: {ex.Message}");
                    //sw.WriteLine($"Stack Trace: {ex.StackTrace}");
                }
                else
                {
                    sw.WriteLine("No rows affected.");
                }
                sw.WriteLine("---------------------------");
            }
        }



        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UploadDataToDatabaseWithError();
            progressBarControl1.Hide();
        }

        private void tbl_Multi_PO_HBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_Multi_PO_HBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPurchaseOrderNew);

        }

        private void FrmAutoUpload_Load(object sender, EventArgs e)
        {
            progressBarControl1.Hide();
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.tbl_Pro_Article_D' table. You can move, or remove it, as needed.
            this.tbl_Pro_Article_DTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Pro_Article_D);
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.tbl_Multi_PO_S' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_STableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Multi_PO_S);
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.tbl_Multi_PO_M' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_MTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Multi_PO_M);
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.tbl_Multi_PO_H' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_HTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Multi_PO_H);

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

            //MessageBox.Show($"Data processing completed. Check the log file at: {logFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UploadDataToDatabaseWithError();
        }

        private void spreadsheetControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UploadDatedataToDatabaseWithError();
        }
    }
}