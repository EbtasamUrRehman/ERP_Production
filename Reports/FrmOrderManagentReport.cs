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
    public partial class FrmOrderManagentReport : DevExpress.XtraEditors.XtraForm
    {
        public FrmOrderManagentReport()
        {
            InitializeComponent();
        }

        private void tbl_Pro_ArticleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_Pro_ArticleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSReports);

        }

        private void FrmOrderManagentReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSReports.tbl_Pro_Customer' table. You can move, or remove it, as needed.
            this.tbl_Pro_CustomerTableAdapter.Fill(this.dSReports.tbl_Pro_Customer);
            // TODO: This line of code loads data into the 'dSReports.tbl_Pro_Client1' table. You can move, or remove it, as needed.
            this.tbl_Pro_Client1TableAdapter.Fill(this.dSReports.tbl_Pro_Client1);
            // TODO: This line of code loads data into the 'dSReports.tbl_Pro_Client' table. You can move, or remove it, as needed.
            this.tbl_Pro_ClientTableAdapter.Fill(this.dSReports.tbl_Pro_Client);
            // TODO: This line of code loads data into the 'dSReports.tbl_Pro_Article' table. You can move, or remove it, as needed.
            this.tbl_Pro_ArticleTableAdapter.Fill(this.dSReports.tbl_Pro_Article);

        }

        void VerticleButton(bool CBFactory, bool Client1, bool Client2, bool CustCode, bool Artcode, bool Dt1, bool Dt2, bool Dt3, bool Dt4)
        {
            this.CBFactoryCode.Enabled = CBFactory;
            this.ClientNameComboBox.Enabled = Client1;
            this.ClientNameComboBox1.Enabled = Client2;
            this.CustCodeMTGCComboBox.Enabled = CustCode;
            this.ArtCodeMTGCComboBox.Enabled = Artcode;
            this.DateTimePicker1.Enabled = Dt1;
            this.DateTimePicker2.Enabled = Dt2;
            this.DTPicker1.Enabled = Dt3;
            this.DTPicker2.Enabled = Dt4;
        }

        private void btnVerticleRptShow_Click(object sender, EventArgs e)
        {
            string path = @"\\dnsserver\MyReports$\FSERPMER\MER\RptPOVerticle.rpt";

            string filter = "";

            if (RadioButton16.Checked || RadioButton17.Checked)
            {
                //path = "\\dnsserver\\MyReports$\\FSERPMER\\MER\\RptPOVerticleMS.rpt";
                path = @"\\dnsserver\\MyReports$\\FSERPMER\\MER\\RptPOVerticleMS.rpt";
            }
            else if (RadioButton18.Checked)
            {
                //path = "\\dnsserver\\MyReports$\\FSERPMER\\MER\\RptPOVerticleWorkingNo.rpt";
                path = @"\\dnsserver\\MyReports$\\FSERPMER\\MER\\RptPOVerticleWorkingNo.rpt";
            }

            // Constructing the filter string based on checked radio buttons and checkboxes
            if (AStatus.Text == "All" || AStatus.Text == "True" || AStatus.Text == "False")
            {
                string dateField = "";
                if (ExFactoryDate.Checked) dateField = "ExFactoryDate";
                else if (EntryDate.Checked) dateField = "EntryDate";
                else if (BothDateButton.Checked) dateField = "BothDate";
                else if (CustReqDate.Checked) dateField = "CustReqDate";
                else if (LPDate.Checked) dateField = "LPDate";
                else if (LastConfDate.Checked) dateField = "LastConfDate";

                filter = $"{{View_Rpt_PO.ClientID}} = {ClientNameComboBox.SelectedValue} ";
                if (!string.IsNullOrEmpty(dateField))
                {
                    filter += $"AND {{View_Rpt_PO.{dateField}}} in #{DTPicker1.Value.ToString("MM/dd/yyyy")}# to #{DTPicker2.Value.ToString("MM/dd/yyyy")}# ";
                }
                filter += $"AND {{View_Rpt_PO.OrderType}} = '{OrderTypeComboBox.Text}'";

                if (AStatus.Text == "True")
                    filter += " AND {View_Rpt_PO.A01}";
                else if (AStatus.Text == "False")
                    filter += " AND NOT {View_Rpt_PO.A01}";
            }

            // Attempt to view the report
            Form1 objFrmFilter = new Form1();
            if (objFrmFilter.ViewReport(path, filter))
            {
                FrmMain mainForm = Application.OpenForms.OfType<FrmMain>().FirstOrDefault();
                if (mainForm != null)
                {
                    objFrmFilter.ShowDialog(mainForm); // Open as a modal dialog with the main form as its owner
                }
                else
                {
                    MessageBox.Show("Main form not found.");
                }
            }
            else
            {
                MessageBox.Show("Failed to load the report.");
            }
        }


        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton7.Checked == true)
            {
                this.GroupBox4.Visible = false;
                this.GroupBox1.Visible = false;
                this.GroupBox5.Visible = true;
                this.btnRptShow.Visible = false;
                this.BothDateButton.Visible = true;
                this.btnRptModelShow.Visible = false;
                this.BothDateButton.Enabled = true;
                this.btnVerticleRptShow.Visible = true;
                this.RadioButton9.Checked = true;
                VerticleButton(false, true, false, false, false, false, false, true, true);
                this.AcceptButton = btnVerticleRptShow;
            }

        }

        private void btnRptShow_Click(object sender, EventArgs e)
        {

        }

        private void btnRptModelShow_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton5.Checked == true)
            {
                this.GroupBox4.Visible = false;
                this.GroupBox1.Visible = true;
                this.GroupBox5.Visible = false;
                this.btnRptShow.Visible = true;
                this.btnRptModelShow.Visible = false;
                this.btnVerticleRptShow.Visible = false;
                this.BothDateButton.Enabled = false;
                this.AllCountries.Checked = true;
                VerticleButton(false, true, false, false, false, false, false, true, true);
                this.AcceptButton = btnRptShow;
            }

        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton6.Checked == true)
            {
                this.GroupBox4.Visible = true;
                this.GroupBox1.Visible = false;
                this.GroupBox5.Visible = false;
                this.btnRptShow.Visible = false;
                this.btnVerticleRptShow.Visible = false;
                this.btnRptModelShow.Visible = true;
                this.BothDateButton.Enabled = false;
                this.RadioButton2.Checked = true;
                VerticleButton(false, true, false, false, false, false, false, true, true);
                this.AcceptButton = btnRptModelShow;
            }

        }

        private void RadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton9.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(false, true, false, false, false, false, false, true, true);
            }
            else if (RadioButton9.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(false, true, false, false, false, true, true, true, true);
            }

            if (RadioButton16.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(false, true, false, false, false, false, false, true, true);
            }
            else if (RadioButton16.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(false, true, false, false, false, true, true, true, true);
            }

            if (RadioButton18.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(false, true, false, false, false, false, false, true, true);
            }
            else if (RadioButton18.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(false, true, false, false, false, true, true, true, true);
            }

        }

        private void RadioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton9.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(false, true, false, false, false, false, false, true, true);
            }
            else if (RadioButton9.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(false, true, false, false, false, true, true, true, true);
            }

            if (RadioButton16.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(false, true, false, false, false, false, false, true, true);
            }
            else if (RadioButton16.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(false, true, false, false, false, true, true, true, true);
            }

            if (RadioButton18.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(false, true, false, false, false, false, false, true, true);
            }
            else if (RadioButton18.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(false, true, false, false, false, true, true, true, true);
            }

        }

        private void RadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton10.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(false, true, false, false, true, false, false, true, true);
            }
            else if (RadioButton10.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(false, true, false, false, true, true, true, true, true);
            }

        }

        private void RadioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton12.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(false, true, true, false, false, false, false, true, true);
            }
            else if (RadioButton12.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(false, true, true, false, false, true, true, true, true);
            }

        }

        private void RadioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton11.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(true, true, false, false, true, false, false, true, true);
            }
            else if (RadioButton11.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(true, true, false, false, true, true, true, true, true);
            }

        }

        private void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton8.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(true, true, false, false, false, false, false, true, true);
            }
            else if (RadioButton8.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(true, true, false, false, false, true, true, true, true);
            }

            if (RadioButton17.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(true, true, false, false, false, false, false, true, true);
            }
            else if (RadioButton17.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(true, true, false, false, false, true, true, true, true);
            }

            if (RadioButton15.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(true, true, false, false, false, false, false, true, true);
            }
            else if (RadioButton15.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(true, true, false, false, false, true, true, true, true);
            }

        }

        private void RadioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton8.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(true, true, false, false, false, false, false, true, true);
            }
            else if (RadioButton8.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(true, true, false, false, false, true, true, true, true);
            }

            if (RadioButton17.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(true, true, false, false, false, false, false, true, true);
            }
            else if (RadioButton17.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(true, true, false, false, false, true, true, true, true);
            }

            if (RadioButton15.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(true, true, false, false, false, false, false, true, true);
            }
            else if (RadioButton15.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(true, true, false, false, false, true, true, true, true);
            }

        }

        private void RadioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton9.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(false, true, false, false, false, false, false, true, true);
            }
            else if (RadioButton9.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(false, true, false, false, false, true, true, true, true);
            }

            if (RadioButton16.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(false, true, false, false, false, false, false, true, true);
            }
            else if (RadioButton16.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(false, true, false, false, false, true, true, true, true);
            }

            if (RadioButton18.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(false, true, false, false, false, false, false, true, true);
            }
            else if (RadioButton18.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(false, true, false, false, false, true, true, true, true);
            }

        }

        private void RadioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton8.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(true, true, false, false, false, false, false, true, true);
            }
            else if (RadioButton8.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(true, true, false, false, false, true, true, true, true);
            }

            if (RadioButton17.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(true, true, false, false, false, false, false, true, true);
            }
            else if (RadioButton17.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(true, true, false, false, false, true, true, true, true);
            }

            if (RadioButton15.Checked == true && this.BothDateButton.Checked == false)
            {
                VerticleButton(true, true, false, false, false, false, false, true, true);
            }
            else if (RadioButton15.Checked == true && this.BothDateButton.Checked == true)
            {
                VerticleButton(true, true, false, false, false, true, true, true, true);
            }

        }

        private void EntryDate_CheckedChanged(object sender, EventArgs e)
        {
            if (this.EntryDate.Checked == true)
            {
                this.DateTimePicker1.Enabled = false;
                this.DateTimePicker2.Enabled = false;
                this.DTPicker1.Enabled = true;
                this.DTPicker2.Enabled = true;
            }

        }

        private void CustReqDate_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CustReqDate.Checked == true)
            {
                this.DateTimePicker1.Enabled = false;
                this.DateTimePicker2.Enabled = false;
                this.DTPicker1.Enabled = true;
                this.DTPicker2.Enabled = true;
            }

        }

        private void ExFactoryDate_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ExFactoryDate.Checked == true)
            {
                this.DateTimePicker1.Enabled = false;
                this.DateTimePicker2.Enabled = false;
                this.DTPicker1.Enabled = true;
                this.DTPicker2.Enabled = true;
            }

        }

        private void LastConfDate_CheckedChanged(object sender, EventArgs e)
        {
            if (this.LastConfDate.Checked == true)
            {
                this.DateTimePicker1.Enabled = false;
                this.DateTimePicker2.Enabled = false;
                this.DTPicker1.Enabled = true;
                this.DTPicker2.Enabled = true;
            }

        }

        private void BothDateButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BothDateButton.Checked == true)
            {
                this.DateTimePicker1.Enabled = true;
                this.DateTimePicker2.Enabled = true;
                this.DTPicker1.Enabled = true;
                this.DTPicker2.Enabled = true;
            }

        }

        private void RadioButton19_CheckedChanged(object sender, EventArgs e)
        {
            ClientNameComboBox.Enabled = false;
            DTPicker1.Enabled = false;
            DTPicker2.Enabled = false;
            OrderTypeComboBox.Enabled = false;

        }
    }
}
