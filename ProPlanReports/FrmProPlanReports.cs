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

namespace ERP_Production.ProPlanReports
{
    public partial class FrmProPlanReports : DevExpress.XtraEditors.XtraForm
    {
        public string Param { get; private set; }

        public FrmProPlanReports()
        {
            InitializeComponent();
        }



        private void auth_userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.auth_userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSRptMER);

        }

        private void FrmProPlanReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.tbl_Multi_PO_H' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_HTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Multi_PO_H);
            // TODO: This line of code loads data into the 'dSRptMER.tbl_Pro_Client1' table. You can move, or remove it, as needed.
            this.tbl_Pro_Client1TableAdapter.Fill(this.dSRptMER.tbl_Pro_Client1);
            // TODO: This line of code loads data into the 'dSRptMER.tbl_Pro_Model1' table. You can move, or remove it, as needed.
            this.tbl_Pro_Model1TableAdapter.Fill(this.dSRptMER.tbl_Pro_Model1);
            // TODO: This line of code loads data into the 'dSRptMER.tbl_Pro_Model' table. You can move, or remove it, as needed.
            this.tbl_Pro_ModelTableAdapter.Fill(this.dSRptMER.tbl_Pro_Model);
            // TODO: This line of code loads data into the 'dSRptMER.tbl_Pro_Article1' table. You can move, or remove it, as needed.
            this.tbl_Pro_Article1TableAdapter.Fill(this.dSRptMER.tbl_Pro_Article1);
            // TODO: This line of code loads data into the 'dSRptMER.tbl_Pro_Article' table. You can move, or remove it, as needed.
            this.tbl_Pro_ArticleTableAdapter.Fill(this.dSRptMER.tbl_Pro_Article);
            // TODO: This line of code loads data into the 'dSRptMER.tbl_Pro_Client' table. You can move, or remove it, as needed.
            this.tbl_Pro_ClientTableAdapter.Fill(this.dSRptMER.tbl_Pro_Client);
            // TODO: This line of code loads data into the 'dSRptMER.auth_user' table. You can move, or remove it, as needed.
            this.auth_userTableAdapter.Fill(this.dSRptMER.auth_user);

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ExFactoryDate.Visible = true;
            CustReqDate.Visible = false;
            LastPrdDate.Visible = false;
            SecondConfDate.Visible = false;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ExFactoryDate.Visible = false;
            CustReqDate.Visible = false;
            LastPrdDate.Visible = true;
            SecondConfDate.Visible = false;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ExFactoryDate.Visible = false;
            CustReqDate.Visible = true;
            LastPrdDate.Visible = false;
            SecondConfDate.Visible = false;
        }

        //private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        //{
        //    ExFactoryDate.Visible = false;
        //    CustReqDate.Visible = false;
        //    LastPrdDate.Visible = false;
        //    SecondConfDate.Visible = true;
        //}
        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Path = "";
            string Filter = "";
            Form1 objFrmFilter = new Form1();

            if (RadioButton1.Checked && RadioButton4.Checked)
            {
                Path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptModelList.rpt";
                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{tbl_Pro_Client.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} And {{tbl_Pro_Model.Status}}";
                }
                else if (CheckBox1.CheckState == CheckState.Unchecked)
                {
                    Filter = $"{{tbl_Pro_Client.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} And not {{tbl_Pro_Model.Status}}";
                }
                else if (CheckBox1.CheckState == CheckState.Indeterminate)
                {
                    Filter = $"{{tbl_Pro_Client.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue}";
                }
            }
            else if (RadioButton1.Checked && RadioButton5.Checked)
            {
                Path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptModelList.rpt";
                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{tbl_Pro_Client.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} And {{tbl_Pro_Model.SesonalRange}} in '{SesonalRangeComboBox.SelectedValue}' to '{SesonalRangeComboBox1.SelectedValue}' And {{tbl_Pro_Model.Status}}";
                }
                else if (CheckBox1.CheckState == CheckState.Unchecked)
                {
                    Filter = $"{{tbl_Pro_Client.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} And {{tbl_Pro_Model.SesonalRange}} in '{SesonalRangeComboBox.SelectedValue}' to '{SesonalRangeComboBox1.SelectedValue}' And not {{tbl_Pro_Model.Status}}";
                }
                else if (CheckBox1.CheckState == CheckState.Indeterminate)
                {
                    Filter = $"{{tbl_Pro_Client.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} And {{tbl_Pro_Model.SesonalRange}} in '{SesonalRangeComboBox.SelectedValue}' to '{SesonalRangeComboBox1.SelectedValue}'";
                }
            }
            else if (RadioButton2.Checked && RadioButton4.Checked)
            {
                Path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptArticleList.rpt";
                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{tbl_Pro_Client.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} And {{tbl_Pro_Article.Status}}";
                }
                else if (CheckBox1.CheckState == CheckState.Unchecked)
                {
                    Filter = $"{{tbl_Pro_Client.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} And not {{tbl_Pro_Article.Status}}";
                }
                else if (CheckBox1.CheckState == CheckState.Indeterminate)
                {
                    Filter = $"{{tbl_Pro_Client.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue}";
                }
            }
            else if (RadioButton2.Checked && RadioButton5.Checked)
            {
                Path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptArticleList.rpt";
                if (CheckBox1.CheckState == CheckState.Checked)
                {
                    Filter = $"{{tbl_Pro_Client.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} And {{tbl_Pro_Model.SesonalRange}} in '{SesonalRangeComboBox.SelectedValue}' to '{SesonalRangeComboBox1.SelectedValue}' And {{tbl_Pro_Article.Status}}";
                }
                else if (CheckBox1.CheckState == CheckState.Unchecked)
                {
                    Filter = $"{{tbl_Pro_Client.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} And {{tbl_Pro_Model.SesonalRange}} in '{SesonalRangeComboBox.SelectedValue}' to '{SesonalRangeComboBox1.SelectedValue}' And not {{tbl_Pro_Article.Status}}";
                }
                else if (CheckBox1.CheckState == CheckState.Indeterminate)
                {
                    Filter = $"{{tbl_Pro_Client.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} And {{tbl_Pro_Model.SesonalRange}} in '{SesonalRangeComboBox.SelectedValue}' to '{SesonalRangeComboBox1.SelectedValue}'";
                }
            }
            else if (RadioButton3.Checked && RadioButton4.Checked)
            {
                if (RadioButton14.Checked)
                {
                    Path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptArticleSize.rpt";
                }
                else if (RadioButton13.Checked)
                {
                    Path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptArticleSizewithbalance.rpt";
                }
                Filter = $"{{view_Article_Wise_Value.ArtCode}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue}";
            }
            else if (RadioButton3.Checked && RadioButton5.Checked)
            {
                if (RadioButton14.Checked)
                {
                    Path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptArticleSize.rpt";
                }
                else if (RadioButton13.Checked)
                {
                    Path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptArticleSizewithbalance.rpt";
                }
                Filter = $"{{view_Article_Wise_Value.ClientID}} = {ClientNameComboBox.SelectedValue} And {{view_Article_Wise_Value.SesonalRange}} in '{SesonalRangeComboBox.SelectedValue}' to '{SesonalRangeComboBox1.SelectedValue}'";
            }
            else if (RadioButton3.Checked && RadioButton6.Checked)
            {
                if (RadioButton14.Checked)
                {
                    Path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptArticleSize.rpt";
                }
                else if (RadioButton13.Checked)
                {
                    Path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptArticleSizewithbalance.rpt";
                }
                Filter = $"{{view_Article_Wise_Value.ClientID}} = {ClientNameComboBox.SelectedValue} And {{view_Article_Wise_Value.ArtCode}} in '{ArtCodeComboBox.SelectedValue}' to '{ArtCodeComboBox1.SelectedValue}'";
            }
            else if (RadioButton3.Checked && RadioButton7.Checked)
            {
                if (RadioButton14.Checked)
                {
                    Path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptArticleSize.rpt";
                }
                else if (RadioButton13.Checked)
                {
                    Path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptArticleSizewithbalance.rpt";
                }
                Filter = $"{{view_Article_Wise_Value.ClientID}} = {ClientNameComboBox.SelectedValue} And {{view_Article_Wise_Value.FactoryCode}} = '{FactoryCodeComboBox.Text}'";
            }
            else if (RadioButton3.Checked && RadioButton8.Checked)
            {
                if (RadioButton14.Checked)
                {
                    Path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptArticleSize.rpt";
                }
                else if (RadioButton13.Checked)
                {
                    Path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptArticleSizewithbalance.rpt";
                }
                Filter = $"{{view_Article_Wise_Value.ClientID}} = {ClientNameComboBox.SelectedValue} And {{tbl_Pro_Model.FactoryCode}} = '{FactoryCodeComboBox.Text}' And {{view_Article_Wise_Value.SesonalRange}} = '{SesonalRangeComboBox.SelectedValue}'";
            }
            else if (RadioButton9.Checked && RadioButton7.Checked)
            {
                Path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptArticleDesc.rpt";
                Filter = $"{{tbl_Pro_Client.ClientID}} = {ClientNameComboBox.SelectedValue} And {{tbl_Pro_Model.FactoryCode}} in '{FactoryCodeComboBox.Text}' to '{FactoryCodeComboBox1.Text}'";
            }
            else if (RadioButton9.Checked && RadioButton10.Checked)
            {
                Path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptArticleDesc.rpt";
                Filter = $"{{tbl_Pro_Client.ClientID}} = {ClientNameComboBox.SelectedValue} And {{tbl_Pro_Model.FactoryCode}} = '{FactoryCodeComboBox.Text}' And {{tbl_Pro_Model.SesonalRange}} in '{SesonalRangeComboBox.SelectedValue}' to '{SesonalRangeComboBox1.SelectedValue}'";
            }
            else if (RadioButton11.Checked && RadioButton4.Checked)
            {
                Path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptArticleSizeCutOff.rpt";
                Filter = $"{{tbl_Pro_Article_D.SecondConfDate}} in #{DateTimePicker1.Value:MM/dd/yyyy}# to #{DateTimePicker2.Value:MM/dd/yyyy}# And {{tbl_Pro_Client.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue}";
            }
            else if (RadioButton11.Checked && RadioButton6.Checked)
            {
                Path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptArticleSizeCutOff.rpt";
                Filter = $"{{tbl_Pro_Article_D.SecondConfDate}} in #{DateTimePicker1.Value:MM/dd/yyyy}# to #{DateTimePicker2.Value:MM/dd/yyyy}# And {{tbl_Pro_Client.ClientID}} = {ClientNameComboBox.SelectedValue} And {{tbl_Pro_Article_D.ArtCode}} in '{ArtCodeComboBox.SelectedValue}' to '{ArtCodeComboBox1.SelectedValue}'";
            }
            else if (RadioButton11.Checked && RadioButton7.Checked)
            {
                Path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptArticleSizeCutOff.rpt";
                Filter = $"{{tbl_Pro_Article_D.SecondConfDate}} in #{DateTimePicker1.Value:MM/dd/yyyy}# to #{DateTimePicker2.Value:MM/dd/yyyy}# And {{tbl_Pro_Client.ClientID}} = {ClientNameComboBox.SelectedValue} And {{tbl_Pro_Article_D.FactoryCode}} = '{FactoryCodeComboBox.Text}'";
            }
            // Load the report
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

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnShowRpt_Click(object sender, EventArgs e)
        {
            string Filter = null;
            string Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\RptPlanPO.rpt";
            Form1 objFrmFilter = new Form1();

            if (radioButton_1.Checked)
            {
                Filter = "{View_Rpt_Plan_PO_SF.ExFactoryDate} in #" +
                         this.DateTimePicker1.Value.ToString("MM/dd/yyyy") +
                         "# to #" +
                         this.DateTimePicker2.Value.ToString("MM/dd/yyyy") +
                         "# AND {View_Rpt_Plan_PO_SF.OrderType} in ['Original Order','B-Grade Order'] AND {View_Rpt_Plan_PO_SF.FactoryCode} in ['B34001', 'B34005','B34501']";
            }
            else if (radioButton_2.Checked)
            {
                Filter = "{View_Rpt_Plan_PO_SF.LPDate} in #" +
                         this.DateTimePicker1.Value.ToString("MM/dd/yyyy") +
                         "# to #" +
                         this.DateTimePicker2.Value.ToString("MM/dd/yyyy") +
                         "# AND {View_Rpt_Plan_PO_SF.OrderType} in ['Original Order','B-Grade Order'] AND {View_Rpt_Plan_PO_SF.FactoryCode} in ['B34001', 'B34501','B34005']";
            }
            else if (radioButton_3.Checked)
            {
                Filter = "{View_Rpt_Plan_PO_SF.CustReqDate} in #" +
                         this.DateTimePicker1.Value.ToString("MM/dd/yyyy") +
                         "# to #" +
                         this.DateTimePicker2.Value.ToString("MM/dd/yyyy") +
                         "# AND {View_Rpt_Plan_PO_SF.OrderType} in ['Original Order','B-Grade Order'] AND {View_Rpt_Plan_PO_SF.FactoryCode} in ['B34001', 'B34501','B34005']";
            }
            else if (radioButton_4.Checked)
            {
                Filter = "{View_Rpt_Plan_PO_SF.SecondConfDate} in #" +
                         this.DateTimePicker1.Value.ToString("MM/dd/yyyy") +
                         "# to #" +
                         this.DateTimePicker2.Value.ToString("MM/dd/yyyy") +
                         "# AND {View_Rpt_Plan_PO_SF.OrderType} in ['Original Order','B-Grade Order'] AND {View_Rpt_Plan_PO_SF.FactoryCode} in ['B34001', 'B34501','B34005']";
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

        private void radioButton_1_CheckedChanged(object sender, EventArgs e)
        {
            ExFactoryDate.Visible = true;
            CustReqDate.Visible = false;
            LastPrdDate.Visible = false;
            SecondConfDate.Visible = false;
        }

        private void radioButton_2_CheckedChanged(object sender, EventArgs e)
        {
            ExFactoryDate.Visible = false;
            CustReqDate.Visible = false;
            LastPrdDate.Visible = true;
            SecondConfDate.Visible = false;
        }

        private void radioButton_3_CheckedChanged(object sender, EventArgs e)
        {
            ExFactoryDate.Visible = false;
            CustReqDate.Visible = true;
            LastPrdDate.Visible = false;
            SecondConfDate.Visible = false;
        }

        private void radioButton_4_CheckedChanged(object sender, EventArgs e)
        {
            ExFactoryDate.Visible = false;
            CustReqDate.Visible = false;
            LastPrdDate.Visible = false;
            SecondConfDate.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Filter = null;
            string Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\RptPlanPO.rpt";
            Form1 objFrmFilter = new Form1();

            if (RadioButtonp3.Checked)
            {
                Filter = $"{{View_Rpt_PackList.PageRefNo}} in '{POComboBox.SelectedValue}' to '{POComboBox1.SelectedValue}'";
                Path = @"\\dnsserver\MyReports$\MISPro\PrdOffice\RptPackList.rpt";
            }
            else if (RadioButtonp6.Checked)
            {
                Filter = $"{{View_Rpt_PackList.SecondConfDate}} in #{DateTimePicker1.Value:MM/dd/yyyy}# to #{DateTimePicker2.Value:MM/dd/yyyy}# And {{View_Rpt_PackList.FactoryCode}}='{FactoryCodeComboBox.Text}'";
                Path = @"\\dnsserver\MyReports$\MISPro\PrdOffice\RptPackList.rpt";
            }
            else if (RadioButtonp1.Checked)
            {
                Filter = $"{{View_Rpt_PackList.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} and {{View_Rpt_PackList.SecondConfDate}} in #{DateTimePicker1.Value:MM/dd/yyyy}# to #{DateTimePicker2.Value:MM/dd/yyyy}#";
                Path = @"\\dnsserver\MyReports$\MISPro\PrdOffice\RptPackList.rpt";
            }
            else if (RadioButtonp9.Checked)
            {
                Filter = $"{{View_Rpt_PackList.ClientID}} = 1 to {ClientNameComboBox1.SelectedValue} and {{View_Rpt_PackList.SecondConfDate}} in #{DateTimePicker1.Value:MM/dd/yyyy}# to #{DateTimePicker2.Value:MM/dd/yyyy}# And {{View_Rpt_PackList.ArtCode}} = '{ArtCodeComboBox.Text}'";
                Path = @"\\dnsserver\MyReports$\MISPro\PrdOffice\RptPackList.rpt";
            }
            else if (RadioButtonp4.Checked)
            {
                if (CBPL.Text == "MLP")
                {
                    Filter = $"{{View_Rpt_PWO.PO}} = {POComboBox3.SelectedValue}";
                    Param = "PrdLine = 1";
                }
                else if (CBPL.Text == "QR")
                {
                    Filter = $"{{View_Rpt_PWO.PO}} = {POComboBox3.SelectedValue}";
                    Param = "PrdLine = 2";
                }
                else if (CBPL.Text == "Aware Sports")
                {
                    Filter = $"{{View_Rpt_PWO.PO}} = {POComboBox3.SelectedValue}";
                    Param = "PrdLine = 7";
                }
                else if (CBPL.Text == "Rehan & Sons")
                {
                    Filter = $"{{View_Rpt_PWO.PO}} = {POComboBox3.SelectedValue}";
                    Param = "PrdLine = 12";
                }
                else if (CBPL.Text == "B.J Sports")
                {
                    Filter = $"{{View_Rpt_PWO.PO}} = {POComboBox3.SelectedValue}";
                    Param = "PrdLine = 10";
                }
                Path = @"\\dnsserver\MyReports$\MISPro\PrdOffice\RptPWO.rpt";
            }
            else if (RadioButtonp5.Checked)
            {
                Filter = $"{{View_Rpt_PO_TransferoldSoft.PO}} in {POComboBox3.SelectedValue} to {POComboBox4.SelectedValue}";
                Path = @"\\dnsserver\MyReports$\MISPro\PrdOffice\RptTransferOldSoft.rpt";
            }
            else if (RadioButtonp2.Checked)
            {
                if (checkBox2.CheckState == CheckState.Checked)
                {
                    Filter = $"{{tbl_Pro_PO_H.PO}} in {POComboBox3.SelectedValue} to {POComboBox4.SelectedValue} And {{tbl_Pro_PO_H.OrderType}} ='Original Order' And {{@SBA1}} = 3";
                }
                else if (checkBox2.CheckState == CheckState.Unchecked)
                {
                    Filter = $"{{tbl_Pro_PO_H.PO}} in {POComboBox3.SelectedValue} to {POComboBox4.SelectedValue} And {{tbl_Pro_PO_H.OrderType}} ='Original Order' And {{@SBA1}} <= 2";
                }
                else if (checkBox2.CheckState == CheckState.Indeterminate)
                {
                    Filter = $"{{tbl_Pro_PO_H.PO}} in {POComboBox3.SelectedValue} to {POComboBox4.SelectedValue} And {{tbl_Pro_PO_H.OrderType}} ='Original Order'";
                }
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\RptPOLabelStatus.rpt";
            }
            else if (RadioButtonp7.Checked)
            {
                Param = $"FromDate={DateTimePicker1.Value:dd/MM/yyyy}&ToDate={DateTimePicker2.Value:dd/MM/yyyy}";
                if (checkBox2.CheckState == CheckState.Checked)
                {
                    Filter = $"{{tbl_Pro_PO_H.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} And {{tbl_Pro_PO_H.SecondConfDate}} in #{DateTimePicker1.Value:MM/dd/yyyy}# to #{DateTimePicker2.Value:MM/dd/yyyy}# And {{tbl_Pro_PO_H.OrderType}} ='Original Order' And {{@SBA1}} = 3";
                }
                else if (checkBox2.CheckState == CheckState.Unchecked)
                {
                    Filter = $"{{tbl_Pro_PO_H.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} And {{tbl_Pro_PO_H.SecondConfDate}} in #{DateTimePicker1.Value:MM/dd/yyyy}# to #{DateTimePicker2.Value:MM/dd/yyyy}# And {{tbl_Pro_PO_H.OrderType}} ='Original Order' And {{@SBA1}} <= 2";
                }
                else if (checkBox2.CheckState == CheckState.Indeterminate)
                {
                    Filter = $"{{tbl_Pro_PO_H.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} And {{tbl_Pro_PO_H.SecondConfDate}} in #{DateTimePicker1.Value:MM/dd/yyyy}# to #{DateTimePicker2.Value:MM/dd/yyyy}# And {{tbl_Pro_PO_H.OrderType}} ='Original Order'";
                }
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\RptPOLabelStatus1.rpt";
            }
            else if (RadioButtonp8.Checked)
            {
                Param = $"FromDate={DateTimePicker1.Value:dd/MM/yyyy}&ToDate={DateTimePicker2.Value:dd/MM/yyyy}";
                if (checkBox2.CheckState == CheckState.Checked)
                {
                    Filter = $"{{tbl_Pro_PO_H.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} And {{tbl_Pro_PO_H.SecondConfDate}} in #{DateTimePicker1.Value:MM/dd/yyyy}# to #{DateTimePicker2.Value:MM/dd/yyyy}# And {{tbl_Pro_PO_H.OrderType}} ='Original Order' And {{tbl_Pro_PO_H.FactoryCode}}='{FactoryCodeComboBox.Text}' And {{@SBA1}} = 3";
                }
                else if (checkBox2.CheckState == CheckState.Unchecked)
                {
                    Filter = $"{{tbl_Pro_PO_H.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} And {{tbl_Pro_PO_H.SecondConfDate}} in #{DateTimePicker1.Value:MM/dd/yyyy}# to #{DateTimePicker2.Value:MM/dd/yyyy}# And {{tbl_Pro_PO_H.OrderType}} ='Original Order' And {{tbl_Pro_PO_H.FactoryCode}}='{FactoryCodeComboBox.Text}' And {{@SBA1}} <= 2";
                }
                else if (checkBox2.CheckState == CheckState.Indeterminate)
                {
                    Filter = $"{{tbl_Pro_PO_H.ClientID}} in {ClientNameComboBox.SelectedValue} to {ClientNameComboBox1.SelectedValue} And {{tbl_Pro_PO_H.SecondConfDate}} in #{DateTimePicker1.Value:MM/dd/yyyy}# to #{DateTimePicker2.Value:MM/dd/yyyy}# And {{tbl_Pro_PO_H.OrderType}} ='Original Order' And {{tbl_Pro_PO_H.FactoryCode}}='{FactoryCodeComboBox.Text}'";
                }
                Path = @"\\dnsserver\MyReports$\ERPPPS\PPS\RptPOLabelStatus1.rpt";
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

        private void radioButton_p17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonp9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RadioButtonp3_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void groupControl6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
