using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: This line of code loads data into the 'dSPackingList.tbl_Multi_PO_S' table. You can move, or remove it, as needed.
            this.tbl_Multi_PO_STableAdapter.Fill(this.dSPackingList.tbl_Multi_PO_S);
            // TODO: This line of code loads data into the 'dSPackingList.View_MullinePacking_requ' table. You can move, or remove it, as needed.
            this.view_MullinePacking_requTableAdapter.Fill(this.dSPackingList.View_MullinePacking_requ, (int)searchLookUpEdit1.EditValue);

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
