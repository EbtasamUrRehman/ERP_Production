
namespace ERP_Production.Planning
{
    partial class FrmPlanningNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FrmPlanningNew
            // 
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Name = "FrmPlanningNew";
            this.Load += new System.EventHandler(this.FrmPlanningNew_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemPQty;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DSPlanning1 dSPlanning1;
        private System.Windows.Forms.BindingSource view_Multi_po_planningBindingSource;
        private DSPlanning1TableAdapters.View_Multi_po_planningTableAdapter view_Multi_po_planningTableAdapter;
        private DSPlanning1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colPID;
        private DevExpress.XtraGrid.Columns.GridColumn colPDID;
        private DevExpress.XtraGrid.Columns.GridColumn colPO;
        private DevExpress.XtraGrid.Columns.GridColumn colLAName;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
        private DevExpress.XtraGrid.Columns.GridColumn colLine;
        private DevExpress.XtraGrid.Columns.GridColumn colDD;
        private DevExpress.XtraGrid.Columns.GridColumn colShipMode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustReqDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExFactoryDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanQty;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderQty;
        private DevExpress.XtraGrid.Columns.GridColumn colBalance;
        private DevExpress.XtraGrid.Columns.GridColumn colPartielQty;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colClientID;
        private DevExpress.XtraGrid.Columns.GridColumn colModelID;
        private DevExpress.XtraGrid.Columns.GridColumn colArtID;
        private System.Windows.Forms.BindingSource tbl_Pro_Plan_MultiplanBindingSource;
        private DSPlanning1TableAdapters.tbl_Pro_Plan_MultiplanTableAdapter tbl_Pro_Plan_MultiplanTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Pro_Plan_D_MultilineBindingSource;
        private DSPlanning1TableAdapters.tbl_Pro_Plan_D_MultilineTableAdapter tbl_Pro_Plan_D_MultilineTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Multi_PO_PlanBindingSource;
        private DSPlanning1TableAdapters.tbl_Multi_PO_PlanTableAdapter tbl_Multi_PO_PlanTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Multi_PO_Plan_DBindingSource;
        private DSPlanning1TableAdapters.Tbl_Multi_PO_Plan_DTableAdapter tbl_Multi_PO_Plan_DTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colFactoryCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPOCode;
    }
}