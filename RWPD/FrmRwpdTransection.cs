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

namespace ERP_Production.RWPD
{
    public partial class FrmRwpdTransection : DevExpress.XtraEditors.XtraForm
    {

        public FrmRwpdTransection()
        {
            InitializeComponent();
        }

        private void searchLookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void panelControl26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbl_RackNOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_RackNOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSRwpd);

        }

        private void FrmRwpdTransection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSRwpd.tbl_RPWD_Out' table. You can move, or remove it, as needed.
            this.tbl_RPWD_OutTableAdapter.Fill(this.dSRwpd.tbl_RPWD_Out);
            // TODO: This line of code loads data into the 'dSRwpd.View_RWPD_Multi_IN_Balance' table. You can move, or remove it, as needed.
            this.view_RWPD_Multi_IN_BalanceTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN_Balance);
            // TODO: This line of code loads data into the 'dSRwpd.View_RWPD_Multi_Out_Balance' table. You can move, or remove it, as needed.
            this.view_RWPD_Multi_Out_BalanceTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_Out_Balance);
            // TODO: This line of code loads data into the 'dSRwpd.View_RWPD_Multi_IN' table. You can move, or remove it, as needed.
            this.view_RWPD_Multi_INTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
            // TODO: This line of code loads data into the 'dSRwpd.View_Multi_PO_Reports' table. You can move, or remove it, as needed.
            //this.view_Multi_PO_ReportsTableAdapter.Fill(this.dSRwpd.View_Multi_PO_Reports);
            // TODO: This line of code loads data into the 'dSRwpd.tbl_RackNO' table. You can move, or remove it, as needed.
            this.tbl_RackNOTableAdapter.Fill(this.dSRwpd.tbl_RackNO);
            dateEdit1.EditValue = DateTime.Now;
            dateEdit2.EditValue = DateTime.Now;
            dateEdit3.EditValue = DateTime.Now;
            dateEdit4.EditValue = DateTime.Now;
            dateEdit5.EditValue = DateTime.Now;
            dateEdit9.EditValue = DateTime.Now;
        }

        private void dateEdit9_EditValueChanged(object sender, EventArgs e)
        {
            //this.view_Multi_PO_ReportsTableAdapter.FillBy(dSRwpd.View_Multi_PO_Reports, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
            this.view_RWPD_Multi_IN_BalanceTableAdapter.FillBy(dSRwpd.View_RWPD_Multi_IN_Balance, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
            this.view_RWPD_Multi_INTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
        }

        private void dateEdit4_EditValueChanged(object sender, EventArgs e)
        {
            //this.view_Multi_PO_ReportsTableAdapter.FillBy(dSRwpd.View_Multi_PO_Reports, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
            this.view_RWPD_Multi_IN_BalanceTableAdapter.FillBy(dSRwpd.View_RWPD_Multi_IN_Balance, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
            try
            {
                this.view_RWPD_Multi_INTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //this.view_Multi_PO_ReportsTableAdapter.FillBy(dSRwpd.View_Multi_PO_Reports, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
            this.view_RWPD_Multi_IN_BalanceTableAdapter.FillBy(dSRwpd.View_RWPD_Multi_IN_Balance, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
            this.view_RWPD_Multi_INTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
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
                        string POCode = gridView.GetRowCellValue(selectedRowHandle, "POCode") != DBNull.Value
                            ? gridView.GetRowCellValue(selectedRowHandle, "POCode").ToString()
                            : null;
                        string ArtCode = gridView.GetRowCellValue(selectedRowHandle, "ArtCode") != DBNull.Value
                        ? gridView.GetRowCellValue(selectedRowHandle, "ArtCode").ToString()
                        : null;
                        string Size = gridView.GetRowCellValue(selectedRowHandle, "Size") != DBNull.Value
                        ? gridView.GetRowCellValue(selectedRowHandle, "Size").ToString()
                        : null;
                        string Warehouse = (string)comboBoxEdit1.EditValue;
                        int RackNo = Convert.ToInt32(searchLookUpEdit1.EditValue);

                        DateTime? DeliverDate = gridView.GetRowCellValue(selectedRowHandle, "DD") != DBNull.Value
                            ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "DD"))
                            : null;

                        DateTime? EntryDate = DateTime.Now;

                        DateTime? ReceiveDate = (DateTime?)dateEdit1.EditValue;




                        string factoryCode = gridView.GetRowCellValue(selectedRowHandle, "FactoryCode") != DBNull.Value
                            ? gridView.GetRowCellValue(selectedRowHandle, "FactoryCode").ToString()
                            : null;


                        double balance = gridView.GetRowCellValue(selectedRowHandle, "Balance") != DBNull.Value
                        ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "Balance"))
                        : 0.0;


                        double PartialQty = gridView.GetRowCellValue(selectedRowHandle, "PartielQty") != DBNull.Value
                        ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "PartielQty"))
                        : 0.0;

                        double totalPlanQty;
                        totalPlanQty = PartialQty > 0 ? PartialQty : balance;

                        if (dateEdit1.EditValue != null)
                        {

                            if (Convert.ToInt32(searchLookUpEdit1.EditValue) != 0)
                            {
                                if (PartialQty <= balance)
                            {

                                view_RWPD_Multi_INTableAdapter.InsertQuery(PO, POCode,  ArtCode,Size, (decimal?)totalPlanQty, RackNo, DeliverDate, EntryDate, null,ReceiveDate, factoryCode, Warehouse);



                                MessageBox.Show("Data inserted successfully!");

                                //this.view_Multi_PO_ReportsTableAdapter.FillBy(dSRwpd.View_Multi_PO_Reports, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
                                this.view_RWPD_Multi_IN_BalanceTableAdapter.FillBy(dSRwpd.View_RWPD_Multi_IN_Balance, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
                                this.view_RWPD_Multi_INTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
                            }
                            else
                            {
                                MessageBox.Show("Can not Send AvailableQty Error ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            }


                            else
                            {
                                MessageBox.Show("Please Select Rack# ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Select Receive Date");
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
                        int TID = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "TID"));
                        view_RWPD_Multi_INTableAdapter.DeleteQuery(TID);
                        MessageBox.Show("Record deleted successfuly");
                        //this.view_Multi_PO_ReportsTableAdapter.FillBy(dSRwpd.View_Multi_PO_Reports, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
                        this.view_RWPD_Multi_IN_BalanceTableAdapter.FillBy(dSRwpd.View_RWPD_Multi_IN_Balance, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
                        this.view_RWPD_Multi_INTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }



                }
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            this.view_RWPD_Multi_INTableAdapter.Fill(dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit3.EditValue, (DateTime?)dateEdit5.EditValue);
            this.dataTable1TableAdapter.Fill(this.dSRwpd.DataTable1, (DateTime?)dateEdit3.EditValue, (DateTime?)dateEdit5.EditValue);

            //this.view_RWPD_Multi_INTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
        }

        private void dateEdit3_EditValueChanged(object sender, EventArgs e)
        {
            this.view_RWPD_Multi_INTableAdapter.Fill(dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit3.EditValue, (DateTime?)dateEdit5.EditValue);
            this.dataTable1TableAdapter.Fill(this.dSRwpd.DataTable1, (DateTime?)dateEdit3.EditValue, (DateTime?)dateEdit5.EditValue);

        }

        private void panelControl7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateEdit5_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.view_RWPD_Multi_INTableAdapter.Fill(dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit3.EditValue, (DateTime?)dateEdit5.EditValue);
                this.dataTable1TableAdapter.Fill(this.dSRwpd.DataTable1, (DateTime?)dateEdit3.EditValue, (DateTime?)dateEdit5.EditValue);

            }
            catch (Exception ex)
            {
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
                        int TID = gridView.GetRowCellValue(selectedRowHandle, "TID") != DBNull.Value
                            ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "TID"))
                            : 0;
                        int PO = gridView.GetRowCellValue(selectedRowHandle, "PO") != DBNull.Value
                            ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PO"))
                            : 0;
                        string POCode = gridView.GetRowCellValue(selectedRowHandle, "POCode") != DBNull.Value
                            ? gridView.GetRowCellValue(selectedRowHandle, "POCode").ToString()
                            : null;
                        string factoryCode = gridView.GetRowCellValue(selectedRowHandle, "FactoryCode") != DBNull.Value
                            ? gridView.GetRowCellValue(selectedRowHandle, "FactoryCode").ToString()
                            : null;
                        string ArtCode = gridView.GetRowCellValue(selectedRowHandle, "Article") != DBNull.Value
                        ? gridView.GetRowCellValue(selectedRowHandle, "Article").ToString()
                        : null;
                        string Size = gridView.GetRowCellValue(selectedRowHandle, "Size") != DBNull.Value
                        ? gridView.GetRowCellValue(selectedRowHandle, "Size").ToString()
                        : null;

                        int RackNo = gridView.GetRowCellValue(selectedRowHandle, "RackID") != DBNull.Value
                        ? Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "RackID"))
                        : 0;
                        DateTime? EntryDate = DateTime.Now;

                        DateTime ? DeliverDate = gridView.GetRowCellValue(selectedRowHandle, "DeliverDate") != DBNull.Value
                            ? (DateTime?)Convert.ToDateTime(gridView.GetRowCellValue(selectedRowHandle, "DeliverDate"))
                            : null;

                        DateTime? ReceiveDate = (DateTime?)dateEdit2.EditValue;

                        double balance = gridView.GetRowCellValue(selectedRowHandle, "balance") != DBNull.Value
                        ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "balance"))
                        : 0.0;

                        double PartialQty = gridView.GetRowCellValue(selectedRowHandle, "PartielQty") != DBNull.Value
                        ? Convert.ToDouble(gridView.GetRowCellValue(selectedRowHandle, "PartielQty"))
                        : 0.0;

                        double totalPlanQty;
                        totalPlanQty = PartialQty > 0 ? PartialQty : balance;

                        if (dateEdit2.EditValue != null)
                        {
                            
                                Console.WriteLine($"searchLookUpEdit1.EditValue", searchLookUpEdit1.EditValue);
                                if (PartialQty <= balance)
                                {

                                    tbl_RPWD_OutTableAdapter.InsertQuery(TID, PO, POCode, factoryCode, ArtCode, Size, (decimal?)totalPlanQty, RackNo, EntryDate, null, DeliverDate, Size, null, ReceiveDate);



                                    MessageBox.Show("Data inserted successfully!");

                                    //this.view_Multi_PO_ReportsTableAdapter.FillBy(dSRwpd.View_Multi_PO_Reports, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
                                    //this.view_RWPD_Multi_IN_BalanceTableAdapter.FillBy(dSRwpd.View_RWPD_Multi_IN_Balance, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
                                    this.view_RWPD_Multi_INTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit3.EditValue, (DateTime?)dateEdit5.EditValue);
                                    this.dataTable1TableAdapter.Fill(this.dSRwpd.DataTable1, (DateTime?)dateEdit3.EditValue, (DateTime?)dateEdit5.EditValue);
                                }
                                else
                                {
                                    MessageBox.Show("Can not Send AvailableQty Error ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            
                        }
                        else
                        {
                            MessageBox.Show("Please Select Receive Date");
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

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.dataTable1TableAdapter.Fill(this.dSRwpd.DataTable1, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(receivedDateToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(receivedDate1ToolStripTextBox.Text, typeof(System.DateTime))))));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void repositoryItemButtonEdit5_Click(object sender, EventArgs e)
        {
            var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl4.FocusedView;

            if (gridView.SelectedRowsCount > 0)
            {
                var selectedRowHandle = gridView.GetSelectedRows()[0];

                if (selectedRowHandle >= 0)
                {
                    try
                    {
                        int TID = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "TransID"));
                        this.tbl_RPWD_OutTableAdapter.DeleteQuery(TID);
                        MessageBox.Show("Record deleted successfuly");
                        //this.view_Multi_PO_ReportsTableAdapter.FillBy(dSRwpd.View_Multi_PO_Reports, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
                        //this.view_RWPD_Multi_IN_BalanceTableAdapter.FillBy(dSRwpd.View_RWPD_Multi_IN_Balance, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
                        //this.view_RWPD_Multi_INTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit9.EditValue, (DateTime?)dateEdit4.EditValue);
                        this.view_RWPD_Multi_INTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit3.EditValue, (DateTime?)dateEdit5.EditValue);
                        this.dataTable1TableAdapter.Fill(this.dSRwpd.DataTable1, (DateTime?)dateEdit3.EditValue, (DateTime?)dateEdit5.EditValue);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }



                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl4.FocusedView;

            if (gridView.SelectedRowsCount > 0)
            {
                try
                {
                    // Loop through the selected rows
                    for (int t = 0; t < gridView.SelectedRowsCount; t++)
                    {
                        var rowHandle = gridView.GetSelectedRows()[t];
                        
                        int TID = Convert.ToInt32(gridView.GetRowCellValue(rowHandle, "TransID"));
                        this.tbl_RPWD_OutTableAdapter.UpdateQuery(TID);
                    }

                    MessageBox.Show("Record Locked successfully");
                    this.view_RWPD_Multi_INTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN, (DateTime?)dateEdit3.EditValue, (DateTime?)dateEdit5.EditValue);
                    this.dataTable1TableAdapter.Fill(this.dSRwpd.DataTable1, (DateTime?)dateEdit3.EditValue, (DateTime?)dateEdit5.EditValue);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

            }
        }

        

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            string gtpOne = "";
            foreach (Control ctrl in groupControl1.Controls)
            {
                if (ctrl is RadioButton radioButton && radioButton.Checked)
                {
                    gtpOne = radioButton.Text;
                    
                }
            }

            string gtpTwo = "";
            foreach (Control ctrl in groupControl3.Controls)
            {
                if (ctrl is RadioButton radioButton && radioButton.Checked)
                {
                    gtpTwo = radioButton.Text;
                }
            }

            string selectionFormula = "";
            string parameters = "";
            string reportName = "";
            var factoryCode = "";
            var POCode = "";
            var Article = "";
            // Construct the selection formula string

            var requisitionDate = ((DateTime)dateEdit7.EditValue).ToString("yyyy-MM-dd HH-mm-ss");
            var requisitionDate2 = ((DateTime)dateEdit6.EditValue).ToString("yyyy-MM-dd HH-mm-ss");
            try
            {
                factoryCode = comboBoxEdit4.EditValue.ToString();
            }
            catch(Exception ex) { }
            try
            {
                POCode = textEdit1.EditValue.ToString();
            }
            catch (Exception ex) { }
            try
            {
                Article = textEdit2.EditValue.ToString();
            }
            catch (Exception ex) { }

            
            Form1 objFrmFilter = new Form1();

            if (gtpOne == "RWPD Transaction")
            {
                reportName = @"\\dnsserver\MyReports$\FSERPPC\Dispatch\RWPD\rptRWPDMultiReport.rpt";
                if (radioButton5.Checked == true)
                {
                    selectionFormula = $"{{View_RWPD_Multi_Rpt.DeliverDate}} in DateTime({requisitionDate.Replace("-", ",").Replace(" ", ",")}) to DateTime({requisitionDate2.Replace("-", ",").Replace(" ", ",")})";

                }
                if (radioButton4.Checked == true)
                {
                    selectionFormula = $"{{View_RWPD_Multi_Rpt.FactoryCode}} = '{factoryCode}'";

                }
                if (radioButton6.Checked == true)
                {
                    selectionFormula = $"{{View_RWPD_Multi_Rpt.DeliverDate}} in DateTime({requisitionDate.Replace("-", ",").Replace(" ", ",")}) to DateTime({requisitionDate2.Replace("-", ",").Replace(" ", ",")}) and {{View_RWPD_Multi_Rpt.POCode}} = '{POCode}'";
                }
                if (radioButton7.Checked == true)
                {
                    selectionFormula = $"{{View_RWPD_Multi_Rpt.DeliverDate}} in DateTime({requisitionDate.Replace("-", ",").Replace(" ", ",")}) to DateTime({requisitionDate2.Replace("-", ",").Replace(" ", ",")}) and {{View_RWPD_Multi_Rpt.Article}} = '{Article}'";
                }
                if (radioButton8.Checked == true)
                {
                    selectionFormula = $"{{View_RWPD_Multi_Rpt.DeliverDate}} in DateTime({requisitionDate.Replace("-", ",").Replace(" ", ",")}) to DateTime({requisitionDate2.Replace("-", ",").Replace(" ", ",")}) and {{View_RWPD_Multi_Rpt.POCode}} = '{POCode}' and {{View_RWPD_Multi_Rpt.Article}} = '{Article}'";

                }
                
            }
            else if (gtpOne == "By In Transaction")
                {
                reportName = @"\\dnsserver\MyReports$\ERPPPS\labeling\LabelMultiPlan.rpt";
                if (radioButton5.Checked = true)
                {
                    selectionFormula = $"{{View_RWPD_Multi_IN.DeliverDate}} in DateTime({requisitionDate.Replace("-", ",").Replace(" ", ",")}) to DateTime({requisitionDate2.Replace("-", ",").Replace(" ", ",")})";

                }
                if (radioButton4.Checked = true)
                {
                    selectionFormula = $"{{View_RWPD_Multi_IN.FactoryCode}} = '{factoryCode}'";

                }
                if (radioButton6.Checked = true)
                {
                    selectionFormula = $"{{View_RWPD_Multi_IN.DeliverDate}} in DateTime({requisitionDate.Replace("-", ",").Replace(" ", ",")}) to DateTime({requisitionDate2.Replace("-", ",").Replace(" ", ",")}) and {{View_RWPD_Multi_Rpt.POCode}} = '{POCode}'";
                }
                if (radioButton7.Checked = true)
                {
                    selectionFormula = $"{{View_RWPD_Multi_IN.DeliverDate}} in DateTime({requisitionDate.Replace("-", ",").Replace(" ", ",")}) to DateTime({requisitionDate2.Replace("-", ",").Replace(" ", ",")}) and {{View_RWPD_Multi_Rpt.Article}} = '{Article}'";
                }
                if (radioButton8.Checked = true)
                {
                    selectionFormula = $"{{View_RWPD_Multi_IN.DeliverDate}} in DateTime({requisitionDate.Replace("-", ",").Replace(" ", ",")}) to DateTime({requisitionDate2.Replace("-", ",").Replace(" ", ",")}) and {{View_RWPD_Multi_Rpt.POCode}} = '{POCode}' and {{View_RWPD_Multi_Rpt.Article}} = '{Article}'";

                }
            }
            else
            {
                reportName = @"\\dnsserver\MyReports$\ERPPPS\labeling\LabelMultiPlan.rpt";
                if (radioButton5.Checked = true)
                {
                    selectionFormula = $"{{View_RWPD_Multi_Out.DeliverDate}} in DateTime({requisitionDate.Replace("-", ",").Replace(" ", ",")}) to DateTime({requisitionDate2.Replace("-", ",").Replace(" ", ",")})";

                }
                if (radioButton4.Checked = true)
                {
                    selectionFormula = $"{{View_RWPD_Multi_Out.FactoryCode}} = '{factoryCode}'";

                }
                if (radioButton6.Checked = true)
                {
                    selectionFormula = $"{{View_RWPD_Multi_Out.DeliverDate}} in DateTime({requisitionDate.Replace("-", ",").Replace(" ", ",")}) to DateTime({requisitionDate2.Replace("-", ",").Replace(" ", ",")}) and {{View_RWPD_Multi_Rpt.POCode}} = '{POCode}'";
                }
                if (radioButton7.Checked = true)
                {
                    selectionFormula = $"{{View_RWPD_Multi_Out.DeliverDate}} in DateTime({requisitionDate.Replace("-", ",").Replace(" ", ",")}) to DateTime({requisitionDate2.Replace("-", ",").Replace(" ", ",")}) and {{View_RWPD_Multi_Rpt.Article}} = '{Article}'";
                }
                if (radioButton8.Checked = true)
                {
                    selectionFormula = $"{{View_RWPD_Multi_Out.DeliverDate}} in DateTime({requisitionDate.Replace("-", ",").Replace(" ", ",")}) to DateTime({requisitionDate2.Replace("-", ",").Replace(" ", ",")}) and {{View_RWPD_Multi_Rpt.POCode}} = '{POCode}' and {{View_RWPD_Multi_Rpt.Article}} = '{Article}'";

                }
            }

            if (objFrmFilter.ViewReport(reportName, selectionFormula))
            {
                FrmMain mainForm = (FrmMain)Application.OpenForms.OfType<FrmMain>().FirstOrDefault();
                if (mainForm != null)
                {
                    objFrmFilter.ShowDialog();
                }
                else
                {
                    MessageBox.Show(" form not found.");
                }

            }

            else
            {
                MessageBox.Show("Failed to load the report.");
            }


            //if (!string.IsNullOrEmpty(dateEdit1.Text))
            //{
            //    // Create an instance of Form1
                

            //    // Path to your Crystal Report file
                







                

            //    // Create the selection formula with proper formatting
 

            //    //selectionFormula = $"{{View_Multi_PO_Reports.CustReqDate}} in DateTime ({formattedDate1Start}) to DateTime ({formattedDate2End})";

            //    // View the report
                
            //}
            //else
            //{
            //    MessageBox.Show("Select Date First.");

            //}
        }

        private void tabNavigationPage3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}