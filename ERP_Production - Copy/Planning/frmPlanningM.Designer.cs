
namespace ERP_Production.Planning
{
    partial class frmPlanningM
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.view_Multi_po_planningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPlanning = new ERP_Production.Planning.DSPlanning();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colClientID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactoryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipMode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustReqDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExFactoryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartielQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPlan = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tbl_Multi_PO_PlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Multi_PO_PlanTableAdapter = new ERP_Production.Planning.DSPlanningTableAdapters.tbl_Multi_PO_PlanTableAdapter();
            this.tableAdapterManager = new ERP_Production.Planning.DSPlanningTableAdapters.TableAdapterManager();
            this.tbl_Multi_PO_Plan_DTableAdapter = new ERP_Production.Planning.DSPlanningTableAdapters.Tbl_Multi_PO_Plan_DTableAdapter();
            this.tbl_Multi_PO_Plan_DBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Multi_po_planningTableAdapter = new ERP_Production.Planning.DSPlanningTableAdapters.View_Multi_po_planningTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Multi_po_planningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPlanning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Multi_PO_PlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Multi_PO_Plan_DBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(1307, 641);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1307, 641);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "tabNavigationPage1";
            this.tabNavigationPage1.Controls.Add(this.gridControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1307, 608);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.view_Multi_po_planningBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPlan});
            this.gridControl1.Size = new System.Drawing.Size(1307, 608);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // view_Multi_po_planningBindingSource
            // 
            this.view_Multi_po_planningBindingSource.DataMember = "View_Multi_po_planning";
            this.view_Multi_po_planningBindingSource.DataSource = this.dSPlanning;
            // 
            // dSPlanning
            // 
            this.dSPlanning.DataSetName = "DSPlanning";
            this.dSPlanning.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClientID,
            this.colModelID,
            this.colArtID,
            this.colPO,
            this.colPOCode,
            this.colFactoryCode,
            this.colLAName,
            this.colSize,
            this.colLine,
            this.colDD,
            this.colShipMode,
            this.colCustReqDate,
            this.colExFactoryDate,
            this.colPlanQty,
            this.colOrderQty,
            this.colBalance,
            this.colPartielQty,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colClientID
            // 
            this.colClientID.FieldName = "ClientID";
            this.colClientID.Name = "colClientID";
            // 
            // colModelID
            // 
            this.colModelID.FieldName = "ModelID";
            this.colModelID.Name = "colModelID";
            // 
            // colArtID
            // 
            this.colArtID.FieldName = "ArtID";
            this.colArtID.Name = "colArtID";
            // 
            // colPO
            // 
            this.colPO.FieldName = "PO";
            this.colPO.Name = "colPO";
            // 
            // colPOCode
            // 
            this.colPOCode.FieldName = "POCode";
            this.colPOCode.Name = "colPOCode";
            this.colPOCode.Visible = true;
            this.colPOCode.VisibleIndex = 0;
            // 
            // colFactoryCode
            // 
            this.colFactoryCode.FieldName = "FactoryCode";
            this.colFactoryCode.Name = "colFactoryCode";
            this.colFactoryCode.Visible = true;
            this.colFactoryCode.VisibleIndex = 1;
            // 
            // colLAName
            // 
            this.colLAName.FieldName = "LAName";
            this.colLAName.Name = "colLAName";
            this.colLAName.Visible = true;
            this.colLAName.VisibleIndex = 2;
            // 
            // colSize
            // 
            this.colSize.FieldName = "Size";
            this.colSize.Name = "colSize";
            this.colSize.Visible = true;
            this.colSize.VisibleIndex = 3;
            // 
            // colLine
            // 
            this.colLine.FieldName = "Line";
            this.colLine.Name = "colLine";
            this.colLine.Visible = true;
            this.colLine.VisibleIndex = 4;
            // 
            // colDD
            // 
            this.colDD.FieldName = "DD";
            this.colDD.Name = "colDD";
            this.colDD.Visible = true;
            this.colDD.VisibleIndex = 5;
            // 
            // colShipMode
            // 
            this.colShipMode.FieldName = "ShipMode";
            this.colShipMode.Name = "colShipMode";
            this.colShipMode.Visible = true;
            this.colShipMode.VisibleIndex = 6;
            // 
            // colCustReqDate
            // 
            this.colCustReqDate.FieldName = "CustReqDate";
            this.colCustReqDate.Name = "colCustReqDate";
            this.colCustReqDate.Visible = true;
            this.colCustReqDate.VisibleIndex = 7;
            // 
            // colExFactoryDate
            // 
            this.colExFactoryDate.FieldName = "ExFactoryDate";
            this.colExFactoryDate.Name = "colExFactoryDate";
            this.colExFactoryDate.Visible = true;
            this.colExFactoryDate.VisibleIndex = 8;
            // 
            // colPlanQty
            // 
            this.colPlanQty.AppearanceCell.Options.UseTextOptions = true;
            this.colPlanQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlanQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlanQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlanQty.FieldName = "PlanQty";
            this.colPlanQty.Name = "colPlanQty";
            this.colPlanQty.Visible = true;
            this.colPlanQty.VisibleIndex = 9;
            // 
            // colOrderQty
            // 
            this.colOrderQty.AppearanceCell.Options.UseTextOptions = true;
            this.colOrderQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrderQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderQty.FieldName = "OrderQty";
            this.colOrderQty.Name = "colOrderQty";
            this.colOrderQty.Visible = true;
            this.colOrderQty.VisibleIndex = 10;
            // 
            // colBalance
            // 
            this.colBalance.AppearanceCell.Options.UseTextOptions = true;
            this.colBalance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBalance.AppearanceHeader.Options.UseTextOptions = true;
            this.colBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBalance.FieldName = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 11;
            // 
            // colPartielQty
            // 
            this.colPartielQty.AppearanceCell.Options.UseTextOptions = true;
            this.colPartielQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPartielQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colPartielQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPartielQty.FieldName = "PartielQty";
            this.colPartielQty.Name = "colPartielQty";
            this.colPartielQty.Visible = true;
            this.colPartielQty.VisibleIndex = 12;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Plan";
            this.gridColumn1.ColumnEdit = this.repositoryItemPlan;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 13;
            // 
            // repositoryItemPlan
            // 
            this.repositoryItemPlan.AutoHeight = false;
            editorButtonImageOptions1.Image = global::ERP_Production.Properties.Resources.apply_16x161;
            this.repositoryItemPlan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemPlan.Name = "repositoryItemPlan";
            this.repositoryItemPlan.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemPlan.Click += new System.EventHandler(this.repositoryItemPlan_Click);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "tabNavigationPage2";
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(75, 23);
            // 
            // tbl_Multi_PO_PlanBindingSource
            // 
            this.tbl_Multi_PO_PlanBindingSource.DataMember = "tbl_Multi_PO_Plan";
            this.tbl_Multi_PO_PlanBindingSource.DataSource = this.dSPlanning;
            // 
            // tbl_Multi_PO_PlanTableAdapter
            // 
            this.tbl_Multi_PO_PlanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tbl_Multi_PO_Plan_DTableAdapter = this.tbl_Multi_PO_Plan_DTableAdapter;
            this.tableAdapterManager.tbl_Multi_PO_PlanTableAdapter = this.tbl_Multi_PO_PlanTableAdapter;
            this.tableAdapterManager.UpdateOrder = ERP_Production.Planning.DSPlanningTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_Multi_PO_Plan_DTableAdapter
            // 
            this.tbl_Multi_PO_Plan_DTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Multi_PO_Plan_DBindingSource
            // 
            this.tbl_Multi_PO_Plan_DBindingSource.DataMember = "Tbl_Multi_PO_Plan_D";
            this.tbl_Multi_PO_Plan_DBindingSource.DataSource = this.dSPlanning;
            // 
            // view_Multi_po_planningTableAdapter
            // 
            this.view_Multi_po_planningTableAdapter.ClearBeforeFill = true;
            // 
            // frmPlanningM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 641);
            this.Controls.Add(this.tabPane1);
            this.Name = "frmPlanningM";
            this.Text = "frmPlanningM";
            this.Load += new System.EventHandler(this.frmPlanningM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Multi_po_planningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPlanning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Multi_PO_PlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Multi_PO_Plan_DBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DSPlanning dSPlanning;
        private System.Windows.Forms.BindingSource tbl_Multi_PO_PlanBindingSource;
        private DSPlanningTableAdapters.tbl_Multi_PO_PlanTableAdapter tbl_Multi_PO_PlanTableAdapter;
        private DSPlanningTableAdapters.TableAdapterManager tableAdapterManager;
        private DSPlanningTableAdapters.Tbl_Multi_PO_Plan_DTableAdapter tbl_Multi_PO_Plan_DTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Multi_PO_Plan_DBindingSource;
        private System.Windows.Forms.BindingSource view_Multi_po_planningBindingSource;
        private DSPlanningTableAdapters.View_Multi_po_planningTableAdapter view_Multi_po_planningTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colClientID;
        private DevExpress.XtraGrid.Columns.GridColumn colModelID;
        private DevExpress.XtraGrid.Columns.GridColumn colArtID;
        private DevExpress.XtraGrid.Columns.GridColumn colPO;
        private DevExpress.XtraGrid.Columns.GridColumn colPOCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFactoryCode;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemPlan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}