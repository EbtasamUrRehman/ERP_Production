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

namespace ERP_Production.MatReplacement
{
    public partial class frmMatReplacement : DevExpress.XtraEditors.XtraForm
    {
        public frmMatReplacement()
        {
            InitializeComponent();
        }

        private void searchLookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tbl_Prd_LinesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_Prd_LinesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSMatRep);

        }

        private void frmMatReplacement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSMatRep.tbl_Multi_FullBall_Replacement_request' table. You can move, or remove it, as needed.
            this.tbl_Multi_FullBall_Replacement_requestTableAdapter.Fill(this.dSMatRep.tbl_Multi_FullBall_Replacement_request);
            this.dataTable4TableAdapter.Fill(dSMatRep.DataTable4, frmLogin.UserID);
            // TODO: This line of code loads data into the 'dSMatRep.tbl_Multi_Mat_Replacement_request' table. You can move, or remove it, as needed.
            this.tbl_Multi_Mat_Replacement_requestTableAdapter.Fill(this.dSMatRep.tbl_Multi_Mat_Replacement_request);
            // TODO: This line of code loads data into the 'dSMatRep.tbl_Multi_Mat_Replacement_request' table. You can move, or remove it, as needed.
            this.tbl_Multi_Mat_Replacement_requestTableAdapter.Fill(this.dSMatRep.tbl_Multi_Mat_Replacement_request);
            // TODO: This line of code loads data into the 'dSMatRep.tbl_Prd_Lines' table. You can move, or remove it, as needed.
            this.tbl_Prd_LinesTableAdapter.Fill(this.dSMatRep.tbl_Prd_Lines);

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.tbl_Multi_PO_HTableAdapter.Fill(this.dSMatRep.tbl_Multi_PO_H, comboBoxEdit3.Text, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
            
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.dataTable1TableAdapter.Fill(this.dSMatRep.DataTable1, ((int)(System.Convert.ChangeType(clientIDToolStripTextBox.Text, typeof(int)))), ((int)(System.Convert.ChangeType(modelIDToolStripTextBox.Text, typeof(int)))), ((int)(System.Convert.ChangeType(artIDToolStripTextBox.Text, typeof(int)))), artSizeToolStripTextBox.Text, ((int)(System.Convert.ChangeType(prdLineToolStripTextBox.Text, typeof(int)))));
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
                //this.dataTable1TableAdapter.Fill(this.dSMatRep.DataTable1, ((int)(System.Convert.ChangeType(clientIDToolStripTextBox.Text, typeof(int)))), ((int)(System.Convert.ChangeType(modelIDToolStripTextBox.Text, typeof(int)))), ((int)(System.Convert.ChangeType(artIDToolStripTextBox.Text, typeof(int)))), artSizeToolStripTextBox.Text, ((int)(System.Convert.ChangeType(prdLineToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
            try
            {
                this.tbl_Multi_PO_H1TableAdapter.Fill(this.dSMatRep.tbl_Multi_PO_H1, searchLookUpEdit1.Text);

            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                this.tbl_Multi_PO_STableAdapter.Fill(this.dSMatRep.tbl_Multi_PO_S, (int)(System.Convert.ChangeType(pOLabel1.Text, typeof(int))), (int)(System.Convert.ChangeType(pOMLabel3.Text, typeof(int))));
            }


        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                //this.tbl_Multi_PO_H1TableAdapter.Fill(this.dSMatRep.tbl_Multi_PO_H1, factoryCodeToolStripTextBox.Text, pOCodeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
                //this.tbl_Pro_ArticleTableAdapter.Fill(this.dSMatRep.tbl_Pro_Article, ((int)(System.Convert.ChangeType(modelIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //this.tbl_Multi_PO_STableAdapter.Fill(this.dSMatRep.tbl_Multi_PO_S, ((int)(System.Convert.ChangeType(textBox3.Text, typeof(int)))));
        }

        private void modelIDTextBox_TextChanged(object sender, EventArgs e)
        {
            //this.tbl_Multi_PO_STableAdapter.Fill(this.dSMatRep.tbl_Multi_PO_S, (int)(System.Convert.ChangeType(textBox4.Text, typeof(int))), (int)(System.Convert.ChangeType(textBox5.Text, typeof(int))));
        }

        private void fillToolStripButton_Click_4(object sender, EventArgs e)
        {
            try
            {
                //this.dataTable1TableAdapter.Fill(this.dSMatRep.DataTable1, ((int)(System.Convert.ChangeType(clientIDToolStripTextBox.Text, typeof(int)))), ((int)(System.Convert.ChangeType(modelIDToolStripTextBox.Text, typeof(int)))), ((int)(System.Convert.ChangeType(artIDToolStripTextBox.Text, typeof(int)))), artSizeToolStripTextBox.Text, ((int)(System.Convert.ChangeType(prdLineToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_5(object sender, EventArgs e)
        {
            try
            {
                //this.dataTable1TableAdapter.Fill(this.dSMatRep.DataTable1, ((int)(System.Convert.ChangeType(clientIDToolStripTextBox.Text, typeof(int)))), ((int)(System.Convert.ChangeType(modelIDToolStripTextBox.Text, typeof(int)))), ((int)(System.Convert.ChangeType(artIDToolStripTextBox.Text, typeof(int)))), artSizeToolStripTextBox.Text, ((int)(System.Convert.ChangeType(prdLineToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter.Fill(this.dSMatRep.DataTable1, 1, int.Parse(modelIDLabel1.Text), int.Parse(artIDLabel1.Text), comboBoxEdit2.EditValue as string, Convert.ToInt32(comboBoxEdit1.EditValue));
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void load()
        {
            this.view_Mat_Multi_Rep_byMpNoTableAdapter.Fill(dSMatRep.view_Mat_Multi_Rep_byMpNo, int.Parse(pOLabel1.Text));
            try
            {

            dataTable2TableAdapter.Fill(dSMatRep.DataTable2, int.Parse(pOLabel1.Text));
            }
            catch
            {

            }
            dataTable4TableAdapter.Fill(dSMatRep.DataTable4, frmLogin.UserID);
        }

        
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to generate a replacement request?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int count = 0;
            if (result == DialogResult.Yes)
            {
                // Check if the quantity entered is not zero
                if (textBox1.Text != "")
                {
                    DateTime ReqDate = (DateTime)dateEdit1.EditValue;
                    int ReqQty = int.Parse(textBox1.Text);
                    String Narration = textBox2.Text;

                    // If the checkbox is checked, insert a full ball entry
                    if (checkEdit1.Checked == true)
                    {
                        try
                        {
                            this.tbl_Multi_PO_Plan_DTableAdapter.Fill(dSMatRep.Tbl_Multi_PO_Plan_D, int.Parse(pOLabel1.Text), int.Parse(pOMLabel3.Text), int.Parse(pOSLabel1.Text));
                            tbl_Multi_FullBall_Replacement_requestTableAdapter.Insert("FullBall", null, null, null, int.Parse(pOLabel1.Text), int.Parse(pOMLabel3.Text), int.Parse(pOSLabel1.Text), ReqDate, ReqQty, null, null, null, frmLogin.UserID, null, null, null, null, null, null, int.Parse(artIDLabel1.Text), int.Parse(modelIDLabel1.Text), 1, int.Parse(deptIDLabel1.Text), Narration, null, null, comboBoxEdit2.EditValue as string, null, null, (String)loginNameLabel1.Text);
                            MessageBox.Show($"Full ball repalcement genemerated sucecsfully");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                        finally
                        {
                            load();
                        }
                    }
                    else
                    {
                        // Get the GridView instance from the focused grid control
                        var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl2.FocusedView;


                        // Loop through all rows in the GridView (not just selected rows)
                        for (int i = 0; i < gridView.RowCount; i++)
                        {
                            // Check if the CheckEdit value is true (row selected)
                            bool isSelected = gridView.GetRowCellValue(i, "MatStatus") != DBNull.Value && (bool)gridView.GetRowCellValue(i, "MatStatus");

                            if (isSelected) // If the CheckEdit is checked (Status is true)
                            {
                                count += 1;
                                try
                                {
                                    // Retrieve data for the current row
                                    string Code = gridView.GetRowCellValue(i, "Code") as string;
                                    string Unit = gridView.GetRowCellValue(i, "Unit") as string;
                                    decimal MatFormula = gridView.GetRowCellValue(i, "MatFormula") != DBNull.Value
                                        ? (decimal)gridView.GetRowCellValue(i, "MatFormula")
                                        : 0;

                                    decimal qty = (MatFormula != 0
                                        ? MatFormula * (decimal)ReqQty
                                        : 0);

                                    // Refresh the data table with updated parameters
                                    this.tbl_Multi_PO_Plan_DTableAdapter.Fill(dSMatRep.Tbl_Multi_PO_Plan_D, int.Parse(pOLabel1.Text), int.Parse(pOMLabel3.Text), int.Parse(pOSLabel1.Text));

                                    // Get MPno from the refreshed data
                                    int MPno = (int)dSMatRep.Tbl_Multi_PO_Plan_D.Rows[0]["MPID"];

                                    // Insert the replacement request for the current row
                                    tbl_Multi_Mat_Replacement_requestTableAdapter.Insert(
                                        "byMPNO",  // This is the identifier type
                                        MPno, // The MPno value from the database
                                        null, null,
                                        int.Parse(pOLabel1.Text),
                                        int.Parse(pOMLabel3.Text),
                                        int.Parse(pOSLabel1.Text),
                                        ReqDate, ReqQty,
                                        Code, MatFormula,
                                        qty, frmLogin.UserID,
                                        null, null, null, null, null, null,
                                        int.Parse(artIDLabel1.Text), int.Parse(modelIDLabel1.Text),
                                        1, int.Parse(deptIDLabel1.Text), Narration,
                                        Convert.ToInt32(comboBoxEdit1.EditValue),
                                        null, comboBoxEdit2.EditValue as string,
                                        Unit, 0, (String)loginNameLabel1.Text
                                    );
                                    
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Error: {ex.Message}");
                                }
                            }
                        }
                        if (count == 0)
                        {
                            System.Windows.Forms.MessageBox.Show("No Entry selected");
                        }

                        else
                        {
                            MessageBox.Show($"repalcement generated sucecsfully");

                        // Reload the data to refresh the UI
                            load();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No qty entered!");
                }
            }
        }


        private void fillToolStripButton_Click_6(object sender, EventArgs e)
        {
            try
            {
                //this.tbl_Multi_PO_Plan_DTableAdapter.Fill(this.dSMatRep.Tbl_Multi_PO_Plan_D, new System.Nullable<int>(((int)(System.Convert.ChangeType(pOToolStripTextBox.Text, typeof(int))))), ((int)(System.Convert.ChangeType(pOMToolStripTextBox.Text, typeof(int)))), new System.Nullable<int>(((int)(System.Convert.ChangeType(pOSToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void panelControl17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fillToolStripButton_Click_7(object sender, EventArgs e)
        {
            try
            {
                //this.view_Mat_Multi_Rep_byMpNoTableAdapter.Fill(this.dSMatRep.view_Mat_Multi_Rep_byMpNo, new System.Nullable<int>(((int)(System.Convert.ChangeType(pOToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
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
                    int TID = (int)gridView.GetRowCellValue(selectedRowHandle, "TID");
                    this.tbl_Multi_Mat_Replacement_requestTableAdapter.Undo(TID);
                    System.Windows.Forms.MessageBox.Show("Deletion successful");
                    load();
                }
            }
        }

        private void fillToolStripButton_Click_8(object sender, EventArgs e)
        {
            try
            {
                //this.dataTable2TableAdapter.Fill(this.dSMatRep.DataTable2, new System.Nullable<int>(((int)(System.Convert.ChangeType(pOToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl1.FocusedView;

            if (gridView.SelectedRowsCount > 0)
            {
                var selectedRowHandle = gridView.GetSelectedRows()[0];

                if (selectedRowHandle >= 0)
                {
                    int TID = (int)gridView.GetRowCellValue(selectedRowHandle, "TID");
                    this.dataTable2TableAdapter.Undo(TID);
                    System.Windows.Forms.MessageBox.Show("Deletion successful");
                    load();
                }
            }
        }

        private void fillToolStripButton_Click_9(object sender, EventArgs e)
        {
            try
            {
                //this.dataTable4TableAdapter.Fill(this.dSMatRep.DataTable4, ((int)(System.Convert.ChangeType(userIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBoxEdit3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            this.tbl_Multi_PO_HTableAdapter.Fill(this.dSMatRep.tbl_Multi_PO_H, comboBoxEdit3.Text, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
            }
            catch
            {

            }

        }
    }
}