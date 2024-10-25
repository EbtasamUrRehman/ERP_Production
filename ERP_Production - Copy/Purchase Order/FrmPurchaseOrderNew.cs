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
        }

        private void tbl_Pro_ClientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_Pro_ClientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPurchaseOrderNew);

        }

        private void FrmPurchaseOrderNew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.View_Multi_PO_MS' table. You can move, or remove it, as needed.
            this.view_Multi_PO_MSTableAdapter.Fill(this.dSPurchaseOrderNew.View_Multi_PO_MS, Convert.ToInt32(POCodeComboBox.SelectedValue));
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.View_Multi_PO_H' table. You can move, or remove it, as needed.
            this.view_Multi_PO_HTableAdapter.Fill(this.dSPurchaseOrderNew.View_Multi_PO_H, Convert.ToInt32(ClientNameComboBox.SelectedValue));
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.tbl_Pro_Article_D' table. You can move, or remove it, as needed.
            this.tbl_Pro_Article_DTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Pro_Article_D);
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

        }
        private void ClearFields()
        {

            ModelIDLabel1.Text = string.Empty; // Clear model ID label
            gridLookUpEdit1.EditValue = null; // Clear grid look-up edit
            gridLookUpEdit2.EditValue = null; // Clear grid look-up edit
            TextEdit3.Text = string.Empty; // Clear text edit
            FectoryCodeEdit2.EditValue = null; // Clear factory code edit
            CustomerOrderNoTextBox.Text = string.Empty; // Clear customer order number text box
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Perform the insert operation if TextEdit3 is not empty
                if (TextEdit3.Text.Length > 0 && gridLookUpEdit1.Text.Length > 0)
                {
                    // Ensure all necessary parameters are provided and properly converted
                    int clientId = Convert.ToInt32(ClientNameComboBox.SelectedValue);
                    int modelId = Convert.ToInt32(ModelIDLabel1.Text);
                    int artId = Convert.ToInt32(artIDLabel1.Text);
                    int gridValue = Convert.ToInt32(gridLookUpEdit2.EditValue);
                    string textValue = TextEdit3.Text;
                    string factoryCode = FectoryCodeEdit2.EditValue?.ToString(); // Using null-conditional operator for safe conversion
                    string customerOrderNo = CustomerOrderNoTextBox.Text;
                    string gridLookUpValue = (string)gridLookUpEdit1.EditValue;

                    // Call the Insert method
                    int rowsAffected = this.tbl_Multi_PO_HTableAdapter.Insert(
                        clientId, modelId, artId, gridValue, textValue, factoryCode,
                        null, null, null, customerOrderNo, gridLookUpValue
                    );

                    // Check if the insert was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        this.view_Multi_PO_HTableAdapter.Fill(this.dSPurchaseOrderNew.View_Multi_PO_H, Convert.ToInt32(ClientNameComboBox.SelectedValue));
                        //this.tbl_Multi_PO_HTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Multi_PO_H);
                        this.tbl_Multi_PO_HBindingSource.MoveLast();
                    }
                    else
                    {
                        MessageBox.Show("No data was inserted. Please check your inputs.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                // ClearFields(); Uncomment if you want to clear fields on error
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

                    // Show success message
                    DevExpress.XtraEditors.XtraMessageBox.Show("Operation is completed Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.view_Multi_PO_MSTableAdapter.Fill(this.dSPurchaseOrderNew.View_Multi_PO_MS, Convert.ToInt32(POCodeComboBox.SelectedValue));
                    // Fill the View_PoNewLa with the selected PO code
                    //view_PoNewLaTableAdapter.Fill(DSPONew1.View_PoNewLa, (int)POCodeComboBox.SelectedValue);

                    // Refresh the data in tbl_PO_New_LA
                    this.tbl_Multi_PO_MTableAdapter.Fill(dSPurchaseOrderNew.tbl_Multi_PO_M);
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
            if (GridView3.SelectedRowsCount > 0)
            {
                // Get the handle of the selected row
                int selectedRowHandle = GridView3.GetSelectedRows()[0];

                // Check if the selected row handle is valid
                if (selectedRowHandle >= 0)
                {
                    // Get the value of the first column (index 0) for the selected row
                    int rowID = Convert.ToInt32(GridView3.GetRowCellValue(selectedRowHandle, GridView3.Columns[0]));

                    // Show a confirmation message
                    DialogResult result = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // If the user confirms the deletion
                    if (result == DialogResult.Yes)
                    {
                        // Delete the record from the database using the TableAdapter
                        this.tbl_Multi_PO_HTableAdapter.Delete(rowID);

                        // Delete the selected row from the GridView
                        GridView3.DeleteRow(selectedRowHandle);

                        // Optionally, update the DataTable and refresh the GridControl
                        // this.YourDataTableAdapter.Fill(this.YourDataSet.YourDataTable);
                        // gridControl1.RefreshDataSource();
                    }
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Invalid row handle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Please select a row to delete.", "Delete Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
