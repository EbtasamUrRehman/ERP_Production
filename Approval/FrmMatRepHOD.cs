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
    public partial class FrmMatRepHOD : DevExpress.XtraEditors.XtraForm
    {
        public FrmMatRepHOD()
        {
            InitializeComponent();
        }

     

        private void searchLookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }


        private void simpleButton6_Click(object sender, EventArgs e)
        {
            this.view_mat_multi_replace_verify1TableAdapter.FillBy(dSMatRepHOD.view_mat_multi_replace_verify1, int.Parse(deptIDLabel1.Text), (DateTime)dateEdit1.EditValue, (DateTime)dateEdit2.EditValue);
        }

        public void loadData()
        {
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.dataTable3TableAdapter.FillBy(this.dSMatRep.DataTable3, new System.Nullable<int>(((int)(System.Convert.ChangeType(pOToolStripTextBox.Text, typeof(int))))), hODStatusToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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
                    String Msg;
                    String ApprovedByName = (loginNameLabel1.Text) as String;
                    int TID = (int)gridView.GetRowCellValue(selectedRowHandle, "TID");
                    String Status = gridView.GetRowCellValue(selectedRowHandle, "HODStatus") as String;
                    if (!string.IsNullOrEmpty(Status))
                    {
                        if (Status == "Approved")
                        {
                            Msg = "Approved";
                        }
                        else
                        {
                            Msg = "Cancelled";
                        }
                        //System.Windows.Forms.MessageBox.Show($"Status: {Status}");
                        this.view_mat_multi_replace_verifyTableAdapter.UpdateQuery1(Status, DateTime.Now, int.Parse(userIDLabel1.Text), ApprovedByName, TID);
                        this.view_mat_multi_replace_verifyTableAdapter.Fill(dSMatRepHOD.view_mat_multi_replace_verify, int.Parse(deptIDLabel1.Text));
                        System.Windows.Forms.MessageBox.Show($"{Msg} successfully");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("no status selected");
                    }
                }
            }
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
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

        private void panelControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMatRepHOD_Load(object sender, EventArgs e)
        {
                    this.dataTable4TableAdapter.Fill(dSMatRep.DataTable4, frmLogin.UserID);
                try {
                    this.view_mat_multi_replace_verifyTableAdapter.Fill(dSMatRepHOD.view_mat_multi_replace_verify, int.Parse(deptIDLabel1.Text));
                    this.dataTable3TableAdapter.FillBy(dSMatRep.DataTable3, int.Parse(deptIDLabel1.Text));
                }
                catch
                {

                }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.dataTable5TableAdapter.FillBy(dSMatRep.DataTable5, (DateTime)dateEdit4.EditValue, (DateTime)dateEdit3.EditValue, int.Parse(deptIDLabel1.Text));
        }

        //full ball datatable 3
        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {
            var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl2.FocusedView;

            if (gridView.SelectedRowsCount > 0)
            {
                var selectedRowHandle = gridView.GetSelectedRows()[0];

                if (selectedRowHandle >= 0)
                {
                    String Msg;
                    String ApprovedByName = (loginNameLabel1.Text) as String;
                    int TID = (int)gridView.GetRowCellValue(selectedRowHandle, "TID");
                    String Status = gridView.GetRowCellValue(selectedRowHandle, "HODStatus") as String;
                    if (!string.IsNullOrEmpty(Status))
                    {
                        if (Status == "Approved")
                        {
                            Msg = "Approved";
                        }
                        else
                        {
                            Msg = "Cancelled";
                        }
                        //System.Windows.Forms.MessageBox.Show($"Status: {Status}");
                        this.dataTable3TableAdapter.UpdateQuery1(Status, DateTime.Now, int.Parse(userIDLabel1.Text), ApprovedByName, TID);
                        this.dataTable3TableAdapter.FillBy(dSMatRep.DataTable3, int.Parse(deptIDLabel1.Text));

                        System.Windows.Forms.MessageBox.Show($"{Msg} successfully");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("no status selected");
                    }
                }
            }
        }

        private void fillToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
                //this.dataTable5TableAdapter.Fill(this.dSMatRep.DataTable5, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(requestDateToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(requestDate1ToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dateEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click_4(object sender, EventArgs e)
        {
            try
            {
                //this.dataTable5TableAdapter.Fill(this.dSMatRep.DataTable5, new System.Nullable<int>(((int)(System.Convert.ChangeType(deptidToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}