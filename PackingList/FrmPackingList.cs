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

namespace ERP_Production.PackingList
{
    public partial class FrmPackingList : Form
    {
        public FrmPackingList()
        {
            InitializeComponent();
        }

        private void FrmPackingList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPackingList.tbl_carton_name' table. You can move, or remove it, as needed.
            this.tbl_carton_nameTableAdapter.Fill(this.dSPackingList.tbl_carton_name);
            // TODO: This line of code loads data into the 'dSPackingList.tbl_Pro_Cust_Ident' table. You can move, or remove it, as needed.
            this.tbl_Pro_Cust_IdentTableAdapter.Fill(this.dSPackingList.tbl_Pro_Cust_Ident);
            // TODO: This line of code loads data into the 'dSPackingList.tbl_Multi_PO_H_Packing' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_H_PackingTableAdapter.Fill(this.dSPackingList.tbl_Multi_PO_H_Packing);
            // TODO: This line of code loads data into the 'dSPackingList.View_MultiLine_Packing_List_Finel' table. You can move, or remove it, as needed.
            //this.view_MultiLine_Packing_List_FinelTableAdapter.Fill(this.dSPackingList.View_MultiLine_Packing_List_Finel);
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.tbl_Multi_PO_M' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_MTableAdapter.Fill(this.dSPurchaseOrderNew.tbl_Multi_PO_M);
            // TODO: This line of code loads data into the 'dSPackingList.View_213_CARTON' table. You can move, or remove it, as needed.
            this.view_213_CARTONTableAdapter.Fill(this.dSPackingList.View_213_CARTON);
            // TODO: This line of code loads data into the 'dSPurchaseOrderNew.tbl_Multi_PO_H' table. You can move, or remove it, as needed.
            if (dateEdit1.Text != null && dateEdit2.Text != null)
            {
                this.tbl_Multi_PO_HMTableAdapter.Fill(this.dSPackingList.tbl_Multi_PO_HM, (DateTime?)dateEdit1.EditValue, (DateTime?)dateEdit2.EditValue);
            }
           
