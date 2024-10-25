using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Production.Purchase_Order
{
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        public void RefreshGrid()
        {
            // Re-fill the data to refresh the GridControl
            this.view_Pro_Customer_MultiLineTableAdapter.Fill(this.dataSet1.View_Pro_Customer_MultiLine);
        }
        private void tbl_Pro_CustomerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_Pro_CustomerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tbl_Pro_Client' table. You can move, or remove it, as needed.
            this.tbl_Pro_ClientTableAdapter.Fill(this.dataSet1.tbl_Pro_Client);
            // TODO: This line of code loads data into the 'dataSet1.tbl_Pro_Country' table. You can move, or remove it, as needed.
            this.tbl_Pro_CountryTableAdapter.Fill(this.dataSet1.tbl_Pro_Country);
            // TODO: This line of code loads data into the 'dataSet1.tbl_Pro_Customer_MultiLine' table. You can move, or remove it, as needed.
            this.tbl_Pro_Customer_MultiLineTableAdapter.Fill(this.dataSet1.tbl_Pro_Customer_MultiLine);
            // TODO: This line of code loads data into the 'dataSet1.View_Pro_Customer_MultiLine' table. You can move, or remove it, as needed.
            this.view_Pro_Customer_MultiLineTableAdapter.Fill(this.dataSet1.View_Pro_Customer_MultiLine);
            // TODO: This line of code loads data into the 'dataSet1.view_CustomerClient' table. You can move, or remove it, as needed.
            this.view_CustomerClientTableAdapter.Fill(this.dataSet1.view_CustomerClient);
            // TODO: This line of code loads data into the 'dataSet1.tbl_Pro_Customer' table. You can move, or remove it, as needed.
            this.tbl_Pro_CustomerTableAdapter.Fill(this.dataSet1.tbl_Pro_Customer);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmAddCustomer form2 = new frmAddCustomer(this);

            // Show the form
            form2.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // Check if there are any selected rows
            if (gridView1.SelectedRowsCount > 0)
            {
                // Get the selected row handle
                int[] selectedRowHandles = gridView1.GetSelectedRows();
                int rowHandle = selectedRowHandles[0]; // Assuming single selection. Adjust if multiple selections are allowed.

                // Get the DataRow from the DataSet corresponding to the selected row
                DataRow row = gridView1.GetDataRow(rowHandle);

                // If the DataRow is not null, proceed
                if (row != null)
                {
                    string customerName = row["CustomerName"].ToString(); // Adjust the column name to your actual customer name column
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete the customer '{customerName}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Iterate through the selected rows and delete them
                        for (int i = selectedRowHandles.Length - 1; i >= 0; i--)
                        {
                            rowHandle = selectedRowHandles[i];
                            if (rowHandle >= 0)
                            {
                                // Get the DataRow from the DataSet corresponding to the selected row
                                row = gridView1.GetDataRow(rowHandle);

                                // If the DataRow is not null, delete it
                                if (row != null)
                                {
                                    int customerId = (int)row["CustID"];
                                    // Delete the row from the database using the TableAdapter
                                    this.view_Pro_Customer_MultiLineTableAdapter.DeleteQuery(customerId);
                                    // Delete the row from the DataSet
                                    row.Delete();
                                }
                            }
                        }

                        // Re-fill the data to refresh the GridControl
                        this.tbl_Pro_Customer_MultiLineTableAdapter.Fill(this.dataSet1.tbl_Pro_Customer_MultiLine);

                        // Show a success message
                        MessageBox.Show("Selected row(s) deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                // Show a message if no rows are selected
                MessageBox.Show("No rows are selected to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

            private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.view_Pro_Customer_MultiLineTableAdapter.Fill(dataSet1.View_Pro_Customer_MultiLine);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {



            this.tbl_Pro_Customer_MultiLineBindingSource.EndEdit();

            // Update the data table using the table adapter
            //try
            //{
            //    // Assuming 'dataSet1.tbl_Pro_Customer_MultiLine' is the DataTable being updated
            //    this.tbl_Pro_Customer_MultiLineTableAdapter.Update(this.dataSet1.tbl_Pro_Customer_MultiLine);

            //    // Notify the user of success
            //    MessageBox.Show("Record is Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    // Refresh the DataTables to reflect the changes
            //    this.tbl_Pro_Customer_MultiLineTableAdapter.Fill(this.dataSet1.tbl_Pro_Customer_MultiLine);
            //    this.view_Pro_Customer_MultiLineTableAdapter.Fill(this.dataSet1.View_Pro_Customer_MultiLine);
            //}
            //catch (Exception ex)
            //{
            //    // Handle any errors that occur during the update
            //    MessageBox.Show($"An error occurred while updating the record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl1.FocusedView;

            if (gridView.SelectedRowsCount > 0)
            {
                var selectedRowHandle = gridView.GetSelectedRows()[0];

                if (selectedRowHandle >= 0)
                {
                    try
                    {


                        int CustID = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "CustID") ?? 0);
                        //int clientId = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ClientName") ?? 0);
                        //int CountryName = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "CountryName") ?? 0);
                        int artId = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ArtID") ?? 0);
                        string BarCode = gridView.GetRowCellValue(selectedRowHandle, "BarCode") as string ?? string.Empty;
                        string PlantCode = gridView.GetRowCellValue(selectedRowHandle, "PlantCode") as string ?? string.Empty;
                        string CompanyCode = gridView.GetRowCellValue(selectedRowHandle, "CompanyCode") as string ?? string.Empty;
                        int POS = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "POS") ?? 0);
                        int PO = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PO") ?? 0);
                        int POM = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "POM") ?? 0);
                        string CustomerName = gridView.GetRowCellValue(selectedRowHandle, "CustomerName") as string ?? string.Empty;
                        int Line = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "Line") ?? 0);

                        this.tbl_Pro_Customer_MultiLineTableAdapter.UpdateQuery( PlantCode, CompanyCode, CustomerName, BarCode, CustID);
                        this.view_Pro_Customer_MultiLineTableAdapter.Fill(this.dataSet1.View_Pro_Customer_MultiLine);
                        MessageBox.Show("Record Updated.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Selected row handle is invalid.");
                }
            }
            else
            {
                MessageBox.Show("No row selected!");
            }

        }
    }
}
