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

namespace ERP_Production.Approval
{
    public partial class frmMatRepAudit : DevExpress.XtraEditors.XtraForm
    {
        public frmMatRepAudit()
        {
            InitializeComponent();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.view_mat_multi_replace_verify2TableAdapter.FillBy(dSMatRepHOD.view_mat_multi_replace_verify2,comboBoxEdit1.Text);
            this.dataTable3TableAdapter.FillByFullBall(dSMatRep.DataTable3, comboBoxEdit1.Text);
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.view_mat_multi_replace_verify1TableAdapter.Fill(this.dSMatRepHOD.view_mat_multi_replace_verify1, new System.Nullable<int>(((int)(System.Convert.ChangeType(deptidToolStripTextBox.Text, typeof(int))))));
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
                //this.view_mat_multi_replace_verifyTableAdapter.Fill(this.dSMatRepHOD.view_mat_multi_replace_verify, new System.Nullable<int>(((int)(System.Convert.ChangeType(deptidToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            this.view_mat_multi_replace_verify3TableAdapter.FillBy1(dSMatRepHOD.view_mat_multi_replace_verify3, (DateTime)dateEdit1.EditValue, (DateTime)dateEdit2.EditValue, comboBoxEdit1.Text);

        }

        private void frmMatRepAudit_Load(object sender, EventArgs e)
        {
            this.dataTable4TableAdapter.Fill(dSMatRep.DataTable4, frmLogin.UserID);
            this.dataTable3TableAdapter.FillByFullBall(dSMatRep.DataTable3, comboBoxEdit1.Text);
            // TODO: This line of code loads data into the 'dSMatRepHOD.view_mat_multi_replace_verify3' table. You can move, or remove it, as needed.
            //this.view_mat_multi_replace_verify3TableAdapter.Fill(this.dSMatRepHOD.view_mat_multi_replace_verify3);
            // TODO: This line of code loads data into the 'dSMatRepHOD.view_mat_multi_replace_verify2' table. You can move, or remove it, as needed.
            //this.view_mat_multi_replace_verify2TableAdapter.Fill(this.dSMatRepHOD.view_mat_multi_replace_verify2);

        }

