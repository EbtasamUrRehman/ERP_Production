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
    public partial class FrmPlanningReports : DevExpress.XtraEditors.XtraForm
    {
        public FrmPlanningReports()
        {
            InitializeComponent();
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            if (ListBox1.Items.Count > 0)
            {
                if (ListBox1.SelectedIndex >= 0)
                {
                    ListBox1.Items.RemoveAt(ListBox1.SelectedIndex);
                    if (ListBox1.Items.Count > 0)
                        ListBox1.SelectedIndex = ListBox1.Items.Count - 1;
                }
            }
        }
        private DateTime GetLastDayOfMonth(DateTime dtDate)
        {
            DateTime dtTo = new DateTime(dtDate.Year, dtDate.Month, 1);
            dtTo = dtTo.AddMonths(1);
            dtTo = dtTo.AddDays(-dtTo.Day);
            return dtTo;
        }
        private void RadioButton28_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox3.Enabled = RadioButton28.Checked;
        }

        private void RadioButton30_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton30.Checked)
            {
                GroupBox1.Visible = true;
                RadioButton26.Checked = true;
                ArtCodeComboBox.Enabled = true;
                ArtCodeComboBox1.Enabled = true;
            }
            else
            {
                RadioButton26.Checked = false;
                ArtCodeComboBox.Enabled = false;
                ArtCodeComboBox1.Enabled = false;
            }
        }

        private void btnRptModelShow_Click(object sender, EventArgs e)
        {
            string Path = "";
            string Filter = "";
            Form1 objFrmFilter = new Form1();

            if (RadioButton1.Checked && CustReqDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiArtStatus.rpt";

                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{View_Rpt_Art_Plan_Status.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} " +
                             $"AND {{View_Rpt_Art_Plan_Status.CustReqDate}} in #{DTPicker1.Value:MM/dd/yyyy}# to #{DTPicker2.Value:MM/dd/yyyy}# " +
                             $"AND {{View_Rpt_Art_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                             $"AND {{View_Rpt_Art_Plan_Status.BalanceQty}} >= 0 " +
                             $"AND {{View_Rpt_Art_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
                }
            }
            else if (RadioButton1.Checked && ExFactoryDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiArtStatus.rpt";

                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{View_Rpt_Art_Plan_Status.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} " +
                             $"AND {{View_Rpt_Art_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                             $"AND {{View_Rpt_Art_Plan_Status.LPDate}} in #{DTPicker1.Value:MM/dd/yyyy}# to #{DTPicker2.Value:MM/dd/yyyy}# " +
                             $"AND {{View_Rpt_Art_Plan_Status.BalanceQty}} >= 0 " +
                             $"AND {{View_Rpt_Art_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
                }
            }
            else if (RadioButton1.Checked && LastConfDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiArtStatus.rpt";

                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{View_Rpt_Art_Plan_Status.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} " +
                             $"AND {{View_Rpt_Art_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                             $"AND {{View_Rpt_Art_Plan_Status.SecondConfDate}} in #{DTPicker1.Value:MM/dd/yyyy}# to #{DTPicker2.Value:MM/dd/yyyy}# " +
                             $"AND {{View_Rpt_Art_Plan_Status.BalanceQty}} >= 0 " +
                             $"AND {{View_Rpt_Art_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
                }
            }
            else if (RadioButton1.Checked && EntryDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiArtStatus.rpt";

                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{View_Rpt_Art_Plan_Status.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} " +
                             $"AND {{View_Rpt_Art_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                             $"AND {{View_Rpt_Art_Plan_Status.EntryDate}} in #{DTPicker1.Value:MM/dd/yyyy}# to #{DTPicker2.Value:MM/dd/yyyy}# " +
                             $"AND {{View_Rpt_Art_Plan_Status.BalanceQty}} >= 0 " +
                             $"AND {{View_Rpt_Art_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
                }
            }
            else if (RadioButton5.Checked && CustReqDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiArtStatus.rpt";

                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{View_Rpt_Art_Plan_Status.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                             $"AND {{View_Rpt_Art_Plan_Status.ArtCode}} in '{ArtCodeComboBox.SelectedValue}' to '{ArtCodeComboBox1.SelectedValue}' " +
                             $"AND {{View_Rpt_Art_Plan_Status.CustReqDate}} in #{DTPicker1.Value:MM/dd/yyyy}# to #{DTPicker2.Value:MM/dd/yyyy}# " +
                             $"AND {{View_Rpt_Art_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                             $"AND {{View_Rpt_Art_Plan_Status.BalanceQty}} >= 0 " +
                             $"AND {{View_Rpt_Art_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
                }
            }
            if (RadioButton5.Checked && ExFactoryDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiArtStatus.rpt";

                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{View_Rpt_Art_Plan_Status.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                             $"And {{View_Rpt_Art_Plan_Status.ArtCode}} in '{ArtCodeComboBox.SelectedValue}' to '{ArtCodeComboBox1.SelectedValue}' " +
                             $"And {{View_Rpt_Art_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                             $"And {{View_Rpt_Art_Plan_Status.LPDate}} in #{DTPicker1.Value:MM/dd/yyyy}# to #{DTPicker2.Value:MM/dd/yyyy}# " +
                             $"And {{View_Rpt_Art_Plan_Status.BalanceQty}} >= 0 " +
                             $"And {{View_Rpt_Art_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
                }
            }
            else if (RadioButton5.Checked && LastConfDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiArtStatus.rpt";

                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{View_Rpt_Art_Plan_Status.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                             $"And {{View_Rpt_Art_Plan_Status.ArtCode}} in '{ArtCodeComboBox.SelectedValue}' to '{ArtCodeComboBox1.SelectedValue}' " +
                             $"And {{View_Rpt_Art_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                             $"And {{View_Rpt_Art_Plan_Status.SecondConfDate}} in #{DTPicker1.Value:MM/dd/yyyy}# to #{DTPicker2.Value:MM/dd/yyyy}# " +
                             $"And {{View_Rpt_Art_Plan_Status.BalanceQty}} >= 0 " +
                             $"And {{View_Rpt_Art_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
                }
            }
            else if (RadioButton5.Checked && EntryDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiArtStatus.rpt";

                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{View_Rpt_Art_Plan_Status.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                             $"And {{View_Rpt_Art_Plan_Status.ArtCode}} in '{ArtCodeComboBox.SelectedValue}' to '{ArtCodeComboBox1.SelectedValue}' " +
                             $"And {{View_Rpt_Art_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                             $"And {{View_Rpt_Art_Plan_Status.EntryDate}} in #{DTPicker1.Value:MM/dd/yyyy}# to #{DTPicker2.Value:MM/dd/yyyy}# " +
                             $"And {{View_Rpt_Art_Plan_Status.BalanceQty}} >= 0 " +
                             $"And {{View_Rpt_Art_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
                }
            }
            else if (RadioButton6.Checked && ExFactoryDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiArtStatus.rpt";

                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{View_Rpt_Art_Plan_Status.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                             $"And {{View_Rpt_Art_Plan_Status.ArtCode}} in '{ArtCodeComboBox.SelectedValue}' to '{ArtCodeComboBox1.SelectedValue}' " +
                             $"And {{View_Rpt_Art_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                             $"And {{View_Rpt_Art_Plan_Status.LPDate}} in #{DTPicker1.Value:MM/dd/yyyy}# to #{DTPicker2.Value:MM/dd/yyyy}# " +
                             $"And {{View_Rpt_Art_Plan_Status.BalanceQty}} >= 0 " +
                             $"And {{View_Rpt_Art_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
                }
            }
            else if (RadioButton6.Checked && LastConfDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiArtStatus.rpt";

                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{View_Rpt_Art_Plan_Status.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                             $"And {{View_Rpt_Art_Plan_Status.ArtCode}} in '{ArtCodeComboBox.SelectedValue}' to '{ArtCodeComboBox1.SelectedValue}' " +
                             $"And {{View_Rpt_Art_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                             $"And {{View_Rpt_Art_Plan_Status.SecondConfDate}} in #{DTPicker1.Value:MM/dd/yyyy}# to #{DTPicker2.Value:MM/dd/yyyy}# " +
                             $"And {{View_Rpt_Art_Plan_Status.BalanceQty}} >= 0 " +
                             $"And {{View_Rpt_Art_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
                }
            }
            else if (RadioButton6.Checked && EntryDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiArtStatus.rpt";

                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{View_Rpt_Art_Plan_Status.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                             $"And {{View_Rpt_Art_Plan_Status.ArtCode}} in '{ArtCodeComboBox.SelectedValue}' to '{ArtCodeComboBox1.SelectedValue}' " +
                             $"And {{View_Rpt_Art_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                             $"And {{View_Rpt_Art_Plan_Status.EntryDate}} in #{DTPicker1.Value:MM/dd/yyyy}# to #{DTPicker2.Value:MM/dd/yyyy}# " +
                             $"And {{View_Rpt_Art_Plan_Status.BalanceQty}} >= 0 " +
                             $"And {{View_Rpt_Art_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
                }
            }


            if (RadioButton2.Checked && CustReqDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiPOStatus.rpt";

                Filter = $"{{View_Rpt_PO_Plan_Status.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} " +
                         $"AND {{View_Rpt_PO_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                         $"AND {{View_Rpt_PO_Plan_Status.CustReqDate}} in #{DTPicker1.Value.ToString("MM/dd/yyyy")}# to #{DTPicker2.Value.ToString("MM/dd/yyyy")}# " +
                         $"AND {{View_Rpt_PO_Plan_Status.BalanceQty}} >= 0 " +
                         $"AND {{View_Rpt_PO_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
            }
            else if (RadioButton2.Checked && ExFactoryDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiPOStatus.rpt";

                Filter = $"{{View_Rpt_PO_Plan_Status.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} " +
                         $"AND {{View_Rpt_PO_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                         $"AND {{View_Rpt_PO_Plan_Status.LPDate}} in #{DTPicker1.Value.ToString("MM/dd/yyyy")}# to #{DTPicker2.Value.ToString("MM/dd/yyyy")}# " +
                         $"AND {{View_Rpt_PO_Plan_Status.BalanceQty}} >= 0 " +
                         $"AND {{View_Rpt_PO_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
            }
            else if (RadioButton2.Checked && LastConfDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiPOStatus.rpt";

                Filter = $"{{View_Rpt_PO_Plan_Status.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} " +
                         $"AND {{View_Rpt_PO_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                         $"AND {{View_Rpt_PO_Plan_Status.SecondConfDate}} in #{DTPicker1.Value.ToString("MM/dd/yyyy")}# to #{DTPicker2.Value.ToString("MM/dd/yyyy")}# " +
                         $"AND {{View_Rpt_PO_Plan_Status.BalanceQty}} >= 0 " +
                         $"AND {{View_Rpt_PO_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
            }
            else if (RadioButton2.Checked && EntryDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiPOStatus.rpt";

                Filter = $"{{View_Rpt_PO_Plan_Status.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} " +
                         $"AND {{View_Rpt_PO_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                         $"AND {{View_Rpt_PO_Plan_Status.EntryDate}} in #{DTPicker1.Value.ToString("MM/dd/yyyy")}# to #{DTPicker2.Value.ToString("MM/dd/yyyy")}# " +
                         $"AND {{View_Rpt_PO_Plan_Status.BalanceQty}} >= 0 " +
                         $"AND {{View_Rpt_PO_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
            }
            else if (RadioButton3.Checked && CustReqDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiPOStatus.rpt";

                Filter = $"{{View_Rpt_PO_Plan_Status.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                         $"AND {{View_Rpt_PO_Plan_Status.ArtCode}} in '{ArtCodeComboBox.SelectedValue}' to '{ArtCodeComboBox1.SelectedValue}' " +
                         $"AND {{View_Rpt_PO_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                         $"AND {{View_Rpt_PO_Plan_Status.CustReqDate}} in #{DTPicker1.Value.ToString("MM/dd/yyyy")}# to #{DTPicker2.Value.ToString("MM/dd/yyyy")}# " +
                         $"AND {{View_Rpt_PO_Plan_Status.BalanceQty}} >= 0 " +
                         $"AND {{View_Rpt_PO_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
            }
            else if (RadioButton3.Checked && ExFactoryDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiPOStatus.rpt";

                Filter = $"{{View_Rpt_PO_Plan_Status.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                         $"AND {{View_Rpt_PO_Plan_Status.ArtCode}} in '{ArtCodeComboBox.SelectedValue}' to '{ArtCodeComboBox1.SelectedValue}' " +
                         $"AND {{View_Rpt_PO_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                         $"AND {{View_Rpt_PO_Plan_Status.LPDate}} in #{DTPicker1.Value.ToString("MM/dd/yyyy")}# to #{DTPicker2.Value.ToString("MM/dd/yyyy")}# " +
                         $"AND {{View_Rpt_PO_Plan_Status.BalanceQty}} >= 0 " +
                         $"AND {{View_Rpt_PO_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
            }
            else if (RadioButton3.Checked && LastConfDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiPOStatus.rpt";

                Filter = $"{{View_Rpt_PO_Plan_Status.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                         $"AND {{View_Rpt_PO_Plan_Status.ArtCode}} in '{ArtCodeComboBox.SelectedValue}' to '{ArtCodeComboBox1.SelectedValue}' " +
                         $"AND {{View_Rpt_PO_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                         $"AND {{View_Rpt_PO_Plan_Status.SecondConfDate}} in #{DTPicker1.Value.ToString("MM/dd/yyyy")}# to #{DTPicker2.Value.ToString("MM/dd/yyyy")}# " +
                         $"AND {{View_Rpt_PO_Plan_Status.BalanceQty}} >= 0 " +
                         $"AND {{View_Rpt_PO_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
            }
            else if (RadioButton3.Checked && EntryDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiPOStatus.rpt";

                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{View_Rpt_PO_Plan_Status.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                             $"AND {{View_Rpt_PO_Plan_Status.ArtCode}} = '{ArtCodeComboBox.SelectedValue}' " +
                             $"AND {{View_Rpt_PO_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                             $"AND {{View_Rpt_PO_Plan_Status.EntryDate}} in #{DTPicker1.Value.ToString("MM/dd/yyyy")}# to #{DTPicker2.Value.ToString("MM/dd/yyyy")}# " +
                             $"AND {{View_Rpt_PO_Plan_Status.BalanceQty}} >= 0 " +
                             $"AND {{View_Rpt_PO_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
                }
            }
            else if (RadioButton4.Checked && CustReqDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiPOStatus.rpt";

                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{View_Rpt_PO_Plan_Status.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                             $"AND {{View_Rpt_PO_Plan_Status.ArtCode}} = '{ArtCodeComboBox.SelectedValue}' " +
                             $"AND {{View_Rpt_PO_Plan_Status.ArtSize}} in '{ArtSizeComboBox.SelectedValue}' to '{ArtSizeComboBox1.SelectedValue}' " +
                             $"AND {{View_Rpt_PO_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                             $"AND {{View_Rpt_PO_Plan_Status.CustReqDate}} in #{DTPicker1.Value.ToString("MM/dd/yyyy")}# to #{DTPicker2.Value.ToString("MM/dd/yyyy")}# " +
                             $"AND {{View_Rpt_PO_Plan_Status.BalanceQty}} >= 0 " +
                             $"AND {{View_Rpt_PO_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
                }
            }
            else if (RadioButton4.Checked && ExFactoryDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiPOStatus.rpt";

                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{View_Rpt_PO_Plan_Status.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                             $"AND {{View_Rpt_PO_Plan_Status.ArtCode}} = '{ArtCodeComboBox.SelectedValue}' " +
                             $"AND {{View_Rpt_PO_Plan_Status.ArtSize}} in '{ArtSizeComboBox.SelectedValue}' to '{ArtSizeComboBox1.SelectedValue}' " +
                             $"AND {{View_Rpt_PO_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                             $"AND {{View_Rpt_PO_Plan_Status.LPDate}} in #{DTPicker1.Value.ToString("MM/dd/yyyy")}# to #{DTPicker2.Value.ToString("MM/dd/yyyy")}# " +
                             $"AND {{View_Rpt_PO_Plan_Status.BalanceQty}} >= 0 " +
                             $"AND {{View_Rpt_PO_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
                }
            }
            else if (RadioButton4.Checked && LastConfDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiPOStatus.rpt";

                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{View_Rpt_PO_Plan_Status.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                             $"AND {{View_Rpt_PO_Plan_Status.ArtCode}} = '{ArtCodeComboBox.SelectedValue}' " +
                             $"AND {{View_Rpt_PO_Plan_Status.ArtSize}} in '{ArtSizeComboBox.SelectedValue}' to '{ArtSizeComboBox1.Text}' " +
                             $"AND {{View_Rpt_PO_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                             $"AND {{View_Rpt_PO_Plan_Status.SecondConfDate}} in #{DTPicker1.Value.ToString("MM/dd/yyyy")}# to #{DTPicker2.Value.ToString("MM/dd/yyyy")}# " +
                             $"AND {{View_Rpt_PO_Plan_Status.BalanceQty}} >= 0 " +
                             $"AND {{View_Rpt_PO_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
                }
            }
            else if (RadioButton4.Checked && EntryDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiPOStatus.rpt";

                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{View_Rpt_PO_Plan_Status.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                             $"AND {{View_Rpt_PO_Plan_Status.ArtCode}} = '{ArtCodeComboBox.SelectedValue}' " +
                             $"AND {{View_Rpt_PO_Plan_Status.ArtSize}} in '{ArtSizeComboBox.SelectedValue}' to '{ArtSizeComboBox1.SelectedValue}' " +
                             $"AND {{View_Rpt_PO_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                             $"AND {{View_Rpt_PO_Plan_Status.EntryDate}} in #{DTPicker1.Value.ToString("MM/dd/yyyy")}# to #{DTPicker2.Value.ToString("MM/dd/yyyy")}# " +
                             $"AND {{View_Rpt_PO_Plan_Status.BalanceQty}} >= 0 " +
                             $"AND {{View_Rpt_PO_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
                }
            }
            else if (RadioButton7.Checked && ReplacementDate.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiPOStatus(Replacement).rpt";

                Filter = $"{{View_Rpt_PO_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                         $"AND {{View_Rpt_PO_Plan_Status.SecondConfDate}} in #{DTPicker1.Value.ToString("MM/dd/yyyy")}# to #{DTPicker2.Value.ToString("MM/dd/yyyy")}# " +
                         $"AND {{View_Rpt_PO_Plan_Status.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                         $"AND {{View_Rpt_PO_Plan_Status.ReplacementQuantity}} >= 0";
            }


            else if (RadioButton8.Checked)
            {
                string path = @"\\dnsserver\MyReports$\ERPPPS\PPS\POrders.rpt";
                DateTime firstDate = new DateTime(this.DTPicker1.Value.Year, this.DTPicker1.Value.Month, 1);
                DateTime secondDate = GetLastDayOfMonth(DTPicker2.Value.Date); // Assuming GetLastDayOfMonth is a method that returns a DateTime.

                // Assuming you want to use the month and year from the DateTime objects for filtering.
                // Note: Adjust the filter string to match your data access method.
                string filter = $"{{View_PO_Orders_15ThCuttOff.ClientID}} = 1 and {{View_PO_Orders_15ThCuttOff.SecondConfDate}} in #{firstDate:MM/dd/yyyy}# to #{secondDate:MM/dd/yyyy}#";
            }


            if (RadioButton10.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiStockOrderReport.rpt";
                Filter = $"{{tbl_Pro_PO_H.OrderType}} in ['Forcast Order', 'Forcast Stock'] " +
                         $"And {{tbl_Pro_Model.ClientID}} in {ClientNameComboBox.SelectedValue} To {ClientNameComboBox1.SelectedValue} " +
                         $"And {{tbl_Pro_Model.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                         $"And {{tbl_Pro_PO_D.OrderQty}} >= 0";
            }
            else if (RadioButton9.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiStockOrderReport.rpt";
                Filter = $"{{tbl_Pro_PO_H.OrderType}} in ['Forcast Order', 'Forcast Stock'] " +
                         $"And {{tbl_Pro_Model.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                         $"And {{tbl_Pro_Model.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                         $"And {{tbl_Pro_Article.ArtCode}} in '{ArtCodeComboBox.Text}' to '{ArtCodeComboBox1.Text}' " +
                         $"And {{tbl_Pro_PO_D.OrderQty}} >= 0";
            }
            else if (RadioButton11.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiStockOrderReport.rpt";
                Filter = $"{{tbl_Pro_PO_H.OrderType}} in ['Forcast Order', 'Forcast Stock'] " +
                         $"And {{tbl_Pro_Model.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                         $"And {{tbl_Pro_Model.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                         $"And {{tbl_Pro_Article.ArtCode}} = '{ArtCodeComboBox.Text}' " +
                         $"And {{tbl_Pro_PO_D.ArtSize}} in '{ArtSizeComboBox.Text}' to '{ArtSizeComboBox1.Text}' " +
                         $"And {{tbl_Pro_PO_D.OrderQty}} >= 0";
            }

            if (RadioButton14.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiStockAdjustRecord.rpt";
                Filter = $"{{tbl_Pro_Model.ClientID}} in {ClientNameComboBox.SelectedValue} To {ClientNameComboBox1.SelectedValue} " +
                         $"And {{tbl_Pro_Model.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                         $"And {{tbl_Pro_PO_D.QtyAdjFrmStock}} >= 0";
            }
            else if (RadioButton13.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiStockAdjustRecord.rpt";
                Filter = $"{{tbl_Pro_Model.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                         $"And {{tbl_Pro_Model.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                         $"And {{tbl_Pro_Article.ArtCode}} in '{ArtCodeComboBox.Text}' to '{ArtCodeComboBox1.Text}' " +
                         $"And {{tbl_Pro_PO_D.QtyAdjFrmStock}} >= 0";
            }
            else if (RadioButton12.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiStockAdjustRecord.rpt";
                Filter = $"{{tbl_Pro_Model.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                         $"And {{tbl_Pro_Model.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                         $"And {{tbl_Pro_Article.ArtCode}} = '{ArtCodeComboBox.Text}' " +
                         $"And {{tbl_Pro_PO_D.ArtSize}} in '{ArtSizeComboBox.Text}' to '{ArtSizeComboBox1.Text}' " +
                         $"And {{tbl_Pro_PO_D.QtyAdjFrmStock}} >= 0";
            }

            if (RadioButton17.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiRptPOStockBalance.rpt";
                Filter = $"{{View_PO_Stock_Balance.ClientID}} in {ClientNameComboBox.SelectedValue} To {ClientNameComboBox1.SelectedValue} " +
                         $"And {{tbl_Pro_Model.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}'";
            }
            else if (RadioButton16.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiRptPOStockBalance.rpt";
                Filter = $"{{View_PO_Stock_Balance.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                         $"And {{tbl_Pro_Model.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                         $"And {{tbl_Pro_Article.ArtCode}} in '{ArtCodeComboBox.Text}' to '{ArtCodeComboBox1.Text}'";
            }
            else if (RadioButton15.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiRptPOStockBalance.rpt";
                Filter = $"{{View_PO_Stock_Balance.ClientID}} = {ClientNameComboBox.SelectedValue} " +
                         $"And {{tbl_Pro_Model.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                         $"And {{tbl_Pro_Article.ArtCode}} = '{ArtCodeComboBox.Text}' " +
                         $"And {{View_PO_Stock_Balance.ArtSize}} in '{ArtSizeComboBox.Text}' to '{ArtSizeComboBox1.Text}'";
            }

            if (RadioButton18.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiRptPOOrderQtyDeliveryDateWise.rpt";

                if (RadioButton26.Checked)
                {
                    Filter = $"{{View_Rpt_Dispatch_Bal_Sum.ClientId}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} " +
                             $"and {{View_Rpt_Dispatch_Bal_Sum.SecondConfDate}} in #{this.DTPicker1.Value:MM/dd/yyyy}# to #{this.DTPicker2.Value:MM/dd/yyyy}# " +
                             $"AND {{View_Rpt_Dispatch_Bal_Sum.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}'";
                }
                else if (RadioButton27.Checked)
                {
                    Filter = $"{{View_Rpt_Dispatch_Bal_Sum.ClientId}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} " +
                             $"and {{View_Rpt_Dispatch_Bal_Sum.SecondConfDate}} in #{this.DTPicker1.Value:MM/dd/yyyy}# to #{this.DTPicker2.Value:MM/dd/yyyy}# " +
                             $"AND {{View_Rpt_Dispatch_Bal_Sum.FactoryCode}} In [\"{GetCardsInString()}\"]";
                }
            }
            else if (RadioButton19.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiRptPOOrderQtyCustReqDateWise.rpt";
                Filter = $"{{View_Rpt_Dispatch_Bal_Sum.ClientId}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} " +
                         $"and {{View_Rpt_Dispatch_Bal_Sum.CustReqDate}} in #{this.DTPicker1.Value:MM/dd/yyyy}# to #{this.DTPicker2.Value:MM/dd/yyyy}# " +
                         $"AND {{View_Rpt_Dispatch_Bal_Sum.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}'";
            }
            else if (RadioButton20.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\RptPOOrderQtyLPDateWise.rpt";
                Filter = $"{{View_Rpt_Dispatch_Bal_Sum.ClientId}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} " +
                         $"and {{View_Rpt_Dispatch_Bal_Sum.LPDate}} in #{this.DTPicker1.Value:MM/dd/yyyy}# to #{this.DTPicker2.Value:MM/dd/yyyy}# " +
                         $"AND {{View_Rpt_Dispatch_Bal_Sum.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}'";
            }
            else if (RadioButton21.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiPOSummar1PODD.rpt";
                Filter = $"{{View_Rpt_PO_Plan_Status.ClientId}} in {1} to {1} " +
                         $"and {{View_Rpt_PO_Plan_Status.SecondConfDate}} in #{this.DTPicker1.Value:MM/dd/yyyy}# to #{this.DTPicker2.Value:MM/dd/yyyy}# " +
                         $"AND {{View_Rpt_PO_Plan_Status.OrderType}} = 'Original Order'";
            }
            else if (RadioButton24.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiPOSummar1PODDYear.rpt";
                Filter = $"{{View_Rpt_PO_Plan_Status.ClientId}} in {1} to {1} " +
                         $"and {{View_Rpt_PO_Plan_Status.SecondConfDate}} in #{this.DTPicker1.Value:MM/dd/yyyy}# to #{this.DTPicker2.Value:MM/dd/yyyy}# " +
                         $"AND {{View_Rpt_PO_Plan_Status.OrderType}} = 'Original Order'";
            }
            if (RadioButton22.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiArtStatusReport.rpt";
                Filter = $"{{View_Rpt_Art_Plan_Status.ClientID}}=1 And {{View_Rpt_Art_Plan_Status.SecondConfDate}} in #{this.DTPicker1.Value:MM/dd/yyyy}# to #{this.DTPicker2.Value:MM/dd/yyyy}# " +
                         $"AND {{View_Rpt_Art_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                         $"And {{View_Rpt_Art_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
            }
            else if (RadioButton25.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiArtStatusReportNew.rpt";
                Filter = $"{{View_Rpt_Art_Plan_Status.ClientID}}=1 And {{View_Rpt_Art_Plan_Status.SecondConfDate}} in #{this.DTPicker1.Value:MM/dd/yyyy}# to #{this.DTPicker2.Value:MM/dd/yyyy}# " +
                         $"AND {{View_Rpt_Art_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                         $"And {{View_Rpt_Art_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
            }
            else if (RadioButton23.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiArtStatusMonthly.rpt";
                Filter = $"{{View_Rpt_Art_Plan_Status.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} " +
                         $"AND {{View_Rpt_Art_Plan_Status.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                         $"And {{View_Rpt_Art_Plan_Status.SecondConfDate}} in #{this.DTPicker1.Value:MM/dd/yyyy}# to #{this.DTPicker2.Value:MM/dd/yyyy}# " +
                         $"And {{View_Rpt_Art_Plan_Status.OrderType}} in '{OrderTypeComboBox.Text}' to '{OrderTypeComboBox1.Text}'";
            }
            else if (RadioButton28.Checked)
            {
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\Multiconfirmorderrpt.rpt";
                if (CustReqDate.Checked)
                {
                    Filter = $"{{View_Rpt_PO_Plan_Status.ClientId}} in {1} to {1} " +
                             $"and {{View_Rpt_PO_Plan_Status.SecondConfDate}} in #{this.DTPicker1.Value:MM/dd/yyyy}# to #{this.DTPicker2.Value:MM/dd/yyyy}# " +
                             $"AND {{View_Rpt_PO_Plan_Status.OrderType}} = 'Original Order'";
                }
                else if (RadioButton29.Checked)
                {
                    Filter = $"{{View_Rpt_PO_Plan_Status.FC}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}' " +
                             $"and {{View_Rpt_PO_Plan_Status.ClientId}} in {1} to {1} " +
                             $"and {{View_Rpt_PO_Plan_Status.SecondConfDate}} in #{this.DTPicker1.Value:MM/dd/yyyy}# to #{this.DTPicker2.Value:MM/dd/yyyy}# " +
                             $"AND {{View_Rpt_PO_Plan_Status.OrderType}} = 'Original Order'";
                }
            }
            else if (RadioButton30.Checked)
            {
                if (RadioButton26.Checked)
                {
                    Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiRptArticleDetailPPS.rpt";
                }
                else if (RadioButton31.Checked)
                {
                    Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\MultiRptArticleDetailPPS.rpt";
                    Filter = $"{{View_Muzammil_Art_Detail.ArtCode}} In '{ArtCodeComboBox.SelectedValue}' To '{ArtCodeComboBox1.SelectedValue}'";
                }
            }



            if (objFrmFilter.ViewReport(Path, Filter))
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

        private string GetCardsInString()
        {
            string str = "";
            for (int i = 0; i < ListBox1.Items.Count; i++)
            {
                if (i == 0)
                {
                    str += ListBox1.Items[i].ToString();
                }
                else
                {
                    str += "\", \"" + ListBox1.Items[i].ToString();
                }
            }
            return str;
        }

        private void tbl_Pro_ClientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_Pro_ClientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSReports);

        }

        private void FrmPlanningReports_Load(object sender, EventArgs e)
        {
            this.tbl_Pro_Article1TableAdapter.Fill(this.dSReports.tbl_Pro_Article1);
            this.tbl_Pro_Article_DTableAdapter.Fill(this.dSReports.tbl_Pro_Article_D);
            try
            {
                this.tbl_Pro_Article1TableAdapter.Fill(this.dSReports.tbl_Pro_Article1);
            }
            catch (Exception ex)
            {
                // Handle exception if necessary
            }
            this.tbl_Pro_ArticleTableAdapter.Fill(this.dSReports.tbl_Pro_Article);
            this.tbl_Pro_Client1TableAdapter.Fill(this.dSReports.tbl_Pro_Client1);
            this.tbl_Pro_ClientTableAdapter.Fill(this.dSReports.tbl_Pro_Client);

            //if (frmLoginVer.DeptID == 71)
            {
                this.OrderTypeComboBox.Items.Add("RND Ball");
                this.OrderTypeComboBox.Items.Add("Dev Ball");
                this.OrderTypeComboBox.Items.Add("SMS Ball");
                this.OrderTypeComboBox1.Items.Add("RND Ball");
                this.OrderTypeComboBox1.Items.Add("Dev Ball");
                this.OrderTypeComboBox1.Items.Add("SMS Ball");
            }
            //else
            {
                this.OrderTypeComboBox.Items.Add("Original Order");
                this.OrderTypeComboBox.Items.Add("Forecast Stock");
                this.OrderTypeComboBox.Items.Add("B-Grade Order");
                this.OrderTypeComboBox.Items.Add("Cancel Order");
                this.OrderTypeComboBox.Items.Add("RND Ball");
                this.OrderTypeComboBox.Items.Add("Dev Ball");
                this.OrderTypeComboBox.Items.Add("SMS Ball");
                this.OrderTypeComboBox1.Items.Add("Original Order");
                this.OrderTypeComboBox1.Items.Add("Forecast Stock");
                this.OrderTypeComboBox1.Items.Add("B-Grade Order");
                this.OrderTypeComboBox1.Items.Add("Cancel Order");
                this.OrderTypeComboBox1.Items.Add("RND Ball");
                this.OrderTypeComboBox1.Items.Add("Dev Ball");
                this.OrderTypeComboBox1.Items.Add("SMS Ball");
            }


            {
                RadioButton7.Visible = true;
                RadioButton9.Visible = true;
                RadioButton10.Visible = true;
                RadioButton11.Visible = true;
                RadioButton12.Visible = true;
                RadioButton13.Visible = true;
                RadioButton14.Visible = true;
                RadioButton15.Visible = true;
                RadioButton16.Visible = true;
                RadioButton17.Visible = true;
            }

            {
                RadioButton9.Visible = true;
                RadioButton10.Visible = true;
                RadioButton11.Visible = true;
                RadioButton12.Visible = true;
                RadioButton13.Visible = true;
                RadioButton14.Visible = true;
                RadioButton15.Visible = true;
                RadioButton16.Visible = true;
                RadioButton17.Visible = true;
            }

            {
                RadioButton7.Visible = true;

                RadioButton9.Visible = true;
                RadioButton10.Visible = true;
                RadioButton11.Visible = true;
                RadioButton12.Visible = true;
                RadioButton13.Visible = true;
                RadioButton14.Visible = true;
                RadioButton15.Visible = true;
                RadioButton16.Visible = true;
                RadioButton17.Visible = true;
            }


        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ShowContents(true, false, false, false, false, true, false, true);
            if (RadioButton1.Checked)
            {
                GroupBox3.Enabled = true;
            }
            else if (RadioButton21.Checked || RadioButton24.Checked)
            {
                ShowContents(false, false, false, false, false, true, false, false);
                GroupBox3.Enabled = false;
                GroupBox1.Visible = false;
            }
            else if (RadioButton18.Checked)
            {
                GroupBox1.Visible = true;
            }
            else
            {
                GroupBox3.Enabled = false;
                GroupBox1.Visible = false;
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ShowContents(bool Client, bool ArtCode1, bool ArtCode2, bool ArtSize1, bool ArtSize2, bool RepDate, bool RepDate1, bool Fact)
        {
            ClientNameComboBox1.Enabled = Client;
            ClientNameComboBox.Enabled = Fact;
            ArtCodeComboBox.Enabled = ArtCode1;
            ArtCodeComboBox1.Enabled = ArtCode2;
            ArtSizeComboBox.Enabled = ArtSize1;
            ArtSizeComboBox1.Enabled = ArtSize2;
            FactoryCodeComboBox.Enabled = Fact;
            FactoryCodeComboBox1.Enabled = Fact;
            OrderTypeComboBox.Enabled = Fact;
            OrderTypeComboBox1.Enabled = Fact;
            CustReqDate.Enabled = RepDate;
            LastConfDate.Enabled = RepDate;
            ExFactoryDate.Enabled = RepDate;
            EntryDate.Enabled = RepDate;
            ReplacementDate.Visible = RepDate1;

            DTPicker1.CustomFormat = "dd/MM/yy";
            DTPicker2.CustomFormat = "dd/MM/yy";
            DTPicker1.Format = DateTimePickerFormat.Custom;
            DTPicker2.Format = DateTimePickerFormat.Custom;
            GroupBox3.Enabled = true;
        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            ShowContents(false, false, false, false, false, false, true, true);
            OrderTypeComboBox.Enabled = false;
            OrderTypeComboBox1.Enabled = false;
        }

        private void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            ShowContents(false, false, false, false, false, true, true, false);
            DTPicker1.CustomFormat = "MMM-yyyy";
            DTPicker2.CustomFormat = "MMM-yyyy";
            DTPicker1.Enabled = true;
            DTPicker2.Enabled = true;
            DTPicker1.Format = DateTimePickerFormat.Custom;
            DTPicker2.Format = DateTimePickerFormat.Custom;
        }

        private void RadioButton27_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox7.Visible = RadioButton27.Checked;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedText.Length >= 0)
            {
                ListBox1.Items.Add(ComboBox1.Text);
                ListBox1.SelectedIndex = ListBox1.Items.Count - 1;
            }
        }

        private void RadioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            ShowContents(false, true, true, false, false, true, false, true);
            GroupBox3.Enabled = true;
        }

        private void RadioButton6_CheckedChanged_1(object sender, EventArgs e)
        {
            ShowContents(false, true, false, true, true, true, false, true);
        }

        private void RadioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RadioButton2.Checked)
            {
                ShowContents(true, false, false, false, false, true, false, true);
                GroupBox3.Enabled = true;
                DTPicker1.Enabled = true;
                DTPicker2.Enabled = true;
                OrderTypeComboBox.Enabled = true;
                OrderTypeComboBox1.Enabled = true;
            }
            else
            {
                ShowContents(true, false, false, false, false, true, false, true);
                GroupBox3.Enabled = false;
                OrderTypeComboBox.Enabled = false;
                OrderTypeComboBox1.Enabled = false;
            }
        }
        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RadioButton3.Checked)
            {
                ShowContents(false, true, true, false, false, true, false, true);
                GroupBox3.Enabled = true;
                DTPicker1.Enabled = true;
                DTPicker2.Enabled = true;
                OrderTypeComboBox.Enabled = true;
                OrderTypeComboBox1.Enabled = true;
            }
            else
            {
                ShowContents(false, true, true, false, false, true, false, true);
                OrderTypeComboBox.Enabled = false;
                OrderTypeComboBox1.Enabled = false;
            }
        }

        private void RadioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RadioButton4.Checked)
            {
                ShowContents(false, true, false, true, true, true, false, true);
                GroupBox3.Enabled = true;
                DTPicker1.Enabled = true;
                DTPicker2.Enabled = true;
                OrderTypeComboBox.Enabled = true;
                OrderTypeComboBox1.Enabled = true;
            }
            else
            {
                ShowContents(false, true, false, true, true, true, false, true);
                OrderTypeComboBox.Enabled = false;
                OrderTypeComboBox1.Enabled = false;
            }
        }

        private void RadioButton7_CheckedChanged_1(object sender, EventArgs e)
        {
            ShowContents(false, false, false, false, false, false, true, true);
            OrderTypeComboBox.Enabled = false;
            OrderTypeComboBox1.Enabled = false;

        }

        private void RadioButton8_CheckedChanged_1(object sender, EventArgs e)
        {
            ShowContents(false, false, false, false, false, true, true, false);
            DTPicker1.CustomFormat = "MMM-yyyy";
            DTPicker2.CustomFormat = "MMM-yyyy";
            DTPicker1.Enabled = true;
            DTPicker2.Enabled = true;
            DTPicker1.Format = DateTimePickerFormat.Custom;
            DTPicker2.Format = DateTimePickerFormat.Custom;

        }

        private void RadioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked)
            {
                ShowContents(true, false, false, false, false, true, false, true);
                GroupBox3.Enabled = true;
                DTPicker1.Enabled = true;
                DTPicker2.Enabled = true;
                OrderTypeComboBox.Enabled = true;
                OrderTypeComboBox1.Enabled = true;
            }
            else
            {
                ShowContents(true, false, false, false, false, true, false, true);
                GroupBox3.Enabled = false;
                // DTPicker1.Enabled = false;
                // DTPicker2.Enabled = false;
                OrderTypeComboBox.Enabled = false;
                OrderTypeComboBox1.Enabled = false;
            }

        }

        private void RadioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton4.Checked)
            {
                ShowContents(false, true, false, true, true, true, false, true);
                GroupBox3.Enabled = true;
                DTPicker1.Enabled = true;
                DTPicker2.Enabled = true;
                OrderTypeComboBox.Enabled = true;
                OrderTypeComboBox1.Enabled = true;
            }
            else
            {
                ShowContents(false, true, false, true, true, true, false, true);
                // DTPicker1.Enabled = false;
                // DTPicker2.Enabled = false;
                OrderTypeComboBox.Enabled = false;
                OrderTypeComboBox1.Enabled = false;
            }

        }

        private void RadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton3.Checked)
            {
                ShowContents(false, true, true, false, false, true, false, true);
                GroupBox3.Enabled = true;
                DTPicker1.Enabled = true;
                DTPicker2.Enabled = true;
                OrderTypeComboBox.Enabled = true;
                OrderTypeComboBox1.Enabled = true;
            }
            else
            {
                ShowContents(false, true, true, false, false, true, false, true);
                // DTPicker1.Enabled = false;
                // DTPicker2.Enabled = false;
                OrderTypeComboBox.Enabled = false;
                OrderTypeComboBox1.Enabled = false;
            }

        }

        private void RadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked)
            {
                ShowContents(true, false, false, false, false, true, false, true);
                GroupBox3.Enabled = true;
                DTPicker1.Enabled = true;
                DTPicker2.Enabled = true;
                OrderTypeComboBox.Enabled = true;
                OrderTypeComboBox1.Enabled = true;
            }
            else
            {
                ShowContents(true, false, false, false, false, true, false, true);
                GroupBox3.Enabled = false;
                // DTPicker1.Enabled = false;
                // DTPicker2.Enabled = false;
                OrderTypeComboBox.Enabled = false;
                OrderTypeComboBox1.Enabled = false;
            }

        }

        private void RadioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton3.Checked)
            {
                ShowContents(false, true, true, false, false, true, false, true);
                GroupBox3.Enabled = true;
                DTPicker1.Enabled = true;
                DTPicker2.Enabled = true;
                OrderTypeComboBox.Enabled = true;
                OrderTypeComboBox1.Enabled = true;
            }
            else
            {
                ShowContents(false, true, true, false, false, true, false, true);
                // DTPicker1.Enabled = false;
                // DTPicker2.Enabled = false;
                OrderTypeComboBox.Enabled = false;
                OrderTypeComboBox1.Enabled = false;
            }

        }

        private void RadioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton4.Checked)
            {
                ShowContents(false, true, false, true, true, true, false, true);
                GroupBox3.Enabled = true;
                DTPicker1.Enabled = true;
                DTPicker2.Enabled = true;
                OrderTypeComboBox.Enabled = true;
                OrderTypeComboBox1.Enabled = true;
            }
            else
            {
                ShowContents(false, true, false, true, true, true, false, true);
                // DTPicker1.Enabled = false;
                // DTPicker2.Enabled = false;
                OrderTypeComboBox.Enabled = false;
                OrderTypeComboBox1.Enabled = false;
            }

        }

        private void RadioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked)
            {
                ShowContents(true, false, false, false, false, true, false, true);
                GroupBox3.Enabled = true;
                DTPicker1.Enabled = true;
                DTPicker2.Enabled = true;
                OrderTypeComboBox.Enabled = true;
                OrderTypeComboBox1.Enabled = true;
            }
            else
            {
                ShowContents(true, false, false, false, false, true, false, true);
                GroupBox3.Enabled = false;
                // DTPicker1.Enabled = false;
                // DTPicker2.Enabled = false;
                OrderTypeComboBox.Enabled = false;
                OrderTypeComboBox1.Enabled = false;
            }

        }

        private void RadioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton3.Checked)
            {
                ShowContents(false, true, true, false, false, true, false, true);
                GroupBox3.Enabled = true;
                DTPicker1.Enabled = true;
                DTPicker2.Enabled = true;
                OrderTypeComboBox.Enabled = true;
                OrderTypeComboBox1.Enabled = true;
            }
            else
            {
                ShowContents(false, true, true, false, false, true, false, true);
                // DTPicker1.Enabled = false;
                // DTPicker2.Enabled = false;
                OrderTypeComboBox.Enabled = false;
                OrderTypeComboBox1.Enabled = false;
            }

        }

        private void RadioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton4.Checked)
            {
                ShowContents(false, true, false, true, true, true, false, true);
                GroupBox3.Enabled = true;
                DTPicker1.Enabled = true;
                DTPicker2.Enabled = true;
                OrderTypeComboBox.Enabled = true;
                OrderTypeComboBox1.Enabled = true;
            }
            else
            {
                ShowContents(false, true, false, true, true, true, false, true);
                // DTPicker1.Enabled = false;
                // DTPicker2.Enabled = false;
                OrderTypeComboBox.Enabled = false;
                OrderTypeComboBox1.Enabled = false;
            }

        }

        private void RadioButton23_CheckedChanged(object sender, EventArgs e)
        {
            ShowContents(true, false, false, false, false, true, false, true);

            if (RadioButton1.Checked)
            {
                GroupBox3.Enabled = true;
            }
            else if (RadioButton21.Checked || RadioButton24.Checked)
            {
                ShowContents(false, false, false, false, false, true, false, false);
                GroupBox3.Enabled = false;
                GroupBox1.Visible = false;
            }
            else if (RadioButton18.Checked)
            {
                GroupBox1.Visible = true;
            }
            else
            {
                GroupBox3.Enabled = false;
                GroupBox1.Visible = false;
            }

        }

        private void RadioButton18_CheckedChanged(object sender, EventArgs e)
        {
            ShowContents(true, false, false, false, false, true, false, true);

            if (RadioButton1.Checked)
            {
                GroupBox3.Enabled = true;
            }
            else if (RadioButton21.Checked || RadioButton24.Checked)
            {
                ShowContents(false, false, false, false, false, true, false, false);
                GroupBox3.Enabled = false;
                GroupBox1.Visible = false;
            }
            else if (RadioButton18.Checked)
            {
                GroupBox1.Visible = true;
            }
            else
            {
                GroupBox3.Enabled = false;
                GroupBox1.Visible = false;
            }

        }

        private void RadioButton19_CheckedChanged(object sender, EventArgs e)
        {
            ShowContents(true, false, false, false, false, true, false, true);

            if (RadioButton1.Checked)
            {
                GroupBox3.Enabled = true;
            }
            else if (RadioButton21.Checked || RadioButton24.Checked)
            {
                ShowContents(false, false, false, false, false, true, false, false);
                GroupBox3.Enabled = false;
                GroupBox1.Visible = false;
            }
            else if (RadioButton18.Checked)
            {
                GroupBox1.Visible = true;
            }
            else
            {
                GroupBox3.Enabled = false;
                GroupBox1.Visible = false;
            }

        }

        private void RadioButton20_CheckedChanged(object sender, EventArgs e)
        {
            ShowContents(true, false, false, false, false, true, false, true);

            if (RadioButton1.Checked)
            {
                GroupBox3.Enabled = true;
            }
            else if (RadioButton21.Checked || RadioButton24.Checked)
            {
                ShowContents(false, false, false, false, false, true, false, false);
                GroupBox3.Enabled = false;
                GroupBox1.Visible = false;
            }
            else if (RadioButton18.Checked)
            {
                GroupBox1.Visible = true;
            }
            else
            {
                GroupBox3.Enabled = false;
                GroupBox1.Visible = false;
            }

        }

        private void RadioButton21_CheckedChanged(object sender, EventArgs e)
        {
            ShowContents(true, false, false, false, false, true, false, true);

            if (RadioButton1.Checked)
            {
                GroupBox3.Enabled = true;
            }
            else if (RadioButton21.Checked || RadioButton24.Checked)
            {
                ShowContents(false, false, false, false, false, true, false, false);
                GroupBox3.Enabled = false;
                GroupBox1.Visible = false;
            }
            else if (RadioButton18.Checked)
            {
                GroupBox1.Visible = true;
            }
            else
            {
                GroupBox3.Enabled = false;
                GroupBox1.Visible = false;
            }

        }

        private void RadioButton22_CheckedChanged(object sender, EventArgs e)
        {
            ShowContents(true, false, false, false, false, true, false, true);

            if (RadioButton1.Checked)
            {
                GroupBox3.Enabled = true;
            }
            else if (RadioButton21.Checked || RadioButton24.Checked)
            {
                ShowContents(false, false, false, false, false, true, false, false);
                GroupBox3.Enabled = false;
                GroupBox1.Visible = false;
            }
            else if (RadioButton18.Checked)
            {
                GroupBox1.Visible = true;
            }
            else
            {
                GroupBox3.Enabled = false;
                GroupBox1.Visible = false;
            }

        }

        private void RadioButton24_CheckedChanged(object sender, EventArgs e)
        {
            ShowContents(true, false, false, false, false, true, false, true);

            if (RadioButton1.Checked)
            {
                GroupBox3.Enabled = true;
            }
            else if (RadioButton21.Checked || RadioButton24.Checked)
            {
                ShowContents(false, false, false, false, false, true, false, false);
                GroupBox3.Enabled = false;
                GroupBox1.Visible = false;
            }
            else if (RadioButton18.Checked)
            {
                GroupBox1.Visible = true;
            }
            else
            {
                GroupBox3.Enabled = false;
                GroupBox1.Visible = false;

            }
        }

        private void RadioButton25_CheckedChanged(object sender, EventArgs e)
        {
            ShowContents(true, false, false, false, false, true, false, true);

            if (RadioButton1.Checked)
            {
                GroupBox3.Enabled = true;
            }
            else if (RadioButton21.Checked || RadioButton24.Checked)
            {
                ShowContents(false, false, false, false, false, true, false, false);
                GroupBox3.Enabled = false;
                GroupBox1.Visible = false;
            }
            else if (RadioButton18.Checked)
            {
                GroupBox1.Visible = true;
            }
            else
            {
                GroupBox3.Enabled = false;
                GroupBox1.Visible = false;
            }

        }

        private void RadioButton28_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RadioButton28.Checked)
            {
                GroupBox3.Enabled = true;
            }
            else
            {
                GroupBox3.Enabled = false;
            }

        }

        private void RadioButton30_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RadioButton30.Checked)
            {
                GroupBox1.Visible = true;
                RadioButton26.Checked = true;
                ArtCodeComboBox.Enabled = true;
                ArtCodeComboBox1.Enabled = true;
            }
            else
            {
                // GroupBox1.Visible = false; // Uncomment if needed
                RadioButton26.Checked = false;
                ArtCodeComboBox.Enabled = false;
                ArtCodeComboBox1.Enabled = false;
            }

        }
    }
}
