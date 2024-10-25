
namespace ERP_Production.Purchase_Order
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.view_Pro_Customer_MultiLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ERP_Production.Purchase_Order.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.view_CustomerClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Pro_CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Pro_CustomerTableAdapter = new ERP_Production.Purchase_Order.DataSet1TableAdapters.tbl_Pro_CustomerTableAdapter();
            this.tableAdapterManager = new ERP_Production.Purchase_Order.DataSet1TableAdapters.TableAdapterManager();
            this.view_CustomerClientTableAdapter = new ERP_Production.Purchase_Order.DataSet1TableAdapters.view_CustomerClientTableAdapter();
            this.view_Pro_Customer_MultiLineTableAdapter = new ERP_Production.Purchase_Order.DataSet1TableAdapters.View_Pro_Customer_MultiLineTableAdapter();
            this.tbl_Pro_Customer_MultiLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Pro_Customer_MultiLineTableAdapter = new ERP_Production.Purchase_Order.DataSet1TableAdapters.tbl_Pro_Customer_MultiLineTableAdapter();
            this.colCustID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlantCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEntryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Pro_Customer_MultiLineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_CustomerClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Pro_CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Pro_Customer_MultiLineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.simpleButton4);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.simpleButton3);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1097, 494);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.view_Pro_Customer_MultiLineBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 38);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1073, 444);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // view_Pro_Customer_MultiLineBindingSource
            // 
            this.view_Pro_Customer_MultiLineBindingSource.DataMember = "View_Pro_Customer_MultiLine";
            this.view_Pro_Customer_MultiLineBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustID,
            this.colClientName,
            this.colPlantCode,
            this.colCustomerName,
            this.colCompanyCode,
            this.colCountryName,
            this.colBarCode,
            this.colEntryDate});
            this.gridView1.DetailHeight = 404;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(193, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Add New";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(209, 12);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(174, 22);
            this.simpleButton4.StyleController = this.layoutControl1;
            this.simpleButton4.TabIndex = 8;
            this.simpleButton4.Text = "Update";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(387, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(151, 22);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Delete";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(542, 12);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(164, 22);
            this.simpleButton3.StyleController = this.layoutControl1;
            this.simpleButton3.TabIndex = 10;
            this.simpleButton3.Text = "Refresh";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1097, 494);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1077, 448);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(197, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton4;
            this.layoutControlItem5.Location = new System.Drawing.Point(197, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(178, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton2;
            this.layoutControlItem3.Location = new System.Drawing.Point(375, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(155, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton3;
            this.layoutControlItem4.Location = new System.Drawing.Point(530, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(168, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(698, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(379, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // view_CustomerClientBindingSource
            // 
            this.view_CustomerClientBindingSource.DataMember = "view_CustomerClient";
            this.view_CustomerClientBindingSource.DataSource = this.dataSet1;
            // 
            // tbl_Pro_CustomerBindingSource
            // 
            this.tbl_Pro_CustomerBindingSource.DataMember = "tbl_Pro_Customer";
            this.tbl_Pro_CustomerBindingSource.DataSource = this.dataSet1;
            // 
            // tbl_Pro_CustomerTableAdapter
            // 
            this.tbl_Pro_CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_12TableAdapter = null;
            this.tableAdapterManager.tbl_PO_New_LATableAdapter = null;
            this.tableAdapterManager.tbl_PO_New_SizeTableAdapter = null;
            this.tableAdapterManager.tbl_PO_NewTableAdapter = null;
            this.tableAdapterManager.tbl_Pro_Article_DTableAdapter = null;
            this.tableAdapterManager.tbl_Pro_ClientTableAdapter = null;
            this.tableAdapterManager.tbl_Pro_Customer_MultiLineTableAdapter = null;
            this.tableAdapterManager.tbl_Pro_CustomerTableAdapter = this.tbl_Pro_CustomerTableAdapter;
            this.tableAdapterManager.UpdateOrder = ERP_Production.Purchase_Order.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.view_CustomerClientTableAdapter = null;
            // 
            // view_CustomerClientTableAdapter
            // 
            this.view_CustomerClientTableAdapter.ClearBeforeFill = true;
            // 
            // view_Pro_Customer_MultiLineTableAdapter
            // 
            this.view_Pro_Customer_MultiLineTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Pro_Customer_MultiLineBindingSource
            // 
            this.tbl_Pro_Customer_MultiLineBindingSource.DataMember = "tbl_Pro_Customer_MultiLine";
            this.tbl_Pro_Customer_MultiLineBindingSource.DataSource = this.dataSet1;
            // 
            // tbl_Pro_Customer_MultiLineTableAdapter
            // 
            this.tbl_Pro_Customer_MultiLineTableAdapter.ClearBeforeFill = true;
            // 
            // colCustID
            // 
            this.colCustID.FieldName = "CustID";
            this.colCustID.Name = "colCustID";
            // 
            // colClientName
            // 
            this.colClientName.FieldName = "ClientName";
            this.colClientName.Name = "colClientName";
            this.colClientName.Visible = true;
            this.colClientName.VisibleIndex = 0;
            // 
            // colCompanyCode
            // 
            this.colCompanyCode.FieldName = "CompanyCode";
            this.colCompanyCode.Name = "colCompanyCode";
            this.colCompanyCode.Visible = true;
            this.colCompanyCode.VisibleIndex = 3;
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 2;
            // 
            // colPlantCode
            // 
            this.colPlantCode.FieldName = "PlantCode";
            this.colPlantCode.Name = "colPlantCode";
            this.colPlantCode.Visible = true;
            this.colPlantCode.VisibleIndex = 4;
            // 
            // colBarCode
            // 
            this.colBarCode.FieldName = "BarCode";
            this.colBarCode.Name = "colBarCode";
            this.colBarCode.Visible = true;
            this.colBarCode.VisibleIndex = 5;
            // 
            // colEntryDate
            // 
            this.colEntryDate.FieldName = "EntryDate";
            this.colEntryDate.Name = "colEntryDate";
            // 
            // colCountryName
            // 
            this.colCountryName.FieldName = "CountryName";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.Visible = true;
            this.colCountryName.VisibleIndex = 1;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 494);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Pro_Customer_MultiLineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_CustomerClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Pro_CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Pro_Customer_MultiLineBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tbl_Pro_CustomerBindingSource;
        private DataSet1TableAdapters.tbl_Pro_CustomerTableAdapter tbl_Pro_CustomerTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.BindingSource view_CustomerClientBindingSource;
        private DataSet1TableAdapters.view_CustomerClientTableAdapter view_CustomerClientTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource view_Pro_Customer_MultiLineBindingSource;
        private DataSet1TableAdapters.View_Pro_Customer_MultiLineTableAdapter view_Pro_Customer_MultiLineTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Pro_Customer_MultiLineBindingSource;
        private DataSet1TableAdapters.tbl_Pro_Customer_MultiLineTableAdapter tbl_Pro_Customer_MultiLineTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCustID;
        private DevExpress.XtraGrid.Columns.GridColumn colClientName;
        private DevExpress.XtraGrid.Columns.GridColumn colPlantCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryName;
        private DevExpress.XtraGrid.Columns.GridColumn colBarCode;
        private DevExpress.XtraGrid.Columns.GridColumn colEntryDate;
    }
}