
namespace ERP_Production.PackingList
{
    partial class FrmPackingList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPackingList));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.view_MullinePacking_requBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPackingList = new ERP_Production.PackingList.DSPackingList();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPOCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatFormula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrdLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactoryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.view_MullinePacking_requTableAdapter = new ERP_Production.PackingList.DSPackingListTableAdapters.View_MullinePacking_requTableAdapter();
            this.tableAdapterManager = new ERP_Production.PackingList.DSPackingListTableAdapters.TableAdapterManager();
            this.tbl_Multi_PO_SBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Multi_PO_STableAdapter = new ERP_Production.PackingList.DSPackingListTableAdapters.tbl_Multi_PO_STableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_MullinePacking_requBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPackingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Multi_PO_SBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(1482, 507);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1482, 507);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Production Order";
            this.tabNavigationPage1.Controls.Add(this.panelControl4);
            this.tabNavigationPage1.Controls.Add(this.panelControl3);
            this.tabNavigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage1.ImageOptions.Image")));
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1482, 459);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.gridControl2);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(0, 73);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1482, 386);
            this.panelControl4.TabIndex = 1;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.view_MullinePacking_requBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 2);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1478, 382);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // view_MullinePacking_requBindingSource
            // 
            this.view_MullinePacking_requBindingSource.DataMember = "View_MullinePacking_requ";
            this.view_MullinePacking_requBindingSource.DataSource = this.dSPackingList;
            // 
            // dSPackingList
            // 
            this.dSPackingList.DataSetName = "DSPackingList";
            this.dSPackingList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPOCode,
            this.colCode,
            this.colMatFormula,
            this.colPrdLine,
            this.colClientID,
            this.colMaterialName,
            this.colSize,
            this.colArtCode,
            this.colFactoryCode,
            this.colBalance,
            this.colPO});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colPOCode
            // 
            this.colPOCode.FieldName = "POCode";
            this.colPOCode.Name = "colPOCode";
            this.colPOCode.Visible = true;
            this.colPOCode.VisibleIndex = 0;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            // 
            // colMatFormula
            // 
            this.colMatFormula.FieldName = "MatFormula";
            this.colMatFormula.Name = "colMatFormula";
            this.colMatFormula.Visible = true;
            this.colMatFormula.VisibleIndex = 2;
            // 
            // colPrdLine
            // 
            this.colPrdLine.FieldName = "PrdLine";
            this.colPrdLine.Name = "colPrdLine";
            this.colPrdLine.Visible = true;
            this.colPrdLine.VisibleIndex = 3;
            // 
            // colClientID
            // 
            this.colClientID.FieldName = "ClientID";
            this.colClientID.Name = "colClientID";
            this.colClientID.Visible = true;
            this.colClientID.VisibleIndex = 4;
            // 
            // colMaterialName
            // 
            this.colMaterialName.FieldName = "MaterialName";
            this.colMaterialName.Name = "colMaterialName";
            this.colMaterialName.Visible = true;
            this.colMaterialName.VisibleIndex = 5;
            // 
            // colSize
            // 
            this.colSize.FieldName = "Size";
            this.colSize.Name = "colSize";
            this.colSize.Visible = true;
            this.colSize.VisibleIndex = 6;
            // 
            // colArtCode
            // 
            this.colArtCode.FieldName = "ArtCode";
            this.colArtCode.Name = "colArtCode";
            this.colArtCode.Visible = true;
            this.colArtCode.VisibleIndex = 7;
            // 
            // colFactoryCode
            // 
            this.colFactoryCode.FieldName = "FactoryCode";
            this.colFactoryCode.Name = "colFactoryCode";
            this.colFactoryCode.Visible = true;
            this.colFactoryCode.VisibleIndex = 8;
            // 
            // colBalance
            // 
            this.colBalance.FieldName = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 9;
            // 
            // colPO
            // 
            this.colPO.FieldName = "PO";
            this.colPO.Name = "colPO";
            this.colPO.Visible = true;
            this.colPO.VisibleIndex = 10;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.searchLookUpEdit1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1482, 73);
            this.panelControl3.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 15);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "PO Code";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(65, 18);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.DataSource = this.view_MullinePacking_requBindingSource;
            this.searchLookUpEdit1.Properties.DisplayMember = "POCode";
            this.searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Properties.ValueMember = "PO";
            this.searchLookUpEdit1.Size = new System.Drawing.Size(274, 22);
            this.searchLookUpEdit1.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Packing List";
            this.tabNavigationPage2.Controls.Add(this.panelControl2);
            this.tabNavigationPage2.Controls.Add(this.panelControl1);
            this.tabNavigationPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage2.ImageOptions.Image")));
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1482, 459);
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 54);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1482, 405);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1482, 54);
            this.panelControl1.TabIndex = 0;
            // 
            // view_MullinePacking_requTableAdapter
            // 
            this.view_MullinePacking_requTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tbl_Multi_PO_STableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ERP_Production.PackingList.DSPackingListTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_Multi_PO_SBindingSource
            // 
            this.tbl_Multi_PO_SBindingSource.DataMember = "tbl_Multi_PO_S";
            this.tbl_Multi_PO_SBindingSource.DataSource = this.dSPackingList;
            // 
            // tbl_Multi_PO_STableAdapter
            // 
            this.tbl_Multi_PO_STableAdapter.ClearBeforeFill = true;
            // 
            // FrmPackingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 507);
            this.Controls.Add(this.tabPane1);
            this.Name = "FrmPackingList";
            this.Text = "FrmPackingList";
            this.Load += new System.EventHandler(this.FrmPackingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_MullinePacking_requBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPackingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Multi_PO_SBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DSPackingList dSPackingList;
        private System.Windows.Forms.BindingSource view_MullinePacking_requBindingSource;
        private DSPackingListTableAdapters.View_MullinePacking_requTableAdapter view_MullinePacking_requTableAdapter;
        private DSPackingListTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colPOCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colMatFormula;
        private DevExpress.XtraGrid.Columns.GridColumn colPrdLine;
        private DevExpress.XtraGrid.Columns.GridColumn colClientID;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
        private DevExpress.XtraGrid.Columns.GridColumn colArtCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFactoryCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBalance;
        private DevExpress.XtraGrid.Columns.GridColumn colPO;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource tbl_Multi_PO_SBindingSource;
        private DSPackingListTableAdapters.tbl_Multi_PO_STableAdapter tbl_Multi_PO_STableAdapter;
    }
}