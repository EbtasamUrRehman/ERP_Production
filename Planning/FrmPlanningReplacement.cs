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
    public partial class frmLabelPlanning : DevExpress.XtraEditors.XtraForm
    {
        public frmLabelPlanning()
        {
            InitializeComponent();
        }
        //private void GetGridView()
        //{
        //    DateTime startDate = dateEdit5.DateTime;
        //    DateTime endDate = dateEdit6.DateTime;
        //    if (startDate != DateTime.MinValue && endDate != DateTime.MinValue)
        //    {
        //        // Proceed with your logic here

        //        if (radioButtonCRD.Checked)
        //        {
        //            try
        //            {
        //                this.view_Multi_po_planningTableAdapter.CustReqDate(this.dSRep.View_Multi_po_planning, startDate, endDate, (string)comboBoxEdit1.EditValue);
        //            }
        //            catch (Exception ex)
        //            {
        //                // Handle the exception, for example, log it or show a message to the user
        //                MessageBox.Show($"An error occurred while fetching data by Customer Request Date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        else if (radioButtonLP.Checked)
        //        {
        //            try
        //            {
        //                this.view_Multi_po_planningTableAdapter.LPDate(this.dSRep.View_Multi_po_planning, startDate, endDate, (string)comboBoxEdit1.EditValue);
        //            }
        //            catch (Exception ex)
        //            {
        //                // Handle the exception, for example, log it or show a message to the user
        //                MessageBox.Show($"An error occurred while fetching data by Plan Date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        else if (radioButtonBatch.Checked)
        //        {
        //            try
        //            {
        //                this.view_Multi_po_planningTableAdapter.BatchDate(this.dSRep.View_Multi_po_planning, startDate, endDate, (string)comboBoxEdit1.EditValue);
        //            }
        //            catch (Exception ex)
        //            {
        //                // Handle the exception, for example, log it or show a message to the user
        //                MessageBox.Show($"An error occurred while fetching data by Batch Date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        //else if (radioButtonFP.Checked)
        //        //{
        //        //    try
        //        //    {
        //        //        this.view_Multi_po_planningTableAdapter.FPDate(this.dSPlanning.View_Multi_po_planning, startDate, endDate);
        //        //    }
        //        //    catch (Exception ex)
        //        //    {
        //        //        // Handle the exception, for example, log it or show a message to the user
        //        //        MessageBox.Show($"An error occurred while fetching data by Batch Date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        //    }
        //        //}
        //        else if (radioButtonPlan.Checked)
        //        {
        //            try
        //            {
        //                this.view_Multi_po_planningTableAdapter.FillPODD(this.dSRep.View_Multi_po_planning, (string)comboBoxEdit1.EditValue, startDate, endDate);
        //            }
        //            catch (Exception ex)
        //            {
        //                // Handle the exception, for example, log it or show a message to the user
        //                MessageBox.Show($"An error occurred while fetching data by Batch Date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        //else if (radioButtonPS.Checked)
        //        //{
        //        //    try
        //        //    {
        //        //        this.view_Multi_po_planningTableAdapter.PSDate(this.dSPlanning.View_Multi_po_planning, startDate, endDate);
        //        //    }
        //        //    catch (Exception ex)
        //        //    {
        //        //        // Handle the exception, for example, log it or show a message to the user
        //        //        MessageBox.Show($"An error occurred while fetching data by Batch Date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        //    }
        //        //}
        //        else
        //        {
        //            MessageBox.Show("Please select valid start and end dates.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }


        //    gridControl1.Show();

        //    // Use the selectionFormula for your report as needed
        //    // Example: Set the formula for a Crystal Report object
        //    // reportDocument.DataDefinition.RecordSelectionFormula = selectionFormula;
        //    //this.tbl_Multi_PO_ReqTableAdapter.Fill(this.dSPlanning.tbl_Multi_PO_Req);
        //}

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void FrmPlanningReplacement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mISDataSet.tbl_Multi_PO_ReqInsert' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_ReqInsertTableAdapter.Fill(this.mISDataSet.tbl_Multi_PO_ReqInsert);
            // TODO: This line of code loads data into the 'dSRep.tbl_Prd_Lines' table. You can move, or remove it, as needed.
            this.tbl_Prd_LinesTableAdapter.Fill(this.dSRep.tbl_Prd_Lines);
            // TODO: This line of code loads data into the 'dSRep.tbl_Multi_PO_S' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_STableAdapter.Fill(this.dSRep.tbl_Multi_PO_S);
            // TODO: This line of code loads data into the 'dSRep.tbl_Multi_PO_H' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_HTableAdapter.Fill(this.dSRep.tbl_Multi_PO_H);
            // TODO: This line of code loads data into the 'dSRep.Tbl_Multi_PO_Plan_D' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_Plan_DTableAdapter.Fill(this.dSRep.Tbl_Multi_PO_Plan_D);
            // TODO: This line of code loads data into the 'dSRep.View_Multi_po_planning' table. You can move, or remove it, as needed.


        }

        //private void repositoryItemPlan_Click(object sender, EventArgs e)
        //{
        //    var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl1.FocusedView;

        //    if (gridView.SelectedRowsCount > 0)
        //    {
        //        var selectedRowHandle = gridView.GetSelectedRows()[0];

        //        if (selectedRowHandle >= 0)
        //        {
        //            try
        //            {
        //                // Initialize variables with default values
        //                int partialQty = 0;
        //                int totalPlanQty = 0;
        //                int clientId = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ClientID") ?? 0);
        //                int modelId = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ModelID") ?? 0);
        //                int artId = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ArtID") ?? 0);
        //                string artSize = gridView.GetRowCellValue(selectedRowHandle, "Size") as string ?? string.Empty;
        //                string PlantCode = gridView.GetRowCellValue(selectedRowHandle, "PlantCode") as string ?? string.Empty;
        //                string POCode = gridView.GetRowCellValue(selectedRowHandle, "POCode") as string ?? string.Empty;
        //                string BarCode = gridView.GetRowCellValue(selectedRowHandle, "BarCode") as string ?? string.Empty;
        //                int POS = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "POS") ?? 0);
        //                int PO = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PO") ?? 0);
        //                int POM = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "POM") ?? 0);
        //                string LAName = gridView.GetRowCellValue(selectedRowHandle, "LAName") as string ?? string.Empty;
        //                int Line = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "Line") ?? 0);

        //                DateTime GetDateValue(object value)
        //                {
        //                    return value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(value);
        //                }

        //                DateTime planDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "PlanDate"));

        //                DateTime PSDD = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "PSDD"));
        //                DateTime FPD = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "FPD"));
        //                DateTime PODD = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "PODD"));
        //                DateTime LPDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "LPDate"));

        //                DateTime ExFactoryDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "ExFactoryDate"));
        //                DateTime custReqDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "CustReqDate"));
        //                DateTime SecondConfDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "SecondConfDate"));
        //                DateTime LastEditDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "LastEditDate"));
        //                DateTime ReceiveDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "ReceiveDate"));
        //                //DateTime productionDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "ProductionDate"));

        //                int totalQty = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "TotalQty") ?? 0);
        //                int balance = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "Balance") ?? 0);

        //                object partialQtyValue = gridView.GetRowCellValue(selectedRowHandle, "PartielQty");
        //                partialQty = partialQtyValue == DBNull.Value ? 0 : Convert.ToInt32(partialQtyValue);

        //                string factoryCode = gridView.GetRowCellValue(selectedRowHandle, "FactoryCode") as string ?? string.Empty;

        //                // Calculate totalPlanQty based on partialQty and balance
        //                totalPlanQty = partialQty > 0 ? partialQty : balance;

        //                // Ensure date values are within valid ranges
        //                DateTime minDate = new DateTime(1753, 1, 1);
        //                DateTime maxDate = new DateTime(9999, 12, 31);

        //                void CheckDateRange(DateTime date, string fieldName)
        //                {
        //                    if (date < minDate || date > maxDate)
        //                    {
        //                        throw new Exception($"{fieldName} is out of range.");
        //                    }
        //                }

        //                CheckDateRange(custReqDate, "Customer Request Date");
        //                CheckDateRange(planDate, "Plan Date");
        //                CheckDateRange(SecondConfDate, "Second Confirmation Date");
        //                CheckDateRange(LastEditDate, "Last Edit Date");
        //                CheckDateRange(ReceiveDate, "Receive Date");

        //                // Fetch MaxPID
        //                int? maxPID = (int?)tbl_Multi_PO_PlanTableAdapter.ScalarQuery() + 1;

        //                if (!maxPID.HasValue)
        //                {
        //                    maxPID = 1; // If maxPID is null, set maxPID to 1.
        //                }

        //                // Check if PrdLine.EditValue is valid and if partialQty is less than balance
        //                if (PrdLine.EditValue != null && Convert.ToInt32(PrdLine.EditValue) > 0)
        //                {
        //                    if (partialQty <= balance)
        //                    {
        //                        // Insert into tbl_Multi_PO_Plan
        //                        tbl_Multi_PO_PlanTableAdapter.Insert(maxPID.Value, clientId, modelId, artId, LAName, (int)PrdLine.EditValue, DateTime.Now, custReqDate, ExFactoryDate, LPDate, SecondConfDate, LastEditDate, DateTime.Now.Date, BarCode, null, planDate, factoryCode, totalPlanQty, null, null, artSize, PlantCode, PSDD, FPD, PODD, true, DateTime.Now.Date);

        //                        try
        //                        {
        //                            // Insert into tbl_Multi_PO_Plan_D
        //                            tbl_Multi_PO_Plan_DTableAdapter.Insert(maxPID.Value, clientId, modelId, artId, LAName, POCode, POM, artSize, totalPlanQty, Line, null, null, POS, PO, totalPlanQty);

        //                            MessageBox.Show("Data inserted successfully!");
        //                            //GetGridView();
        //                            this.tbl_Multi_PO_Plan_DTableAdapter.Fill(this.dSRep.Tbl_Multi_PO_Plan_D);
        //                            // TODO: This line of code loads data into the 'dSPlanning.tbl_Multi_PO_Plan' table. You can move, or remove it, as needed.
        //                            this.tbl_Multi_PO_PlanTableAdapter.FillBy(this.dSRep.tbl_Multi_PO_Plan);
        //                            // Refresh the data in the view
        //                            //this.view_Multi_po_planningTableAdapter.Fill(this.dSPlanning.View_Multi_po_planning);
        //                        }
        //                        catch (Exception ex)
        //                        {
        //                            MessageBox.Show($"Error inserting into tbl_Multi_PO_Plan_D: {ex.Message}");
        //                        }
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Partial quantity must be less than Balance.");
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Select MP Line first.");
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show($"Error: {ex.Message}");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Selected row handle is invalid.");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("No row selected!");
        //    }

        //}

        private void tabNavigationPage5_Paint(object sender, PaintEventArgs e)
        {

        }



        private void simpleButton7_Click(object sender, EventArgs e)
        {
            view_Multi_PO_ReplacementTableAdapter.Fill(dSRep.View_Multi_PO_Replacement, (int)searchLookUpEdit1.EditValue);
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            view_Multi_PO_ReplacementTableAdapter.Fill(dSRep.View_Multi_PO_Replacement, (int)searchLookUpEdit1.EditValue);
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl4.FocusedView;

            if (gridView.SelectedRowsCount > 0)
            {
                var selectedRowHandle = gridView.GetSelectedRows()[0];

                if (selectedRowHandle >= 0)
                {
                    try
                    {
                        // Initialize variables with default values
                        int partialQty = 0;
                        int PO = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PO") ?? 0);
                        int POM = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "POM") ?? 0);
                        int POS = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "POS") ?? 0);
                        var partialQtyValue = gridView.GetRowCellValue(selectedRowHandle, "PartielQty");
                        partialQty = partialQtyValue == DBNull.Value ? 0 : Convert.ToInt32(partialQtyValue);

                        try
                        {
                            tbl_Multi_PO_STableAdapter.UpdateQuery(partialQty, DateTime.Now.Date, PO, POS, POM);
                            MessageBox.Show("Updated Successfully.");
                            view_Multi_PO_ReplacementTableAdapter.Fill(dSRep.View_Multi_PO_Replacement, (int)searchLookUpEdit1.EditValue);
                        }
                        catch (Exception ex)
                        {

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

        //private void repositoryItemPlan_Click_1(object sender, EventArgs e)
        //{
        //    {
        //        var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl1.FocusedView;

        //        if (gridView.SelectedRowsCount > 0)
        //        {
        //            var selectedRowHandle = gridView.GetSelectedRows()[0];

        //            if (selectedRowHandle >= 0)
        //            {
        //                try
        //                {
        //                    // Initialize variables with default values
        //                    int partialQty = 0;
        //                    int totalPlanQty = 0;
        //                    int clientId = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ClientID") ?? 0);
        //                    int modelId = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ModelID") ?? 0);
        //                    int artId = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ArtID") ?? 0);
        //                    string artSize = gridView.GetRowCellValue(selectedRowHandle, "Size") as string ?? string.Empty;
        //                    string PlantCode = gridView.GetRowCellValue(selectedRowHandle, "PlantCode") as string ?? string.Empty;
        //                    string POCode = gridView.GetRowCellValue(selectedRowHandle, "POCode") as string ?? string.Empty;
        //                    string BarCode = gridView.GetRowCellValue(selectedRowHandle, "BarCode") as string ?? string.Empty;
        //                    int POS = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "POS") ?? 0);
        //                    int PO = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PO") ?? 0);
        //                    int POM = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "POM") ?? 0);
        //                    string LAName = gridView.GetRowCellValue(selectedRowHandle, "LAName") as string ?? string.Empty;
        //                    int Line = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "Line") ?? 0);

        //                    DateTime GetDateValue(object value)
        //                    {
        //                        return value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(value);
        //                    }

        //                    DateTime planDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "PlanDate"));

        //                    DateTime PSDD = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "PSDD"));
        //                    DateTime FPD = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "FPD"));
        //                    DateTime PODD = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "PODD"));
        //                    DateTime LPDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "LPDate"));

        //                    DateTime ExFactoryDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "ExFactoryDate"));
        //                    DateTime custReqDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "CustReqDate"));
        //                    DateTime SecondConfDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "SecondConfDate"));
        //                    DateTime LastEditDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "LastEditDate"));
        //                    DateTime ReceiveDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "ReceiveDate"));
        //                    //DateTime productionDate = GetDateValue(gridView.GetRowCellValue(selectedRowHandle, "ProductionDate"));

        //                    int totalQty = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "TotalQty") ?? 0);
        //                    int balance = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "Balance") ?? 0);

        //                    object partialQtyValue = gridView.GetRowCellValue(selectedRowHandle, "PartielQty");
        //                    partialQty = partialQtyValue == DBNull.Value ? 0 : Convert.ToInt32(partialQtyValue);

        //                    string factoryCode = gridView.GetRowCellValue(selectedRowHandle, "FactoryCode") as string ?? string.Empty;

        //                    // Calculate totalPlanQty based on partialQty and balance
        //                    totalPlanQty = partialQty > 0 ? partialQty : balance;

        //                    // Ensure date values are within valid ranges
        //                    DateTime minDate = new DateTime(1753, 1, 1);
        //                    DateTime maxDate = new DateTime(9999, 12, 31);

        //                    void CheckDateRange(DateTime date, string fieldName)
        //                    {
        //                        if (date < minDate || date > maxDate)
        //                        {
        //                            throw new Exception($"{fieldName} is out of range.");
        //                        }
        //                    }

        //                    CheckDateRange(custReqDate, "Customer Request Date");
        //                    CheckDateRange(planDate, "Plan Date");
        //                    CheckDateRange(SecondConfDate, "Second Confirmation Date");
        //                    CheckDateRange(LastEditDate, "Last Edit Date");
        //                    CheckDateRange(ReceiveDate, "Receive Date");

        //                    // Fetch MaxPID
        //                    int? maxPID = (int?)tbl_Multi_PO_PlanTableAdapter.ScalarQuery() + 1;

        //                    if (!maxPID.HasValue)
        //                    {
        //                        maxPID = 1; // If maxPID is null, set maxPID to 1.
        //                    }

        //                    // Check if PrdLine.EditValue is valid and if partialQty is less than balance
        //                    if (PrdLine.EditValue != null && Convert.ToInt32(PrdLine.EditValue) > 0)
        //                    {
        //                        if (partialQty <= balance)
        //                        {
        //                            // Insert into tbl_Multi_PO_Plan
        //                            tbl_Multi_PO_PlanTableAdapter.Insert(maxPID.Value, clientId, modelId, artId, LAName, (int)PrdLine.EditValue, DateTime.Now, custReqDate, ExFactoryDate, LPDate, SecondConfDate, LastEditDate, DateTime.Now.Date, BarCode, null, planDate, factoryCode, totalPlanQty, null, null, artSize, PlantCode, PSDD, FPD, PODD, true, DateTime.Now.Date);

        //                            try
        //                            {
        //                                // Insert into tbl_Multi_PO_Plan_D
        //                                tbl_Multi_PO_Plan_DTableAdapter.Insert(maxPID.Value, clientId, modelId, artId, LAName, POCode, POM, artSize, totalPlanQty, Line, null, null, POS, PO, totalPlanQty);

        //                                MessageBox.Show("Data inserted successfully!");
        //                                GetGridView();
        //                                this.tbl_Multi_PO_Plan_DTableAdapter.Fill(this.dSRep.Tbl_Multi_PO_Plan_D);
        //                                // TODO: This line of code loads data into the 'dSPlanning.tbl_Multi_PO_Plan' table. You can move, or remove it, as needed.
        //                                this.tbl_Multi_PO_PlanTableAdapter.FillBy(this.dSRep.tbl_Multi_PO_Plan);
        //                                // Refresh the data in the view
        //                                //this.view_Multi_po_planningTableAdapter.Fill(this.dSPlanning.View_Multi_po_planning);
        //                            }
        //                            catch (Exception ex)
        //                            {
        //                                MessageBox.Show($"Error inserting into tbl_Multi_PO_Plan_D: {ex.Message}");
        //                            }
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Partial quantity must be less than Balance.");
        //                        }
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Select MP Line first.");
        //                    }
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show($"Error: {ex.Message}");
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Selected row handle is invalid.");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("No row selected!");
        //        }

        //    }
        //}

        //private void simpleButton3_Click_1(object sender, EventArgs e)
        //{

        //    GetGridView();

        //    try
        //    {
        //        tbl_Multi_PO_PlanTableAdapter.FillBy(this.dSRep.tbl_Multi_PO_Plan);

        //        int selectedValue;
        //        if (comboBoxEdit2.EditValue != null && int.TryParse(comboBoxEdit2.EditValue.ToString(), out selectedValue) && selectedValue > 0)
        //        {
        //            this.view_Multi_po_PlanRECTableAdapter.Fill(this.dSRep.View_Multi_po_PlanREC, selectedValue);
        //            this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSRep.View_Multi_Plan_Req, selectedValue);
        //        }
        //        //this.view_Multi_po_PlanRECTableAdapter.Fill(this.dSPlanning.View_Multi_po_PlanREC, (int)comboBoxEdit2.EditValue);
        //        //this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSPlanning.View_Multi_Plan_Req, (int)comboBoxEdit2.EditValue);

        //    }

        //    catch (Exception ex)
        //    {
        //        // Log the exception or handle it as needed
        //        MessageBox.Show($"An error occurred: {ex.Message}");
        //        // Optionally, rethrow the exception if you want it to propagate further
        //        // throw;
        //    }
        //}

        //private void simpleButton4_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        tbl_Multi_PO_Plan1TableAdapter.Fill(dSRep.tbl_Multi_PO_Plan1, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue, (string)comboBoxEdit3.EditValue);
        //        if (checkButton1.Checked)
        //        {
        //            this.view_Multi_Plan_ReqTableAdapter.FillBy(this.dSRep.View_Multi_Plan_Req, (int)comboBoxEdit2.EditValue, 22);
        //        }
        //        else
        //        {
        //            this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSRep.View_Multi_Plan_Req, (int)comboBoxEdit2.EditValue);
        //        }

        //    }

        //    catch (Exception ex)
        //    {

        //        // Optionally, rethrow the exception if you want it to propagate further
        //        // throw;
        //    }
        //}
        //private void DeleteRecords()
        //{
        //    // Ensure the comboBoxEdit2 has a valid value
        //    if (comboBoxEdit2.EditValue != null)
        //    {
        //        int selectedValue = (int)comboBoxEdit2.EditValue;

        //        // Show a confirmation dialog to the user
        //        var confirmResult = MessageBox.Show(
        //            "Are you sure you want to undo the Planning associated with the selected value?",
        //            "Confirm Deletion",
        //            MessageBoxButtons.YesNo,
        //            MessageBoxIcon.Question
        //        );

        //        if (confirmResult == DialogResult.Yes)
        //        {
        //            try
        //            {
        //                // Perform deletions
        //                int rowsAffectedD = this.tbl_Multi_PO_Plan_DTableAdapter.Delete(selectedValue);
        //                int rowsAffected = this.tbl_Multi_PO_PlanTableAdapter.Delete(selectedValue);

        //                // Check if the deletions were successful
        //                if (rowsAffectedD > 0 || rowsAffected > 0)
        //                {
        //                    MessageBox.Show("Records deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    this.tbl_Multi_PO_Plan1TableAdapter.Fill(dSRep.tbl_Multi_PO_Plan1, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue, (string)comboBoxEdit3.EditValue);
        //                    this.view_Multi_po_PlanRECTableAdapter.Fill(dSRep.View_Multi_po_PlanREC, (int)comboBoxEdit2.EditValue);
        //                }
        //                else
        //                {
        //                    MessageBox.Show("You Can not Delete Record From here.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                // Handle any exceptions that may occur
        //                MessageBox.Show($"An error occurred while deleting records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }


        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select a valid value from the dropdown.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}
        //private void simpleButton5_Click(object sender, EventArgs e)
        //{
        //    if (tbl_Multi_PO_ReqInsertTableAdapter.FillBy(this.mISDataSet.tbl_Multi_PO_ReqInsert, (int)comboBoxEdit2.EditValue) > 0)
        //    {
        //        MessageBox.Show("Can not Undo Planning", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    else
        //    {
        //        DeleteRecords();

        //        int selectedValue;
        //        if (comboBoxEdit2.EditValue != null && int.TryParse(comboBoxEdit2.EditValue.ToString(), out selectedValue) && selectedValue > 0)
        //        {
        //            this.view_Multi_po_PlanRECTableAdapter.Fill(this.dSRep.View_Multi_po_PlanREC, selectedValue);
        //            this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSRep.View_Multi_Plan_Req, selectedValue);
        //        }

        //    }
        //}

        //private void checkButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkButton1.Checked)
        //    {
        //        this.view_Multi_Plan_ReqTableAdapter.FillBy(this.dSRep.View_Multi_Plan_Req, (int)comboBoxEdit2.EditValue, 22);
        //    }
        //    else
        //    {
        //        this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSRep.View_Multi_Plan_Req, (int)comboBoxEdit2.EditValue);
        //    }
        //}

        //private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        //{
        //    var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl2.FocusedView;

        //    if (gridView.SelectedRowsCount > 0)
        //    {
        //        var selectedRowHandle = gridView.GetSelectedRows()[0];

        //        if (selectedRowHandle >= 0)
        //        {
        //            try
        //            {
        //                int MPID = gridView.GetRowCellValue(selectedRowHandle, "MPID") != DBNull.Value
        //                    ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "MPID"))
        //                    : 0;
        //                int ArtID = gridView.GetRowCellValue(selectedRowHandle, "ArtID") != DBNull.Value
        //                ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ArtID"))
        //                : 0;
        //                int ClientID = gridView.GetRowCellValue(selectedRowHandle, "ClientID") != DBNull.Value
        //                ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ClientID"))
        //                : 0;
        //                int ModelID = gridView.GetRowCellValue(selectedRowHandle, "ModelID") != DBNull.Value
        //                ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ModelID"))
        //                : 0;


        //                int PrdLine = gridView.GetRowCellValue(selectedRowHandle, "PrdLine") != DBNull.Value
        //                    ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PrdLine"))
        //                    : 0;


        //                double ReqFormula = gridView.GetRowCellValue(selectedRowHandle, "MatFormula") != DBNull.Value
        //                  ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "MatFormula"))
        //                  : 0.0;

        //                int RequiredQty = gridView.GetRowCellValue(selectedRowHandle, "RequiredQty") != DBNull.Value
        //                    ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "RequiredQty"))
        //                    : 0;
        //                double PartialQty = gridView.GetRowCellValue(selectedRowHandle, "PartialQty") != DBNull.Value
        //                 ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "PartialQty"))
        //                 : 0.0;

        //                //decimal PartialQty = gridView.GetRowCellValue(selectedRowHandle, "PartialQty") != DBNull.Value
        //                //   ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PartialQty"))
        //                //: 0;
        //                string PlanType = gridView.GetRowCellValue(selectedRowHandle, "PlanType") != DBNull.Value
        //                    ? gridView.GetRowCellValue(selectedRowHandle, "PlanType").ToString()
        //                    : null;
        //                string LineAgre = gridView.GetRowCellValue(selectedRowHandle, "LAName") != DBNull.Value
        //                   ? gridView.GetRowCellValue(selectedRowHandle, "LAName").ToString()
        //                   : null;

        //                string L4Name = gridView.GetRowCellValue(selectedRowHandle, "L4Name") != DBNull.Value
        //                    ? gridView.GetRowCellValue(selectedRowHandle, "L4Name").ToString()
        //                    : null;
        //                string Code = gridView.GetRowCellValue(selectedRowHandle, "Code") != DBNull.Value
        //                   ? gridView.GetRowCellValue(selectedRowHandle, "Code").ToString()
        //                   : null;
        //                string artSize = gridView.GetRowCellValue(selectedRowHandle, "Size") != DBNull.Value
        //                    ? gridView.GetRowCellValue(selectedRowHandle, "Size").ToString()
        //                    : null;

        //                string Unit = gridView.GetRowCellValue(selectedRowHandle, "Unit") != DBNull.Value
        //                    ? gridView.GetRowCellValue(selectedRowHandle, "Unit").ToString()
        //                    : null;

        //                int Line = gridView.GetRowCellValue(selectedRowHandle, "PrdLine") != DBNull.Value
        //                    ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PrdLine"))
        //                    : 0;


        //                DateTime? planDate = gridView.GetRowCellValue(selectedRowHandle, "PlanDate") != DBNull.Value
        //                    ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "PlanDate"))
        //                    : null;

        //                DateTime? custReqDate = gridView.GetRowCellValue(selectedRowHandle, "CustReqDate") != DBNull.Value
        //                    ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "CustReqDate"))
        //                    : null;

        //                //DateTime? productionDate = gridView.GetRowCellValue(selectedRowHandle, "ProductionDate") != DBNull.Value
        //                //    ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "ProductionDate"))
        //                //    : null;

        //                DateTime? creationDate = gridView.GetRowCellValue(selectedRowHandle, "CreationDate") != DBNull.Value
        //                    ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "CreationDate"))
        //                    : null;

        //                DateTime? ExfactoryDate = gridView.GetRowCellValue(selectedRowHandle, "ExFactoryDate") != DBNull.Value
        //                    ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "ExFactoryDate"))
        //                    : null;

        //                DateTime? LastEditDate = gridView.GetRowCellValue(selectedRowHandle, "LastEditDate") != DBNull.Value
        //                    ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "LastEditDate"))
        //                    : null;

        //                DateTime? LpDate = gridView.GetRowCellValue(selectedRowHandle, "LPDate") != DBNull.Value
        //                    ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "LPDate"))
        //                    : null;
        //                DateTime? PSDD = gridView.GetRowCellValue(selectedRowHandle, "PSDD") != DBNull.Value
        //                   ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "PSDD"))
        //                   : null;
        //                DateTime? FPD = gridView.GetRowCellValue(selectedRowHandle, "FPD") != DBNull.Value
        //                   ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "FPD"))
        //                   : null;
        //                DateTime? PODD = gridView.GetRowCellValue(selectedRowHandle, "PODD") != DBNull.Value
        //                   ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "PODD"))
        //                   : null;


        //                DateTime? secondConDate = gridView.GetRowCellValue(selectedRowHandle, "SecondConfDate") != DBNull.Value
        //                    ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "SecondConfDate"))
        //                    : null;
        //                //double RecQty = gridView.GetRowCellValue(selectedRowHandle, "RecQty") != DBNull.Value
        //                //? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "RecQty"))
        //                //: 0.0;


        //                //int RecQty = gridView.GetRowCellValue(selectedRowHandle, "RecQty") != DBNull.Value
        //                //    ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "RecQty"))
        //                //    : 0;
        //                double RecQty = gridView.GetRowCellValue(selectedRowHandle, "RecQty") != DBNull.Value
        //               ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "RecQty"))
        //               : 0.0;
        //                //int balance = gridView.GetRowCellValue(selectedRowHandle, "Balance") != DBNull.Value
        //                //    ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "Balance"))
        //                //    : 0;
        //                double balance = gridView.GetRowCellValue(selectedRowHandle, "Balance") != DBNull.Value
        //                ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "Balance"))
        //                : 0.0;

        //                object partialQtyValue = gridView.GetRowCellValue(selectedRowHandle, "PartialQty");

        //                string factoryCode = gridView.GetRowCellValue(selectedRowHandle, "FactoryCode") != DBNull.Value
        //                    ? gridView.GetRowCellValue(selectedRowHandle, "FactoryCode").ToString()
        //                    : null;

        //                // Verify each date field before insertion
        //                VerifyDate(planDate, "PlanDate");
        //                VerifyDate(custReqDate, "CustReqDate");
        //                //VerifyDate(productionDate, "ProductionDate");
        //                VerifyDate(creationDate, "CreationDate");
        //                VerifyDate(ExfactoryDate, "ExFactoryDate");
        //                VerifyDate(LastEditDate, "LastEditDate");
        //                VerifyDate(LpDate, "LPDate");
        //                //VerifyDate(PODD, "PODD");
        //                //VerifyDate(FPD, "FPD");
        //                //VerifyDate(PSDD, "PSDD");
        //                VerifyDate(secondConDate, "SecondConfDate");
        //                double totalPlanQty;
        //                totalPlanQty = PartialQty > 0 ? PartialQty : balance;

        //                if (dateEdit3.EditValue != null)
        //                {
        //                    if (PartialQty <= balance)
        //                    {
        //                        int v = tbl_Multi_PO_ReqInsertTableAdapter.Insert(MPID, ClientID, ModelID, ArtID, LineAgre, artSize, null, PrdLine, null, (decimal?)ReqFormula, (decimal)RecQty,
        //                        null, null, null, null, null, null, null, DateTime.Now.Date, null, null, null, null, null, null, Unit, null, null, DateTime.Now.Date,
        //                        null, null, Unit, null, planDate, L4Name, null, null, null, null, null, artSize, (decimal?)totalPlanQty, dateEdit3.DateTime.Date, custReqDate, null, null, null, LpDate, Code);

        //                        MessageBox.Show("Data inserted successfully!");
        //                        if (checkButton1.Checked)
        //                        {
        //                            this.view_Multi_Plan_ReqTableAdapter.FillBy(this.dSRep.View_Multi_Plan_Req, (int)comboBoxEdit2.EditValue, 22);
        //                        }
        //                        else
        //                        {
        //                            this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSRep.View_Multi_Plan_Req, (int)comboBoxEdit2.EditValue);
        //                        }
        //                        view_Multi_requsitionTableAdapter.Fill(this.dSRep.View_Multi_requsition, (int)comboBoxEdit2.EditValue);
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Partial Qty must be less than balance.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    }


        //                }
        //                else
        //                {
        //                    MessageBox.Show("Please Enter Requisition date.");
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show($"Error: {ex.Message}");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Selected row handle is invalid.");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("No row selected!");
        //    }

        //    void VerifyDate(DateTime? dateValue, string fieldName)
        //    {
        //        // Example validation logic
        //        if (dateValue.HasValue && (dateValue.Value < new DateTime(1900, 1, 1) || dateValue.Value > DateTime.MaxValue))
        //        {
        //            throw new ArgumentOutOfRangeException(fieldName, "The date value is out of range.");
        //        }
        //    }
        //}

        //private void repositoryItemButtonEdit4_Click(object sender, EventArgs e)
        //{
        //    var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl3.FocusedView;

        //    if (gridView.SelectedRowsCount > 0)
        //    {
        //        var selectedRowHandle = gridView.GetSelectedRows()[0];

        //        if (selectedRowHandle >= 0)
        //        {
        //            try
        //            {
        //                // Retrieve values from the selected row
        //                int ReqID = gridView.GetRowCellValue(selectedRowHandle, "ReqID") != DBNull.Value
        //                    ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ReqID"))
        //                    : 0;


        //                // Perform deletion
        //                var confirmResult = MessageBox.Show(
        //         "Are you sure you want to delete this record?",
        //         "Confirm Deletion",
        //         MessageBoxButtons.YesNo,
        //         MessageBoxIcon.Question
        //     );

        //                if (confirmResult == DialogResult.Yes)
        //                {
        //                    // Perform deletion
        //                    tbl_Multi_PO_ReqInsertTableAdapter.Delete(ReqID);
        //                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        //                    int selectedValue;
        //                    if (comboBoxEdit2.EditValue != null && int.TryParse(comboBoxEdit2.EditValue.ToString(), out selectedValue) && selectedValue > 0)
        //                    {
        //                        view_Multi_requsitionTableAdapter.Fill(this.dSRep.View_Multi_requsition, (int)comboBoxEdit2.EditValue);
        //                        this.view_Multi_po_PlanRECTableAdapter.Fill(this.dSRep.View_Multi_po_PlanREC, selectedValue);
        //                        this.view_Multi_Plan_ReqTableAdapter.Fill(this.dSRep.View_Multi_Plan_Req, selectedValue);
        //                    }

        //                }

        //            }
        //            catch (Exception ex)
        //            {
        //                // Handle any exceptions that may occur
        //                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Selected row handle is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("No row selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}