            // TODO: This line of code loads data into the 'dSPackingList.View_MultiLine_Packing_List' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dSPackingList.tbl_Multi_PO_S' table. You can move, or remove it, as needed.
            //this.tbl_Multi_PO_STableAdapter.Fill(this.dSPackingList.tbl_Multi_PO_S);
            // TODO: This line of code loads data into the 'dSPackingList.View_MullinePacking_requ' table. You can move, or remove it, as needed.


        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.view_MultiLine_Packing_List_FinelTableAdapter.Fill(this.dSPackingList.View_MultiLine_Packing_List_Finel, (int)searchLookUpEdit1.EditValue);
                this.tbl_Multi_PackListTableAdapter.Fill(dSPackingList.tbl_Multi_PackList, (int)searchLookUpEdit1.EditValue);
            }
            catch (Exception)
            {

            }

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult btnMsg = MessageBox.Show("Are You Sure You Want To Generate Packing List Of Serial " + this.searchLookUpEdit1.Text + "?",
            "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (btnMsg == DialogResult.Yes)
            {
                int po = Convert.ToInt32(this.searchLookUpEdit1.EditValue);
                //int pom = Convert.ToInt32(this.pOMLabel1.Text);
                //int pos = Convert.ToInt32(this.pOSLabel1.Text);

                // Fill the DataSet and get row counts
                var dataTable = dSPackingList.View_MultiLine_Packing_List1;
                int rowCount = view_MultiLine_Packing_List1TableAdapter.Fill(dSPackingList.View_MultiLine_Packing_List1, po);
                //view_MultiLine_Packing_List1BindingSource.Count
                //int rowCount1 = view_MultiLine_Packing_List1TableAdapter.Fill(dSPackingList.View_MultiLine_Packing_List1, po);
                //dataTable = dSPackingList.View_MultiLine_Packing_List1;
                int maxPackage, maxPackNo, startPackage, remainder, endPackage;
                string codeValue = comboBoxEdit1.Text;

                for (int i = 0; i < view_MultiLine_Packing_List1BindingSource.Count; i++)
                {
                    var orderQty = dSPackingList.View_MultiLine_Packing_List1.Rows[i]["orderQty"]; // replace with actual column name
                    var CartonQty = dSPackingList.View_MultiLine_Packing_List1.Rows[i]["CartonQty"];
                   
                    int pos = (int)dSPackingList.View_MultiLine_Packing_List1.Rows[i]["POS"];
                    int pom = (int)dSPackingList.View_MultiLine_Packing_List1.Rows[i]["POM"];
                    object cartonIdValue = dSPackingList.View_MultiLine_Packing_List1.Rows[i]["CartonID"];
                    int CartonID;

                    if (cartonIdValue != DBNull.Value)
                    {
                        CartonID = Convert.ToInt32(cartonIdValue); // Use Convert to handle different types
                    }
                    else
                    {
                        // Handle the case where the value is DBNull
                        CartonID = 0;// Or any default value or throw an exception based on your needs
                    }
                    //view_MultiLine_Packing_List1TableAdapter.FillBy(dSPackingList.View_MultiLine_Packing_List1, po, pom, pos);
                    // Check if order quantities match


                    try
                    {
                        int orderQtyQueryResult = (int)this.view_MultiLine_Packing_ListTableAdapter.OrderQtyQuery(dSPackingList.View_MultiLine_Packing_List, po, pom, pos);
                        var orderQtyResult = this.view_MultiLine_Packing_ListTableAdapter.OrderQty(dSPackingList.View_MultiLine_Packing_List,po,pom,pos);
                        if (orderQtyQueryResult == orderQtyResult)
                        {
                            continue;
                        }

                        {


                            // Ensure the value is not DBNull
                            //if (orderQty != DBNull.Value && CartonQty != DBNull.Value)
                            {
                               
                                try
                                {
                                    maxPackage = (int)this.tbl_Multi_PackListTableAdapter.ScalarQueryMaxEndPackage(po);
                                }
                                catch (Exception)
                                {
                                    maxPackage = 0;
                                }

                                 startPackage = maxPackage + 1;
                                 endPackage = Convert.ToInt32(Math.Floor(Convert.ToDouble(orderQty) /
                                    Convert.ToDouble(CartonQty)));
                                 remainder = Convert.ToInt32(orderQty) %
                                    Convert.ToInt32(CartonQty);

                                if (endPackage > 0)
                                {
                                    endPackage = maxPackage + endPackage;
                                    this.view_MultiLine_Packing_ListTableAdapter.InsertQuery(po, pom, pos, startPackage, endPackage, (decimal)CartonQty, null, null, searchLookUpEdit1.Text + comboBoxEdit1.Text, (int)orderQty, this.searchLookUpEdit1.EditValue + comboBoxEdit1.Text, (int)CartonID);


                                    maxPackNo = (int)this.tbl_Multi_PackListTableAdapter.ScalarQueryMaxPackNo(po, pom, pos);
                                    //this.tbl_Multi_PackListTableAdapter.UpdateQuery(tbl_Multi_PackListTableAdapter.CartonId(dSPackingList.tbl_Multi_PackList, maxPackNo), maxPackNo);
                                    //this.view_MultiLine_Packing_List_FinelTableAdapter.Fill(this.dSPackingList.View_MultiLine_Packing_List_Finel, (int)searchLookUpEdit1.EditValue);
                                }

                                if (remainder > 0)
                                {

                                    try
                                    {
                                        maxPackage = (int)this.tbl_Multi_PackListTableAdapter.ScalarQueryMaxEndPackage(po);
                                    }
                                    catch (Exception)
                                    {
                                        maxPackage = 0;
                                    }
                                    this.view_MultiLine_Packing_ListTableAdapter.InsertQuery(po, pom, pos, maxPackage + 1, maxPackage + 1, remainder, null, null, searchLookUpEdit1.Text + comboBoxEdit1.Text, (int)orderQty, this.searchLookUpEdit1.EditValue + comboBoxEdit1.Text, (int?)CartonID);
                                    //this.view_MultiLine_Packing_List_FinelTableAdapter.Fill(this.dSPackingList.View_MultiLine_Packing_List_Finel, (int)searchLookUpEdit1.EditValue);
                                    //InsertRecord(po, pom, pos, maxPackage + 1, maxPackage + 1,
                                    //    remainder, searchLookUpEdit1.Text + codeValue, (int)orderQty, (int)CartonQty);

                                    maxPackNo = this.tbl_Multi_PackListTableAdapter.MaxPackNo(dSPackingList.tbl_Multi_PackList, po, pom, pos);
                                    //this.tbl_Multi_PackListTableAdapter.UpdateQuery(tbl_Multi_PackListTableAdapter.CartonId(dSPackingList.tbl_Multi_PackList, maxPackNo), maxPackNo);
                                }

                                if (Convert.ToInt32(CartonQty) > Convert.ToInt32(orderQty))
                                {
                                    try
                                    {
                                        maxPackage = (int)this.tbl_Multi_PackListTableAdapter.ScalarQueryMaxEndPackage(po);
                                    }
                                    catch (Exception)
                                    {
                                        maxPackage = 0;
                                    }
                                    //InsertRecord(po, pom, pos, maxPackage + 1, maxPackage + 1,
                                        //remainder, this.searchLookUpEdit1.Text + codeValue, (int)orderQty, 0);

                                     maxPackNo = this.tbl_Multi_PackListTableAdapter.MaxPackNo(dSPackingList.tbl_Multi_PackList, po, pom, pos);
                                    this.tbl_Multi_PackListTableAdapter.UpdateQuery( tbl_Multi_PackListTableAdapter.CartonId(dSPackingList.tbl_Multi_PackList, maxPackNo), maxPackNo);
                                }

                            }
                        }

                    }
                    catch (Exception ex) // Catching a general exception, but you might want to specify a more precise type
                    {
                        // Log the exception message for debugging purposes
                        MessageBox.Show($"An error occurred while checking order quantities: {ex.Message}");
                    }

                    

                   

                    // Fill the updated packing list
                   
                }


             
                // Fill the updated packing list
                this.view_MultiLine_Packing_List_FinelTableAdapter.Fill(this.dSPackingList.View_MultiLine_Packing_List_Finel, (int)searchLookUpEdit1.EditValue);
                this.tbl_Multi_PackListTableAdapter.Fill(dSPackingList.tbl_Multi_PackList, po);
                }




            
        }
            private void InsertRecord(int po, int pom, int pod, int startPackage, int endPackage, int perPackage, string poCode, int orderQty, int ctnId)
            {
                this.view_MultiLine_Packing_ListTableAdapter.InsertQuery(po, pom, pod, startPackage, endPackage, perPackage, null, null, poCode + comboBoxEdit1.Text, orderQty, this.searchLookUpEdit1.Text + comboBoxEdit1.Text, ctnId);

            }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchLookUpEdit1.Text))
            {
                if (!string.IsNullOrEmpty(lookUpEdit1.Text))
                {
                    Form1 objFrmFilter = new Form1();

                    // Path to your Crystal Report file
                    string reportName = @"\\dnsserver\MyReports$\MultiProduction\RptS4PackList.rpt";

                    // Construct the selection formula string
                    var PO = searchLookUpEdit1.EditValue;
                    var PORange = lookUpEdit1.Text;
                    string selectionFormula = string.Empty;

                    // Build selection formula based on input values
                    if (PO != null)
                    {
                        selectionFormula += $"{{View_Rpt_PackList.PO}} = {PO}";
                    }

                    if (!string.IsNullOrEmpty(PORange) && PORange != "[EditValue is null]")
                    {
                        if (!string.IsNullOrEmpty(selectionFormula))
                        {
                            selectionFormula += " AND "; // Add 'AND' if there's already a condition
                        }
                        selectionFormula += $"{{View_Rpt_PackList.PONumber}} = \"{PORange}\"";
                    }
                    if (string.IsNullOrEmpty(PORange) || PORange == "[EditValue is null]")
                    {
                        selectionFormula = selectionFormula;
                    }

                    // View the report
                    if (objFrmFilter.ViewReport(reportName, selectionFormula))
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
                else
                {
                    MessageBox.Show("Select a valid range first.");
                }
            }
            else
            {
                MessageBox.Show("Select a PO first.");
            }

        }

        private void repositoryItemButtonDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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
                        //int PO = 0;
                        //int totalPlanQty = 0;
                        int PONumber = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PO") ?? 0);
                        int packNo = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PackNo") ?? 0);
                        try
                        {
                            // Insert into tbl_Multi_PO_Plan_D
                            tbl_Multi_PackListTableAdapter.DeleteQuery(packNo);

                            MessageBox.Show("Data inserted successfully!");

                            // Refresh the data in the view
                            tbl_Multi_PackListTableAdapter.Fill(dSPackingList.tbl_Multi_PackList, PONumber);
                            this.view_MultiLine_Packing_List_FinelTableAdapter.Fill(this.dSPackingList.View_MultiLine_Packing_List_Finel, (int)searchLookUpEdit1.EditValue);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error Deleteing : {ex.Message}");
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

        private void repositoryItemUpdate_Click(object sender, EventArgs e)
        {
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
                            //int PO = 0;
                            //int totalPlanQty = 0;
                            int PONumber = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PO") ?? 0);
                            int POM = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "POM") ?? 0);
                            int POS = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "POS") ?? 0);
                            int packNo = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PackNo") ?? 0);
                            int CartonId = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "CartonId") ?? 0);
                            try
                            {
                                // Insert into tbl_Multi_PO_Plan_D
                                tbl_Multi_PackListTableAdapter.UpdateQuery(CartonId,packNo);

                                MessageBox.Show("Data Updated successfully!");

                                // Refresh the data in the view
                                tbl_Multi_PackListTableAdapter.Fill(dSPackingList.tbl_Multi_PackList, PONumber);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error Updateing : {ex.Message}");
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
        }

        

        private void panelControl10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //if (dateEdit1.Text != null && dateEdit2.Text != null)
            //{
            //    this.tbl_Multi_PO_HMTableAdapter.Fill(this.dSPackingList.tbl_Multi_PO_HM, (DateTime?)dateEdit1.EditValue, (DateTime?)dateEdit2.EditValue);
            //}
        }

        private void dateEdit2_EditValueChanged(object sender, EventArgs e)
        {
            //if (dateEdit1.Text != null && dateEdit2.Text != null)
            //{
            //    this.tbl_Multi_PO_HMTableAdapter.Fill(this.dSPackingList.tbl_Multi_PO_HM, (DateTime?)dateEdit1.EditValue, (DateTime?)dateEdit2.EditValue);
            //}
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreatePackingList_Click(object sender, EventArgs e)
        {
            int maxPackage, maxPackNo, startPackage, remainder, endPackage;
            string codeValue = comboBoxEdit1.Text;
            {
                var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl2.FocusedView;
                DialogResult btnMsg = MessageBox.Show("Are You Sure You Want To Generate Packing List Of Serial  ?",
           "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (btnMsg == DialogResult.Yes)
                {
                    if (gridView.SelectedRowsCount > 0)
                    {
                        var selectedRowHandle = gridView.GetSelectedRows()[0];

                        if (selectedRowHandle >= 0)
                        {
                            try
                            {
                                // Initialize variables with default values
                                //int PO = 0;
                                //int totalPlanQty = 0;
                                int po = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PO") ?? 0);
                                int pom = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "POM") ?? 0);
                                int pos = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "POS") ?? 0);
                                int packNo = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PackNo") ?? 0);
                                int orderQty = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "orderQty") ?? 0);
                                int CartonQty = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "CartonQty") ?? 0);
                                object cartonIdValue = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle,"CartonID")??0);
                                int CartonID;

                                if (cartonIdValue != DBNull.Value)
                                {
                                    CartonID = Convert.ToInt32(cartonIdValue); // Use Convert to handle different types
                                }
                                else
                                {
                                    // Handle the case where the value is DBNull
                                    CartonID = 0;// Or any default value or throw an exception based on your needs
                                }
                                int Balance = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "Balance") ?? 0);
                                object partialQtyValue = gridView.GetRowCellValue(selectedRowHandle, "PartielQty");
                                int PartielQty = (partialQtyValue != DBNull.Value) ? Convert.ToInt32(partialQtyValue) : 0;

                              
                                if (PartielQty > 0)
                                {
                                    if (PartielQty <= Balance )
                                    {
                                        orderQty = PartielQty;
                                    }

                                    else
                                    {
                                        MessageBox.Show("Partial Qty must be less than Balance.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    }
                                }
                                try
                                {
                                    int orderQtyQueryResult = (int)this.view_MultiLine_Packing_ListTableAdapter.OrderQtyQuery(dSPackingList.View_MultiLine_Packing_List, po, pom, pos);
                                    var orderQtyResult = this.view_MultiLine_Packing_ListTableAdapter.OrderQty(dSPackingList.View_MultiLine_Packing_List, po, pom, pos);
                                    if (orderQtyQueryResult == orderQtyResult)
                                    {
                                      
                                    }
                                  
                                    {


                                        // Ensure the value is not DBNull
                                        //if (orderQty != DBNull.Value && CartonQty != DBNull.Value)
                                        {

                                            try
                                            {
                                                maxPackage = (int)this.tbl_Multi_PackListTableAdapter.ScalarQueryMaxEndPackage(po);
                                            }
                                            catch (Exception)
                                            {
                                                maxPackage = 0;
                                            }

                                           

                                            startPackage = maxPackage + 1;
                                            endPackage = Convert.ToInt32(Math.Floor(Convert.ToDouble(orderQty) /
                                               Convert.ToDouble(CartonQty)));
                                            remainder = Convert.ToInt32(orderQty) %
                                               Convert.ToInt32(CartonQty);

                                            if (endPackage > 0)
                                            {
                                                endPackage = maxPackage + endPackage;
                                                this.view_MultiLine_Packing_ListTableAdapter.InsertQuery(po, pom, pos, startPackage, endPackage, (decimal)CartonQty, null, null, searchLookUpEdit1.Text + comboBoxEdit1.Text, (int)orderQty, this.searchLookUpEdit1.Text + comboBoxEdit1.Text, (int)CartonID);
                                                //tbl_Multi_PackListTableAdapter.Fill(dSPackingList.tbl_Multi_PackList, (int)searchLookUpEdit1.EditValue);
                                                //this.view_MultiLine_Packing_List_FinelTableAdapter.Fill(this.dSPackingList.View_MultiLine_Packing_List_Finel, (int)searchLookUpEdit1.EditValue);

                                                maxPackNo = (int)this.tbl_Multi_PackListTableAdapter.ScalarQueryMaxPackNo(po, pom, pos);
                                                //this.tbl_Multi_PackListTableAdapter.UpdateQuery(tbl_Multi_PackListTableAdapter.CartonId(dSPackingList.tbl_Multi_PackList, maxPackNo), maxPackNo);
                                                //this.view_MultiLine_Packing_List_FinelTableAdapter.Fill(this.dSPackingList.View_MultiLine_Packing_List_Finel, (int)searchLookUpEdit1.EditValue);
                                            }

                                            if (remainder > 0)
                                            {

                                                try
                                                {
                                                    maxPackage = (int)this.tbl_Multi_PackListTableAdapter.ScalarQueryMaxEndPackage(po);
                                                }
                                                catch (Exception)
                                                {
                                                    maxPackage = 0;
                                                }
                                                this.view_MultiLine_Packing_ListTableAdapter.InsertQuery(po, pom, pos, maxPackage + 1, maxPackage + 1, remainder, null, null, searchLookUpEdit1.Text + comboBoxEdit1.Text, (int)orderQty, this.searchLookUpEdit1.Text + comboBoxEdit1.Text, (int?)CartonID);
                                                //this.view_MultiLine_Packing_List_FinelTableAdapter.Fill(this.dSPackingList.View_MultiLine_Packing_List_Finel, (int)searchLookUpEdit1.EditValue);
                                                //InsertRecord(po, pom, pos, maxPackage + 1, maxPackage + 1,
                                                //    remainder, searchLookUpEdit1.Text + codeValue, (int)orderQty, (int)CartonQty);
                                                

                                                maxPackNo = this.tbl_Multi_PackListTableAdapter.MaxPackNo(dSPackingList.tbl_Multi_PackList, po, pom, pos);
                                                //this.tbl_Multi_PackListTableAdapter.UpdateQuery(tbl_Multi_PackListTableAdapter.CartonId(dSPackingList.tbl_Multi_PackList, maxPackNo), maxPackNo);
                                                this.view_MultiLine_Packing_List_FinelTableAdapter.Fill(this.dSPackingList.View_MultiLine_Packing_List_Finel, (int)searchLookUpEdit1.EditValue);
                                                this.tbl_Multi_PackListTableAdapter.Fill(dSPackingList.tbl_Multi_PackList, po);
                                            }

                                            if (Convert.ToInt32(CartonQty) > Convert.ToInt32(orderQty))
                                            {
                                                try
                                                {
                                                    maxPackage = (int)this.tbl_Multi_PackListTableAdapter.ScalarQueryMaxEndPackage(po);
                                                }
                                                catch (Exception)
                                                {
                                                    maxPackage = 0;
                                                }
                                                //InsertRecord(po, pom, pos, maxPackage + 1, maxPackage + 1,
                                                //remainder, this.searchLookUpEdit1.Text + codeValue, (int)orderQty, 0);

                                                maxPackNo = this.tbl_Multi_PackListTableAdapter.MaxPackNo(dSPackingList.tbl_Multi_PackList, po, pom, pos);
                                                this.tbl_Multi_PackListTableAdapter.UpdateQuery(tbl_Multi_PackListTableAdapter.CartonId(dSPackingList.tbl_Multi_PackList, maxPackNo), maxPackNo);
                                            }

                                        }
                                    }

                                }
                                catch (Exception ex) // Catching a general exception, but you might want to specify a more precise type
                                {
                                    // Log the exception message for debugging purposes
                                    MessageBox.Show($"An error occurred while checking order quantities: {ex.Message}");
                                }

                                tbl_Multi_PackListTableAdapter.Fill(dSPackingList.tbl_Multi_PackList, (int)searchLookUpEdit1.EditValue);
                                this.view_MultiLine_Packing_List_FinelTableAdapter.Fill(this.dSPackingList.View_MultiLine_Packing_List_Finel, (int)searchLookUpEdit1.EditValue);



                                // Fill the updated packing list
                                //dffffffffffffd
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
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            DialogResult btnMsg = MessageBox.Show("Are You Sure You Want To Generate Packing List Of Serial " + this.searchLookUpEdit1.Text + "?",
            "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (btnMsg == DialogResult.Yes)


                for (int j = 0; j < tbl_Multi_PO_HMBindingSource.Count; j++) {
                    {
                        int po = (int)dSPackingList.tbl_Multi_PO_HM.Rows[j]["po"];
                        String PoCode = (string)dSPackingList.tbl_Multi_PO_HM.Rows[j]["POCode"];

                        int maxPackage, maxPackNo, startPackage, remainder, endPackage;
                        string codeValue = comboBoxEdit1.Text;
                        int rowCount = view_MultiLine_Packing_List1TableAdapter.Fill(dSPackingList.View_MultiLine_Packing_List1, po);
                        for (int i = 0; i < view_MultiLine_Packing_List1BindingSource.Count; i++)
                        {
                            var orderQty = dSPackingList.View_MultiLine_Packing_List1.Rows[i]["orderQty"]; // replace with actual column name
                            var CartonQty = dSPackingList.View_MultiLine_Packing_List1.Rows[i]["CartonQty"];

                            int pos = (int)dSPackingList.View_MultiLine_Packing_List1.Rows[i]["POS"];
                            int pom = (int)dSPackingList.View_MultiLine_Packing_List1.Rows[i]["POM"];
                             object cartonIdValue = dSPackingList.View_MultiLine_Packing_List1.Rows[i]["CartonID"];
                            int CartonID;

                            if (cartonIdValue != DBNull.Value)
                            {
                                CartonID = Convert.ToInt32(cartonIdValue); // Use Convert to handle different types
                            }
                            else
                            {
                                // Handle the case where the value is DBNull
                                CartonID = 0;// Or any default value or throw an exception based on your needs
                            } 
                            //view_MultiLine_Packing_List1TableAdapter.FillBy(dSPackingList.View_MultiLine_Packing_List1, po, pom, pos);
                            // Check if order quantities match


                            try
                            {
                                int orderQtyQueryResult = (int)this.view_MultiLine_Packing_ListTableAdapter.OrderQtyQuery(dSPackingList.View_MultiLine_Packing_List, po, pom, pos);
                                var orderQtyResult = this.view_MultiLine_Packing_ListTableAdapter.OrderQty(dSPackingList.View_MultiLine_Packing_List, po, pom, pos);
                                if (orderQtyQueryResult == orderQtyResult)
                                {
                                    continue;
                                }

                                {


                                    // Ensure the value is not DBNull
                                    //if (orderQty != DBNull.Value && CartonQty != DBNull.Value)
                                    {

                                        try
                                        {
                                            maxPackage = (int)this.tbl_Multi_PackListTableAdapter.ScalarQueryMaxEndPackage(po);
                                        }
                                        catch (Exception)
                                        {
                                            maxPackage = 0;
                                        }

                                        startPackage = maxPackage + 1;
                                        endPackage = Convert.ToInt32(Math.Floor(Convert.ToDouble(orderQty) /
                                           Convert.ToDouble(CartonQty)));
                                        remainder = Convert.ToInt32(orderQty) %
                                           Convert.ToInt32(CartonQty);

                                        if (endPackage > 0)
                                        {
                                            endPackage = maxPackage + endPackage;
                                            this.view_MultiLine_Packing_ListTableAdapter.InsertQuery(po, pom, pos, startPackage, endPackage, (decimal)CartonQty, null, null, PoCode + comboBoxEdit1.Text, (int)orderQty, this.searchLookUpEdit1.Text + comboBoxEdit1.Text, (int)CartonID);


                                            maxPackNo = (int)this.tbl_Multi_PackListTableAdapter.ScalarQueryMaxPackNo(po, pom, pos);
                                            //this.tbl_Multi_PackListTableAdapter.UpdateQuery(tbl_Multi_PackListTableAdapter.CartonId(dSPackingList.tbl_Multi_PackList, maxPackNo), maxPackNo);
                                            //this.view_MultiLine_Packing_List_FinelTableAdapter.Fill(this.dSPackingList.View_MultiLine_Packing_List_Finel, (int)searchLookUpEdit1.EditValue);
                                        }

                                        if (remainder > 0)
                                        {

                                            try
                                            {
                                                maxPackage = (int)this.tbl_Multi_PackListTableAdapter.ScalarQueryMaxEndPackage(po);
                                            }
                                            catch (Exception)
                                            {
                                                maxPackage = 0;
                                            }
                                            this.view_MultiLine_Packing_ListTableAdapter.InsertQuery(po, pom, pos, maxPackage + 1, maxPackage + 1, remainder, null, null, PoCode + comboBoxEdit1.Text, (int)orderQty, this.searchLookUpEdit1.Text + comboBoxEdit1.Text, (int?)CartonID);
                                            //this.view_MultiLine_Packing_List_FinelTableAdapter.Fill(this.dSPackingList.View_MultiLine_Packing_List_Finel, (int)searchLookUpEdit1.EditValue);
                                            //InsertRecord(po, pom, pos, maxPackage + 1, maxPackage + 1,
                                            //    remainder, searchLookUpEdit1.Text + codeValue, (int)orderQty, (int)CartonQty);

                                            maxPackNo = this.tbl_Multi_PackListTableAdapter.MaxPackNo(dSPackingList.tbl_Multi_PackList, po, pom, pos);
                                            //this.tbl_Multi_PackListTableAdapter.UpdateQuery(tbl_Multi_PackListTableAdapter.CartonId(dSPackingList.tbl_Multi_PackList, maxPackNo), maxPackNo);
                                        }

                                        if (Convert.ToInt32(CartonQty) > Convert.ToInt32(orderQty))
                                        {
                                            try
                                            {
                                                maxPackage = (int)this.tbl_Multi_PackListTableAdapter.ScalarQueryMaxEndPackage(po);
                                            }
                                            catch (Exception)
                                            {
                                                maxPackage = 0;
                                            }
                                            //InsertRecord(po, pom, pos, maxPackage + 1, maxPackage + 1,
                                            //remainder, this.searchLookUpEdit1.Text + codeValue, (int)orderQty, 0);

                                            maxPackNo = this.tbl_Multi_PackListTableAdapter.MaxPackNo(dSPackingList.tbl_Multi_PackList, po, pom, pos);
                                            this.tbl_Multi_PackListTableAdapter.UpdateQuery(tbl_Multi_PackListTableAdapter.CartonId(dSPackingList.tbl_Multi_PackList, maxPackNo), maxPackNo);
                                        }

                                    }
                                }

                            }
                            catch (Exception ex) // Catching a general exception, but you might want to specify a more precise type
                            {
                                // Log the exception message for debugging purposes
                                MessageBox.Show($"An error occurred while checking order quantities: {ex.Message}");
                            }





                            // Fill the updated packing list

                        }






                        //this.view_MultiLine_Packing_List_FinelTableAdapter.Fill(this.dSPackingList.View_MultiLine_Packing_List_Finel, po);
                        //this.tbl_Multi_PackListTableAdapter.Fill(dSPackingList.tbl_Multi_PackList, po);

                    }
                    // Fill the updated packing list
                  

                }
            



        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (checkedListBoxControl1.CheckedItems.Count > 0)
            {
                // Create an instance of Form1
                Form1 objFrmFilter = new Form1();

                // Path to your Crystal Report file
                string reportName = @"\\dnsserver\MyReports$\MultiProduction\RptS4PackList.rpt";

                // Initialize an empty selection formula
                string selectionFormula = string.Empty;

                // Iterate through the checked items to build the selection formula
                foreach (DataRowView item in checkedListBoxControl1.CheckedItems)
                {
                    var poValue = item["PO"];

                    // Build the selection formula (assuming you want an 'OR' condition)
                    if (!string.IsNullOrEmpty(selectionFormula))
                    {
                        selectionFormula += " OR ";
                    }
                    selectionFormula += $"{{View_Rpt_PackList.PO}} = {poValue}"; // Replace 'YourFieldName' with the actual field name from the report
                }

                // Show the selection formula for debugging
               

                if (objFrmFilter.ViewReport(reportName, selectionFormula))
                {
                    FrmMain mainForm = Application.OpenForms.OfType<FrmMain>().FirstOrDefault();
                    if (mainForm != null)
                    {
                        objFrmFilter.ShowDialog(); // Show the form modally
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


        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (dateEdit5.Text != null && dateEdit6.Text != null)
            {
                this.tbl_Multi_PO_HMTableAdapter.Fill(this.dSPackingList.tbl_Multi_PO_HM, (DateTime?)dateEdit5.EditValue, (DateTime?)dateEdit6.EditValue);
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (dateEdit1.Text != null && dateEdit2.Text != null)
            {
                this.tbl_Multi_PO_HMTableAdapter.Fill(this.dSPackingList.tbl_Multi_PO_HM, (DateTime?)dateEdit1.EditValue, (DateTime?)dateEdit2.EditValue);
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            int maxPackage, maxPackNo, startPackage, remainder, endPackage;
            string codeValue = comboBoxEdit1.Text;
            {
                var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl2.FocusedView;
                DialogResult btnMsg = MessageBox.Show("Are You Sure You Want To Generate Packing List Of Serial  ?",
           "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (btnMsg == DialogResult.Yes)
                {
                    if (gridView.SelectedRowsCount > 0)
                    {
                        var selectedRowHandle = gridView.GetSelectedRows()[0];

                        if (selectedRowHandle >= 0)
                        {
                            try
                            {
                                // Initialize variables with default values
                                //int PO = 0;
                                //int totalPlanQty = 0;
                                int po = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PO") ?? 0);
                                int pom = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "POM") ?? 0);
                                int pos = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "POS") ?? 0);
                                int packNo = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "PackNo") ?? 0);
                                int orderQty = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "orderQty") ?? 0);
                                int CartonQty = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "CartonQty") ?? 0);
                                object cartonIdValue = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "CartonID") ?? 0);
                                int CartonID;

                                if (cartonIdValue != DBNull.Value)
                                {
                                    CartonID = Convert.ToInt32(cartonIdValue); // Use Convert to handle different types
                                }
                                else
                                {
                                    // Handle the case where the value is DBNull
                                    CartonID = 0;// Or any default value or throw an exception based on your needs
                                }
                                int Balance = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "Balance") ?? 0);
                                object partialQtyValue = gridView.GetRowCellValue(selectedRowHandle, "PartielQty");
                                int PartielQty = (partialQtyValue != DBNull.Value) ? Convert.ToInt32(partialQtyValue) : 0;

                                orderQty = Balance;
                                if (PartielQty > 0)
                                {
                                    if (PartielQty <= Balance)
                                    {
                                        orderQty = PartielQty;
                                    }

                                    else
                                    {
                                        MessageBox.Show("Partial Qty must be less than Balance.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    }
                                }
                                try
                                {
                                    int orderQtyQueryResult = (int)this.view_MultiLine_Packing_ListTableAdapter.OrderQtyQuery(dSPackingList.View_MultiLine_Packing_List, po, pom, pos);
                                    var orderQtyResult = this.view_MultiLine_Packing_ListTableAdapter.OrderQty(dSPackingList.View_MultiLine_Packing_List, po, pom, pos);
                                    if (orderQtyQueryResult == orderQtyResult)
                                    {

                                    }

                                    {


                                        // Ensure the value is not DBNull
                                        //if (orderQty != DBNull.Value && CartonQty != DBNull.Value)
                                        {

                                            try
                                            {
                                                maxPackage = (int)this.tbl_Multi_PackListTableAdapter.ScalarQueryMaxEndPackage(po);
                                            }
                                            catch (Exception)
                                            {
                                                maxPackage = 0;
                                            }



                                            startPackage = maxPackage + 1;
                                            endPackage = Convert.ToInt32(Math.Floor(Convert.ToDouble(orderQty) /
                                               Convert.ToDouble(CartonQty)));
                                            remainder = Convert.ToInt32(orderQty) %
                                               Convert.ToInt32(CartonQty);

                                            if (endPackage > 0)
                                            {
                                                endPackage = maxPackage + endPackage;
                                                this.view_MultiLine_Packing_ListTableAdapter.InsertQuery(po, pom, pos, startPackage, endPackage, (decimal)CartonQty, null, null, searchLookUpEdit1.Text + comboBoxEdit1.Text, (int)orderQty, this.searchLookUpEdit1.Text + comboBoxEdit1.Text, (int)CartonID);
                                                //tbl_Multi_PackListTableAdapter.Fill(dSPackingList.tbl_Multi_PackList, (int)searchLookUpEdit1.EditValue);
                                                //this.view_MultiLine_Packing_List_FinelTableAdapter.Fill(this.dSPackingList.View_MultiLine_Packing_List_Finel, (int)searchLookUpEdit1.EditValue);

                                                maxPackNo = (int)this.tbl_Multi_PackListTableAdapter.ScalarQueryMaxPackNo(po, pom, pos);
                                                //this.tbl_Multi_PackListTableAdapter.UpdateQuery(tbl_Multi_PackListTableAdapter.CartonId(dSPackingList.tbl_Multi_PackList, maxPackNo), maxPackNo);
                                                //this.view_MultiLine_Packing_List_FinelTableAdapter.Fill(this.dSPackingList.View_MultiLine_Packing_List_Finel, (int)searchLookUpEdit1.EditValue);
                                            }

                                            if (remainder > 0)
                                            {

                                                try
                                                {
                                                    maxPackage = (int)this.tbl_Multi_PackListTableAdapter.ScalarQueryMaxEndPackage(po);
                                                }
                                                catch (Exception)
                                                {
                                                    maxPackage = 0;
                                                }
                                                this.view_MultiLine_Packing_ListTableAdapter.InsertQuery(po, pom, pos, maxPackage + 1, maxPackage + 1, remainder, null, null, searchLookUpEdit1.Text + comboBoxEdit1.Text, (int)orderQty, this.searchLookUpEdit1.Text + comboBoxEdit1.Text, (int?)CartonID);
                                                //this.view_MultiLine_Packing_List_FinelTableAdapter.Fill(this.dSPackingList.View_MultiLine_Packing_List_Finel, (int)searchLookUpEdit1.EditValue);
                                                //InsertRecord(po, pom, pos, maxPackage + 1, maxPackage + 1,
                                                //    remainder, searchLookUpEdit1.Text + codeValue, (int)orderQty, (int)CartonQty);


                                                maxPackNo = this.tbl_Multi_PackListTableAdapter.MaxPackNo(dSPackingList.tbl_Multi_PackList, po, pom, pos);
                                                //this.tbl_Multi_PackListTableAdapter.UpdateQuery(tbl_Multi_PackListTableAdapter.CartonId(dSPackingList.tbl_Multi_PackList, maxPackNo), maxPackNo);
                                                this.view_MultiLine_Packing_List_FinelTableAdapter.Fill(this.dSPackingList.View_MultiLine_Packing_List_Finel, (int)searchLookUpEdit1.EditValue);
                                                this.tbl_Multi_PackListTableAdapter.Fill(dSPackingList.tbl_Multi_PackList, po);
                                            }

                                            if (Convert.ToInt32(CartonQty) > Convert.ToInt32(orderQty))
                                            {
                                                try
                                                {
                                                    maxPackage = (int)this.tbl_Multi_PackListTableAdapter.ScalarQueryMaxEndPackage(po);
                                                }
                                                catch (Exception)
                                                {
                                                    maxPackage = 0;
                                                }
                                                //InsertRecord(po, pom, pos, maxPackage + 1, maxPackage + 1,
                                                //remainder, this.searchLookUpEdit1.Text + codeValue, (int)orderQty, 0);

                                                maxPackNo = this.tbl_Multi_PackListTableAdapter.MaxPackNo(dSPackingList.tbl_Multi_PackList, po, pom, pos);
                                                this.tbl_Multi_PackListTableAdapter.UpdateQuery(tbl_Multi_PackListTableAdapter.CartonId(dSPackingList.tbl_Multi_PackList, maxPackNo), maxPackNo);
                                            }

                                        }
                                    }

                                }
                                catch (Exception ex) // Catching a general exception, but you might want to specify a more precise type
                                {
                                    // Log the exception message for debugging purposes
                                    MessageBox.Show($"An error occurred while checking order quantities: {ex.Message}");
                                }

                                tbl_Multi_PackListTableAdapter.Fill(dSPackingList.tbl_Multi_PackList, (int)searchLookUpEdit1.EditValue);
                                this.view_MultiLine_Packing_List_FinelTableAdapter.Fill(this.dSPackingList.View_MultiLine_Packing_List_Finel, (int)searchLookUpEdit1.EditValue);



                                // Fill the updated packing list
                                //dffffffffffffd
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
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            bool BINFStatus;
            if (checkEdit1.Checked == true)
            {
                BINFStatus = true;
            }
            else
            {
                BINFStatus = false;
            }
            if (checkedListBoxControl1.CheckedItems.Count > 0)
            {
                // Create an instance of Form1
               
                // Iterate through the checked items to build the selection formula
                foreach (DataRowView item in checkedListBoxControl1.CheckedItems)
                {
                    var poValue = item["PO"];

                    // Build the selection formula (assuming you want an 'OR' condition)

                    try
                    {
                        this.tbl_Multi_PO_H_PackingTableAdapter.UpdateQuery(searchLookUpEdit2.Text, BINFStatus,Convert.ToInt32(textEdit1.Text), (string)searchLookUpEdit3.EditValue, Convert.ToInt32(poValue)          // Ensures poValue is converted to an integer
                      );

                    }
                    catch (Exception ex)
                    {
                        this.tbl_Multi_PO_H_PackingTableAdapter.UpdateQuery(searchLookUpEdit2.Text, BINFStatus, null, (string)searchLookUpEdit3.EditValue, (int)poValue);
                    }

                }
                MessageBox.Show("Data Saved Successfully");
                this.tbl_Multi_PO_H_PackingTableAdapter.Fill(this.dSPackingList.tbl_Multi_PO_H_Packing);

                // Show the selection formula for debugging



            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchLookUpEdit3.Text))
            {
                //if (!string.IsNullOrEmpty(lookUpEdit1.Text))
                {
                    Form1 objFrmFilter = new Form1();

                    // Path to your Crystal Report file
                    string reportName = @"\\dnsserver\MyReports$\MultiProduction\MultiPOPacklistDetail.rpt";

                    // Construct the selection formula string
                    var PO = searchLookUpEdit3.EditValue;
                    //var PORange = lookUpEdit1.Text;
                    string selectionFormula = $"{{tbl_Pro_PO.PO}} = {PO} ";

                    // Build selection formula based on input values
                    //if (PO != null)
                    //{
                    //    selectionFormula += $"{{View_Rpt_PackList.PO}} = {PO}";
                    //}

                    //if (!string.IsNullOrEmpty(PORange) && PORange != "[EditValue is null]")
                    //{
                    //    if (!string.IsNullOrEmpty(selectionFormula))
                    //    {
                    //        selectionFormula += " AND "; // Add 'AND' if there's already a condition
                    //    }
                    //    selectionFormula += $"{{View_Rpt_PackList.PONumber}} = \"{PORange}\"";
                    //}
                    //if (string.IsNullOrEmpty(PORange) || PORange == "[EditValue is null]")
                    //{
                    //    selectionFormula = selectionFormula;
                    //}

                    // View the report
                    if (objFrmFilter.ViewReport(reportName, selectionFormula))
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
                //else
                //{
                //    MessageBox.Show("Select a valid range first.");
                //}
            }
            else
            {
                MessageBox.Show("Select a PO first.");
            }

        }

        private void labelControl12_Click(object sender, EventArgs e)
        {

        }

       

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            this.tbl_Multi_PO_HMPackingTableAdapter.Fill(this.dSPackingList.tbl_Multi_PO_HMPacking, (DateTime?)dateEdit3.EditValue, (DateTime?)dateEdit4.EditValue);
        }
    }
    }
    

