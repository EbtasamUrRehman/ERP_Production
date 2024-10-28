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

namespace ERP_Production.Label_Planning
{
    public partial class frmLabelPlanning : DevExpress.XtraEditors.XtraForm
    {
        public frmLabelPlanning()
        {
            InitializeComponent();
        }

        private void searchLookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tbl_Pro_ClientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_Pro_ClientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSLabelPlanning);

        }

        private void frmLabelPlanning_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSLabelPlanning.tbl_Pro_Client' table. You can move, or remove it, as needed.
            this.tbl_Pro_ClientTableAdapter.Fill(this.dSLabelPlanning.tbl_Pro_Client);

        }
    }
}