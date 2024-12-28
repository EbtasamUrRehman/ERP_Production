using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Production.MatReq
{
    public partial class frmMatReq : DevExpress.XtraEditors.XtraForm
    {
        public frmMatReq()
        {
            InitializeComponent();
        }

        private void searchLookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.dataTable6TableAdapter.Fill(this.dSMatRep.DataTable6, factoryCodeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                //this.dataTable6TableAdapter.Fill(this.dSMatRep.DataTable6, factoryCodeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                //this.view_Multi_MatRep_BalanceTableAdapter.Fill(this.dSMatRep.View_Multi_MatRep_Balance, factoryCodeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBoxEdit3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataTable6TableAdapter.Fill(this.dSMatRep.DataTable6, comboBoxEdit3.Text);
            this.view_Multi_MatRep_Balance1TableAdapter.Fill(this.dSMatRep.View_Multi_MatRep_Balance1, comboBoxEdit3.Text);

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to generate a requisition?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                    DateTime RequestDate = (DateTime)dateEdit1.EditValue;

                    
                        // Get the GridView instance from the focused grid control
                        var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl4.FocusedView;

                // Loop through all rows in the GridView (not just selected rows)
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    // Check if the CheckEdit value is true (row selected)
                    object value = gridView.GetRowCellValue(i, "Status");

                    // Check if value is null or DBNull.Value before proceeding
                    bool isSelected = false;
                    if (value != null && value != DBNull.Value)
                    {
                        // Now it's safe to cast to bool
                        isSelected = (bool)value;
                    }

                    if (isSelected) // If the CheckEdit is checked (Status is true)
                    {
                        //try
                        //{
                            // Retrieve data for the current row
                            string Code = gridView.GetRowCellValue(i, "Code") as string;
                            int MPNO = gridView.GetRowCellValue(i, "MPNo") != DBNull.Value
                                        ? Convert.ToInt32(gridView.GetRowCellValue(i, "MPNo"))
                                        : 0;
                            int clientid = gridView.GetRowCellValue(i, "ClientID") != DBNull.Value
                                        ? Convert.ToInt32(gridView.GetRowCellValue(i, "ClientID"))
                                        : 0;
                            int modelid = gridView.GetRowCellValue(i, "ModelID") != DBNull.Value
                                        ? Convert.ToInt32(gridView.GetRowCellValue(i, "ModelID"))
                                        : 0;
                            int artid = gridView.GetRowCellValue(i, "ArtID") != DBNull.Value
                                        ? Convert.ToInt32(gridView.GetRowCellValue(i, "ArtID"))
                                        : 0;
                            string size = gridView.GetRowCellValue(i, "ArtSize") as string;
                            int prdline = gridView.GetRowCellValue(i, "prdLine") != DBNull.Value
                                        ? Convert.ToInt32(gridView.GetRowCellValue(i, "prdLine"))
                                        : 0;
                            string code = gridView.GetRowCellValue(i, "Code") as string;
                            decimal reqfor = (decimal)gridView.GetRowCellValue(i, "Yield");
                        decimal Balance = (decimal)gridView.GetRowCellValue(i, "Balance");
                        //decimal reqqty = (int)gridView.GetRowCellValue(i, "PartialQty");
                        //int PartialQty = (int)gridView.GetRowCellValue(i, "PartialQty");

                        object partialQtyValue = gridView.GetRowCellValue(i, "PartialQty");

                        decimal PartialQty = 0; // Default to 0 in case of invalid or missing value

                        if (partialQtyValue != DBNull.Value && partialQtyValue != null)
                        {
                            // Try to cast the value to an int safely
                            PartialQty = (decimal)partialQtyValue;
                        }

                        decimal reqqty = PartialQty ==0 ? Balance: (decimal)PartialQty;
                        decimal VerifiedQty = (decimal)gridView.GetRowCellValue(i, "VerifiedQty");
                            int TID = (int)gridView.GetRowCellValue(i, "TID"); 
                            if (reqqty > Balance)
                            {
                                System.Windows.Forms.MessageBox.Show("Requested Qty is more than Aproved Qty");
                            }

                            else {
                                view_Multi_MatRep_Balance1TableAdapter.InsertQuery(RequestDate, MPNO, prdline, "Normal", code, (decimal?)reqfor, reqqty, RequestDate, null, null, null, VerifiedQty, 0, TID, clientid, modelid, artid, size, reqqty);
                                
                            }
                                
                        //}
                        //catch (Exception ex)
                        //{
                        //    //MessageBox.Show($"Error: {ex.Message}");
                        //}
                    
                    }
                        
                }
                this.view_Multi_MatRep_Balance1TableAdapter.Fill(this.dSMatRep.View_Multi_MatRep_Balance1, comboBoxEdit3.Text);
                this.dataTable6TableAdapter.Fill(this.dSMatRep.DataTable6, comboBoxEdit3.Text);

                // Reload the data to refresh the UI

                //load();

            }
        }

        private void repositoryItemButtonEdit4_Click(object sender, EventArgs e)
        {
            var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl3.FocusedView;

            if (gridView.SelectedRowsCount > 0)
            {
                var selectedRowHandle = gridView.GetSelectedRows()[0];

                if (selectedRowHandle >= 0)
                {
                    int TID = (int)gridView.GetRowCellValue(selectedRowHandle, "Rep_TID");
                    this.dataTable6TableAdapter.Undo(TID);
                    System.Windows.Forms.MessageBox.Show("Deletion successful");
                    this.dataTable6TableAdapter.Fill(this.dSMatRep.DataTable6, comboBoxEdit3.Text);
                    this.view_Multi_MatRep_Balance1TableAdapter.Fill(this.dSMatRep.View_Multi_MatRep_Balance1, comboBoxEdit3.Text);
                }
            }
        }

        private void fillToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
                //this.view_Multi_MatRep_Balance1TableAdapter.Fill(this.dSMatRep.View_Multi_MatRep_Balance1, factoryCodeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}