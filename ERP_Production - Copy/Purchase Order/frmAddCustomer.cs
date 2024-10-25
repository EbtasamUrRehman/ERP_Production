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
    public partial class frmAddCustomer : DevExpress.XtraEditors.XtraForm
    {
        private frmCustomer _customerForm;

        public frmAddCustomer(frmCustomer customerForm)
        {
            InitializeComponent();
            _customerForm = customerForm;
        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tbl_Pro_ClientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_Pro_ClientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.tbl_Multi_PO_Customer' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_CustomerTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Multi_PO_Customer);
            // TODO: This line of code loads data into the 'dataSet1.tbl_Pro_Customer_MultiLine' table. You can move, or remove it, as needed.
            this.tbl_Pro_Customer_MultiLineTableAdapter.Fill(this.dataSet1.tbl_Pro_Customer_MultiLine);
            // TODO: This line of code loads data into the 'dataSet1.view_CustomerClient' table. You can move, or remove it, as needed.
            this.view_CustomerClientTableAdapter.Fill(this.dataSet1.view_CustomerClient);
            // TODO: This line of code loads data into the 'dataSet1.tbl_Pro_Customer' table. You can move, or remove it, as needed.
            this.tbl_Pro_CustomerTableAdapter.Fill(this.dataSet1.tbl_Pro_Customer);
            // TODO: This line of code loads data into the 'dataSet1.tbl_Pro_Client' table. You can move, or remove it, as needed.
            this.tbl_Pro_ClientTableAdapter.Fill(this.dataSet1.tbl_Pro_Client);
            this.view_CustomerClientTableAdapter.Fill(dataSet1.view_CustomerClient);


        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            try
            {
              

                // Insert the values into the database
                this.tbl_Multi_PO_CustomerTableAdapter.Insert(Convert.ToInt32(textEdit3.EditValue),null,txtComCode.Text,txtCusCode.Text,txtCustomerName.Text);

                // Show a success message
                MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _customerForm.RefreshGrid();
                this.Close();
            }
            catch (Exception ex)
            {
                // Show an error message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            {
                try
                {


                    // Insert the values into the database
                    this.tbl_Multi_PO_CustomerTableAdapter.Insert(Convert.ToInt32(textEdit3.EditValue), null, txtComCode.Text, txtCusCode.Text, txtCustomerName.Text);

                    // Show a success message
                    MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _customerForm.RefreshGrid();
                    txtComCode.Text = null;
                    //txtPlantCode.Text = null;
                    textEdit3.Text = null;
                }
                catch (Exception ex)
                {
                    // Show an error message
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
