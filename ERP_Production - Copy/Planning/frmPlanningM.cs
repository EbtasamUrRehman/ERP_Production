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

namespace ERP_Production.Planning
{
    public partial class frmPlanningM : DevExpress.XtraEditors.XtraForm
    {
        public frmPlanningM()
        {
            InitializeComponent();
        }

        private void tbl_Multi_PO_PlanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_Multi_PO_PlanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPlanning);

        }

        private void frmPlanningM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPlanning.View_Multi_po_planning' table. You can move, or remove it, as needed.
            this.view_Multi_po_planningTableAdapter.Fill(this.dSPlanning.View_Multi_po_planning);
            // TODO: This line of code loads data into the 'dSPlanning.Tbl_Multi_PO_Plan_D' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_Plan_DTableAdapter.Fill(this.dSPlanning.Tbl_Multi_PO_Plan_D);
            // TODO: This line of code loads data into the 'dSPlanning.tbl_Multi_PO_Plan' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_PlanTableAdapter.Fill(this.dSPlanning.tbl_Multi_PO_Plan);

        }

        private void repositoryItemPlan_Click(object sender, EventArgs e)
        {
            var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl1.FocusedView;

            if (gridView.SelectedRowsCount > 0)
            {
                var selectedRowHandle = gridView.GetSelectedRows()[0];

                if (selectedRowHandle >= 0)
                {
                    try
                    {
                        // Initialize variables
                        int partialQty = 0;
                        int totalPlanQty = 0;
                        int clientId = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ClientID"));
                        int modelId = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ModelID"));
                        int artId = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ArtID"));
                        string artSize = gridView.GetRowCellValue(selectedRowHandle, "Size")?.ToString();
                        string PO = gridView.GetRowCellValue(selectedRowHandle, "POCode")?.ToString();
                        string LAName = gridView.GetRowCellValue(selectedRowHandle, "LAName")?.ToString();
                        int Line = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "Line"));
                        DateTime planDate = Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "PlanDate"));
                        DateTime custReqDate = Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "CustReqDate"));
                        DateTime productionDate = Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "ProductionDate"));

                        int totalQty = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "TotalQty"));
                        int balance = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "Balance"));

                        object partialQtyValue = gridView.GetRowCellValue(selectedRowHandle, "PartielQty");


                        if (partialQtyValue != DBNull.Value && partialQtyValue != null)
                        {
                            partialQty = Convert.ToInt32(partialQtyValue);
                        }

                        string factoryCode = gridView.GetRowCellValue(selectedRowHandle, "FactoryCode")?.ToString();

                        // Calculate totalPlanQty based on partialQty and balance
                        totalPlanQty = partialQty > 0 ? partialQty : balance;

                        // Ensure custReqDate is within a valid range
                        DateTime minDate = new DateTime(1753, 1, 1);
                        DateTime maxDate = new DateTime(9999, 12, 31);

                        if (custReqDate < minDate || custReqDate > maxDate)
                            throw new Exception("Customer Request Date is out of range.");

                        // Fetch MaxPID
                        int? maxPID = (int?)tbl_Multi_PO_PlanTableAdapter.ScalarQuery() + 1;

                        if (!maxPID.HasValue)
                        {
                            // If maxPID is null, set maxPIDValue to 1.
                            maxPID = 1;
                        }
                        else
                        {
                            // If maxPID has a value, increment it by 1.
                            //maxPID = maxPID ++;
                        }
                        if (partialQty < balance)
                        {
                            //int v = tbl_Multi_PO_PlanTableAdapter.Insert(maxPID.Value, clientId, modelId, artId, LAName, null, custReqDate, null, null, null,
                            //    null, null, null, null, null, factoryCode, totalPlanQty, null, null);

                            try
                            {
                                // Insert into tbl_Multi_PO_Plan_D
                                //int v1 = tbl_Multi_PO_Plan_DTableAdapter.Insert(maxPID.Value, clientId, modelId, artId, LAName, PO, 0, artSize, totalPlanQty, Line, null, null);

                                MessageBox.Show("Data inserted successfully!");

                                // Refresh the data in the view
                                this.view_Multi_po_planningTableAdapter.Fill(this.dSPlanning.View_Multi_po_planning);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error inserting into tbl_Multi_PO_Plan_D: {ex.Message}");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Error inserting into Partialqty mustbe less then Balance");
                        }

                        // Insert into tbl_Multi_PO_Plan

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