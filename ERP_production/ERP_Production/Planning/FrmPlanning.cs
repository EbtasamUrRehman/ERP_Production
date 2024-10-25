using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace ERP_Production.Planning
{
    public partial class FrmPlanning : DevExpress.XtraEditors.XtraForm
    {
        public FrmPlanning()
        {
            InitializeComponent();
        }

        private void FrmPlanning_Load(object sender, EventArgs e)
        {
            // Load data into the datasets
            this.tbl_Pro_Plan_D_MultilineTableAdapter1.Fill(this.dSPlanning1.tbl_Pro_Plan_D_Multiline);
            this.tbl_Pro_Plan_MultiplanTableAdapter1.Fill(this.dSPlanning1.tbl_Pro_Plan_Multiplan);
            this.tbl_Pro_Plan_D_MultilineTableAdapter.Fill(this.dSplanning.tbl_Pro_Plan_D_Multiline);
            this.tbl_Pro_Plan_MultiplanTableAdapter.Fill(this.dSplanning.tbl_Pro_Plan_Multiplan);
            this.view_Auto_Planning_MultiLineTableAdapter.Fill(this.dSplanning.View_Auto_Planning_MultiLine);
        }

        private void repositoryItemButtonEdit1_Click_1(object sender, EventArgs e)
        {
            var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl1.FocusedView;

            if (gridView.SelectedRowsCount > 0)
            {
                var selectedRowHandle = gridView.GetSelectedRows()[0];

                if (selectedRowHandle >= 0)
                {
                    try
                    {
                        int scalarQuery = 0;
                        int totalPlanQty = 0;
                        int clientId = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ClientID"));
                        int modelId = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ModelID"));
                        int artId = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ArtID"));
                        string artSize = gridView.GetRowCellValue(selectedRowHandle, "Size")?.ToString();
                        string PO = gridView.GetRowCellValue(selectedRowHandle, "PO")?.ToString();
                        string planType = gridView.GetRowCellValue(selectedRowHandle, "PlanType")?.ToString();

                        DateTime planDate = Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "PlanDate"));
                        DateTime custReqDate = Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "CustReqDate"));
                        DateTime productionDate = Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "ProductionDate"));

                        int totalQty = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "TotalQty"));
                        int balance = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "Balance"));

                        object partialQtyValue = gridView.GetRowCellValue(selectedRowHandle, "PartialQty");

                        int partialQty = 0;
                        if (partialQtyValue != DBNull.Value && partialQtyValue != null)
                        {
                            partialQty = Convert.ToInt32(partialQtyValue);
                        }

                        string factoryCode = gridView.GetRowCellValue(selectedRowHandle, "FactoryCode")?.ToString();

                        totalPlanQty = balance > 0 ? balance : partialQty;

                        DateTime minDate = new DateTime(1753, 1, 1);
                        DateTime maxDate = new DateTime(9999, 12, 31);

                        if (custReqDate < minDate || custReqDate > maxDate) throw new Exception("Customer Request Date is out of range.");

                         scalarQuery = (int)tbl_Pro_Plan_MultiplanTableAdapter.ScalarQuery();
                        int maxMPID = scalarQuery;

                        // Debugging statement to log the returned value
                        MessageBox.Show($"ScalarQuery returned value: {maxMPID}");

                        int v = tbl_Pro_Plan_MultiplanTableAdapter1.Insert(
                            clientId, modelId, artId, artSize, null, 0, planType, null, null, null, null,
                            custReqDate, null, null, factoryCode, null, null, totalPlanQty, totalQty, null, null,
                            null, null, null, null, null, null, null, null, null, null, null, null
                        );

                        try
                        {
                            int v1 = tbl_Pro_Plan_D_MultilineTableAdapter.Insert(maxMPID, Convert.ToInt32(PO), 0, 0, clientId, modelId, artId, artSize, totalPlanQty, null, null, null, null);

                            MessageBox.Show("Data inserted successfully!");
                            this.view_Auto_Planning_MultiLineTableAdapter.Fill(this.dSplanning.View_Auto_Planning_MultiLine);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
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

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
