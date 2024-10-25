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
using WindowsFormsApplication1;

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
            // TODO: This line of code loads data into the 'mISDataSet.tbl_Multi_PO_ReqInsert' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_ReqInsertTableAdapter.Fill(this.mISDataSet.tbl_Multi_PO_ReqInsert);
            // TODO: This line of code loads data into the 'mISDataSet.tbl_Multi_PO_Req' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_ReqTableAdapter1.Fill(this.mISDataSet.tbl_Multi_PO_Req);
            // TODO: This line of code loads data into the 'dSPlanning.View_Mtlti_po_ReqFinel' table. You can move, or remove it, as needed.
            //this.view_Mtlti_po_ReqFinelTableAdapter.Fill(this.dSPlanning.View_Mtlti_po_ReqFinel);
            // TODO: This line of code loads data into the 'dSPlanning.View_Multi_po_planningFectory' table. You can move, or remove it, as needed.
            //this.view_Multi_po_planningFectoryTableAdapter.Fill(this.dSPlanning.View_Multi_po_planningFectory);
            // TODO: This line of code loads data into the 'dSPlanning.View_Multi_PO_Planning_Reports' table. You can move, or remove it, as needed.
            gridControl4.Hide();
            gridControl1.Hide();
            // TODO: This line of code loads data into the 'dSPlanning.View_Multi_requsition' table. You can move, or remove it, as needed.
            //this.view_Multi_requsitionTableAdapter.Fill(this.dSPlanning.View_Multi_requsition, (int)comboBoxEdit2.EditValue);
            // TODO: This line of code loads data into the 'dSPlanning.tbl_Multi_PO_Req' table. You can move, or remove it, as needed.
            //this.tbl_Multi_PO_ReqTableAdapter.Fill(this.dSPlanning.tbl_Multi_PO_Req);
            // TODO: This line of code loads data into the 'dSPlanning.View_Multi_Plan_Req' table. You can move, or remove it, as needed.
            //this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSPlanning.View_Multi_Plan_Req, (int)comboBoxEdit2.EditValue);
            // TODO: This line of code loads data into the 'dSPlanning.tbl_Prd_Lines' table. You can move, or remove it, as needed.
            this.tbl_Prd_LinesTableAdapter.Fill(this.dSPlanning.tbl_Prd_Lines);
            // TODO: This line of code loads data into the 'dSPlanning.View_Multi_po_planning' table. You can move, or remove it, as needed.
            //this.view_Multi_po_planningTableAdapter.Fill(this.dSPlanning.View_Multi_po_planning);
            // TODO: This line of code loads data into the 'dSPlanning.Tbl_Multi_PO_Plan_D' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_Plan_DTableAdapter.Fill(this.dSPlanning.Tbl_Multi_PO_Plan_D);
            // TODO: This line of code loads data into the 'dSPlanning.tbl_Multi_PO_Plan' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_PlanTableAdapter.Fill(this.dSPlanning.tbl_Multi_PO_Plan);
            try
            {
                //this.view_Multi_po_PlanRECTableAdapter.Fill(this.dSPlanning.View_Multi_po_PlanREC, (int)comboBoxEdit2.EditValue);
            }
            catch
            {

            }
           
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
                        string PlantCode = gridView.GetRowCellValue(selectedRowHandle, "PlantCode") as string ?? string.Empty;
                        string POCode = gridView.GetRowCellValue(selectedRowHandle, "POCode") as string ?? string.Empty;
                        string BarCode = gridView.GetRowCellValue(selectedRowHandle, "BarCode") as string ?? string.Empty;
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

                        DateTime PSDD = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "PSDD"));
                        DateTime FPD = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "FPD"));
                        DateTime PODD = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "PODD"));
                        DateTime LPDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "LPDate"));

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
                            if (partialQty <= balance)
                            {
                                // Insert into tbl_Multi_PO_Plan
                                tbl_Multi_PO_PlanTableAdapter.Insert(maxPID.Value, clientId, modelId, artId, LAName, (int)PrdLine.EditValue, DateTime.Now, custReqDate, ExFactoryDate, LPDate, SecondConfDate, LastEditDate, DateTime.Now.Date, BarCode, null, planDate, factoryCode, totalPlanQty, null, null, artSize,PlantCode,PSDD,FPD,PODD);

                                try
                                {
                                    // Insert into tbl_Multi_PO_Plan_D
                                    tbl_Multi_PO_Plan_DTableAdapter.Insert(maxPID.Value, clientId, modelId, artId, LAName, POCode, POM, artSize, totalPlanQty, Line, null, null, POS, PO);

                                    MessageBox.Show("Data inserted successfully!");
                                    GetGridView();
                                    this.tbl_Multi_PO_Plan_DTableAdapter.Fill(this.dSPlanning.Tbl_Multi_PO_Plan_D);
                                    // TODO: This line of code loads data into the 'dSPlanning.tbl_Multi_PO_Plan' table. You can move, or remove it, as needed.
                                    this.tbl_Multi_PO_PlanTableAdapter.Fill(this.dSPlanning.tbl_Multi_PO_Plan);
                                    // Refresh the data in the view
                                    //this.view_Multi_po_planningTableAdapter.Fill(this.dSPlanning.View_Multi_po_planning);
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

            //this.view_Multi_PO_Planning_ReportsTableAdapter.Fill(this.dSPlanning.View_Multi_PO_Planning_Reports,dateEdit1.DateTime,dateEdit2.DateTime);
            {
                // Create an instance of Form1
                Form1 objFrmFilter = new Form1();

                // Path to your Crystal Report file
                string reportName = @"\\dnsserver\MyReports$\MultiProduction\RptMultiPoPlanning.rpt";

                DateTime date1 = dateEdit1.DateTime;
                DateTime date2 = dateEdit2.DateTime;

                // Format dates as strings
                string formattedDate1Start = date1.ToString("yyyy,MM,dd,00,00,00");
                string formattedDate2End = date2.ToString("yyyy,MM,dd,23,59,59");
                string parameters = "";
                // Construct the selection formula string
                string selectionFormula = "";

                selectionFormula = $"{{View_Multi_PO_Planning_Reports.ExFactoryDate}} in DateTime ({formattedDate1Start}) to DateTime ({formattedDate2End})";

                // View the report
                if (objFrmFilter.ViewReport(reportName, selectionFormula, parameters))
                {
                    FrmMain mainForm = (FrmMain)Application.OpenForms.OfType<FrmMain>().FirstOrDefault();
                    if (mainForm != null)
                    {
                        objFrmFilter.ShowDialog();
                        //await mainForm.ShowReportAsync<objFrmFilter>();
                    }
                    else
                    {
                        MessageBox.Show("Main form not found.");
                    }


                    //await FrmMain.ShowOrToggleFormAsync<objFrmFilter>();
                    // Show the form
                    //objFrmFilter.ShowDialog(); // Use ShowDialog if you want it as a modal form or Show if it should be modeless
                }
                else
                {
                    // Handle the case where the report could not be loaded
                    MessageBox.Show("Failed to load the report.");
                }
            }





            this.view_Multi_PO_Planning_ReportsTableAdapter.FillBy(this.dSPlanning.View_Multi_PO_Planning_Reports);
            gridControl4.Show();
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

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void repositoryItemButtonEdit3_Click(object sender, EventArgs e)
        {
           

        }

        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click_1(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit2_Click_1(object sender, EventArgs e)
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
                            : 0;
                        int ArtID = gridView.GetRowCellValue(selectedRowHandle, "ArtID") != DBNull.Value
                        ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ArtID"))
                        : 0;
                        int ClientID = gridView.GetRowCellValue(selectedRowHandle, "ClientID") != DBNull.Value
                        ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ClientID"))
                        : 0;
                        int ModelID = gridView.GetRowCellValue(selectedRowHandle, "ModelID") != DBNull.Value
                        ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ModelID"))
                        : 0;
                        

                        int PrdLine = gridView.GetRowCellValue(selectedRowHandle, "PrdLine") != DBNull.Value
                            ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PrdLine"))
                            : 0;

                       
                        double ReqFormula = gridView.GetRowCellValue(selectedRowHandle, "MatFormula") != DBNull.Value
                          ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "MatFormula"))
                          : 0.0;

                        int RequiredQty = gridView.GetRowCellValue(selectedRowHandle, "RequiredQty") != DBNull.Value
                            ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "RequiredQty"))
                            : 0;
                        double PartialQty = gridView.GetRowCellValue(selectedRowHandle, "PartialQty") != DBNull.Value
                         ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "PartialQty"))
                         : 0.0;

                        //decimal PartialQty = gridView.GetRowCellValue(selectedRowHandle, "PartialQty") != DBNull.Value
                        //   ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PartialQty"))
                           //: 0;
                        string PlanType = gridView.GetRowCellValue(selectedRowHandle, "PlanType") != DBNull.Value
                            ? gridView.GetRowCellValue(selectedRowHandle, "PlanType").ToString()
                            : null;
                        string LineAgre = gridView.GetRowCellValue(selectedRowHandle, "LAName") != DBNull.Value
                           ? gridView.GetRowCellValue(selectedRowHandle, "LAName").ToString()
                           : null;

                        string L4Name = gridView.GetRowCellValue(selectedRowHandle, "L4Name") != DBNull.Value
                            ? gridView.GetRowCellValue(selectedRowHandle, "L4Name").ToString()
                            : null;
                        string Code = gridView.GetRowCellValue(selectedRowHandle, "Code") != DBNull.Value
                           ? gridView.GetRowCellValue(selectedRowHandle, "Code").ToString()
                           : null;
                        string artSize = gridView.GetRowCellValue(selectedRowHandle, "Size") != DBNull.Value
                            ? gridView.GetRowCellValue(selectedRowHandle, "Size").ToString()
                            : null;

                        string Unit = gridView.GetRowCellValue(selectedRowHandle, "Unit") != DBNull.Value
                            ? gridView.GetRowCellValue(selectedRowHandle, "Unit").ToString()
                            : null;

                        int Line = gridView.GetRowCellValue(selectedRowHandle, "PrdLine") != DBNull.Value
                            ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PrdLine"))
                            : 0;
                        

                        DateTime? planDate = gridView.GetRowCellValue(selectedRowHandle, "PlanDate") != DBNull.Value
                            ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "PlanDate"))
                            : null;

                        DateTime? custReqDate = gridView.GetRowCellValue(selectedRowHandle, "CustReqDate") != DBNull.Value
                            ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "CustReqDate"))
                            : null;

                        //DateTime? productionDate = gridView.GetRowCellValue(selectedRowHandle, "ProductionDate") != DBNull.Value
                        //    ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "ProductionDate"))
                        //    : null;

                        DateTime? creationDate = gridView.GetRowCellValue(selectedRowHandle, "CreationDate") != DBNull.Value
                            ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "CreationDate"))
                            : null;

                        DateTime? ExfactoryDate = gridView.GetRowCellValue(selectedRowHandle, "ExFactoryDate") != DBNull.Value
                            ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "ExFactoryDate"))
                            : null;

                        DateTime? LastEditDate = gridView.GetRowCellValue(selectedRowHandle, "LastEditDate") != DBNull.Value
                            ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "LastEditDate"))
                            : null;

                        DateTime? LpDate = gridView.GetRowCellValue(selectedRowHandle, "LPDate") != DBNull.Value
                            ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "LPDate"))
                            : null;
                        DateTime? PSDD = gridView.GetRowCellValue(selectedRowHandle, "PSDD") != DBNull.Value
                           ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "PSDD"))
                           : null;
                        DateTime? FPD = gridView.GetRowCellValue(selectedRowHandle, "FPD") != DBNull.Value
                           ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "FPD"))
                           : null;
                        DateTime? PODD = gridView.GetRowCellValue(selectedRowHandle, "PODD") != DBNull.Value
                           ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "PODD"))
                           : null;
                       

                        DateTime? secondConDate = gridView.GetRowCellValue(selectedRowHandle, "SecondConfDate") != DBNull.Value
                            ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "SecondConfDate"))
                            : null;
                        //double RecQty = gridView.GetRowCellValue(selectedRowHandle, "RecQty") != DBNull.Value
                        //? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "RecQty"))
                        //: 0.0;


                        //int RecQty = gridView.GetRowCellValue(selectedRowHandle, "RecQty") != DBNull.Value
                        //    ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "RecQty"))
                        //    : 0;
                        double RecQty = gridView.GetRowCellValue(selectedRowHandle, "RecQty") != DBNull.Value
                       ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "RecQty"))
                       : 0.0;
                        //int balance = gridView.GetRowCellValue(selectedRowHandle, "Balance") != DBNull.Value
                        //    ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "Balance"))
                        //    : 0;
                        double balance = gridView.GetRowCellValue(selectedRowHandle, "Balance") != DBNull.Value
                        ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "Balance"))
                        : 0.0;

                        object partialQtyValue = gridView.GetRowCellValue(selectedRowHandle, "PartialQty");

                        string factoryCode = gridView.GetRowCellValue(selectedRowHandle, "FactoryCode") != DBNull.Value
                            ? gridView.GetRowCellValue(selectedRowHandle, "FactoryCode").ToString()
                            : null;

                        // Verify each date field before insertion
                        VerifyDate(planDate, "PlanDate");
                        VerifyDate(custReqDate, "CustReqDate");
                        //VerifyDate(productionDate, "ProductionDate");
                        VerifyDate(creationDate, "CreationDate");
                        VerifyDate(ExfactoryDate, "ExFactoryDate");
                        VerifyDate(LastEditDate, "LastEditDate");
                        VerifyDate(LpDate, "LPDate");
                        //VerifyDate(PODD, "PODD");
                        //VerifyDate(FPD, "FPD");
                        //VerifyDate(PSDD, "PSDD");
                        VerifyDate(secondConDate, "SecondConfDate");
                        double totalPlanQty;
                        totalPlanQty = PartialQty > 0 ? PartialQty : balance;

                        if (dateEdit3.EditValue != null)
                        {
                            if (PartialQty <= balance)
                            {
                                int v = tbl_Multi_PO_ReqInsertTableAdapter.Insert(MPID, ClientID, ModelID, ArtID, LineAgre, artSize, null, PrdLine, null, (decimal?)ReqFormula, (decimal)RecQty,
                                null, null, null, null, null, null, null, DateTime.Now.Date, null, null, null, null, null, null, Unit, null, null, DateTime.Now.Date,
                                null, null, Unit, null, planDate, L4Name, null, null, null, null, null, artSize, (decimal?)totalPlanQty, dateEdit3.DateTime.Date, custReqDate, null, null, null, LpDate,Code);

                                MessageBox.Show("Data inserted successfully!");
                                if (checkButton1.Checked)
                                {
                                    this.view_Multi_Plan_ReqTableAdapter.FillBy(this.dSPlanning.View_Multi_Plan_Req, (int)comboBoxEdit2.EditValue, 22);
                                }
                                else
                                {
                                    this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSPlanning.View_Multi_Plan_Req, (int)comboBoxEdit2.EditValue);
                                }
                                view_Multi_requsitionTableAdapter.Fill(this.dSPlanning.View_Multi_requsition, (int)comboBoxEdit2.EditValue);
                            }
                            else
                            {
                                MessageBox.Show("Partial Qty must be less than balance.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        
                           
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Requisition date.");
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

            void VerifyDate(DateTime? dateValue, string fieldName)
            {
                // Example validation logic
                if (dateValue.HasValue && (dateValue.Value < new DateTime(1900, 1, 1) || dateValue.Value > DateTime.MaxValue))
                {
                    throw new ArgumentOutOfRangeException(fieldName, "The date value is out of range.");
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.tbl_Multi_PO_ReqTableAdapter.Fill(this.dSPlanning.tbl_Multi_PO_Req);
            int selectedValue;
            if (comboBoxEdit2.EditValue != null && int.TryParse(comboBoxEdit2.EditValue.ToString(), out selectedValue) && selectedValue > 0)
            {
                this.view_Multi_requsitionTableAdapter.Fill(this.dSPlanning.View_Multi_requsition, selectedValue);
                // TODO: This line of code loads data into the 'dSPlanning.tbl_Multi_PO_Req' table. You can move, or remove it, as needed.
                
                // TODO: This line of code loads data into the 'dSPlanning.View_Multi_Plan_Req' table. You can move, or remove it, as needed.

                try
                {
                    this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSPlanning.View_Multi_Plan_Req, selectedValue);
                }
                catch (Exception ex)
                {
                    // Log the exception or handle it as needed
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    // Optionally, rethrow the exception if you want it to propagate further
                    // throw;
                }
            }
            // TODO: This line of code loads data into the 'dSPlanning.tbl_Prd_Lines' table. You can move, or remove it, as needed.
            this.tbl_Prd_LinesTableAdapter.Fill(this.dSPlanning.tbl_Prd_Lines);
            // TODO: This line of code loads data into the 'dSPlanning.View_Multi_po_planning' table. You can move, or remove it, as needed.
            GetGridView();
            // TODO: This line of code loads data into the 'dSPlanning.Tbl_Multi_PO_Plan_D' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_Plan_DTableAdapter.Fill(this.dSPlanning.Tbl_Multi_PO_Plan_D);
            // TODO: This line of code loads data into the 'dSPlanning.tbl_Multi_PO_Plan' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_PlanTableAdapter.Fill(this.dSPlanning.tbl_Multi_PO_Plan);
        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl11_Click(object sender, EventArgs e)
        {

        }

        private void dateEdit4_EditValueChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GetGridView()
        {
            DateTime startDate = dateEdit5.DateTime;
            DateTime endDate = dateEdit6.DateTime;
            if (startDate != DateTime.MinValue && endDate != DateTime.MinValue)
            {
                // Proceed with your logic here

                if (radioButtonCRD.Checked)
                {
                    try
                    {
                        this.view_Multi_po_planningTableAdapter.CustReqDate(this.dSPlanning.View_Multi_po_planning, startDate, endDate, (string)comboBoxEdit1.EditValue);
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception, for example, log it or show a message to the user
                        MessageBox.Show($"An error occurred while fetching data by Customer Request Date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (radioButtonLP.Checked)
                {
                    try
                    {
                        this.view_Multi_po_planningTableAdapter.LPDate(this.dSPlanning.View_Multi_po_planning, startDate, endDate, (string)comboBoxEdit1.EditValue);
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception, for example, log it or show a message to the user
                        MessageBox.Show($"An error occurred while fetching data by Plan Date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (radioButtonBatch.Checked)
                {
                    try
                    {
                        this.view_Multi_po_planningTableAdapter.BatchDate(this.dSPlanning.View_Multi_po_planning, startDate, endDate, (string)comboBoxEdit1.EditValue);
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception, for example, log it or show a message to the user
                        MessageBox.Show($"An error occurred while fetching data by Batch Date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //else if (radioButtonFP.Checked)
                //{
                //    try
                //    {
                //        this.view_Multi_po_planningTableAdapter.FPDate(this.dSPlanning.View_Multi_po_planning, startDate, endDate);
                //    }
                //    catch (Exception ex)
                //    {
                //        // Handle the exception, for example, log it or show a message to the user
                //        MessageBox.Show($"An error occurred while fetching data by Batch Date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
                else if (radioButtonPlan.Checked)
                {
                    try
                    {
                        this.view_Multi_po_planningTableAdapter.Plan(this.dSPlanning.View_Multi_po_planning, startDate, endDate, (string)comboBoxEdit1.EditValue);
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception, for example, log it or show a message to the user
                        MessageBox.Show($"An error occurred while fetching data by Batch Date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //else if (radioButtonPS.Checked)
                //{
                //    try
                //    {
                //        this.view_Multi_po_planningTableAdapter.PSDate(this.dSPlanning.View_Multi_po_planning, startDate, endDate);
                //    }
                //    catch (Exception ex)
                //    {
                //        // Handle the exception, for example, log it or show a message to the user
                //        MessageBox.Show($"An error occurred while fetching data by Batch Date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
                else
                {
                    MessageBox.Show("Please select valid start and end dates.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        

        gridControl1.Show();

            // Use the selectionFormula for your report as needed
            // Example: Set the formula for a Crystal Report object
            // reportDocument.DataDefinition.RecordSelectionFormula = selectionFormula;
            this.tbl_Multi_PO_ReqTableAdapter.Fill(this.dSPlanning.tbl_Multi_PO_Req);
        }

        private void dateEdit5_EditValueChanged(object sender, EventArgs e)
        {
            //GetGridView();
        }

        private void dateEdit6_EditValueChanged(object sender, EventArgs e)
        {
            //GetGridView();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            GetGridView();
           
            try
            {
                tbl_Multi_PO_PlanTableAdapter.Fill(this.dSPlanning.tbl_Multi_PO_Plan);

                int selectedValue;
                if (comboBoxEdit2.EditValue != null && int.TryParse(comboBoxEdit2.EditValue.ToString(), out selectedValue) && selectedValue > 0)
                {
                    this.view_Multi_po_PlanRECTableAdapter.Fill(this.dSPlanning.View_Multi_po_PlanREC, selectedValue);
                    this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSPlanning.View_Multi_Plan_Req, selectedValue);
                }
                //this.view_Multi_po_PlanRECTableAdapter.Fill(this.dSPlanning.View_Multi_po_PlanREC, (int)comboBoxEdit2.EditValue);
                //this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSPlanning.View_Multi_Plan_Req, (int)comboBoxEdit2.EditValue);

            }

            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                MessageBox.Show($"An error occurred: {ex.Message}");
                // Optionally, rethrow the exception if you want it to propagate further
                // throw;
            }
        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxEdit2_EditValueChanged(object sender, EventArgs e)
        {
     
           
            try     
            {
                this.view_Multi_po_PlanRECTableAdapter.Fill(this.dSPlanning.View_Multi_po_PlanREC, (int)comboBoxEdit2.EditValue);
                if (checkButton1.Checked)
                {
                    this.view_Multi_Plan_ReqTableAdapter.FillBy(this.dSPlanning.View_Multi_Plan_Req, (int)comboBoxEdit2.EditValue,22);
                }
                else
                {
                    this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSPlanning.View_Multi_Plan_Req, (int)comboBoxEdit2.EditValue);
                }
               
                this.view_Multi_requsitionTableAdapter.Fill(this.dSPlanning.View_Multi_requsition, (int)comboBoxEdit2.EditValue);
               

            }

            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                MessageBox.Show($"An error occurred: {ex.Message}");
                // Optionally, rethrow the exception if you want it to propagate further
                // throw;
            }
            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkButton1.Checked)
                {
                    this.view_Multi_Plan_ReqTableAdapter.FillBy(this.dSPlanning.View_Multi_Plan_Req, (int)comboBoxEdit2.EditValue, 22);
                }
                else
                {
                    this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSPlanning.View_Multi_Plan_Req, (int)comboBoxEdit2.EditValue);
                }

            }

            catch (Exception ex)
            {
             
                // Optionally, rethrow the exception if you want it to propagate further
                // throw;
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
                        // Retrieve values from the selected row
                        int ReqID = gridView.GetRowCellValue(selectedRowHandle, "ReqID") != DBNull.Value
                            ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ReqID"))
                            : 0;


                        // Perform deletion
                        var confirmResult = MessageBox.Show(
                 "Are you sure you want to delete this record?",
                 "Confirm Deletion",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
             );

                        if (confirmResult == DialogResult.Yes)
                        {
                            // Perform deletion
                            tbl_Multi_PO_ReqInsertTableAdapter.Delete(ReqID);
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          

                            int selectedValue;
                            if (comboBoxEdit2.EditValue != null && int.TryParse(comboBoxEdit2.EditValue.ToString(), out selectedValue) && selectedValue > 0)
                            {
                                view_Multi_requsitionTableAdapter.Fill(this.dSPlanning.View_Multi_requsition, (int)comboBoxEdit2.EditValue);
                                this.view_Multi_po_PlanRECTableAdapter.Fill(this.dSPlanning.View_Multi_po_PlanREC, selectedValue);
                                this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSPlanning.View_Multi_Plan_Req, selectedValue);
                            }

                        }
                      
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions that may occur
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selected row handle is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No row selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl15_Click(object sender, EventArgs e)
        {

        }

        private void panelControl19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl20_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DeleteRecords()
        {
            // Ensure the comboBoxEdit2 has a valid value
            if (comboBoxEdit2.EditValue != null)
            {
                int selectedValue = (int)comboBoxEdit2.EditValue;

                // Show a confirmation dialog to the user
                var confirmResult = MessageBox.Show(
                    "Are you sure you want to undo the Planning associated with the selected value?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Perform deletions
                        int rowsAffectedD = this.tbl_Multi_PO_Plan_DTableAdapter.Delete(selectedValue);
                        int rowsAffected = this.tbl_Multi_PO_PlanTableAdapter.Delete(selectedValue);

                        // Check if the deletions were successful
                        if (rowsAffectedD > 0 || rowsAffected > 0)
                        {
                            MessageBox.Show("Records deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.tbl_Multi_PO_PlanTableAdapter.Fill(dSPlanning.tbl_Multi_PO_Plan);
                            this.view_Multi_po_PlanRECTableAdapter.Fill(dSPlanning.View_Multi_po_PlanREC, (int)comboBoxEdit2.EditValue);
                        }
                        else
                        {
                            MessageBox.Show("No records were found for the selected value.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions that may occur
                        MessageBox.Show($"An error occurred while deleting records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
                
            }
            else
            {
                MessageBox.Show("Please select a valid value from the dropdown.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (tbl_Multi_PO_ReqInsertTableAdapter.FillBy(this.mISDataSet.tbl_Multi_PO_ReqInsert, (int)comboBoxEdit2.EditValue) > 0)
            {
                MessageBox.Show("Can not Undo Planning", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DeleteRecords();

                int selectedValue;
                if (comboBoxEdit2.EditValue != null && int.TryParse(comboBoxEdit2.EditValue.ToString(), out selectedValue) && selectedValue > 0)
                {
                    this.view_Multi_po_PlanRECTableAdapter.Fill(this.dSPlanning.View_Multi_po_PlanREC, selectedValue);
                    this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSPlanning.View_Multi_Plan_Req, selectedValue);
                }
              
            }

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            //this.view_Multi_PO_Planning_ReportsTableAdapter.Fill(this.dSPlanning.View_Multi_PO_Planning_Reports,dateEdit1.DateTime,dateEdit2.DateTime);
            if ( !string.IsNullOrEmpty(dateEdit3.Text))
            {
                // Create an instance of Form1
                Form1 objFrmFilter = new Form1();

                // Path to your Crystal Report file
                string reportName = @"\\dnsserver\MyReports$\MultiProduction\RptS4Requisition.rpt";

            


                


                string parameters = "";
                // Construct the selection formula string
                string selectionFormula = "";
                var requisitionDate = ((DateTime)dateEdit3.EditValue).ToString("yyyy-MM-dd HH-mm-ss");

                // Create the selection formula with proper formatting
                selectionFormula = $"{{View_Rpt_Mat_Requisition.RequisitionDate}} = DateTime({requisitionDate.Replace("-", ",").Replace(" ", ",")})";


                //selectionFormula = $"{{View_Multi_PO_Reports.CustReqDate}} in DateTime ({formattedDate1Start}) to DateTime ({formattedDate2End})";

                // View the report
                if (objFrmFilter.ViewReport(reportName, selectionFormula))
                {
                    FrmMain mainForm = (FrmMain)Application.OpenForms.OfType<FrmMain>().FirstOrDefault();
                    if (mainForm != null)
                    {
                        objFrmFilter.ShowDialog();
                        //await mainForm.ShowReportAsync<objFrmFilter>();
                    }
                    else
                    {
                        MessageBox.Show(" form not found.");
                    }


                    //await FrmMain.ShowOrToggleFormAsync<objFrmFilter>();
                    // Show the form
                    //objFrmFilter.ShowDialog(); // Use ShowDialog if you want it as a modal form or Show if it should be modeless
                }

                else
                {
                    // Handle the case where the report could not be loaded
                    MessageBox.Show("Failed to load the report.");
                
            }
        }
            else
            {
                MessageBox.Show("Select Date First.");

            }
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton1.Checked)
            {
                this.view_Multi_Plan_ReqTableAdapter.FillBy(this.dSPlanning.View_Multi_Plan_Req, (int)comboBoxEdit2.EditValue, 22);
            }
            else
            {
                this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSPlanning.View_Multi_Plan_Req, (int)comboBoxEdit2.EditValue);
            }
        }

        private void checkedComboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //// Specify the exact description of the item you want to check
            //string specificItem = "Item Description"; // Replace with the actual item description

            //// Check if the specific item is checked
            //if (checkedComboBoxEdit1.CheckedItems.Contains(specificItem))
            //{
            //    // Show lookUpEdit1
            //    lookUpEdit1.Visible = true;
            //}
            //else
            //{
            //    // Hide lookUpEdit1 if the specific item is not checked
            //    lookUpEdit1.Visible = false;
            //}
        }
    }
}