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

namespace ERP_Production.Packing_Mateial_Requisition
{
    public partial class FrmPackingRequisition : DevExpress.XtraEditors.XtraForm
    {
        public FrmPackingRequisition()
        {
            InitializeComponent();
        }

        private void FrmPackingRequisition_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPackingMaterial.View_Multi_requisition_Packing' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'dSPackingMaterial.tbl_Multi_PO_Req1' table. You can move, or remove it, as needed.
            try
            {

            this.tbl_Multi_PO_Req1TableAdapter.Fill(this.dSPackingMaterial.tbl_Multi_PO_Req1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // TODO: This line of code loads data into the 'dSPackingMaterial.tbl_Multi_PO_Req' table. You can move, or remove it, as needed.
            //this.tbl_Multi_PO_ReqTableAdapter.Fill(this.dSPackingMaterial.tbl_Multi_PO_Req);
            // TODO: This line of code loads data into the 'dSPackingMaterial.tbl_Multi_PO_H' table. You can move, or remove it, as needed.
            //this.tbl_Multi_PO_HTableAdapter.Fill(this.dSPackingMaterial.tbl_Multi_PO_H);
            //// TODO: This line of code loads data into the 'dSPackingMaterial.View_MullinePacking_requ' table. You can move, or remove it, as needed.
            //this.view_MullinePacking_requTableAdapter.Fill(this.dSPackingMaterial.View_MullinePacking_requ);

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.tbl_Multi_PO_HTableAdapter.Fill(this.dSPackingMaterial.tbl_Multi_PO_H, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
            //this.view_Multi_requisition_PackingTableAdapter.Fill(this.dSPackingMaterial.View_Multi_requisition_Packing, (int?)searchLookUpEdit1.EditValue);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.view_MullinePacking_requTableAdapter.Fill(this.dSPackingMaterial.View_MullinePacking_requ, (int)searchLookUpEdit1.EditValue);
            this.view_Multi_requisition_PackingTableAdapter.Fill(this.dSPackingMaterial.View_Multi_requisition_Packing, (int?)searchLookUpEdit1.EditValue);
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
                        int POM = gridView.GetRowCellValue(selectedRowHandle, "POM") != DBNull.Value
                            ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "POM"))
                            : 0;
                        int POS = gridView.GetRowCellValue(selectedRowHandle, "POS") != DBNull.Value
                            ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "POS"))
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
                       

                        //decimal PartialQty = gridView.GetRowCellValue(selectedRowHandle, "PartialQty") != DBNull.Value
                        //   ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PartialQty"))
                        //: 0;
                        //string PlanType = gridView.GetRowCellValue(selectedRowHandle, "PlanType") != DBNull.Value
                        //    ? gridView.GetRowCellValue(selectedRowHandle, "PlanType").ToString()
                        //    : null;
                        string LineAgre = gridView.GetRowCellValue(selectedRowHandle, "LAName") != DBNull.Value
                           ? gridView.GetRowCellValue(selectedRowHandle, "LAName").ToString()
                           : null;

                        //string L4Name = gridView.GetRowCellValue(selectedRowHandle, "L4Name") != DBNull.Value
                        //    ? gridView.GetRowCellValue(selectedRowHandle, "L4Name").ToString()
                        //    : null;
                        string Code = gridView.GetRowCellValue(selectedRowHandle, "Code") != DBNull.Value
                           ? gridView.GetRowCellValue(selectedRowHandle, "Code").ToString()
                           : null;
                        string artSize = gridView.GetRowCellValue(selectedRowHandle, "Size") != DBNull.Value
                            ? gridView.GetRowCellValue(selectedRowHandle, "Size").ToString()
                            : null;

                        //string Unit = gridView.GetRowCellValue(selectedRowHandle, "Unit") != DBNull.Value
                        //    ? gridView.GetRowCellValue(selectedRowHandle, "Unit").ToString()
                        //    : null;

                        int Line = gridView.GetRowCellValue(selectedRowHandle, "PrdLine") != DBNull.Value
                            ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PrdLine"))
                            : 0;


