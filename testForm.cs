using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Production
{
    public partial class testForm : Form
    {
        public testForm()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.view_Multi_LabelPlanning_FinalCompleteTableAdapter.Fill(this.dSLabelPlanning.View_Multi_LabelPlanning_FinalComplete, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(secondConfDateToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(secondConfDate1ToolStripTextBox.Text, typeof(System.DateTime))))), factoryCodeToolStripTextBox.Text);
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
                        string Combo = gridView.GetRowCellValue(selectedRowHandle, "Combo") != DBNull.Value
                           ? gridView.GetRowCellValue(selectedRowHandle, "Combo").ToString()
                           : null;
                        Console.WriteLine($"LAName:", Combo);
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }
    }
}
