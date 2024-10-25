
namespace ERP_Production.Purchase_Order
{
    partial class FrmUpdatesUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdatesUpload));
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.commonBar1 = new DevExpress.XtraSpreadsheet.UI.CommonBar();
            this.spreadsheetDockManager1 = new DevExpress.XtraSpreadsheet.SpreadsheetDockManager(this.components);
            this.fieldListDockPanel1 = new DevExpress.XtraSpreadsheet.FieldListDockPanel();
            this.fieldListDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.spreadsheetBarController1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController(this.components);
            this.commonBar2 = new DevExpress.XtraSpreadsheet.UI.CommonBar();
            this.spreadsheetCommandBarButtonItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.dSPurchaseOrderNew = new ERP_Production.Purchase_Order.DSPurchaseOrderNew();
            this.tbl_Multi_PO_HBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Multi_PO_HTableAdapter = new ERP_Production.Purchase_Order.DSPurchaseOrderNewTableAdapters.tbl_Multi_PO_HTableAdapter();
            this.tableAdapterManager = new ERP_Production.Purchase_Order.DSPurchaseOrderNewTableAdapters.TableAdapterManager();
            this.tbl_Multi_PO_MBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Multi_PO_MTableAdapter = new ERP_Production.Purchase_Order.DSPurchaseOrderNewTableAdapters.tbl_Multi_PO_MTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetDockManager1)).BeginInit();
            this.fieldListDockPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPurchaseOrderNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Multi_PO_HBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Multi_PO_MBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 35);
            this.spreadsheetControl1.MenuManager = this.barManager1;
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Size = new System.Drawing.Size(1218, 571);
            this.spreadsheetControl1.TabIndex = 1;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // commonBar1
            // 
            this.commonBar1.Control = this.spreadsheetControl1;
            this.commonBar1.DockCol = 0;
            this.commonBar1.DockRow = 0;
            this.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            // 
            // spreadsheetDockManager1
            // 
            this.spreadsheetDockManager1.Form = this;
            this.spreadsheetDockManager1.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.fieldListDockPanel1});
            this.spreadsheetDockManager1.SpreadsheetControl = this.spreadsheetControl1;
            this.spreadsheetDockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // fieldListDockPanel1
            // 
            this.fieldListDockPanel1.Controls.Add(this.fieldListDockPanel1_Container);
            this.fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.fieldListDockPanel1.ID = new System.Guid("8ce2910c-af93-44b2-9ed7-cbcbdf2a3edf");
            this.fieldListDockPanel1.Location = new System.Drawing.Point(1130, 0);
            this.fieldListDockPanel1.Name = "fieldListDockPanel1";
            this.fieldListDockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.fieldListDockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.fieldListDockPanel1.SavedIndex = 0;
            this.fieldListDockPanel1.Size = new System.Drawing.Size(200, 610);
            this.fieldListDockPanel1.SpreadsheetControl = this.spreadsheetControl1;
            this.fieldListDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // fieldListDockPanel1_Container
            // 
            this.fieldListDockPanel1_Container.Location = new System.Drawing.Point(5, 25);
            this.fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container";
            this.fieldListDockPanel1_Container.Size = new System.Drawing.Size(191, 581);
            this.fieldListDockPanel1_Container.TabIndex = 0;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.commonBar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.spreadsheetCommandBarButtonItem1,
            this.spreadsheetCommandBarButtonItem2,
            this.spreadsheetCommandBarButtonItem3,
            this.spreadsheetCommandBarButtonItem4,
            this.spreadsheetCommandBarButtonItem5,
            this.spreadsheetCommandBarButtonItem6,
            this.spreadsheetCommandBarButtonItem7,
            this.spreadsheetCommandBarButtonItem8,
            this.spreadsheetCommandBarButtonItem9,
            this.spreadsheetCommandBarButtonItem10,
            this.spreadsheetCommandBarButtonItem11,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 12;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1503, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 632);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1503, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 603);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1503, 29);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 603);
            // 
            // spreadsheetBarController1
            // 
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem2);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem3);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem4);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem5);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem6);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem7);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem8);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem9);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem10);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem11);
            this.spreadsheetBarController1.Control = this.spreadsheetControl1;
            // 
            // commonBar2
            // 
            this.commonBar2.Control = this.spreadsheetControl1;
            this.commonBar2.DockCol = 0;
            this.commonBar2.DockRow = 0;
            this.commonBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.commonBar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem8),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem10),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem11),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            // 
            // spreadsheetCommandBarButtonItem1
            // 
            this.spreadsheetCommandBarButtonItem1.CommandName = "FileNew";
            this.spreadsheetCommandBarButtonItem1.Id = 1;
            this.spreadsheetCommandBarButtonItem1.Name = "spreadsheetCommandBarButtonItem1";
            // 
            // spreadsheetCommandBarButtonItem2
            // 
            this.spreadsheetCommandBarButtonItem2.CommandName = "FileOpen";
            this.spreadsheetCommandBarButtonItem2.Id = 2;
            this.spreadsheetCommandBarButtonItem2.Name = "spreadsheetCommandBarButtonItem2";
            // 
            // spreadsheetCommandBarButtonItem3
            // 
            this.spreadsheetCommandBarButtonItem3.CommandName = "FileSave";
            this.spreadsheetCommandBarButtonItem3.Id = 3;
            this.spreadsheetCommandBarButtonItem3.Name = "spreadsheetCommandBarButtonItem3";
            // 
            // spreadsheetCommandBarButtonItem4
            // 
            this.spreadsheetCommandBarButtonItem4.CommandName = "FileSaveAs";
            this.spreadsheetCommandBarButtonItem4.Id = 4;
            this.spreadsheetCommandBarButtonItem4.Name = "spreadsheetCommandBarButtonItem4";
            // 
            // spreadsheetCommandBarButtonItem5
            // 
            this.spreadsheetCommandBarButtonItem5.CommandName = "FileQuickPrint";
            this.spreadsheetCommandBarButtonItem5.Id = 5;
            this.spreadsheetCommandBarButtonItem5.Name = "spreadsheetCommandBarButtonItem5";
            // 
            // spreadsheetCommandBarButtonItem6
            // 
            this.spreadsheetCommandBarButtonItem6.CommandName = "FilePrint";
            this.spreadsheetCommandBarButtonItem6.Id = 6;
            this.spreadsheetCommandBarButtonItem6.Name = "spreadsheetCommandBarButtonItem6";
            // 
            // spreadsheetCommandBarButtonItem7
            // 
            this.spreadsheetCommandBarButtonItem7.CommandName = "FilePrintPreview";
            this.spreadsheetCommandBarButtonItem7.Id = 7;
            this.spreadsheetCommandBarButtonItem7.Name = "spreadsheetCommandBarButtonItem7";
            // 
            // spreadsheetCommandBarButtonItem8
            // 
            this.spreadsheetCommandBarButtonItem8.CommandName = "FileUndo";
            this.spreadsheetCommandBarButtonItem8.Id = 8;
            this.spreadsheetCommandBarButtonItem8.Name = "spreadsheetCommandBarButtonItem8";
            // 
            // spreadsheetCommandBarButtonItem9
            // 
            this.spreadsheetCommandBarButtonItem9.CommandName = "FileRedo";
            this.spreadsheetCommandBarButtonItem9.Id = 9;
            this.spreadsheetCommandBarButtonItem9.Name = "spreadsheetCommandBarButtonItem9";
            // 
            // spreadsheetCommandBarButtonItem10
            // 
            this.spreadsheetCommandBarButtonItem10.CommandName = "FileEncrypt";
            this.spreadsheetCommandBarButtonItem10.Id = 10;
            this.spreadsheetCommandBarButtonItem10.Name = "spreadsheetCommandBarButtonItem10";
            // 
            // spreadsheetCommandBarButtonItem11
            // 
            this.spreadsheetCommandBarButtonItem11.CommandName = "FileShowDocumentProperties";
            this.spreadsheetCommandBarButtonItem11.Id = 11;
            this.spreadsheetCommandBarButtonItem11.Name = "spreadsheetCommandBarButtonItem11";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Uploads";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarControl1.Location = new System.Drawing.Point(0, 599);
            this.progressBarControl1.MenuManager = this.barManager1;
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Size = new System.Drawing.Size(1503, 33);
            this.progressBarControl1.TabIndex = 6;
            // 
            // dSPurchaseOrderNew
            // 
            this.dSPurchaseOrderNew.DataSetName = "DSPurchaseOrderNew";
            this.dSPurchaseOrderNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Multi_PO_HBindingSource
            // 
            this.tbl_Multi_PO_HBindingSource.DataMember = "tbl_Multi_PO_H";
            this.tbl_Multi_PO_HBindingSource.DataSource = this.dSPurchaseOrderNew;
            // 
            // tbl_Multi_PO_HTableAdapter
            // 
            this.tbl_Multi_PO_HTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_Multi_PO_CustomerTableAdapter = null;
            this.tableAdapterManager.tbl_Multi_PO_HTableAdapter = this.tbl_Multi_PO_HTableAdapter;
            this.tableAdapterManager.tbl_Multi_PO_MTableAdapter = this.tbl_Multi_PO_MTableAdapter;
            this.tableAdapterManager.tbl_Multi_PO_STableAdapter = null;
            this.tableAdapterManager.tbl_Pro_Article_D_NNTableAdapter = null;
            this.tableAdapterManager.tbl_Pro_Article_DTableAdapter = null;
            this.tableAdapterManager.tbl_Pro_ClientTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ERP_Production.Purchase_Order.DSPurchaseOrderNewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_Multi_PO_MBindingSource
            // 
            this.tbl_Multi_PO_MBindingSource.DataMember = "tbl_Multi_PO_H_tbl_Multi_PO_M";
            this.tbl_Multi_PO_MBindingSource.DataSource = this.tbl_Multi_PO_HBindingSource;
            // 
            // tbl_Multi_PO_MTableAdapter
            // 
            this.tbl_Multi_PO_MTableAdapter.ClearBeforeFill = true;
            // 
            // FrmUpdatesUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 632);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.spreadsheetControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmUpdatesUpload";
            this.Text = "FrmUpdatesUpload";
            this.Load += new System.EventHandler(this.FrmUpdatesUpload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetDockManager1)).EndInit();
            this.fieldListDockPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPurchaseOrderNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Multi_PO_HBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Multi_PO_MBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraSpreadsheet.UI.CommonBar commonBar2;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem1;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem2;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem3;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem4;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem5;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem6;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem7;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem8;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem9;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem10;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraSpreadsheet.UI.CommonBar commonBar1;
        private DevExpress.XtraSpreadsheet.SpreadsheetDockManager spreadsheetDockManager1;
        private DevExpress.XtraSpreadsheet.FieldListDockPanel fieldListDockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer fieldListDockPanel1_Container;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController spreadsheetBarController1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private System.Windows.Forms.BindingSource tbl_Multi_PO_HBindingSource;
        private DSPurchaseOrderNew dSPurchaseOrderNew;
        private DSPurchaseOrderNewTableAdapters.tbl_Multi_PO_HTableAdapter tbl_Multi_PO_HTableAdapter;
        private DSPurchaseOrderNewTableAdapters.TableAdapterManager tableAdapterManager;
        private DSPurchaseOrderNewTableAdapters.tbl_Multi_PO_MTableAdapter tbl_Multi_PO_MTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Multi_PO_MBindingSource;
    }
}