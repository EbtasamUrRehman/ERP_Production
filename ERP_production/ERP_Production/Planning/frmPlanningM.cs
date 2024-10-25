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
            // TODO: This line of code loads data into the 'dSPlanning.View_Multi_requsition' table. You can move, or remove it, as needed.
            this.view_Multi_requsitionTableAdapter.Fill(this.dSPlanning.View_Multi_requsition);
            // TODO: This line of code loads data into the 'dSPlanning.tbl_Multi_PO_Req' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_ReqTableAdapter.Fill(this.dSPlanning.tbl_Multi_PO_Req);
            // TODO: This line of code loads data into the 'dSPlanning.View_Multi_Plan_Req' table. You can move, or remove it, as needed.
            this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSPlanning.View_Multi_Plan_Req);
            // TODO: This line of code loads data into the 'dSPlanning.tbl_Prd_Lines' table. You can move, or remove it, as needed.
            this.tbl_Prd_LinesTableAdapter.Fill(this.dSPlanning.tbl_Prd_Lines);
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
                            int v = tbl_Multi_PO_PlanTableAdapter.Insert(maxPID.Value, clientId, modelId, artId, LAName, (int)PrdLine.EditValue, custReqDate, null, null, null,
                                null, null, null, null, null,null, factoryCode, totalPlanQty, null, null);

                            try
                            {
                                // Insert into tbl_Multi_PO_Plan_D
                                int v1 = tbl_Multi_PO_Plan_DTableAdapter.Insert(maxPID.Value, clientId, modelId, artId, LAName, PO, 0, artSize, totalPlanQty, Line, null, null);

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

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl2.FocusedView;

            if (gridView.SelectedRowsCount > 0)
            {
                var selectedRowHandle = gridView.GetSelectedRows()[0];

                if (selectedRowHandle >= 0)
                {
                    try
                    {

                       
                       
                        



                        int MPID = gridView.GetRowCellValue(selectedRowHandle, "MPID") != DBNull.Value
       ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "MPID"))
       : 0; // Default to 0 or another appropriate value

                        int PrdLine = gridView.GetRowCellValue(selectedRowHandle, "PrdLine") != DBNull.Value
                            ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PrdLine"))
                            : 0;

                        int MatNumber = gridView.GetRowCellValue(selectedRowHandle, "MatNumber") != DBNull.Value
                            ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "MatNumber"))
                            : 0;

                        int ReqFormula = gridView.GetRowCellValue(selectedRowHandle, "ReqFormula") != DBNull.Value
                            ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ReqFormula"))
                            : 0;

                        string PlanType = gridView.GetRowCellValue(selectedRowHandle, "PlanType") != DBNull.Value
                            ? gridView.GetRowCellValue(selectedRowHandle, "PlanType").ToString()
                            : null;

                        //string PO = gridView.GetRowCellValue(selectedRowHandle, "PO") != DBNull.Value
                        //    ? gridView.GetRowCellValue(selectedRowHandle, "PO").ToString()
                        //    : null;

                        string L4Name = gridView.GetRowCellValue(selectedRowHandle, "L4Name") != DBNull.Value
                            ? gridView.GetRowCellValue(selectedRowHandle, "L4Name").ToString()
                            : null;

                        string LAName = gridView.GetRowCellValue(selectedRowHandle, "LAName") != DBNull.Value
                            ? gridView.GetRowCellValue(selectedRowHandle, "LAName").ToString()
                            : null;

                        string Unit = gridView.GetRowCellValue(selectedRowHandle, "Unit") != DBNull.Value
                            ? gridView.GetRowCellValue(selectedRowHandle, "Unit").ToString()
                            : null;

                        int Line = gridView.GetRowCellValue(selectedRowHandle, "Line") != DBNull.Value
                            ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "Line"))
                            : 0;

                        DateTime planDate = gridView.GetRowCellValue(selectedRowHandle, "PlanDate") != DBNull.Value
                            ? Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "PlanDate"))
                            : DateTime.MinValue;

                        DateTime custReqDate = gridView.GetRowCellValue(selectedRowHandle, "CustReqDate") != DBNull.Value
                            ? Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "CustReqDate"))
                            : DateTime.MinValue;

                        DateTime productionDate = gridView.GetRowCellValue(selectedRowHandle, "ProductionDate") != DBNull.Value
                            ? Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "ProductionDate"))
                            : DateTime.MinValue;

                        int RecQty = gridView.GetRowCellValue(selectedRowHandle, "RecQty") != DBNull.Value
                            ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "RecQty"))
                            : 0;

                        int balance = gridView.GetRowCellValue(selectedRowHandle, "Balance") != DBNull.Value
                            ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "Balance"))
                            : 0;

                        object partialQtyValue = gridView.GetRowCellValue(selectedRowHandle, "PartielQty");

                        string factoryCode = gridView.GetRowCellValue(selectedRowHandle, "FactoryCode") != DBNull.Value
                            ? gridView.GetRowCellValue(selectedRowHandle, "FactoryCode").ToString()
                            : null;
                     
                        // Fetch MaxPID




                        {
                            int v = tbl_Multi_PO_ReqTableAdapter.Insert(DateTime.Now,MPID,PrdLine, PlanType,ReqFormula, RecQty, null, null, null, null, null, null,
                                null, null, MatNumber, null,null, null,null,null,null,null,null,null,null,null, Unit, null,null,L4Name,null,null,null,null,null,null,null,null, RecQty);

                            MessageBox.Show("Data inserted successfully!");
                            view_Multi_requsitionTableAdapter.Fill(this.dSPlanning.View_Multi_requsition);
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

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }
    }
}