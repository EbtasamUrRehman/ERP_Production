
namespace ERP_Production
{
    partial class FrmAutoUpload
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutoUpload));
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.commonBar1 = new DevExpress.XtraSpreadsheet.UI.CommonBar();
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
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.spreadsheetBarController1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController(this.components);
            this.dSPurchaseOrderNew = new ERP_Production.Purchase_Order.DSPurchaseOrderNew();
            this.tbl_Multi_PO_HBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Multi_PO_HTableAdapter = new ERP_Production.Purchase_Order.DSPurchaseOrderNewTableAdapters.tbl_Multi_PO_HTableAdapter();
            this.tableAdapterManager = new ERP_Production.Purchase_Order.DSPurchaseOrderNewTableAdapters.TableAdapterManager();
            this.tbl_pro_Article_NNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_pro_Article_NNTableAdapter = new ERP_Production.Purchase_Order.DSPurchaseOrderNewTableAdapters.tbl_pro_Article_NNTableAdapter();
            this.tbl_Multi_PO_MBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Multi_PO_MTableAdapter = new ERP_Production.Purchase_Order.DSPurchaseOrderNewTableAdapters.tbl_Multi_PO_MTableAdapter();
            this.tbl_Multi_PO_SBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Multi_PO_STableAdapter = new ERP_Production.Purchase_Order.DSPurchaseOrderNewTableAdapters.tbl_Multi_PO_STableAdapter();
            this.tbl_Pro_Article_DBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Pro_Article_DTableAdapter = new ERP_Production.Purchase_Order.DSPurchaseOrderNewTableAdapters.tbl_Pro_Article_DTableAdapter();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPurchaseOrderNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Multi_PO_HBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pro_Article_NNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Multi_PO_MBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Multi_PO_SBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Pro_Article_DBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 29);
            this.spreadsheetControl1.MenuManager = this.barManager1;
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Size = new System.Drawing.Size(1218, 571);
            this.spreadsheetControl1.TabIndex = 0;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            this.spreadsheetControl1.Click += new System.EventHandler(this.spreadsheetControl1_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.commonBar1});
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
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 13;
            // 
            // commonBar1
            // 
            this.commonBar1.Control = this.spreadsheetControl1;
            this.commonBar1.DockCol = 0;
            this.commonBar1.DockRow = 0;
            this.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.commonBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem11),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            // 
            // spreadsheetCommandBarButtonItem1
            // 
            this.spreadsheetCommandBarButtonItem1.CommandName = "FileNew";
            this.spreadsheetCommandBarButtonItem1.Id = 0;
            this.spreadsheetCommandBarButtonItem1.Name = "spreadsheetCommandBarButtonItem1";
            // 
            // spreadsheetCommandBarButtonItem2
            // 
            this.spreadsheetCommandBarButtonItem2.CommandName = "FileOpen";
            this.spreadsheetCommandBarButtonItem2.Id = 1;
            this.spreadsheetCommandBarButtonItem2.Name = "spreadsheetCommandBarButtonItem2";
            // 
            // spreadsheetCommandBarButtonItem3
            // 
            this.spreadsheetCommandBarButtonItem3.CommandName = "FileSave";
            this.spreadsheetCommandBarButtonItem3.Id = 2;
            this.spreadsheetCommandBarButtonItem3.Name = "spreadsheetCommandBarButtonItem3";
            // 
            // spreadsheetCommandBarButtonItem4
            // 
            this.spreadsheetCommandBarButtonItem4.CommandName = "FileSaveAs";
            this.spreadsheetCommandBarButtonItem4.Id = 3;
            this.spreadsheetCommandBarButtonItem4.Name = "spreadsheetCommandBarButtonItem4";
            // 
            // spreadsheetCommandBarButtonItem5
            // 
            this.spreadsheetCommandBarButtonItem5.CommandName = "FileQuickPrint";
            this.spreadsheetCommandBarButtonItem5.Id = 4;
            this.spreadsheetCommandBarButtonItem5.Name = "spreadsheetCommandBarButtonItem5";
            // 
            // spreadsheetCommandBarButtonItem6
            // 
            this.spreadsheetCommandBarButtonItem6.CommandName = "FilePrint";
            this.spreadsheetCommandBarButtonItem6.Id = 5;
            this.spreadsheetCommandBarButtonItem6.Name = "spreadsheetCommandBarButtonItem6";
            // 
            // spreadsheetCommandBarButtonItem7
            // 
            this.spreadsheetCommandBarButtonItem7.CommandName = "FilePrintPreview";
            this.spreadsheetCommandBarButtonItem7.Id = 6;
            this.spreadsheetCommandBarButtonItem7.Name = "spreadsheetCommandBarButtonItem7";
            // 
            // spreadsheetCommandBarButtonItem8
            // 
            this.spreadsheetCommandBarButtonItem8.CommandName = "FileUndo";
            this.spreadsheetCommandBarButtonItem8.Id = 7;
            this.spreadsheetCommandBarButtonItem8.Name = "spreadsheetCommandBarButtonItem8";
            // 
            // spreadsheetCommandBarButtonItem9
            // 
            this.spreadsheetCommandBarButtonItem9.CommandName = "FileRedo";
            this.spreadsheetCommandBarButtonItem9.Id = 8;
            this.spreadsheetCommandBarButtonItem9.Name = "spreadsheetCommandBarButtonItem9";
            // 
            // spreadsheetCommandBarButtonItem10
            // 
            this.spreadsheetCommandBarButtonItem10.CommandName = "FileEncrypt";
            this.spreadsheetCommandBarButtonItem10.Id = 9;
            this.spreadsheetCommandBarButtonItem10.Name = "spreadsheetCommandBarButtonItem10";
            // 
            // spreadsheetCommandBarButtonItem11
            // 
            this.spreadsheetCommandBarButtonItem11.CommandName = "FileShowDocumentProperties";
            this.spreadsheetCommandBarButtonItem11.Id = 10;
            this.spreadsheetCommandBarButtonItem11.Name = "spreadsheetCommandBarButtonItem11";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Upload File ";
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.ImageOptions.Image = global::ERP_Production.Properties.Resources.upload_16x16;
            this.barButtonItem1.ImageOptions.LargeImage = global::ERP_Production.Properties.Resources.upload_32x322;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipItem1.Text = "Click To Upload File Date into Database";
            superToolTip1.Items.Add(toolTipItem1);
            this.barButtonItem1.SuperTip = superToolTip1;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Update Dates";
            this.barButtonItem2.Id = 12;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1218, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 600);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1218, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 571);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1218, 29);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 571);
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
            this.tableAdapterManager.tbl_Multi_PO_MTableAdapter = null;
            this.tableAdapterManager.tbl_Multi_PO_STableAdapter = null;
            this.tableAdapterManager.tbl_Pro_Article_D_NNTableAdapter = null;
            this.tableAdapterManager.tbl_Pro_Article_DTableAdapter = null;
            this.tableAdapterManager.tbl_Pro_ClientTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ERP_Production.Purchase_Order.DSPurchaseOrderNewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_pro_Article_NNBindingSource
            // 
            this.tbl_pro_Article_NNBindingSource.DataMember = "tbl_pro_Article_NN";
            this.tbl_pro_Article_NNBindingSource.DataSource = this.dSPurchaseOrderNew;
            // 
            // tbl_pro_Article_NNTableAdapter
            // 
            this.tbl_pro_Article_NNTableAdapter.ClearBeforeFill = true;
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
            // tbl_Multi_PO_SBindingSource
            // 
            this.tbl_Multi_PO_SBindingSource.DataMember = "tbl_Multi_PO_M_tbl_Multi_PO_S";
            this.tbl_Multi_PO_SBindingSource.DataSource = this.tbl_Multi_PO_MBindingSource;
            // 
            // tbl_Multi_PO_STableAdapter
            // 
            this.tbl_Multi_PO_STableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Pro_Article_DBindingSource
            // 
            this.tbl_Pro_Article_DBindingSource.DataMember = "tbl_Pro_Article_D";
            this.tbl_Pro_Article_DBindingSource.DataSource = this.dSPurchaseOrderNew;
            // 
            // tbl_Pro_Article_DTableAdapter
            // 
            this.tbl_Pro_Article_DTableAdapter.ClearBeforeFill = true;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarControl1.Location = new System.Drawing.Point(0, 567);
            this.progressBarControl1.MenuManager = this.barManager1;
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Size = new System.Drawing.Size(1218, 33);
            this.progressBarControl1.TabIndex = 0;
            // 
            // FrmAutoUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 600);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.spreadsheetControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmAutoUpload";
            this.Text = "FrmAutoUpload";
            this.Load += new System.EventHandler(this.FrmAutoUpload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPurchaseOrderNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Multi_PO_HBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pro_Article_NNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Multi_PO_MBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Multi_PO_SBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Pro_Article_DBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraSpreadsheet.UI.CommonBar commonBar1;
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
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController spreadsheetBarController1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource tbl_Multi_PO_HBindingSource;
        private Purchase_Order.DSPurchaseOrderNew dSPurchaseOrderNew;
        private Purchase_Order.DSPurchaseOrderNewTableAdapters.tbl_Multi_PO_HTableAdapter tbl_Multi_PO_HTableAdapter;
        private Purchase_Order.DSPurchaseOrderNewTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tbl_pro_Article_NNBindingSource;
        private Purchase_Order.DSPurchaseOrderNewTableAdapters.tbl_pro_Article_NNTableAdapter tbl_pro_Article_NNTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Multi_PO_MBindingSource;
        private Purchase_Order.DSPurchaseOrderNewTableAdapters.tbl_Multi_PO_MTableAdapter tbl_Multi_PO_MTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Multi_PO_SBindingSource;
        private Purchase_Order.DSPurchaseOrderNewTableAdapters.tbl_Multi_PO_STableAdapter tbl_Multi_PO_STableAdapter;
        private System.Windows.Forms.BindingSource tbl_Pro_Article_DBindingSource;
        private Purchase_Order.DSPurchaseOrderNewTableAdapters.tbl_Pro_Article_DTableAdapter tbl_Pro_Article_DTableAdapter;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}