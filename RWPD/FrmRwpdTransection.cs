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

namespace ERP_Production.RWPD
{
    public partial class FrmRwpdTransection : DevExpress.XtraEditors.XtraForm
    {
        public FrmRwpdTransection()
        {
            InitializeComponent();
        }

        private void searchLookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void panelControl26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbl_RackNOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_RackNOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSRwpd);

        }

        private void FrmRwpdTransection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSRwpd.View_RWPD_Multi_IN_Balance' table. You can move, or remove it, as needed.
            this.view_RWPD_Multi_IN_BalanceTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN_Balance);
            // TODO: This line of code loads data into the 'dSRwpd.View_RWPD_Multi_Out_Balance' table. You can move, or remove it, as needed.
            this.view_RWPD_Multi_Out_BalanceTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_Out_Balance);
            // TODO: This line of code loads data into the 'dSRwpd.View_RWPD_Multi_IN' table. You can move, or remove it, as needed.
            this.view_RWPD_Multi_INTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
            // TODO: This line of code loads data into the 'dSRwpd.View_Multi_PO_Reports' table. You can move, or remove it, as needed.
            this.view_Multi_PO_ReportsTableAdapter.Fill(this.dSRwpd.View_Multi_PO_Reports);
            // TODO: This line of code loads data into the 'dSRwpd.tbl_RackNO' table. You can move, or remove it, as needed.
            this.tbl_RackNOTableAdapter.Fill(this.dSRwpd.tbl_RackNO);

        }

        private void dateEdit9_EditValueChanged(object sender, EventArgs e)
        {
            this.view_Multi_PO_ReportsTableAdapter.FillBy(dSRwpd.View_Multi_PO_Reports, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
            this.view_RWPD_Multi_INTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
        }

        private void dateEdit4_EditValueChanged(object sender, EventArgs e)
        {
            this.view_Multi_PO_ReportsTableAdapter.FillBy(dSRwpd.View_Multi_PO_Reports, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
            this.view_RWPD_Multi_INTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.view_Multi_PO_ReportsTableAdapter.FillBy(dSRwpd.View_Multi_PO_Reports, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
            this.view_RWPD_Multi_INTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
        }

        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {
            var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl2.FocusedView;

            if (gridView.SelectedRowsCount > 0)
            {
                var selectedRowHandle = gridView.GetSelectedRows()[0];

                if (selectedRowHandle >= 0)
                {
                    try
                    {
                        int PO = gridView.GetRowCellValue(selectedRowHandle, "PO") != DBNull.Value
                            ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PO"))
                            : 0;
                        string POCode = gridView.GetRowCellValue(selectedRowHandle, "POCode") != DBNull.Value
                            ? gridView.GetRowCellValue(selectedRowHandle, "POCode").ToString()
                            : null;
                        string ArtCode = gridView.GetRowCellValue(selectedRowHandle, "ArtCode") != DBNull.Value
                        ? gridView.GetRowCellValue(selectedRowHandle, "ArtCode").ToString()
                        : null;
                        string Size = gridView.GetRowCellValue(selectedRowHandle, "Size") != DBNull.Value
                        ? gridView.GetRowCellValue(selectedRowHandle, "Size").ToString()
                        : null;

                        int RackNo = Convert.ToInt32(searchLookUpEdit1.EditValue);

                        DateTime? DeliverDate = gridView.GetRowCellValue(selectedRowHandle, "DD") != DBNull.Value
                            ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "DD"))
                            : null;

                        DateTime? EntryDate = DateTime.Now;

                        DateTime? ReceiveDate = (DateTime?)dateEdit1.EditValue;




                        string factoryCode = gridView.GetRowCellValue(selectedRowHandle, "FactoryCode") != DBNull.Value
                            ? gridView.GetRowCellValue(selectedRowHandle, "FactoryCode").ToString()
                            : null;


                        double balance = gridView.GetRowCellValue(selectedRowHandle, "Balance") != DBNull.Value
                        ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "Balance"))
                        : 0.0;


                        double PartialQty = gridView.GetRowCellValue(selectedRowHandle, "PartielQty") != DBNull.Value
                        ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "PartielQty"))
                        : 0.0;

                        double totalPlanQty;
                        totalPlanQty = PartialQty > 0 ? PartialQty : balance;

                        if (dateEdit1.EditValue != null)
                        {


                            if (PartialQty <= balance)
                            {

                                view_RWPD_Multi_INTableAdapter.InsertQuery(PO, POCode,  ArtCode,Size, (decimal?)totalPlanQty, RackNo, DeliverDate, EntryDate, null,ReceiveDate, factoryCode);



                                MessageBox.Show("Data inserted successfully!");

                                this.view_Multi_PO_ReportsTableAdapter.FillBy(dSRwpd.View_Multi_PO_Reports, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
                                this.view_RWPD_Multi_INTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
                            }
                            else
                            {
                                MessageBox.Show("Can not Send AvailableQty Error ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Select Receive Date");
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

        private void repositoryItemButtonEdit4_Click(object sender, EventArgs e)
        {
            var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl3.FocusedView;

            if (gridView.SelectedRowsCount > 0)
            {
                var selectedRowHandle = gridView.GetSelectedRows()[0];

                if (selectedRowHandle >= 0)
                {
                    try
                    {
                        int TID = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "TID"));
                        view_RWPD_Multi_INTableAdapter.DeleteQuery(TID);
                        MessageBox.Show("Record deleted successfuly");
                        this.view_Multi_PO_ReportsTableAdapter.FillBy(dSRwpd.View_Multi_PO_Reports, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
                        this.view_RWPD_Multi_INTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }



                }
            }
        }
    }
}