        private void repositoryItemButtonEdit4_Click(object sender, EventArgs e)
        {
            var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl3.FocusedView;

            if (gridView.SelectedRowsCount > 0)
            {
                var selectedRowHandle = gridView.GetSelectedRows()[0];

                if (selectedRowHandle >= 0)
                {
                    String Msg;
                    int TID = (int)gridView.GetRowCellValue(selectedRowHandle, "TID");
                    decimal RQuantity = (decimal)gridView.GetRowCellValue(selectedRowHandle, "RQuantity");
                    String Status = gridView.GetRowCellValue(selectedRowHandle, "VerfiyStatus") as String;
                    String ApprovedByName = (String)loginNameLabel1.Text;


                    object value = gridView.GetRowCellValue(selectedRowHandle, "VerifiedQty");
                    // Check if the value is DBNull or null before attempting to convert it to decimal
                    decimal VerifiedQty = value != DBNull.Value ? Convert.ToDecimal(value) : 0m;
                    decimal newQty;
<<<<<<< HEAD
                    if(VerifiedQty == 0)
                    {
                        newQty = Convert.ToDecimal(RQuantity);
                    }
                    else
                    {
                        newQty = VerifiedQty;
                    }

                    if (Status == "Approved")
                    {
                        Msg = "Entry Verified";
                        Status = "Verified";
                    }
                    else
                    {
                        Msg = "Cancelled";
                    }
                    //System.Windows.Forms.MessageBox.Show($"Status: {Status}");
                    this.view_mat_multi_replace_verify2TableAdapter.UpdateQuery1(Status, DateTime.Now, int.Parse(userIDLabel1.Text), newQty,ApprovedByName, TID);
                    this.view_mat_multi_replace_verify2TableAdapter.FillBy(dSMatRepHOD.view_mat_multi_replace_verify2,comboBoxEdit1.Text);
                    System.Windows.Forms.MessageBox.Show($"{Msg} successfully");
=======

                    if (!string.IsNullOrEmpty(Status))
                    {
                        if (VerifiedQty == 0)
                        {
                            newQty = Convert.ToDecimal(RQuantity);
                        }
                        else
                        {
                            newQty = VerifiedQty;
                        }

                        if (Status == "Approved")
                        {
                            Msg = "Verified";
                            Status = "Verified";
                        }
                        else
                        {
                            Msg = "Cancelled";
                        }
                        //System.Windows.Forms.MessageBox.Show($"Status: {Status}");
                        this.view_mat_multi_replace_verify2TableAdapter.UpdateQuery1(Status, DateTime.Now, int.Parse(userIDLabel1.Text), newQty, ApprovedByName, TID);
                        this.view_mat_multi_replace_verify2TableAdapter.FillBy(dSMatRepHOD.view_mat_multi_replace_verify2, comboBoxEdit1.Text);
                        System.Windows.Forms.MessageBox.Show($"{Msg} successfully");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("no status selected");
                    }
>>>>>>> master
                }
            }
        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.dataTable3TableAdapter.FillBy(this.dSMatRep.DataTable3, new System.Nullable<int>(((int)(System.Convert.ChangeType(deptidToolStripTextBox.Text, typeof(int))))));
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
                //this.dataTable5TableAdapter.Fill(this.dSMatRep.DataTable5, new System.Nullable<int>(((int)(System.Convert.ChangeType(deptidToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.dataTable5TableAdapter.FillByFullBallByDate(this.dSMatRep.DataTable5, comboBoxEdit1.Text, (DateTime)dateEdit4.EditValue, (DateTime)dateEdit3.EditValue);
        }

        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {
            var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl2.FocusedView;

            if (gridView.SelectedRowsCount > 0)
            {
                var selectedRowHandle = gridView.GetSelectedRows()[0];

                if (selectedRowHandle >= 0)
                {
                    String Msg;
                    int TID = (int)gridView.GetRowCellValue(selectedRowHandle, "TID");
                    int PO = (int)gridView.GetRowCellValue(selectedRowHandle, "PO");
                    int POD = (int)gridView.GetRowCellValue(selectedRowHandle, "POD");
                    String Status = gridView.GetRowCellValue(selectedRowHandle, "VerfiyStatus") as String;
                    decimal RQuantity = (decimal)gridView.GetRowCellValue(selectedRowHandle, "RQuantity");
                    object value = gridView.GetRowCellValue(selectedRowHandle, "VerifiedQty");
                    // Check if the value is DBNull or null before attempting to convert it to decimal
                    decimal VerifiedQty = value != DBNull.Value ? Convert.ToDecimal(value) : 0m;
                    decimal newQty;
<<<<<<< HEAD
                    String ApprovedByName = (String)loginNameLabel1.Text;
                    if (VerifiedQty == 0)
                    {
                        newQty = Convert.ToDecimal(RQuantity);
                    }
                    else
                    {
                        newQty = VerifiedQty;
                    }
                    if (Status == "Approved")
                    {
                        Msg = "Verified";
                        Status = "Verified";
                    }
                    else
                    {
                        Msg = "Cancelled";
                    }
                    //System.Windows.Forms.MessageBox.Show($"Status: {Status}");
                    this.dataTable3TableAdapter.UpdateQuery2(Status, DateTime.Now, int.Parse(userIDLabel1.Text), newQty, ApprovedByName, TID);
                    this.dataTable3TableAdapter.FillByFullBall(dSMatRep.DataTable3, comboBoxEdit1.Text);
                    this.dataTable7TableAdapter.Fill(dSMatRep.DataTable7, comboBoxEdit1.Text, PO, POD);
                    decimal updateQty = (decimal)dSMatRep.DataTable7.Rows[0]["VerifiedQty"];
                    this.dataTable7TableAdapter.UpdateQuery(updateQty, PO, POD);
                    System.Windows.Forms.MessageBox.Show($"{Msg} successfully");
=======
                    if (!string.IsNullOrEmpty(Status))
                    {
                        String ApprovedByName = (String)loginNameLabel1.Text;
                        if (VerifiedQty == 0)
                        {
                            newQty = Convert.ToDecimal(RQuantity);
                        }
                        else
                        {
                            newQty = VerifiedQty;
                        }
                        if (Status == "Approved")
                        {
                            Msg = "Verified";
                            Status = "Verified";
                        }
                        else
                        {
                            Msg = "Cancelled";
                        }
                        //System.Windows.Forms.MessageBox.Show($"Status: {Status}");
                        this.dataTable3TableAdapter.UpdateQuery2(Status, DateTime.Now, int.Parse(userIDLabel1.Text), newQty, ApprovedByName, TID);
                        this.dataTable3TableAdapter.FillByFullBall(dSMatRep.DataTable3, comboBoxEdit1.Text);
                        this.dataTable7TableAdapter.Fill(dSMatRep.DataTable7, comboBoxEdit1.Text, PO, POD);
                        decimal updateQty = (decimal)dSMatRep.DataTable7.Rows[0]["VerifiedQty"];
                        this.dataTable7TableAdapter.UpdateQuery(updateQty, PO, POD);
                        System.Windows.Forms.MessageBox.Show($"{Msg} successfully");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("no status selected");
                    }
>>>>>>> master
                }
            }
        }

        private void fillToolStripButton_Click_4(object sender, EventArgs e)
        {
            try
            {
                //this.dataTable7TableAdapter.Fill(this.dSMatRep.DataTable7, factoryCodeToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(pOToolStripTextBox.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(pODToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}