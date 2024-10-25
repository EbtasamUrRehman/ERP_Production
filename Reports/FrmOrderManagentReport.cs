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

        }

        private void btnRptShow_Click(object sender, EventArgs e)
        {

        }

        private void btnRptModelShow_Click(object sender, EventArgs e)
        {

        }
    }
}
