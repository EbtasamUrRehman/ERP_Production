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

namespace ERP_Production.Reports
{
    public partial class frmMasterPlanningReports : DevExpress.XtraEditors.XtraForm
    {
        public frmMasterPlanningReports()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string Path = null;
            string Param = "";
            Form1 objFrmFilter = new Form1();
            string Filter = null;

            if (this.RadioButton7.Checked == true)
            {
                if ((int)this.ClientIDComboBox.SelectedValue == 1 || (int)this.ClientIDComboBox.SelectedValue == 2)
                {
                    Filter = "{View_Rpt_MP.ClientID} in [1,2] AND {View_Rpt_MP.MPID} in " + this.MPIDComboBox.SelectedValue + " TO " + this.MPIDComboBox1.SelectedValue;
                }
                else
                {
                    Filter = "{View_Rpt_MP.ClientID} = " + this.ClientIDComboBox.SelectedValue + " AND {View_Rpt_MP.MPID} in " + this.MPIDComboBox.SelectedValue + " TO " + this.MPIDComboBox1.SelectedValue;
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\MP.rpt";
            }
            else if (this.RadioButton8.Checked == true)
            {
                Filter = "{View_Rpt_Mat_Requisition.PrdLine}=" + this.PrdLineNameComboBox.SelectedValue + " And {View_Rpt_Mat_Requisition.ClientID} = " + this.ClientIDComboBox.SelectedValue + " AND {View_Rpt_Mat_Requisition.MPID} in " + this.MPIDComboBox.SelectedValue + " TO " + this.MPIDComboBox1.SelectedValue;
                if ((int)this.ClientIDComboBox.SelectedValue == 1 || (int)this.ClientIDComboBox.SelectedValue == 2)
                {
                    Filter = "{View_Rpt_Mat_Requisition.PrdLine}=" + this.PrdLineNameComboBox.SelectedValue + " And {View_Rpt_Mat_Requisition.ClientID} in [1,2] AND {View_Rpt_Mat_Requisition.MPID} in " + this.MPIDComboBox.SelectedValue + " TO " + this.MPIDComboBox1.SelectedValue;
                }
                else
                {
                    Filter = "{View_Rpt_Mat_Requisition.PrdLine}=" + this.PrdLineNameComboBox.SelectedValue + " And {View_Rpt_Mat_Requisition.ClientID} = " + this.ClientIDComboBox.SelectedValue + " AND {View_Rpt_Mat_Requisition.MPID} in " + this.MPIDComboBox.SelectedValue + " TO " + this.MPIDComboBox1.SelectedValue;
                }
                Path = @"\\dnsserver\MyReports$\ERPPPS\Material\MatReq.rpt";
            }
            else if (this.RadioButton1.Checked == true)
            {
                Filter = "";
                if ((int)this.ClientIDComboBox.SelectedValue == 1 || (int)this.ClientIDComboBox.SelectedValue == 2)
                {
                    Filter = "{tbl_Pro_Plan.ClientID} in [1,2] AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "#";
                }
                else
                {
                    Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "#";
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\R2I\R2IBalance.rpt";
            }
            else if (this.RadioButton2.Checked == true)
            {
                if ((int)this.PrdLineNameComboBox.SelectedValue == 1)
                {
                    Filter = "";
                    if ((int)this.ClientIDComboBox.SelectedValue == 1 || (int)this.ClientIDComboBox.SelectedValue == 2)
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} in [1,2] AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [1, 4]";
                    }
                    else
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [1, 4]";
                    }
                    Path = @"\\dnsserver\MyReports$\FSERPPC\R2I\R2IBalance.rpt";
                }
                else if ((int)this.PrdLineNameComboBox.SelectedValue == 2)
                {
                    Filter = "";
                    if ((int)this.ClientIDComboBox.SelectedValue == 1 || (int)this.ClientIDComboBox.SelectedValue == 2)
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} in [1,2] AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [2, 3]";
                    }
                    else
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [2, 3]";
                    }
                    Path = @"\\dnsserver\MyReports$\FSERPPC\R2I\R2IBalance.rpt";
                }
                else if ((int)this.PrdLineNameComboBox.SelectedValue > 2)
                {
                    MessageBox.Show("Select Correct Production Line.");
                }
            }
            else if (this.RadioButton3.Checked == true)
            {
                Filter = "";
                if ((int)this.ClientIDComboBox.SelectedValue == 1 || (int)this.ClientIDComboBox.SelectedValue == 2)
                {
                    Filter = "{View_PC_Plan1.ClientID} in [1,2] AND {View_PC_Plan1.CustReqDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "#";
                }
                else
                {
                    Filter = "{View_PC_Plan1.ClientID} = " + this.ClientIDComboBox.SelectedValue + " AND {View_PC_Plan1.CustReqDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "#";
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\Issue\PlanIssueBalance.rpt";
            }
            if (this.RadioButton4.Checked == true)
            {
                Filter = "";
                if (this.ClientIDComboBox.SelectedValue.ToString() == "1" || this.ClientIDComboBox.SelectedValue.ToString() == "2")
                {
                    Filter = "{View_PC_Plan1.ClientID}  in [1,2] AND {View_PC_Plan1.SecondConfDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "#";
                }
                else
                {
                    Filter = "{View_PC_Plan1.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {View_PC_Plan1.SecondConfDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "#";
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\Issue\PlanIssueBalance.rpt";
            }
            else if (this.RadioButton6.Checked == true)
            {
                Filter = "";
                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdStartStatus} AND {@Balance} > 0.00";
                }
                else
                {
                    Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdStartStatus}";
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\S4PlanBalance.rpt";
            }
            else if (this.RadioButton14.Checked == true)
            {
                Filter = "{@ReptCalQty} >= 1.00 and isnull({tbl_Pro_Plan.RepStatus}) and {@BalanceVerified} = 0.00 and {@IssueBal} = 0.00 and {tbl_Pro_Client.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString();
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\PlanBalanceWOTPO.rpt";
            }
            else if (this.RadioButton5.Checked == true)
            {
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\S4PlanBalance.rpt";
                if (this.PrdLineNameComboBox.SelectedValue.ToString() == "1" || this.PrdLineNameComboBox.SelectedValue.ToString() == "4")
                {
                    if (CheckBox1.CheckState == CheckState.Checked)
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [1, 4] AND {tbl_Pro_Plan.PrdStartStatus} AND {@Balance} > 0.00";
                    }
                    else
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [1, 4] AND {tbl_Pro_Plan.PrdStartStatus}";
                    }
                }
                else if (this.PrdLineNameComboBox.SelectedValue.ToString() == "2" || this.PrdLineNameComboBox.SelectedValue.ToString() == "3")
                {
                    Filter = "";
                    if (CheckBox1.CheckState == CheckState.Checked)
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [2, 3] AND {tbl_Pro_Plan.PrdStartStatus} AND {@Balance} > 0.00";
                    }
                    else
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [2, 3] AND {tbl_Pro_Plan.PrdStartStatus}";
                    }
                    Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\PlanBalance(B34005).rpt";
                }
                else if (int.Parse(this.PrdLineNameComboBox.SelectedValue.ToString()) > 4)
                {
                    Filter = "";
                    if (CheckBox1.CheckState == CheckState.Checked)
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} = " + this.PrdLineNameComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PrdStartStatus} AND {@Balance} > 0.00";
                    }
                    else
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} = " + this.PrdLineNameComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PrdStartStatus}";
                    }
                    Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\S4PlanBalance.rpt";
                }
            }
            else if (RadioButton15.Checked)
            {
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\S4PlanBalance.rpt";
                if (this.PrdLineNameComboBox.SelectedValue.ToString() == "1" || this.PrdLineNameComboBox.SelectedValue.ToString() == "4")
                {
                    if (CheckBox2.CheckState == CheckState.Checked)
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Model.FactoryCode} ='" + this.FactoryCodeComboBox1.Text + "' AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [1, 4] AND {tbl_Pro_Plan.PrdStartStatus} AND {@Balance} > 0.00";
                    }
                    else
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Model.FactoryCode} ='" + this.FactoryCodeComboBox1.Text + "' AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [1, 4] AND {tbl_Pro_Plan.PrdStartStatus}";
                    }
                }
                else if (this.PrdLineNameComboBox.SelectedValue.ToString() == "2" || this.PrdLineNameComboBox.SelectedValue.ToString() == "3")
                {
                    Filter = "";
                    if (CheckBox1.CheckState == CheckState.Checked)
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Model.FactoryCode} ='" + this.FactoryCodeComboBox1.Text + "' AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [2, 3] AND {tbl_Pro_Plan.PrdStartStatus} AND {@Balance} > 0.00";
                    }
                    else
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Model.FactoryCode} ='" + this.FactoryCodeComboBox1.Text + "' AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [2, 3] AND {tbl_Pro_Plan.PrdStartStatus}";
                    }
                    Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\PlanBalance(B34005).rpt";
                }
            }
            if (this.RadioButton9.Checked == true)
            {
                Filter = "";
                if ((int)(this.ClientIDComboBox.SelectedValue) == 1 || (int)this.ClientIDComboBox.SelectedValue == 2)
                {
                    Filter = "{View_Rpt_Prd_Status_Art.ClientID} in [1,2] AND {View_Rpt_Prd_Status_Art.SecondConfDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "#";
                }
                else
                {
                    Filter = "{View_Rpt_Prd_Status_Art.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {View_Rpt_Prd_Status_Art.SecondConfDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "#";
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\PlanStatus.rpt";
            }
            else if (this.RadioButton10.Checked == true)
            {
                Filter = "";
                if ((int)this.ClientIDComboBox.SelectedValue == 1 || (int)this.ClientIDComboBox.SelectedValue == 2)
                {
                    Filter = "{View_Rpt_Prd_Status_Art.ClientID} in [1,2] AND {View_Rpt_Prd_Status_Art.SecondConfDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {View_Rpt_Prd_Status_Art.ArtCode} = '" + this.ArtCodeComboBox.SelectedValue.ToString() + "'";
                }
                else
                {
                    Filter = "{View_Rpt_Prd_Status_Art.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {View_Rpt_Prd_Status_Art.SecondConfDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {View_Rpt_Prd_Status_Art.ArtCode} = '" + this.ArtCodeComboBox.SelectedValue.ToString() + "'";
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\PlanStatus.rpt";
            }
            else if (this.RadioButton11.Checked == true)
            {
                Filter = "";
                if ((int)this.ClientIDComboBox.SelectedValue == 1 || (int)this.ClientIDComboBox.SelectedValue == 2)
                {
                    Filter = "{View_Rpt_Prd_Status_Art.ClientID} in [1,2] AND {View_Rpt_Prd_Status_Art.SecondConfDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {View_Rpt_Prd_Status_Art.ArtCode} = '" + this.ArtCodeComboBox.SelectedValue.ToString() + "' AND {View_Rpt_Prd_Status_Art.ArtSize} = '" + this.ArtSizeComboBox.SelectedValue.ToString() + "'";
                }
                else
                {
                    Filter = "{View_Rpt_Prd_Status_Art.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {View_Rpt_Prd_Status_Art.SecondConfDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {View_Rpt_Prd_Status_Art.ArtCode} = '" + this.ArtCodeComboBox.SelectedValue.ToString() + "' AND {View_Rpt_Prd_Status_Art.ArtSize} = '" + this.ArtSizeComboBox.SelectedValue.ToString() + "'";
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\PlanStatus.rpt";
            }
            else if (this.RadioButton16.Checked == true)
            {
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\S4PlanBalance.rpt";
                Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " And {tbl_Pro_Plan.PlanDate} > DateTime(2010, 10, 18, 00, 00, 00) And {tbl_Pro_Model.FactoryCode} = 'B34005' And {tbl_Prd_Lines.PrdLineName} in ['MLP','QR', 'MLP+QR', 'QR+MLP', 'QR+RND'] And {tbl_Pro_Plan.PrdStartStatus} And ({@Balance} <> 0.00 OR {@BalanceVerified} <> 0.00) And {@FinalIssueBal} <> 0.00";
            }
            else if (this.RadioButton17.Checked == true)
            {
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\S4PlanBalance.rpt";
                Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " And {tbl_Pro_Plan.PlanDate} > DateTime(2010, 10, 18, 00, 00, 00) And {tbl_Pro_Model.FactoryCode} = 'B34001' And {tbl_Prd_Lines.PrdLineName} in ['MLP','QR', 'MLP+QR', 'QR+MLP', 'QR+RND'] And {tbl_Pro_Plan.PrdStartStatus} And ({@Balance} <> 0.00 OR {@IssueBal} <> 0.00 OR {@BalanceVerified} <> 0.00)";
            }
            else if (this.RadioButton12.Checked == true)
            {
                Filter = "";
                if (this.PrdLineNameComboBox.Text == "MLP")
                {
                    Filter = "{@Line} = 'MLP' AND {View_Rpt_MP.ArtCode} = 'e42026' And {View_Rpt_MP.ArtSize} = '" + this.CbSize.Text + "'";
                }
                else if (this.PrdLineNameComboBox.Text == "QR")
                {
                    Filter = "{@Line} = 'QR' AND {View_Rpt_MP.ArtCode} = 'e42026' And {View_Rpt_MP.ArtSize} = '" + this.CbSize.Text + "'";
                }
                else
                {
                    MessageBox.Show("Select the Appropriate Production Line.");
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\LamSum.rpt";
            }
            else if (this.RadioButton13.Checked == true)
            {
                Filter = "";
                if (this.PrdLineNameComboBox.Text == "MLP")
                {
                    Filter = "{@Line} = 'MLP' AND {View_Rpt_MP.ArtCode} = 'e42026' And {View_Rpt_MP.ArtSize} = '" + this.CbSize.Text + "'";
                }
                else if (this.PrdLineNameComboBox.Text == "QR")
                {
                    Filter = "{@Line} = 'QR' AND {View_Rpt_MP.ArtCode} = 'e42026' And {View_Rpt_MP.ArtSize} = '" + this.CbSize.Text + "'";
                }
                else
                {
                    MessageBox.Show("Select the appropriate Production Line.");
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\MatchingSum.rpt";
            }
            else if (this.RadioButton18.Checked == true)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\PlanError.rpt";
                Filter = "{View_Rpt_Planning_Error.Balance} <> 0";
            }
            else if (this.RadioButton19.Checked == true)
            {
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\S4PlanBalance.rpt";
                Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " And {tbl_Pro_Plan.PlanDate} > DateTime(2010, 10, 18, 00, 00, 00) And {tbl_Pro_Model.FactoryCode} = 'B34005' And {tbl_Prd_Lines.PrdLineName} in ['MLP','QR', 'MLP+QR', 'QR+MLP', 'QR+RND'] And {tbl_Pro_Plan.PrdStartStatus} And ({@Balance} <> 0.00 OR {@IssueBal} <> 0.00 OR {@BalanceVerified} <> 0.00)";
            }
            else if (this.RadioButton20.Checked == true)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\RptMSPrdStatus.rpt";
                Filter = "{View_MS_Production_Status.DeliveryDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# And {View_MS_Production_Status.FactoryCode} = 'B34005'";
            }
            else if (this.RadioButton26.Checked == true)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\RptHSPrdStatus.rpt";
                Filter = "{View_MS_Production_Status.DeliveryDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# And {View_MS_Production_Status.FactoryCode} = 'B34001'";
            }

            if (objFrmFilter.ViewReport(Path, Filter))
            {
                FrmMain mainForm = Application.OpenForms.OfType<FrmMain>().FirstOrDefault();
                if (mainForm != null)
                {
                    objFrmFilter.ShowDialog(); // Show the filter form
                }
                else
                {
                    MessageBox.Show("Main form not found.");
                }
            }
            else
            {
                // Handle the case where the report could not be loaded
                MessageBox.Show("Failed to load the report.");
            }
        }

        private void tbl_Pro_ClientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_Pro_ClientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSMP);

        }

        private void frmMasterPlanningReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSMP.tbl_Prd_Lines' table. You can move, or remove it, as needed.
            this.tbl_Prd_LinesTableAdapter.Fill(this.dSMP.tbl_Prd_Lines);
            // TODO: This line of code loads data into the 'dSMP.tbl_Pro_Plan2' table. You can move, or remove it, as needed.
            this.tbl_Pro_Plan2TableAdapter.Fill(this.dSMP.tbl_Pro_Plan2);
            // TODO: This line of code loads data into the 'dSMP.tbl_Pro_Plan1' table. You can move, or remove it, as needed.
            this.tbl_Pro_Plan1TableAdapter.Fill(this.dSMP.tbl_Pro_Plan1);
            // TODO: This line of code loads data into the 'dSMP.tbl_Pro_Article_D' table. You can move, or remove it, as needed.
            this.tbl_Pro_Article_DTableAdapter.Fill(this.dSMP.tbl_Pro_Article_D);
            // TODO: This line of code loads data into the 'dSMP.tbl_Pro_Article1' table. You can move, or remove it, as needed.
            this.tbl_Pro_Article1TableAdapter.Fill(this.dSMP.tbl_Pro_Article1);
            // TODO: This line of code loads data into the 'dSMP.tbl_Pro_Client' table. You can move, or remove it, as needed.
            this.tbl_Pro_ClientTableAdapter.Fill(this.dSMP.tbl_Pro_Client);

        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            string Path = null;
            string Param = "";
            Form1 objFrmFilter = new Form1();
            string Filter = null;

            if (this.RadioButton7.Checked == true)
            {
                if ((int)this.ClientIDComboBox.SelectedValue == 1 || (int)this.ClientIDComboBox.SelectedValue == 2)
                {
                    Filter = "{View_Rpt_MP.ClientID} in [1,2] AND {View_Rpt_MP.MPID} in " + this.MPIDComboBox.SelectedValue + " TO " + this.MPIDComboBox1.SelectedValue;
                }
                else
                {
                    Filter = "{View_Rpt_MP.ClientID} = " + this.ClientIDComboBox.SelectedValue + " AND {View_Rpt_MP.MPID} in " + this.MPIDComboBox.SelectedValue + " TO " + this.MPIDComboBox1.SelectedValue;
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\MP.rpt";
            }
            else if (this.RadioButton8.Checked == true)
            {
                Filter = "{View_Rpt_Mat_Requisition.PrdLine}=" + this.PrdLineNameComboBox.SelectedValue + " And {View_Rpt_Mat_Requisition.ClientID} = " + this.ClientIDComboBox.SelectedValue + " AND {View_Rpt_Mat_Requisition.MPID} in " + this.MPIDComboBox.SelectedValue + " TO " + this.MPIDComboBox1.SelectedValue;
                if ((int)this.ClientIDComboBox.SelectedValue == 1 || (int)this.ClientIDComboBox.SelectedValue == 2)
                {
                    Filter = "{View_Rpt_Mat_Requisition.PrdLine}=" + this.PrdLineNameComboBox.SelectedValue + " And {View_Rpt_Mat_Requisition.ClientID} in [1,2] AND {View_Rpt_Mat_Requisition.MPID} in " + this.MPIDComboBox.SelectedValue + " TO " + this.MPIDComboBox1.SelectedValue;
                }
                else
                {
                    Filter = "{View_Rpt_Mat_Requisition.PrdLine}=" + this.PrdLineNameComboBox.SelectedValue + " And {View_Rpt_Mat_Requisition.ClientID} = " + this.ClientIDComboBox.SelectedValue + " AND {View_Rpt_Mat_Requisition.MPID} in " + this.MPIDComboBox.SelectedValue + " TO " + this.MPIDComboBox1.SelectedValue;
                }
                Path = @"\\dnsserver\MyReports$\ERPPPS\Material\MatReq.rpt";
            }
            else if (this.RadioButton1.Checked == true)
            {
                Filter = "";
                if ((int)this.ClientIDComboBox.SelectedValue == 1 || (int)this.ClientIDComboBox.SelectedValue == 2)
                {
                    Filter = "{tbl_Pro_Plan.ClientID} in [1,2] AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "#";
                }
                else
                {
                    Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "#";
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\R2I\R2IBalance.rpt";
            }
            else if (this.RadioButton2.Checked == true)
            {
                if ((int)this.PrdLineNameComboBox.SelectedValue == 1)
                {
                    Filter = "";
                    if ((int)this.ClientIDComboBox.SelectedValue == 1 || (int)this.ClientIDComboBox.SelectedValue == 2)
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} in [1,2] AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [1, 4]";
                    }
                    else
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [1, 4]";
                    }
                    Path = @"\\dnsserver\MyReports$\FSERPPC\R2I\R2IBalance.rpt";
                }
                else if ((int)this.PrdLineNameComboBox.SelectedValue == 2)
                {
                    Filter = "";
                    if ((int)this.ClientIDComboBox.SelectedValue == 1 || (int)this.ClientIDComboBox.SelectedValue == 2)
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} in [1,2] AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [2, 3]";
                    }
                    else
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [2, 3]";
                    }
                    Path = @"\\dnsserver\MyReports$\FSERPPC\R2I\R2IBalance.rpt";
                }
                else if ((int)this.PrdLineNameComboBox.SelectedValue > 2)
                {
                    MessageBox.Show("Select Correct Production Line.");
                }
            }
            else if (this.RadioButton3.Checked == true)
            {
                Filter = "";
                if ((int)this.ClientIDComboBox.SelectedValue == 1 || (int)this.ClientIDComboBox.SelectedValue == 2)
                {
                    Filter = "{View_PC_Plan1.ClientID} in [1,2] AND {View_PC_Plan1.CustReqDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "#";
                }
                else
                {
                    Filter = "{View_PC_Plan1.ClientID} = " + this.ClientIDComboBox.SelectedValue + " AND {View_PC_Plan1.CustReqDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "#";
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\Issue\s4PlanIssueBalance.rpt";
            }
            if (this.RadioButton4.Checked == true)
            {
                Filter = "";
                if (this.ClientIDComboBox.SelectedValue.ToString() == "1" || this.ClientIDComboBox.SelectedValue.ToString() == "2")
                {
                    Filter = "{View_PC_Plan1.ClientID}  in [1,2] AND {View_PC_Plan1.SecondConfDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "#";
                }
                else
                {
                    Filter = "{View_PC_Plan1.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {View_PC_Plan1.SecondConfDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "#";
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\Issue\PlanIssueBalance.rpt";
            }
            else if (this.RadioButton6.Checked == true)
            {
                Filter = "";
                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdStartStatus} AND {@Balance} > 0.00";
                }
                else
                {
                    Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdStartStatus}";
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\S4PlanBalance.rpt";
            }
            else if (this.RadioButton14.Checked == true)
            {
                Filter = "{@ReptCalQty} >= 1.00 and isnull({tbl_Pro_Plan.RepStatus}) and {@BalanceVerified} = 0.00 and {@IssueBal} = 0.00 and {tbl_Pro_Client.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString();
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\PlanBalanceWOTPO.rpt";
            }
            else if (this.RadioButton5.Checked == true)
            {
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\S4PlanBalance.rpt";
                if (this.PrdLineNameComboBox.SelectedValue.ToString() == "1" || this.PrdLineNameComboBox.SelectedValue.ToString() == "4")
                {
                    if (CheckBox1.CheckState == CheckState.Checked)
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [1, 4] AND {tbl_Pro_Plan.PrdStartStatus} AND {@Balance} > 0.00";
                    }
                    else
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [1, 4] AND {tbl_Pro_Plan.PrdStartStatus}";
                    }
                }
                else if (this.PrdLineNameComboBox.SelectedValue.ToString() == "2" || this.PrdLineNameComboBox.SelectedValue.ToString() == "3")
                {
                    Filter = "";
                    if (CheckBox1.CheckState == CheckState.Checked)
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [2, 3] AND {tbl_Pro_Plan.PrdStartStatus} AND {@Balance} > 0.00";
                    }
                    else
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [2, 3] AND {tbl_Pro_Plan.PrdStartStatus}";
                    }
                    Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\PlanBalance(B34005).rpt";
                }
                else if (int.Parse(this.PrdLineNameComboBox.SelectedValue.ToString()) > 4)
                {
                    Filter = "";
                    if (CheckBox1.CheckState == CheckState.Checked)
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} = " + this.PrdLineNameComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PrdStartStatus} AND {@Balance} > 0.00";
                    }
                    else
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} = " + this.PrdLineNameComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Plan.PrdStartStatus}";
                    }
                    Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\S4PlanBalance.rpt";
                }
            }
            else if (RadioButton15.Checked)
            {
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\S4PlanBalance.rpt";
                if (this.PrdLineNameComboBox.SelectedValue.ToString() == "1" || this.PrdLineNameComboBox.SelectedValue.ToString() == "4")
                {
                    if (CheckBox2.CheckState == CheckState.Checked)
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Model.FactoryCode} ='" + this.FactoryCodeComboBox1.Text + "' AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [1, 4] AND {tbl_Pro_Plan.PrdStartStatus} AND {@Balance} > 0.00";
                    }
                    else
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Model.FactoryCode} ='" + this.FactoryCodeComboBox1.Text + "' AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [1, 4] AND {tbl_Pro_Plan.PrdStartStatus}";
                    }
                }
                else if (this.PrdLineNameComboBox.SelectedValue.ToString() == "2" || this.PrdLineNameComboBox.SelectedValue.ToString() == "3")
                {
                    Filter = "";
                    if (CheckBox1.CheckState == CheckState.Checked)
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Model.FactoryCode} ='" + this.FactoryCodeComboBox1.Text + "' AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [2, 3] AND {tbl_Pro_Plan.PrdStartStatus} AND {@Balance} > 0.00";
                    }
                    else
                    {
                        Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {tbl_Pro_Model.FactoryCode} ='" + this.FactoryCodeComboBox1.Text + "' AND {tbl_Pro_Plan.PlanDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {tbl_Pro_Plan.PrdLine} in [2, 3] AND {tbl_Pro_Plan.PrdStartStatus}";
                    }
                    Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\PlanBalance(B34005).rpt";
                }
            }
            if (this.RadioButton9.Checked == true)
            {
                Filter = "";
                if ((int)(this.ClientIDComboBox.SelectedValue) == 1 || (int)this.ClientIDComboBox.SelectedValue == 2)
                {
                    Filter = "{View_Rpt_Prd_Status_Art.ClientID} in [1,2] AND {View_Rpt_Prd_Status_Art.SecondConfDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "#";
                }
                else
                {
                    Filter = "{View_Rpt_Prd_Status_Art.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {View_Rpt_Prd_Status_Art.SecondConfDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "#";
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\PlanStatus.rpt";
            }
            else if (this.RadioButton10.Checked == true)
            {
                Filter = "";
                if ((int)this.ClientIDComboBox.SelectedValue == 1 || (int)this.ClientIDComboBox.SelectedValue == 2)
                {
                    Filter = "{View_Rpt_Prd_Status_Art.ClientID} in [1,2] AND {View_Rpt_Prd_Status_Art.SecondConfDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {View_Rpt_Prd_Status_Art.ArtCode} = '" + this.ArtCodeComboBox.SelectedValue.ToString() + "'";
                }
                else
                {
                    Filter = "{View_Rpt_Prd_Status_Art.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {View_Rpt_Prd_Status_Art.SecondConfDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {View_Rpt_Prd_Status_Art.ArtCode} = '" + this.ArtCodeComboBox.SelectedValue.ToString() + "'";
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\PlanStatus.rpt";
            }
            else if (this.RadioButton11.Checked == true)
            {
                Filter = "";
                if ((int)this.ClientIDComboBox.SelectedValue == 1 || (int)this.ClientIDComboBox.SelectedValue == 2)
                {
                    Filter = "{View_Rpt_Prd_Status_Art.ClientID} in [1,2] AND {View_Rpt_Prd_Status_Art.SecondConfDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {View_Rpt_Prd_Status_Art.ArtCode} = '" + this.ArtCodeComboBox.SelectedValue.ToString() + "' AND {View_Rpt_Prd_Status_Art.ArtSize} = '" + this.ArtSizeComboBox.SelectedValue.ToString() + "'";
                }
                else
                {
                    Filter = "{View_Rpt_Prd_Status_Art.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " AND {View_Rpt_Prd_Status_Art.SecondConfDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# AND {View_Rpt_Prd_Status_Art.ArtCode} = '" + this.ArtCodeComboBox.SelectedValue.ToString() + "' AND {View_Rpt_Prd_Status_Art.ArtSize} = '" + this.ArtSizeComboBox.SelectedValue.ToString() + "'";
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\PlanStatus.rpt";
            }
            else if (this.RadioButton16.Checked == true)
            {
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\S4PlanBalance.rpt";
                Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " And {tbl_Pro_Plan.PlanDate} > DateTime(2010, 10, 18, 00, 00, 00) And {tbl_Pro_Model.FactoryCode} = 'B34005' And {tbl_Prd_Lines.PrdLineName} in ['MLP','QR', 'MLP+QR', 'QR+MLP', 'QR+RND'] And {tbl_Pro_Plan.PrdStartStatus} And ({@Balance} <> 0.00 OR {@BalanceVerified} <> 0.00) And {@FinalIssueBal} <> 0.00";
            }
            else if (this.RadioButton17.Checked == true)
            {
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\S4PlanBalance.rpt";
                Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " And {tbl_Pro_Plan.PlanDate} > DateTime(2010, 10, 18, 00, 00, 00) And {tbl_Pro_Model.FactoryCode} = 'B34001' And {tbl_Prd_Lines.PrdLineName} in ['MLP','QR', 'MLP+QR', 'QR+MLP', 'QR+RND'] And {tbl_Pro_Plan.PrdStartStatus} And ({@Balance} <> 0.00 OR {@IssueBal} <> 0.00 OR {@BalanceVerified} <> 0.00)";
            }
            else if (this.RadioButton12.Checked == true)
            {
                Filter = "";
                if (this.PrdLineNameComboBox.Text == "MLP")
                {
                    Filter = "{@Line} = 'MLP' AND {View_Rpt_MP.ArtCode} = 'e42026' And {View_Rpt_MP.ArtSize} = '" + this.CbSize.Text + "'";
                }
                else if (this.PrdLineNameComboBox.Text == "QR")
                {
                    Filter = "{@Line} = 'QR' AND {View_Rpt_MP.ArtCode} = 'e42026' And {View_Rpt_MP.ArtSize} = '" + this.CbSize.Text + "'";
                }
                else
                {
                    MessageBox.Show("Select the Appropriate Production Line.");
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\LamSum.rpt";
            }
            else if (this.RadioButton13.Checked == true)
            {
                Filter = "";
                if (this.PrdLineNameComboBox.Text == "MLP")
                {
                    Filter = "{@Line} = 'MLP' AND {View_Rpt_MP.ArtCode} = 'e42026' And {View_Rpt_MP.ArtSize} = '" + this.CbSize.Text + "'";
                }
                else if (this.PrdLineNameComboBox.Text == "QR")
                {
                    Filter = "{@Line} = 'QR' AND {View_Rpt_MP.ArtCode} = 'e42026' And {View_Rpt_MP.ArtSize} = '" + this.CbSize.Text + "'";
                }
                else
                {
                    MessageBox.Show("Select the appropriate Production Line.");
                }
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\MatchingSum.rpt";
            }
            else if (this.RadioButton18.Checked == true)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\PlanError.rpt";
                Filter = "{View_Rpt_Planning_Error.Balance} <> 0";
            }
            else if (this.RadioButton19.Checked == true)
            {
                Path = @"\\dnsserver\MyReports$\FSERPPC\Plan\S4PlanBalance.rpt";
                Filter = "{tbl_Pro_Plan.ClientID} = " + this.ClientIDComboBox.SelectedValue.ToString() + " And {tbl_Pro_Plan.PlanDate} > DateTime(2010, 10, 18, 00, 00, 00) And {tbl_Pro_Model.FactoryCode} = 'B34005' And {tbl_Prd_Lines.PrdLineName} in ['MLP','QR', 'MLP+QR', 'QR+MLP', 'QR+RND'] And {tbl_Pro_Plan.PrdStartStatus} And ({@Balance} <> 0.00 OR {@IssueBal} <> 0.00 OR {@BalanceVerified} <> 0.00)";
            }
            else if (this.RadioButton20.Checked == true)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\RptMSPrdStatus.rpt";
                Filter = "{View_MS_Production_Status.DeliveryDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# And {View_MS_Production_Status.FactoryCode} = 'B34005'";
            }
            else if (this.RadioButton26.Checked == true)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\RptHSPrdStatus.rpt";
                Filter = "{View_MS_Production_Status.DeliveryDate} in #" + this.DateTimePicker1.Value.ToString("MM/dd/yyyy") + "# to #" + this.DateTimePicker2.Value.ToString("MM/dd/yyyy") + "# And {View_MS_Production_Status.FactoryCode} = 'B34001'";
            }

            if (objFrmFilter.ViewReport(Path, Filter))
            {
                //FrmMain mainForm = Application.OpenForms.OfType<FrmMain>().FirstOrDefault();
                //if (mainForm != null)
                {
                    objFrmFilter.ShowDialog(); // Show the filter form
                }
                //else
                //{
                //    MessageBox.Show("Main form not found.");
                //}
            }
            else
            {
                // Handle the case where the report could not be loaded
                MessageBox.Show("Failed to load the report.");
            }
        }

        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton7.Checked == true)
            {
                this.FactoryCodeComboBox1.Enabled = false;;

                this.ClientIDLabel.Enabled = true;
                this.ClientIDComboBox.Enabled = true;

                this.Label1.Enabled = false;;
                this.Label2.Enabled = false;;

                this.DateTimePicker1.Enabled = false;;
                this.DateTimePicker2.Enabled = false;;

                this.PrdLineNameLabel.Enabled = false;;
                this.PrdLineNameComboBox.Enabled = false;;

                this.MPIDLabel.Enabled = true;
                this.MPIDLabel1.Enabled = true;
                this.MPIDComboBox.Enabled = true;
                this.MPIDComboBox1.Enabled = true;

                this.ArtCodeLabel.Enabled = false;;
                this.ArtCodeComboBox.Enabled = false;;

                this.ArtSizeLabel.Enabled = false;;
                this.ArtSizeComboBox.Enabled = false;;

                this.Label4.Enabled = false;;
                this.CbSize.Enabled = false;;
            }
        }

        private void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton8.Checked == true)
            {


                this.FactoryCodeComboBox1.Enabled = false;
                this.Label1.Enabled = false;
                this.Label2.Enabled = false;

                this.DateTimePicker1.Enabled = false;
                this.DateTimePicker2.Enabled = false;

                this.PrdLineNameLabel.Enabled = false;
                this.PrdLineNameComboBox.Enabled = true;

                this.MPIDLabel.Enabled = true;
                this.MPIDLabel1.Enabled = true;
                this.MPIDComboBox.Enabled = true;
                this.MPIDComboBox1.Enabled = true;

                this.ArtCodeLabel.Enabled = false;
                this.ArtCodeComboBox.Enabled = false;

                this.ArtSizeLabel.Enabled = false;
                this.ArtSizeComboBox.Enabled = false;

                this.Label4.Enabled = false;
                this.CbSize.Enabled = false;
            }
        }

        private void RadioButton19_CheckedChanged(object sender, EventArgs e)
        {
            this.Label1.Enabled = true;
        this.Label2.Enabled = true;

        this.DateTimePicker1.Enabled = false;
        this.DateTimePicker2.Enabled = false;

        this.PrdLineNameLabel.Enabled = false;
        this.PrdLineNameComboBox.Enabled = false;

        this.MPIDLabel.Enabled = false;
        this.MPIDLabel1.Enabled = false;
        this.MPIDComboBox.Enabled = false;
        this.MPIDComboBox1.Enabled = false;

        this.ArtCodeLabel.Enabled = false;
        this.ArtCodeComboBox.Enabled = false;

        this.ArtSizeLabel.Enabled = false;
        this.ArtSizeComboBox.Enabled = false;
        this.FactoryCodeComboBox1.Enabled = false;

        this.Label4.Enabled = false;
        this.CbSize.Enabled = false;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.Label1.Enabled = true;
            this.Label2.Enabled = true;

            this.FactoryCodeComboBox1.Enabled = false;
            this.DateTimePicker1.Enabled = true;
            this.DateTimePicker2.Enabled = true;

            this.PrdLineNameLabel.Enabled = false;
            this.PrdLineNameComboBox.Enabled = false;

            this.MPIDLabel.Enabled = false;
            this.MPIDLabel1.Enabled = false;
            this.MPIDComboBox.Enabled = false;
            this.MPIDComboBox1.Enabled = false;

            this.ArtCodeLabel.Enabled = false;
            this.ArtCodeComboBox.Enabled = false;

            this.ArtSizeLabel.Enabled = false;
            this.ArtSizeComboBox.Enabled = false;

            this.Label4.Enabled = false;
            this.CbSize.Enabled = false;

        }
    }
}
