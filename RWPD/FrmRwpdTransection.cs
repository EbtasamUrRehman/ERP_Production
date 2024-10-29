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
            // TODO: This line of code loads data into the 'dSRwpd.View_RWPD_Multi_Out_Balance' table. You can move, or remove it, as needed.
            this.view_RWPD_Multi_Out_BalanceTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_Out_Balance);
            // TODO: This line of code loads data into the 'dSRwpd.View_RWPD_Multi_IN' table. You can move, or remove it, as needed.
            this.view_RWPD_Multi_INTableAdapter.Fill(this.dSRwpd.View_RWPD_Multi_IN);
            // TODO: This line of code loads data into the 'dSRwpd.View_Multi_PO_Reports' table. You can move, or remove it, as needed.
            this.view_Multi_PO_ReportsTableAdapter.Fill(this.dSRwpd.View_Multi_PO_Reports);
            // TODO: This line of code loads data into the 'dSRwpd.tbl_RackNO' table. You can move, or remove it, as needed.
            this.tbl_RackNOTableAdapter.Fill(this.dSRwpd.tbl_RackNO);

        }
    }
}