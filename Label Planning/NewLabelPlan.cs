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

namespace ERP_Production.Label_Planning
{
    public partial class NewLabelPlan : DevExpress.XtraEditors.XtraForm
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSLabelPlanning.View_Multi_LabelPlanning_Final' table. You can move, or remove it, as needed.
            //this.view_Multi_LabelPlanning_FinalTableAdapter.Fill(this.dSLabelPlanning.View_Multi_LabelPlanning_Final);
            // TODO: This line of code loads data into the 'dSLabelPlanning.tbl_Pro_Client' table. You can move, or remove it, as needed.
            //this.tbl_Pro_ClientTableAdapter.Fill(this.dSLabelPlanning.tbl_Pro_Client);
            //this.view_Multi_Label_Plan_AMTableAdapter.Fill(this.dSLabelPlanning1.View_Multi_Label_Plan_AM, (DateTime?)dateEdit1.EditValue);
            dateEdit1.EditValue = DateTime.Now;
            dateEdit4.EditValue = DateTime.Now;
            dateEdit9.EditValue = DateTime.Now;
            this.view_Multi_Label_Plan_AMTableAdapter.Fill(this.dSLabelPlanning.View_Multi_Label_Plan_AM, ((DateTime?)dateEdit1.EditValue).Value.Day, ((DateTime?)dateEdit1.EditValue).Value.Month, ((DateTime?)dateEdit1.EditValue).Value.Year);
        }

        public NewLabelPlan()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.view_Multi_LabelPlanning_FinalCompleteTableAdapter.Fill(this.dSLabelPlanning.View_Multi_LabelPlanning_FinalComplete, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(secondConfDateToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(secondConfDate1ToolStripTextBox.Text, typeof(System.DateTime))))), factoryCodeToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    this.view_Multi_Label_Plan_AMTableAdapter.Fill(this.dSLabelPlanning.View_Multi_Label_Plan_AM, new System.Nullable<int>(((int)(System.Convert.ChangeType(dayToolStripTextBox.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(monthToolStripTextBox.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(yearToolStripTextBox.Text, typeof(int))))));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dateEdit1.Text))
            {
                // Create an instance of Form1
                Form1 objFrmFilter = new Form1();

                // Path to your Crystal Report file
                string reportName = @"\\dnsserver\MyReports$\ERPPPS\labeling\LabelMultiPlan.rpt";







                string parameters = "";
                // Construct the selection formula string
                string selectionFormula = "";
                var requisitionDate = ((DateTime)dateEdit1.EditValue).ToString("yyyy-MM-dd HH-mm-ss");

                // Create the selection formula with proper formatting
                selectionFormula = $"{{View_Multi_Label_Plan_rpt.PlanDate}} = DateTime({requisitionDate.Replace("-", ",").Replace(" ", ",")})";


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

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            this.view_Multi_Label_Plan_AMTableAdapter.Fill(this.dSLabelPlanning.View_Multi_Label_Plan_AM, ((DateTime?)dateEdit1.EditValue).Value.Day, ((DateTime?)dateEdit1.EditValue).Value.Month, ((DateTime?)dateEdit1.EditValue).Value.Year);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.view_Multi_LabelPlanning_FinalCompleteTableAdapter.Fill(this.dSLabelPlanning.View_Multi_LabelPlanning_FinalComplete, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue, comboBoxEdit3.Text);
                //this.view_Multi_Label_Plan_AMTableAdapter.FillBy(this.dSLabelPlanning1.View_Multi_Label_Plan_AM, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue, comboBoxEdit3.Text);
                this.view_Multi_Label_Plan_AMTableAdapter.Fill(this.dSLabelPlanning.View_Multi_Label_Plan_AM, ((DateTime?)dateEdit1.EditValue).Value.Day, ((DateTime?)dateEdit1.EditValue).Value.Month, ((DateTime?)dateEdit1.EditValue).Value.Year);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl1.FocusedView;

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
                        int ArtID = gridView.GetRowCellValue(selectedRowHandle, "ArtID") != DBNull.Value
                        ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ArtID"))
                        : 0;
                        int ClientID = gridView.GetRowCellValue(selectedRowHandle, "ClientID") != DBNull.Value
                        ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ClientID"))
                        : 0;
                        int ModelID = gridView.GetRowCellValue(selectedRowHandle, "ModelID") != DBNull.Value
                        ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ModelID"))
                        : 0;

                        string LAName = gridView.GetRowCellValue(selectedRowHandle, "LAName") != DBNull.Value
                           ? gridView.GetRowCellValue(selectedRowHandle, "LAName").ToString()
                           : null;

                        string Code = gridView.GetRowCellValue(selectedRowHandle, "POCode") != DBNull.Value
                           ? gridView.GetRowCellValue(selectedRowHandle, "POCode").ToString()
                           : null;

                        DateTime? planDate = gridView.GetRowCellValue(selectedRowHandle, "PlanDate") != DBNull.Value
                            ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "PlanDate"))
                            : null;

                        DateTime? secondConDate = gridView.GetRowCellValue(selectedRowHandle, "SecondConfDate") != DBNull.Value
                            ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "SecondConfDate"))
                            : null;

                        double RecQty = gridView.GetRowCellValue(selectedRowHandle, "RecQty") != DBNull.Value
                       ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "RecQty"))
                       : 0.0;

                        double balance = gridView.GetRowCellValue(selectedRowHandle, "Balance") != DBNull.Value
                        ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "Balance"))
                        : 0.0;

                        double AvailableQty = gridView.GetRowCellValue(selectedRowHandle, "AvailableQty") != DBNull.Value
                        ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "AvailableQty"))
                        : 0.0;


                        string factoryCode = gridView.GetRowCellValue(selectedRowHandle, "FactoryCode") != DBNull.Value
                            ? gridView.GetRowCellValue(selectedRowHandle, "FactoryCode").ToString()
                            : null;

                        double PartialQty = gridView.GetRowCellValue(selectedRowHandle, "PartialQty") != DBNull.Value
                        ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "PartialQty"))
                        : 0.0;

                        string PlanType = (string)comboBoxEdit1.EditValue;

                        double totalPlanQty;
                        totalPlanQty = PartialQty > 0 ? PartialQty : balance;

                        if (dateEdit1.EditValue != null)
                        {


                            if (PartialQty <= balance)
                            {

                                //tbl_Multi_LabelPlanTableAdapter.Insert(PO, POM, 1, ModelID, ArtID, LAName, (decimal?)totalPlanQty, (DateTime?)dateEdit1.EditValue, DateTime.Now, Code, factoryCode, PlanType);
                                tbl_Multi_LabelPlan1TableAdapter.InsertQuery(PO, POM, 1, ModelID, ArtID, LAName, (decimal?)totalPlanQty, (DateTime?)dateEdit1.EditValue, DateTime.Now, Code, factoryCode, PlanType);


                                MessageBox.Show("Data inserted successfully!");

                                this.view_Multi_Label_Plan_AMTableAdapter.Fill(this.dSLabelPlanning.View_Multi_Label_Plan_AM, ((DateTime?)dateEdit1.EditValue).Value.Day, ((DateTime?)dateEdit1.EditValue).Value.Month, ((DateTime?)dateEdit1.EditValue).Value.Year);
                                //this.view_Multi_Label_Plan_AMTableAdapter.FillBy(this.dSLabelPlanning1.View_Multi_Label_Plan_AM, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue, comboBoxEdit3.Text);
                                this.view_Multi_LabelPlanning_FinalCompleteTableAdapter.Fill(this.dSLabelPlanning.View_Multi_LabelPlanning_FinalComplete, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue, comboBoxEdit3.Text);

                            }
                            else
                            {
                                MessageBox.Show("Can not Send AvailableQty Error ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Select Plan Date");
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

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                //this.tbl_Multi_LabelPlan1TableAdapter.Fill(this.dSLabelPlanning.tbl_Multi_LabelPlan1, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(planDateToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void repositoryItemButtonEdit3_Click(object sender, EventArgs e)
        {
            var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl2.FocusedView;

            if (gridView.SelectedRowsCount > 0)
            {
                var selectedRowHandle = gridView.GetSelectedRows()[0];

                if (selectedRowHandle >= 0)
                {
                    try
                    {
                        int TranID = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "TranID"));
                        tbl_Multi_LabelPlanTableAdapter.DeleteQuery(TranID);
                        MessageBox.Show("Data deleted");
                        this.view_Multi_LabelPlanning_FinalCompleteTableAdapter.Fill(this.dSLabelPlanning.View_Multi_LabelPlanning_FinalComplete, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue, comboBoxEdit3.Text);
                        //this.view_Multi_Label_Plan_AMTableAdapter.FillBy(this.dSLabelPlanning1.View_Multi_Label_Plan_AM, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue, comboBoxEdit3.Text);
                        this.view_Multi_Label_Plan_AMTableAdapter.Fill(this.dSLabelPlanning.View_Multi_Label_Plan_AM, ((DateTime?)dateEdit1.EditValue).Value.Day, ((DateTime?)dateEdit1.EditValue).Value.Month, ((DateTime?)dateEdit1.EditValue).Value.Year);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }



                }
            }
        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //this.tbl_Multi_LabelPlanTableAdapter.Fill(this.dSLabelPlanning.tbl_Multi_LabelPlan, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(planDateToolStripTextBox1.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}