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
    public partial class FrmPurchaseOrderNew : Form
    {
        public FrmPurchaseOrderNew()
        {
            InitializeComponent();
            this.gridLookUpEdit1.GotFocus += new EventHandler(this.gridLookUpEdit1__GotFocus);
        }

        private void tbl_Pro_ClientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_Pro_ClientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPurchaseOrderNew);

        }

        private void FrmPurchaseOrderNew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.tbl_Pro_Article_D_NN' table. You can move, or remove it, as needed.
            this.tbl_Pro_Article_D_NNTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Pro_Article_D_NN);
            gridControl3.Hide();
           
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.View_Multi_PO_Reports' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.View_Multi_PO_MS' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.tbl_Pro_Article_D' table. You can move, or remove it, as needed.
            //this.tbl_Pro_Article_DTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Pro_Article_D);
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.tbl_pro_Article' table. You can move, or remove it, as needed.
            this.tbl_pro_ArticleTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_pro_Article);
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.tbl_Multi_PO_S' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_STableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Multi_PO_S);
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.tbl_Multi_PO_M' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_MTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Multi_PO_M);
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.tbl_Multi_PO_H' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_HTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Multi_PO_H);
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.tbl_Multi_PO_Customer' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_CustomerTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Multi_PO_Customer);
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.tbl_Pro_Client' table. You can move, or remove it, as needed.
            this.tbl_Pro_ClientTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Pro_Client);

            this.view_Multi_PO_MSTableAdapter.Fill(this.dSPurchaseOrderNew.View_Multi_PO_MS, Convert.ToInt32(POCodeComboBox.SelectedValue));
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.View_Multi_PO_H' table. You can move, or remove it, as needed.
            this.view_Multi_PO_HTableAdapter.Fill(this.dSPurchaseOrderNew.View_Multi_PO_H, Convert.ToInt32(ClientID.Text));
        }
        private void ClearFields()
        {

            ModelIDLabel1.Text = string.Empty; // Clear model ID label
            gridLookUpEdit1.EditValue = null; // Clear grid look-up edit
            //gridLookUpEdit2.EditValue = null; // Clear grid look-up edit
            TextEdit3.Text = string.Empty; // Clear text edit
            FectoryCodeEdit2.EditValue = null; // Clear factory code edit
            CustomerOrderNoTextBox.Text = string.Empty; // Clear customer order number text box
        }

        private void gridLookUpEdit1__GotFocus(object sender, EventArgs e)
        {
            try
            {
                // Assuming FectoryCodeEdit2.Text contains the value you want to filter by
                string factoryCode = FectoryCodeEdit2.Text;

                // Properly format the filter expression
                this.tbl_pro_ArticleBindingSource.Filter = $"FactoryCode = '{factoryCode}'";
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the filter application
                DevExpress.XtraEditors.XtraMessageBox.Show($"An error occurred while applying the filter: {ex.Message}", "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Perform the insert operation if TextEdit3 is not empty
                if (TextEdit3.Text.Length > 0 && gridLookUpEdit1.Text.Length > 0)
                {
                    // Fill the DataTable and check if it contains rows
                    if (this.tbl_pro_Article_NNTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_pro_Article_NN, gridLookUpEdit1.Text) > 0)
                    {
                        // Ensure that there is at least one row in the DataTable
                        if (this.dSPurchaseOrderNew.tbl_pro_Article_NN.Rows.Count > 0)
                        {
                            // Access the first row in the DataTable
                            DataRow firstRow = this.dSPurchaseOrderNew.tbl_pro_Article_NN.Rows[0];

                            // Access specific columns in the first row and handle potential type conversions
                            int modelId = Convert.ToInt32(firstRow["ModelID"]);
                            int artId = Convert.ToInt32(firstRow["ArtID"]);

                            // Ensure the values are properly converted and handle possible null values
                            int clientId = Convert.ToInt32(ClientNameComboBox.SelectedValue);
                            int gridValue = 0; // Adjust this if needed, or get it from a control if applicable
                            string textValue = TextEdit3.Text;
                            string factoryCode = FectoryCodeEdit2.EditValue?.ToString(); // Safe conversion
                            string customerOrderNo = CustomerOrderNoTextBox.Text;
                            string gridLookUpValue = gridLookUpEdit1.EditValue?.ToString(); // Safe conversion

                            // Call the Insert method and get the number of rows affected
                            int rowsAffected = this.tbl_Multi_PO_HTableAdapter.Insert(
                                clientId, modelId, artId, gridValue, textValue, factoryCode,
                                null, null, null, null, gridLookUpValue, customerOrderNo
                            );

                            // Check if the insert was successful
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields(); // Uncomment if you want to clear fields after a successful insert

                                // Refresh the data sources and move to the last record
                                this.view_Multi_PO_HTableAdapter.Fill(this.dSPurchaseOrderNew.View_Multi_PO_H, clientId);
                                this.tbl_Multi_PO_HTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Multi_PO_H);
                                this.tbl_Multi_PO_HBindingSource.MoveLast();
                            }
                            else
                            {
                                MessageBox.Show("No data was inserted. Please check your inputs.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No rows found in the DataTable.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No rows returned from the TableAdapter fill operation.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter PO Value.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Optionally clear fields here if needed
                // ClearFields(); // Uncomment if you want to clear fields on error
            }
        }

        private void DataNavigator2_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Custom)
            {
                try
                {
                    // End editing for the binding source

                    this.tbl_Multi_PO_MBindingSource.EndEdit();

                    // Update the data table using the table adapter
                    this.tbl_Multi_PO_MTableAdapter.Update(this.dSPurchaseOrderNew);
                    this.tbl_Multi_PO_MTableAdapter.Fill(dSPurchaseOrderNew.tbl_Multi_PO_M);
                    // Show success message
                    DevExpress.XtraEditors.XtraMessageBox.Show("Operation is completed Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tbl_Multi_PO_MBindingSource.MoveLast();
                    this.view_Multi_PO_MSTableAdapter.Fill(this.dSPurchaseOrderNew.View_Multi_PO_MS, Convert.ToInt32(POCodeComboBox.SelectedValue));
                    //this.tbl_Multi_PO_MBindingSource.MoveLast();
                    // Fill the View_PoNewLa with the selected PO code
                    //view_PoNewLaTableAdapter.Fill(DSPONew1.View_PoNewLa, (int)POCodeComboBox.SelectedValue);

                    // Refresh the data in tbl_PO_New_LA
                   
                }
                catch (Exception ex)
                {
                    // Show error message if something goes wrong
                    DevExpress.XtraEditors.XtraMessageBox.Show("Cannot delete. " + ex.Message, "Delete Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DataNavigator1_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Custom)
            {
                try
                {
                    // End editing for the binding source
                    this.tbl_Multi_PO_SBindingSource.EndEdit();

                    // Update the data table using the table adapter
                    tbl_Multi_PO_STableAdapter.Update(this.dSPurchaseOrderNew);

                    // Show success message
                    DevExpress.XtraEditors.XtraMessageBox.Show("Operation is completed Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Fill the View_PoNewLa with the selected PO code
                    this.view_Multi_PO_MSTableAdapter.Fill(this.dSPurchaseOrderNew.View_Multi_PO_MS, Convert.ToInt32(POCodeComboBox.SelectedValue));
                    //this.view_PoNewLaTableAdapter.Fill(dataSet1.View_PoNewLa, (int)POCodeComboBox.SelectedValue);

                    // Refresh the data in tbl_PO_New_LA
                    tbl_Multi_PO_STableAdapter.Fill(dSPurchaseOrderNew.tbl_Multi_PO_S);
                    //this.view_PoNewLaTableAdapter1.Fill(dataSet1.View_PoNewLa, Convert.ToInt32(POCodeComboBox.SelectedValue));
                }
                catch (Exception ex)
                {
                    // Show error message if something goes wrong
                    DevExpress.XtraEditors.XtraMessageBox.Show("Cannot delete. " + ex.Message, "Delete Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void GridControl1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void repositoryItemButtonEdit3_Click(object sender, EventArgs e)
        {

            var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)GridControl1.FocusedView;

            if (gridView.SelectedRowsCount > 0)
            {
                var selectedRowHandle = gridView.GetSelectedRows()[0];

                if (selectedRowHandle >= 0)
                {
                    try
                    {
                        // Confirm deletion
                        var result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            int PO = gridView.GetRowCellValue(selectedRowHandle, "PO") != DBNull.Value
                                ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PO"))
                                : 0; // Default to 0 or another appropriate value

                            // Fetch MaxPID
                            this.tbl_Multi_PO_HTableAdapter.Delete(PO);

                            MessageBox.Show("Data Deleted successfully!");
                            this.view_Multi_PO_HTableAdapter.Fill(this.dSPurchaseOrderNew.View_Multi_PO_H, Convert.ToInt32(ClientID.Text));
                            this.tbl_Multi_PO_MTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Multi_PO_M);
                        }
                        else
                        {
                          
                        }
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

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClientNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.view_Multi_PO_HTableAdapter.Fill(this.dSPurchaseOrderNew.View_Multi_PO_H, Convert.ToInt32(ClientNameComboBox.SelectedValue));
        }

        private void POCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.view_Multi_PO_MSTableAdapter.Fill(this.dSPurchaseOrderNew.View_Multi_PO_MS, Convert.ToInt32(POCodeComboBox.SelectedValue));
        }

        private void tabNavigationPage4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            {
                // Create an instance of Form1
                Form1 form1 = new Form1();
               
                // Path to your Crystal Report file
                string reportName = @"C:\Users\its-14\Documents\Report1.rpt";
             
                string selectionFormula = ""; // Define any selection formula if needed
                string parameters = ""; // Define parameters in "param1=value1&param2=value2" format
                //form1.ViewReport(reportName, selectionFormula, parameters);
                // Example of how to use ViewReport method to display the report in the CrystalReportViewer
                form1.Show();
                //form1.ViewReport(reportName, selectionFormula, parameters);

                //Example of how to use ViewReport1 method to export to PDF
                //string pdfPath = @"C:\Users\its-14\Documents";
                //string exportedPdfFile = form1.ViewReport1(pdfPath, reportName, selectionFormula, parameters);
                //if (!string.IsNullOrEmpty(exportedPdfFile))
                //{
                //    MessageBox.Show($"Report exported successfully to {exportedPdfFile}");

                //    // Open the exported PDF file
                //    try
                //    {
                //        System.Diagnostics.Process.Start(exportedPdfFile);
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show($"Failed to open PDF file. Error: {ex.Message}");
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Failed to export report.");
                //}
            }
        
    


            if (radioButtonCRD.Checked)
            {
                this.view_Multi_PO_ReportsTableAdapter.FillByCustReqDate(this.dSPurchaseOrderNew.View_Multi_PO_Reports,
                    dateEdit1.DateTime, dateEdit2.DateTime);
            }
            else if (radioButtonPlanDate.Checked)
            {
                this.view_Multi_PO_ReportsTableAdapter.FillByPlanDate(this.dSPurchaseOrderNew.View_Multi_PO_Reports,
                    dateEdit1.DateTime, dateEdit2.DateTime);
            }
            else if (radioButtonEnty.Checked)
            {
                this.view_Multi_PO_ReportsTableAdapter.FillBatch(this.dSPurchaseOrderNew.View_Multi_PO_Reports,
                    dateEdit1.DateTime, dateEdit2.DateTime);
            }
            else if (radioButtonFP.Checked)
            {
                this.view_Multi_PO_ReportsTableAdapter.FillByFPDate(this.dSPurchaseOrderNew.View_Multi_PO_Reports,
                    dateEdit1.DateTime, dateEdit2.DateTime);
            }
            else if (radioButtonLP.Checked)
            {
                this.view_Multi_PO_ReportsTableAdapter.FillByLPDate(this.dSPurchaseOrderNew.View_Multi_PO_Reports,
                    dateEdit1.DateTime, dateEdit2.DateTime);
            }
            else if (radioButtonPOD.Checked)
            {
                this.view_Multi_PO_ReportsTableAdapter.FillPOD(this.dSPurchaseOrderNew.View_Multi_PO_Reports,
                    dateEdit1.DateTime, dateEdit2.DateTime);
            }
            else if (radioButtonPSD.Checked)
            {
                this.view_Multi_PO_ReportsTableAdapter.FillPSDDate(this.dSPurchaseOrderNew.View_Multi_PO_Reports,
                                     dateEdit1.DateTime, dateEdit2.DateTime);
            }













            //object selectedValue = radioGroup1.EditValue;

            //if (selectedValue != null)
            //{
            //    // Iterate over all items in the RadioGroup
            //    foreach (DevExpress.XtraEditors.Controls.RadioGroupItem item in radioGroup1.Properties.Items)
            //    {
            //        // Get the value and description of each item
            //        object itemValue = item.Value;
            //        string itemDescription = item.Description;

            //        // Check if the item value matches the selected value
            //        if (itemValue.Equals(selectedValue))
            //        {
            //            // Execute logic based on the item description
            //            switch (itemDescription)
            //            {
            //                case "By Plan Date:":
            //                    this.view_Multi_PO_ReportsTableAdapter.FillByPlanDate(this.dSPurchaseOrderNew.View_Multi_PO_Reports,
            //                        dateEdit1.DateTime, dateEdit2.DateTime);
            //                    MessageBox.Show("By Plan Date:");
            //                    break;

            //                case "By PSD Date:":
            //                    this.view_Multi_PO_ReportsTableAdapter.FillPSDDate(this.dSPurchaseOrderNew.View_Multi_PO_Reports,
            //                        dateEdit1.DateTime, dateEdit2.DateTime);
            //                    MessageBox.Show("By PSD Date:");
            //                    break;

            //                case "By FP Date:":
            //                    this.view_Multi_PO_ReportsTableAdapter.FillByFPDate(this.dSPurchaseOrderNew.View_Multi_PO_Reports,
            //                        dateEdit1.DateTime, dateEdit2.DateTime);
            //                    MessageBox.Show("By FP Date:");
            //                    break;

            //                case "By POD Date:":
            //                    this.view_Multi_PO_ReportsTableAdapter.FillPOD(this.dSPurchaseOrderNew.View_Multi_PO_Reports,
            //                        dateEdit1.DateTime, dateEdit2.DateTime);
            //                    MessageBox.Show("By POD Date:");
            //                    break;

            //                case "By LP Date:":
            //                    this.view_Multi_PO_ReportsTableAdapter.FillByLPDate(this.dSPurchaseOrderNew.View_Multi_PO_Reports,
            //                        dateEdit1.DateTime, dateEdit2.DateTime);
            //                    MessageBox.Show("By LP Date:");
            //                    break;

            //                case "By Entry Date:":
            //                    this.view_Multi_PO_ReportsTableAdapter.FillBatch(this.dSPurchaseOrderNew.View_Multi_PO_Reports,
            //                        dateEdit1.DateTime, dateEdit2.DateTime);
            //                    MessageBox.Show("By Entry Date:");
            //                    break;

            //                case "By CRD:":
            //                    this.view_Multi_PO_ReportsTableAdapter.FillByCustReqDate(this.dSPurchaseOrderNew.View_Multi_PO_Reports,
            //                        dateEdit1.DateTime, dateEdit2.DateTime);
            //                    MessageBox.Show("By CRD:");
            //                    break;

            //                default:
            //                    MessageBox.Show("Unknown description.");
            //                    break;
            //            }

            //            // Exit the loop once the matching item is found and processed
            //            break;
            //        }
            //    }
            //}
            //else
            //{
            //    // Notify that no item is selected
            //    MessageBox.Show("No item is selected.");
            //}
            // Show the grid control
            gridControl3.Show();
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TabPane1_Click(object sender, EventArgs e)
        {

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    int v = this.view_Multi_PO_ReportsTableAdapter.Fill(
            //        this.dSPurchaseOrderNew.View_Multi_PO_Reports,
            //        dateEdit1.DateTime,
            //        dateEdit2.DateTime
            //    );
            //}
            //catch (Exception ex)
            //{
            //    //MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void dateEdit2_EditValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    int v = this.view_Multi_PO_ReportsTableAdapter.Fill(
            //        this.dSPurchaseOrderNew.View_Multi_PO_Reports,
            //        dateEdit1.DateTime,
            //        dateEdit2.DateTime);
            //}
            //catch (Exception ex)
            //{
            //    //MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void searchLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    int v = this.view_Multi_PO_ReportsTableAdapter.Fill(
            //        this.dSPurchaseOrderNew.View_Multi_PO_Reports,
            //        dateEdit1.DateTime,
            //        dateEdit2.DateTime

            //    );
            //}
            //catch (Exception ex)
            //{
            //    //MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void gridControl3_Click(object sender, EventArgs e)
        {

        }

        private void DataNavigator1_Click(object sender, EventArgs e)
        {

        }

        private void TabNavigationPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FectoryCodeEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void DataNavigator2_Click(object sender, EventArgs e)
        {

        }

        private void TabNavigationPage6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
