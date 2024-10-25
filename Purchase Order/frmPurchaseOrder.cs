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
    public partial class frmPurchaseOrder : DevExpress.XtraEditors.XtraForm
    {
        private object view_PoNewLaTableAdapter;

        public frmPurchaseOrder()
        {
            InitializeComponent();
            this.gridLookUpEdit1.GotFocus += new EventHandler(this.gridLookUpEdit1__GotFocus);
        }

        private void tbl_Pro_ClientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_Pro_ClientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tbl_Pro_Customer_MultiLine' table. You can move, or remove it, as needed.
            this.tbl_Pro_Customer_MultiLineTableAdapter.Fill(this.dataSet1.tbl_Pro_Customer_MultiLine);
            // TODO: This line of code loads data into the 'dataSet1.tbl_Pro_Customer_MultiLine' table. You can move, or remove it, as needed.
            this.tbl_Pro_Customer_MultiLineTableAdapter.Fill(this.dataSet1.tbl_Pro_Customer_MultiLine);
            // TODO: This line of code loads data into the 'dataSet1.tbl_Pro_Article_D' table. You can move, or remove it, as needed.
            this.tbl_Pro_Article_DTableAdapter.Fill(this.dataSet1.tbl_Pro_Article_D);
            // TODO: This line of code loads data into the 'dataSet1.tbl_Pro_Article' table. You can move, or remove it, as needed.
            this.tbl_Pro_ArticleTableAdapter.Fill(this.dataSet1.tbl_Pro_Article);
            // TODO: This line of code loads data into the 'dataSet1.tbl_Pro_Customer' table. You can move, or remove it, as needed.
            this.tbl_Pro_CustomerTableAdapter.Fill(this.dataSet1.tbl_Pro_Customer);
            // TODO: This line of code loads data into the 'dataSet1.tbl_PO_New_Size' table. You can move, or remove it, as needed.
            this.tbl_PO_New_SizeTableAdapter.Fill(this.dataSet1.tbl_PO_New_Size);
            // TODO: This line of code loads data into the 'dataSet1.tbl_PO_New_LA' table. You can move, or remove it, as needed.
            this.tbl_PO_New_LATableAdapter.Fill(this.dataSet1.tbl_PO_New_LA);
            // TODO: This line of code loads data into the 'dataSet1.tbl_PO_New' table. You can move, or remove it, as needed.
            this.tbl_PO_NewTableAdapter.Fill(this.dataSet1.tbl_PO_New);
            // TODO: This line of code loads data into the 'dataSet1.tbl_Pro_Client' table. You can move, or remove it, as needed.
            this.tbl_Pro_ClientTableAdapter.Fill(this.dataSet1.tbl_Pro_Client);
            this.view_PoNewTableAdapter.Fill(dataSet1.View_PoNew, Convert.ToInt32(ClientNameComboBox.SelectedValue));
            this.view_PoNewLaTableAdapter1.Fill(dataSet1.View_PoNewLa, Convert.ToInt32(POCodeComboBox.SelectedValue));

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
        private void DataNavigator2_Click(object sender, EventArgs e)
        {

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
                    //int gridValue = Convert.ToInt32(gridLookUpEdit2.EditValue);
                    string textValue = TextEdit3.Text;
                    string factoryCode = FectoryCodeEdit2.EditValue?.ToString(); // Using null-conditional operator for safe conversion
                    string customerOrderNo = CustomerOrderNoTextBox.Text;
                    string gridLookUpValue = (string)gridLookUpEdit1.EditValue;

                    // Call the Insert method
                    int rowsAffected = tbl_PO_NewTableAdapter.Insert(
                        clientId, modelId, artId, 0, textValue, factoryCode,
                        null, null, null, customerOrderNo, gridLookUpValue
                    );

                    // Check if the insert was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        this.view_PoNewTableAdapter.Fill(dataSet1.View_PoNew, clientId);
                        this.tbl_PO_NewTableAdapter.Fill(this.dataSet1.tbl_PO_New);
                        this.tbl_PO_NewBindingSource.MoveLast();
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

       

        private void ClientNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.view_PoNewTableAdapter.Fill(dataSet1.View_PoNew, Convert.ToInt32(ClientNameComboBox.SelectedValue));
        }

        private void DataNavigator2_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Custom)
            {
                try
                {
                    // End editing for the binding source
                  
                    this.tbl_PO_New_LABindingSource.EndEdit();

                    // Update the data table using the table adapter
                    this.tbl_PO_New_LATableAdapter.Update(this.dataSet1);

                    // Show success message
                    DevExpress.XtraEditors.XtraMessageBox.Show("Operation is completed Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Fill the View_PoNewLa with the selected PO code
                    //view_PoNewLaTableAdapter.Fill(DSPONew1.View_PoNewLa, (int)POCodeComboBox.SelectedValue);

                    // Refresh the data in tbl_PO_New_LA
                    this.tbl_PO_New_LATableAdapter.Fill(dataSet1.tbl_PO_New_LA);
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
                    tbl_PO_New_LABindingSource.EndEdit();

                    // Update the data table using the table adapter
                    tbl_PO_New_LATableAdapter.Update(this.dataSet1);

                    // Show success message
                    DevExpress.XtraEditors.XtraMessageBox.Show("Operation is completed Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Fill the View_PoNewLa with the selected PO code
                    //this.view_PoNewLaTableAdapter.Fill(dataSet1.View_PoNewLa, (int)POCodeComboBox.SelectedValue);

                    // Refresh the data in tbl_PO_New_LA
                    tbl_PO_New_LATableAdapter.Fill(dataSet1.tbl_PO_New_LA);
                }
                catch (Exception ex)
                {
                    // Show error message if something goes wrong
                    DevExpress.XtraEditors.XtraMessageBox.Show("Cannot delete. " + ex.Message, "Delete Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DataNavigator1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataNavigator2_ButtonClick_1(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Custom)
            {
                try
                {
                    // End editing for the binding source

                    this.tbl_PO_New_LABindingSource.EndEdit();

                    // Update the data table using the table adapter
                    this.tbl_PO_New_LATableAdapter.Update(this.dataSet1);

                    // Show success message
                    DevExpress.XtraEditors.XtraMessageBox.Show("Operation is completed Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Fill the View_PoNewLa with the selected PO code
                    //view_PoNewLaTableAdapter.Fill(DSPONew1.View_PoNewLa, (int)POCodeComboBox.SelectedValue);

                    // Refresh the data in tbl_PO_New_LA
                    tbl_PO_New_LATableAdapter.Fill(dataSet1.tbl_PO_New_LA);
                    this.view_PoNewLaTableAdapter1.Fill(dataSet1.View_PoNewLa, Convert.ToInt32(POCodeComboBox.SelectedValue));
                }
                catch (Exception ex)
                {
                    // Show error message if something goes wrong
                    DevExpress.XtraEditors.XtraMessageBox.Show("Cannot delete. " + ex.Message, "Delete Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DataNavigator1_ButtonClick_1(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Custom)
            {
                try
                {
                    // End editing for the binding source
                    tbl_PO_New_SizeBindingSource.EndEdit();

                    // Update the data table using the table adapter
                    tbl_PO_New_SizeTableAdapter.Update(this.dataSet1);

                    // Show success message
                    DevExpress.XtraEditors.XtraMessageBox.Show("Operation is completed Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Fill the View_PoNewLa with the selected PO code
                    //this.view_PoNewLaTableAdapter.Fill(dataSet1.View_PoNewLa, (int)POCodeComboBox.SelectedValue);

                    // Refresh the data in tbl_PO_New_LA
                    tbl_PO_New_LATableAdapter.Fill(dataSet1.tbl_PO_New_LA);
                    this.view_PoNewLaTableAdapter1.Fill(dataSet1.View_PoNewLa, Convert.ToInt32(POCodeComboBox.SelectedValue));
                }
                catch (Exception ex)
                {
                    // Show error message if something goes wrong
                    DevExpress.XtraEditors.XtraMessageBox.Show("Cannot delete. " + ex.Message, "Delete Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void repositoryItemButtonEdit3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // Cast sender to ButtonEdit
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
                        this.tbl_PO_NewTableAdapter.Delete(rowID);

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

        private void GridControl1_Click(object sender, EventArgs e)
        {

        }

        private void TabNavigationPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TabNavigationPage6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridLookUpEdit1__GotFocus(object sender, EventArgs e)
        {
            try
            {
                this.tbl_Pro_ArticleBindingSource.Filter = "FactoryCode='" + FectoryCodeEdit2.Text + "'";
            }
            catch (Exception ex) {
                DevExpress.XtraEditors.XtraMessageBox.Show("Cannot delete. " + ex.Message, "Delete Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

         
        }

        private void POCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.view_PoNewLaTableAdapter1.Fill(dataSet1.View_PoNewLa, Convert.ToInt32(POCodeComboBox.SelectedValue));
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void FectoryCodeEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