                        DateTime? planDate = gridView.GetRowCellValue(selectedRowHandle, "PlanDate") != DBNull.Value
                            ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "PlanDate"))
                            : null;

                        //DateTime? custReqDate = gridView.GetRowCellValue(selectedRowHandle, "CustReqDate") != DBNull.Value
                        //    ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "CustReqDate"))
                        //    : null;

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

                        //DateTime? LpDate = gridView.GetRowCellValue(selectedRowHandle, "LPDate") != DBNull.Value
                        //    ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "LPDate"))
                        //    : null;
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
                        double AvailableQty = gridView.GetRowCellValue(selectedRowHandle, "AvailableQty") != DBNull.Value
                        ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "AvailableQty"))
                        : 0.0;

                        //object partialQtyValue = gridView.GetRowCellValue(selectedRowHandle, "PartielQty");

                        string factoryCode = gridView.GetRowCellValue(selectedRowHandle, "FactoryCode") != DBNull.Value
                            ? gridView.GetRowCellValue(selectedRowHandle, "FactoryCode").ToString()
                            : null;
                        planDate = planDate?.Date;
                        //custReqDate = custReqDate?.Date;
                        // DateTime? productionDateOnly = productionDate?.Date; // Uncomment if you want to use this variable
                        creationDate = creationDate?.Date;
                        //DateTime? exFactoryDateOnly = exFactoryDate?.Date;
                        //DateTime? lastEditDateOnly = lastEditDate?.Date;
                        //DateTime? lpDateOnly = lpDate?.Date;
                        //DateTime? psddOnly = psdd?.Date;
                        //DateTime? fpdOnly = fpd?.Date;
                        //DateTime? poddOnly = podd?.Date;
                        //secondConDate = secondConDate?.Date;

                        // Verify each date field before insertion
                        //VerifyDate(planDate, "PlanDate");
                        //VerifyDate(custReqDate, "CustReqDate");
                        ////VerifyDate(productionDate, "ProductionDate");
                        //VerifyDate(creationDate, "CreationDate");
                        //VerifyDate(ExfactoryDate, "ExFactoryDate");
                        //VerifyDate(LastEditDate, "LastEditDate");
                        //VerifyDate(LpDate, "LPDate");
                        ////VerifyDate(PODD, "PODD");
                        ////VerifyDate(FPD, "FPD");
                        ////VerifyDate(PSDD, "PSDD");
                        //VerifyDate(secondConDate, "SecondConfDate");
                        double PartialQty = gridView.GetRowCellValue(selectedRowHandle, "PartielQty") != DBNull.Value
                        ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "PartielQty"))
                        : 0.0;
                        double totalPlanQty;
                        totalPlanQty = PartialQty > 0 ? PartialQty : balance;

                        if (AvailableQty < totalPlanQty && AvailableQty != 0)
                        {
                            totalPlanQty = AvailableQty;
                        }
                        
                            if (dateEdit3.EditValue != null)
                             {
                            if (AvailableQty > 0)
                            {


                                if (PartialQty <= balance)
                                {

                                    int v = tbl_Multi_PO_Req1TableAdapter.Insert(null, ClientID, ModelID, ArtID, LineAgre, artSize, null, PrdLine, null, (decimal?)ReqFormula, 0,
                                    null, null, null, null, null, null, null, DateTime.Now.Date, null, PO, POM, POS, null, null, null, null, null, DateTime.Now.Date,
                                    null, null, null, null, planDate, null, null, null, null, null, null, artSize, (decimal?)totalPlanQty, dateEdit3.DateTime.Date, null, PSDD, FPD, PODD, null, Code);

                                    MessageBox.Show("Data inserted successfully!");

                                    this.view_MullinePacking_requTableAdapter.Fill(this.dSPackingMaterial.View_MullinePacking_requ, (int)searchLookUpEdit1.EditValue);
                                    this.view_Multi_requisition_PackingTableAdapter.Fill(this.dSPackingMaterial.View_Multi_requisition_Packing, (int?)searchLookUpEdit1.EditValue);
                                    //if (checkButton1.Checked)
                                    //{
                                    //    this.view_Multi_Plan_ReqTableAdapter.FillBy(this.dSPlanning.View_Multi_Plan_Req, (int)comboBoxEdit2.EditValue, 22);
                                    //}
                                    //else
                                    //{
                                    //    this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSPlanning.View_Multi_Plan_Req, (int)comboBoxEdit2.EditValue);
                                    //}
                                    //view_Multi_requsitionTableAdapter.Fill(this.dSPlanning.View_Multi_requsition, (int)comboBoxEdit2.EditValue);
                                }
                                else
                                {
                                    MessageBox.Show("Can not Send AvailableQty Error ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
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

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            // Ensure the comboBoxEdit2 has a valid value
            if (searchLookUpEdit1.EditValue != null)
            {
                int selectedValue = (int)searchLookUpEdit1.EditValue;

                // Show a confirmation dialog to the user
                var confirmResult = MessageBox.Show(
                    "Are you sure you want to undo the Requisition associated with the selected value?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Perform deletions
                        int rowsAffectedD = this.tbl_Multi_PO_Req1TableAdapter.DeleteQuery(selectedValue);
                        int rowsAffected = this.tbl_Multi_PO_Req1TableAdapter.DeleteQuery(selectedValue);

                        // Check if the deletions were successful
                        if (rowsAffectedD > 0 || rowsAffected > 0)
                        {
                            MessageBox.Show("Records deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.view_Multi_requisition_PackingTableAdapter.Fill(this.dSPackingMaterial.View_Multi_requisition_Packing, (int?)searchLookUpEdit1.EditValue);
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

        private void repositoryItemButtonEdit4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
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
                                tbl_Multi_PO_Req1TableAdapter.DeleteQuery(ReqID);
                                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                this.view_MullinePacking_requTableAdapter.Fill(this.dSPackingMaterial.View_MullinePacking_requ, (int)searchLookUpEdit1.EditValue);
                                this.view_Multi_requisition_PackingTableAdapter.Fill(this.dSPackingMaterial.View_Multi_requisition_Packing, (int?)searchLookUpEdit1.EditValue);

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
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            //this.view_Multi_PO_Planning_ReportsTableAdapter.Fill(this.dSPlanning.View_Multi_PO_Planning_Reports,dateEdit1.DateTime,dateEdit2.DateTime);
            if (!string.IsNullOrEmpty(dateEdit3.Text))
            {
                // Create an instance of Form1
                Form1 objFrmFilter = new Form1();

                // Path to your Crystal Report file
                string reportName = @"\\dnsserver\MyReports$\MultiProduction\RptS4RequisitionPacking.rpt";







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

        private void searchLookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpEdit1.EditValue != null && (int)searchLookUpEdit1.EditValue > 0)
            {
                int selectedValue = (int)searchLookUpEdit1.EditValue;

                this.view_MullinePacking_requTableAdapter.Fill(this.dSPackingMaterial.View_MullinePacking_requ, selectedValue);
                this.view_Multi_requisition_PackingTableAdapter.Fill(this.dSPackingMaterial.View_Multi_requisition_Packing, selectedValue);
            }

        }

        private void dateEdit9_EditValueChanged(object sender, EventArgs e)
        {
            if (dateEdit9.EditValue != null && dateEdit4.EditValue != null)
            {
                DateTime? startDate = (DateTime?)dateEdit9.EditValue;
                DateTime? endDate = (DateTime?)dateEdit4.EditValue;

                if (startDate.HasValue && endDate.HasValue && startDate.Value > DateTime.MinValue && endDate.Value > DateTime.MinValue)
                {
                    this.tbl_Multi_PO_HTableAdapter.Fill(this.dSPackingMaterial.tbl_Multi_PO_H, startDate, endDate);
                }
            }

        }

        private void dateEdit4_EditValueChanged(object sender, EventArgs e)
        {
            if (dateEdit9.EditValue != null && dateEdit4.EditValue != null)
            {
                DateTime? startDate = (DateTime?)dateEdit9.EditValue;
                DateTime? endDate = (DateTime?)dateEdit4.EditValue;

                if (startDate.HasValue && endDate.HasValue && startDate.Value > DateTime.MinValue && endDate.Value > DateTime.MinValue)
                {
                    this.tbl_Multi_PO_HTableAdapter.Fill(this.dSPackingMaterial.tbl_Multi_PO_H, startDate, endDate);
                }
            }

        }

        private void panelControl20_Paint(object sender, PaintEventArgs e)
        {

        }


        //private void simpleButton5_Click(object sender, EventArgs e)
        //{
        //    if (tbl_Multi_PO_Req1TableAdapter.FillBy(this.mISDataSet.tbl_Multi_PO_ReqInsert, (int)searchLookUpEdit1.EditValue) > 0)
        //    {
        //        MessageBox.Show("Can not Undo Planning", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    else
        //    {
        //        DeleteRecords();

        //        int selectedValue;
        //        if (searchLookUpEdit1.EditValue != null && int.TryParse(searchLookUpEdit1.EditValue.ToString(), out selectedValue) && selectedValue > 0)
        //        {
        //            this.view_Multi_po_PlanRECTableAdapter.Fill(this.dSPlanning.View_Multi_po_PlanREC, selectedValue);
        //            this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSPlanning.View_Multi_Plan_Req, selectedValue);
        //        }

        //    }
        //}
    }
}