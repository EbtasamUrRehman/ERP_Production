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
            // TODO: This line of code loads data into the 'dSPlanning.View_Multi_PO_Planning_Reports' table. You can move, or remove it, as needed.
            gridControl4.Hide();
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
                        // Initialize variables with default values
                        int partialQty = 0;
                        int totalPlanQty = 0;
                        int clientId = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ClientID") ?? 0);
                        int modelId = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ModelID") ?? 0);
                        int artId = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ArtID") ?? 0);
                        string artSize = gridView.GetRowCellValue(selectedRowHandle, "Size") as string ?? string.Empty;
                        string POCode = gridView.GetRowCellValue(selectedRowHandle, "POCode") as string ?? string.Empty;
                        int POS = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "POS") ?? 0);
                        int PO = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PO") ?? 0);
                        int POM = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "POM") ?? 0);
                        string LAName = gridView.GetRowCellValue(selectedRowHandle, "LAName") as string ?? string.Empty;
                        int Line = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "Line") ?? 0);

                        DateTime GetDateValue(object value)
                        {
                            return value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(value);
                        }

                        DateTime planDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "PlanDate"));
                        DateTime ExFactoryDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "ExFactoryDate"));
                        DateTime custReqDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "CustReqDate"));
                        DateTime SecondConfDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "SecondConfDate"));
                        DateTime LastEditDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "LastEditDate"));
                        DateTime ReceiveDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "ReceiveDate"));
                        //DateTime productionDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "ProductionDate"));

                        int totalQty = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "TotalQty") ?? 0);
                        int balance = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "Balance") ?? 0);

                        object partialQtyValue = gridView.GetRowCellValue(selectedRowHandle, "PartielQty");
                        partialQty = partialQtyValue == DBNull.Value ? 0 : Convert.ToInt32(partialQtyValue);

                        string factoryCode = gridView.GetRowCellValue(selectedRowHandle, "FactoryCode") as string ?? string.Empty;

                        // Calculate totalPlanQty based on partialQty and balance
                        totalPlanQty = partialQty > 0 ? partialQty : balance;

                        // Ensure date values are within valid ranges
                        DateTime minDate = new DateTime(1753, 1, 1);
                        DateTime maxDate = new DateTime(9999, 12, 31);

                        void CheckDateRange(DateTime date, string fieldName)
                        {
                            if (date < minDate || date > maxDate)
                            {
                                throw new Exception($"{fieldName} is out of range.");
                            }
                        }

                        CheckDateRange(custReqDate, "Customer Request Date");
                        CheckDateRange(planDate, "Plan Date");
                        CheckDateRange(SecondConfDate, "Second Confirmation Date");
                        CheckDateRange(LastEditDate, "Last Edit Date");
                        CheckDateRange(ReceiveDate, "Receive Date");

                        // Fetch MaxPID
                        int? maxPID = (int?)tbl_Multi_PO_PlanTableAdapter.ScalarQuery() + 1;

                        if (!maxPID.HasValue)
                        {
                            maxPID = 1; // If maxPID is null, set maxPID to 1.
                        }

                        // Check if PrdLine.EditValue is valid and if partialQty is less than balance
                        if (PrdLine.EditValue != null && Convert.ToInt32(PrdLine.EditValue) > 0)
                        {
                            if (partialQty < balance)
                            {
                                // Insert into tbl_Multi_PO_Plan
                                tbl_Multi_PO_PlanTableAdapter.Insert(maxPID.Value, clientId, modelId, artId, LAName, (int)PrdLine.EditValue, DateTime.Now, custReqDate, ExFactoryDate, null, SecondConfDate, LastEditDate, DateTime.Now.Date, null, null, planDate, factoryCode, totalPlanQty, null, null, artSize);

                                try
                                {
                                    // Insert into tbl_Multi_PO_Plan_D
                                    tbl_Multi_PO_Plan_DTableAdapter.Insert(maxPID.Value, clientId, modelId, artId, LAName, POCode, POM, artSize, totalPlanQty, Line, null, null, POS, PO);

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
                                MessageBox.Show("Partial quantity must be less than Balance.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Select MP Line first.");
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
                        DateTime creationDate = gridView.GetRowCellValue(selectedRowHandle, "CreationDate") != DBNull.Value
                            ? Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "CreationDate"))
                            : DateTime.MinValue;
                        DateTime ExfactoryDate = gridView.GetRowCellValue(selectedRowHandle, "ExFactoryDate") != DBNull.Value
                            ? Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "ExFactoryDate"))
                            : DateTime.MinValue;
                        DateTime LastEditDate = gridView.GetRowCellValue(selectedRowHandle, "LastEditDate") != DBNull.Value
                            ? Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "LastEditDate"))
                            : DateTime.MinValue;
                        DateTime LpDate = gridView.GetRowCellValue(selectedRowHandle, "LPDate") != DBNull.Value
                            ? Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "LPDate"))
                            : DateTime.MinValue;
                        DateTime secondConDate = gridView.GetRowCellValue(selectedRowHandle, "SecondConfDate") != DBNull.Value
                            ? Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "SecondConfDate"))
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
                            int v = tbl_Multi_PO_ReqTableAdapter.Insert(DateTime.Now,MPID,PrdLine, PlanType,ReqFormula, RecQty, ExfactoryDate, null, secondConDate, null, null, null,
                                LpDate, creationDate, MatNumber, null,null, null,null,null,null,null,null,null,null,null, Unit, null,null,L4Name,null,null,null,null,null,null,null,null, RecQty);

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

        private void separatorControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabNavigationPage3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridControl4.Show();
            this.view_Multi_PO_Planning_ReportsTableAdapter.Fill(this.dSPlanning.View_Multi_PO_Planning_Reports,dateEdit1.DateTime,dateEdit2.DateTime);
        }

        private void tabPane1_Click(object sender, EventArgs e)
        {

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            this.view_Multi_PO_Planning_ReportsTableAdapter.Fill(this.dSPlanning.View_Multi_PO_Planning_Reports, dateEdit1.DateTime, dateEdit2.DateTime);

        }

        private void dateEdit2_EditValueChanged(object sender, EventArgs e)
        {
            this.view_Multi_PO_Planning_ReportsTableAdapter.Fill(this.dSPlanning.View_Multi_PO_Planning_Reports, dateEdit1.DateTime, dateEdit2.DateTime);

        }

        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}