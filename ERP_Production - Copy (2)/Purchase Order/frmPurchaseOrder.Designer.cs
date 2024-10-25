
using System;

namespace ERP_Production.Purchase_Order
{
    partial class frmPurchaseOrder
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
            System.Windows.Forms.Label Label9;
            System.Windows.Forms.Label Label8;
            System.Windows.Forms.Label Label6;
            System.Windows.Forms.Label Label1;
            System.Windows.Forms.Label Label14;
            System.Windows.Forms.Label Label13;
            System.Windows.Forms.Label Label12;
            System.Windows.Forms.Label Label7;
            System.Windows.Forms.Label Label5;
            System.Windows.Forms.Label Label4;
            System.Windows.Forms.Label Label3;
            System.Windows.Forms.Label Label2;
            System.Windows.Forms.Label Label10;
            System.Windows.Forms.Label label11;
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseOrder));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dataSet1 = new ERP_Production.Purchase_Order.DataSet1();
            this.tbl_Pro_ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Pro_ClientTableAdapter = new ERP_Production.Purchase_Order.DataSet1TableAdapters.tbl_Pro_ClientTableAdapter();
            this.tableAdapterManager = new ERP_Production.Purchase_Order.DataSet1TableAdapters.TableAdapterManager();
            this.tbl_PO_New_LATableAdapter = new ERP_Production.Purchase_Order.DataSet1TableAdapters.tbl_PO_New_LATableAdapter();
            this.tbl_PO_New_SizeTableAdapter = new ERP_Production.Purchase_Order.DataSet1TableAdapters.tbl_PO_New_SizeTableAdapter();
            this.tbl_PO_NewTableAdapter = new ERP_Production.Purchase_Order.DataSet1TableAdapters.tbl_PO_NewTableAdapter();
            this.tbl_Pro_Article_DTableAdapter = new ERP_Production.Purchase_Order.DataSet1TableAdapters.tbl_Pro_Article_DTableAdapter();
            this.tbl_Pro_CustomerTableAdapter = new ERP_Production.Purchase_Order.DataSet1TableAdapters.tbl_Pro_CustomerTableAdapter();
            this.tbl_PO_NewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PO_New_LABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PO_New_SizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Pro_CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Pro_ArticleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Pro_ArticleTableAdapter = new ERP_Production.Purchase_Order.DataSet1TableAdapters.tbl_Pro_ArticleTableAdapter();
            this.tbl_Pro_Article_DBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.TabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.TabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.GridControl1 = new DevExpress.XtraGrid.GridControl();
            this.view_PoNewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactoryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.artIDLabel1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.TextEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.ModelIDLabel1 = new System.Windows.Forms.Label();
            this.ClientNameComboBox = new System.Windows.Forms.ComboBox();
            this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.CustomerOrderNoTextBox = new System.Windows.Forms.TextBox();
            this.SeparatorControl4 = new DevExpress.XtraEditors.SeparatorControl();
            this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.FectoryCodeEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.TabNavigationPage6 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.PanelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl5 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.view_PoNewLaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLA_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlantCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustReqDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerOrderNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipMode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactoryCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEntryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExFactoryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLPDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecondConfDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastEditDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCancelDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssueStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceiveDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerNumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.ComboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ListBoxControl2 = new DevExpress.XtraEditors.ListBoxControl();
            this.DataNavigator2 = new DevExpress.XtraEditors.DataNavigator();
            this.DataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.TextEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.POCodeComboBox = new System.Windows.Forms.ComboBox();
            this.SeparatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.DateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.ComboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.DateTimeOffsetEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.DateTimeOffsetEdit3 = new DevExpress.XtraEditors.DateEdit();
            this.DateTimeOffsetEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.DateTimeOffsetEdit7 = new DevExpress.XtraEditors.DateEdit();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.TextEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.TabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tbl_Pro_Customer_MultiLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RepositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.RepositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.view_PoNewTableAdapter = new ERP_Production.Purchase_Order.DataSet1TableAdapters.View_PoNewTableAdapter();
            this.view_PoNewLaTableAdapter1 = new ERP_Production.Purchase_Order.DataSet1TableAdapters.View_PoNewLaTableAdapter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tbl_Pro_Customer_MultiLineTableAdapter = new ERP_Production.Purchase_Order.DataSet1TableAdapters.tbl_Pro_Customer_MultiLineTableAdapter();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.defaultLookAndFeel2 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            Label9 = new System.Windows.Forms.Label();
            Label8 = new System.Windows.Forms.Label();
            Label6 = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            Label14 = new System.Windows.Forms.Label();
            Label13 = new System.Windows.Forms.Label();
            Label12 = new System.Windows.Forms.Label();
            Label7 = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            Label4 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            Label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Pro_ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_PO_NewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_PO_New_LABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_PO_New_SizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Pro_CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Pro_ArticleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Pro_Article_DBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabPane1)).BeginInit();
            this.TabPane1.SuspendLayout();
            this.TabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_PoNewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FectoryCodeEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.TabNavigationPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl5)).BeginInit();
            this.layoutControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_PoNewLaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).BeginInit();
            this.layoutControl4.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeOffsetEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeOffsetEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeOffsetEdit3.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeOffsetEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeOffsetEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeOffsetEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeOffsetEdit7.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeOffsetEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Pro_Customer_MultiLineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label9
            // 
            Label9.ForeColor = System.Drawing.Color.Black;
            Label9.Location = new System.Drawing.Point(898, 32);
            Label9.Name = "Label9";
            Label9.Size = new System.Drawing.Size(80, 20);
            Label9.TabIndex = 107;
            Label9.Text = "Ship Method:";
            Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label8
            // 
            Label8.ForeColor = System.Drawing.Color.Black;
            Label8.Location = new System.Drawing.Point(1413, 10);
            Label8.Name = "Label8";
            Label8.Size = new System.Drawing.Size(33, 23);
            Label8.TabIndex = 106;
            Label8.Text = "Line:";
            Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Label8.Visible = false;
            // 
            // Label6
            // 
            Label6.ForeColor = System.Drawing.Color.Black;
            Label6.Location = new System.Drawing.Point(427, 180);
            Label6.Name = "Label6";
            Label6.Size = new System.Drawing.Size(67, 20);
            Label6.TabIndex = 103;
            Label6.Text = "Order Qty:";
            Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            Label1.ForeColor = System.Drawing.Color.Black;
            Label1.Location = new System.Drawing.Point(150, 180);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(67, 20);
            Label1.TabIndex = 102;
            Label1.Text = "Size:";
            Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label14
            // 
            Label14.ForeColor = System.Drawing.Color.Black;
            Label14.Location = new System.Drawing.Point(470, 62);
            Label14.Name = "Label14";
            Label14.Size = new System.Drawing.Size(69, 20);
            Label14.TabIndex = 77;
            Label14.Text = "Entry Date:";
            Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            Label13.ForeColor = System.Drawing.Color.Black;
            Label13.Location = new System.Drawing.Point(898, 60);
            Label13.Name = "Label13";
            Label13.Size = new System.Drawing.Size(80, 20);
            Label13.TabIndex = 76;
            Label13.Text = "Delivery Date:";
            Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label12
            // 
            Label12.ForeColor = System.Drawing.Color.Black;
            Label12.Location = new System.Drawing.Point(682, 60);
            Label12.Name = "Label12";
            Label12.Size = new System.Drawing.Size(67, 20);
            Label12.TabIndex = 75;
            Label12.Text = "L.P Date:";
            Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            Label7.ForeColor = System.Drawing.Color.Black;
            Label7.Location = new System.Drawing.Point(218, 62);
            Label7.Name = "Label7";
            Label7.Size = new System.Drawing.Size(100, 20);
            Label7.TabIndex = 74;
            Label7.Text = "Ex Factory Date:";
            Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            Label5.ForeColor = System.Drawing.Color.Black;
            Label5.Location = new System.Drawing.Point(3, 62);
            Label5.Name = "Label5";
            Label5.Size = new System.Drawing.Size(61, 20);
            Label5.TabIndex = 73;
            Label5.Text = "C.R. Date:";
            Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            Label4.ForeColor = System.Drawing.Color.Black;
            Label4.Location = new System.Drawing.Point(682, 34);
            Label4.Name = "Label4";
            Label4.Size = new System.Drawing.Size(67, 20);
            Label4.TabIndex = 59;
            Label4.Text = "Order Type:";
            Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            Label3.ForeColor = System.Drawing.Color.Black;
            Label3.Location = new System.Drawing.Point(473, 34);
            Label3.Name = "Label3";
            Label3.Size = new System.Drawing.Size(74, 20);
            Label3.TabIndex = 57;
            Label3.Text = "Plant Code:";
            Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            Label2.ForeColor = System.Drawing.Color.Black;
            Label2.Location = new System.Drawing.Point(218, 34);
            Label2.Name = "Label2";
            Label2.Size = new System.Drawing.Size(98, 20);
            Label2.TabIndex = 55;
            Label2.Text = "Line Aggregator:";
            Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label10
            // 
            Label10.ForeColor = System.Drawing.Color.Black;
            Label10.Location = new System.Drawing.Point(2, 34);
            Label10.Name = "Label10";
            Label10.Size = new System.Drawing.Size(61, 20);
            Label10.TabIndex = 40;
            Label10.Text = "PO Code:";
            Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.ForeColor = System.Drawing.Color.Black;
            label11.Location = new System.Drawing.Point(150, 152);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(67, 20);
            label11.TabIndex = 111;
            label11.Text = "Line:";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Pro_ClientBindingSource
            // 
            this.tbl_Pro_ClientBindingSource.DataMember = "tbl_Pro_Client";
            this.tbl_Pro_ClientBindingSource.DataSource = this.dataSet1;
            // 
            // tbl_Pro_ClientTableAdapter
            // 
            this.tbl_Pro_ClientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_12TableAdapter = null;
            this.tableAdapterManager.tbl_PO_New_LATableAdapter = this.tbl_PO_New_LATableAdapter;
            this.tableAdapterManager.tbl_PO_New_SizeTableAdapter = this.tbl_PO_New_SizeTableAdapter;
            this.tableAdapterManager.tbl_PO_NewTableAdapter = this.tbl_PO_NewTableAdapter;
            this.tableAdapterManager.tbl_Pro_Article_DTableAdapter = this.tbl_Pro_Article_DTableAdapter;
            this.tableAdapterManager.tbl_Pro_ClientTableAdapter = this.tbl_Pro_ClientTableAdapter;
            this.tableAdapterManager.tbl_Pro_CountryTableAdapter = null;
            this.tableAdapterManager.tbl_Pro_Customer_MultiLineTableAdapter = null;
            this.tableAdapterManager.tbl_Pro_CustomerTableAdapter = this.tbl_Pro_CustomerTableAdapter;
            this.tableAdapterManager.UpdateOrder = ERP_Production.Purchase_Order.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.view_CustomerClientTableAdapter = null;
            // 
            // tbl_PO_New_LATableAdapter
            // 
            this.tbl_PO_New_LATableAdapter.ClearBeforeFill = true;
            // 
            // tbl_PO_New_SizeTableAdapter
            // 
            this.tbl_PO_New_SizeTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_PO_NewTableAdapter
            // 
            this.tbl_PO_NewTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Pro_Article_DTableAdapter
            // 
            this.tbl_Pro_Article_DTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Pro_CustomerTableAdapter
            // 
            this.tbl_Pro_CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_PO_NewBindingSource
            // 
            this.tbl_PO_NewBindingSource.DataMember = "tbl_Pro_Client_tbl_PO_New";
            this.tbl_PO_NewBindingSource.DataSource = this.tbl_Pro_ClientBindingSource;
            // 
            // tbl_PO_New_LABindingSource
            // 
            this.tbl_PO_New_LABindingSource.DataMember = "tbl_PO_New_tbl_PO_New_LA";
            this.tbl_PO_New_LABindingSource.DataSource = this.tbl_PO_NewBindingSource;
            // 
            // tbl_PO_New_SizeBindingSource
            // 
            this.tbl_PO_New_SizeBindingSource.DataMember = "tbl_PO_New_LA_tbl_PO_New_Size";
            this.tbl_PO_New_SizeBindingSource.DataSource = this.tbl_PO_New_LABindingSource;
            // 
            // tbl_Pro_CustomerBindingSource
            // 
            this.tbl_Pro_CustomerBindingSource.DataMember = "tbl_Pro_Client_tbl_Pro_Customer";
            this.tbl_Pro_CustomerBindingSource.DataSource = this.tbl_Pro_ClientBindingSource;
            // 
            // tbl_Pro_ArticleBindingSource
            // 
            this.tbl_Pro_ArticleBindingSource.DataMember = "tbl_Pro_Client_tbl_Pro_Article";
            this.tbl_Pro_ArticleBindingSource.DataSource = this.tbl_Pro_ClientBindingSource;
            // 
            // tbl_Pro_ArticleTableAdapter
            // 
            this.tbl_Pro_ArticleTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Pro_Article_DBindingSource
            // 
            this.tbl_Pro_Article_DBindingSource.DataMember = "tbl_Pro_Article_tbl_Pro_Article_D";
            this.tbl_Pro_Article_DBindingSource.DataSource = this.tbl_Pro_ArticleBindingSource;
            // 
            // TabPane1
            // 
            this.TabPane1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.TabPane1.Appearance.Options.UseForeColor = true;
            this.TabPane1.AppearanceButton.Normal.ForeColor = System.Drawing.Color.Red;
            this.TabPane1.AppearanceButton.Normal.Options.UseForeColor = true;
            this.TabPane1.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.Olive;
            this.TabPane1.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.TabPane1.Controls.Add(this.TabNavigationPage1);
            this.TabPane1.Controls.Add(this.TabNavigationPage2);
            this.TabPane1.Controls.Add(this.TabNavigationPage6);
            this.TabPane1.Controls.Add(this.TabNavigationPage3);
            this.TabPane1.Location = new System.Drawing.Point(12, 12);
            this.TabPane1.Name = "TabPane1";
            this.TabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.TabNavigationPage2,
            this.TabNavigationPage6});
            this.TabPane1.RegularSize = new System.Drawing.Size(1417, 747);
            this.TabPane1.SelectedPage = this.TabNavigationPage2;
            this.TabPane1.Size = new System.Drawing.Size(1417, 747);
            this.TabPane1.TabIndex = 0;
            this.TabPane1.Text = "Leave Entry";
            // 
            // TabNavigationPage1
            // 
            this.TabNavigationPage1.Caption = "TabNavigationPage1";
            this.TabNavigationPage1.Name = "TabNavigationPage1";
            this.TabNavigationPage1.Size = new System.Drawing.Size(1514, 753);
            // 
            // TabNavigationPage2
            // 
            this.TabNavigationPage2.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TabNavigationPage2.Appearance.Options.UseBackColor = true;
            this.TabNavigationPage2.Caption = "Production Order";
            this.TabNavigationPage2.Controls.Add(this.layoutControl3);
            this.TabNavigationPage2.Controls.Add(this.layoutControl2);
            this.TabNavigationPage2.Name = "TabNavigationPage2";
            this.TabNavigationPage2.Size = new System.Drawing.Size(1417, 714);
            this.TabNavigationPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.TabNavigationPage2_Paint);
            // 
            // layoutControl3
            // 
            this.layoutControl3.Controls.Add(this.GridControl1);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(0, 229);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.Root = this.layoutControlGroup2;
            this.layoutControl3.Size = new System.Drawing.Size(1417, 485);
            this.layoutControl3.TabIndex = 68;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // GridControl1
            // 
            this.GridControl1.DataSource = this.view_PoNewBindingSource;
            this.GridControl1.Location = new System.Drawing.Point(12, 12);
            this.GridControl1.MainView = this.GridView3;
            this.GridControl1.Name = "GridControl1";
            this.GridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit3,
            this.repositoryItemButtonEdit4});
            this.GridControl1.Size = new System.Drawing.Size(1393, 461);
            this.GridControl1.TabIndex = 66;
            this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView3});
            this.GridControl1.Click += new System.EventHandler(this.GridControl1_Click);
            // 
            // view_PoNewBindingSource
            // 
            this.view_PoNewBindingSource.DataMember = "View_PoNew";
            this.view_PoNewBindingSource.DataSource = this.dataSet1;
            // 
            // GridView3
            // 
            this.GridView3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPO,
            this.colClientName,
            this.colPOCode,
            this.colFactoryCode,
            this.colNarration,
            this.colCustCode,
            this.colCustID,
            this.colCustomerOrderNo,
            this.colClientID,
            this.colModelName,
            this.colArtCode,
            this.gridColumn1});
            this.GridView3.DetailHeight = 404;
            this.GridView3.GridControl = this.GridControl1;
            this.GridView3.Name = "GridView3";
            this.GridView3.OptionsView.ShowFooter = true;
            this.GridView3.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colArtCode, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPO, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colPO
            // 
            this.colPO.FieldName = "PO";
            this.colPO.Name = "colPO";
            // 
            // colClientName
            // 
            this.colClientName.FieldName = "ClientName";
            this.colClientName.Name = "colClientName";
            this.colClientName.Visible = true;
            this.colClientName.VisibleIndex = 0;
            // 
            // colPOCode
            // 
            this.colPOCode.FieldName = "POCode";
            this.colPOCode.Name = "colPOCode";
            this.colPOCode.Visible = true;
            this.colPOCode.VisibleIndex = 1;
            // 
            // colFactoryCode
            // 
            this.colFactoryCode.FieldName = "FactoryCode";
            this.colFactoryCode.Name = "colFactoryCode";
            this.colFactoryCode.Visible = true;
            this.colFactoryCode.VisibleIndex = 2;
            // 
            // colNarration
            // 
            this.colNarration.FieldName = "Narration";
            this.colNarration.Name = "colNarration";
            // 
            // colCustCode
            // 
            this.colCustCode.FieldName = "CustCode";
            this.colCustCode.Name = "colCustCode";
            this.colCustCode.Visible = true;
            this.colCustCode.VisibleIndex = 3;
            // 
            // colCustID
            // 
            this.colCustID.FieldName = "CustID";
            this.colCustID.Name = "colCustID";
            // 
            // colCustomerOrderNo
            // 
            this.colCustomerOrderNo.FieldName = "CustomerOrderNo";
            this.colCustomerOrderNo.Name = "colCustomerOrderNo";
            this.colCustomerOrderNo.Visible = true;
            this.colCustomerOrderNo.VisibleIndex = 4;
            // 
            // colClientID
            // 
            this.colClientID.FieldName = "ClientID";
            this.colClientID.Name = "colClientID";
            // 
            // colModelName
            // 
            this.colModelName.FieldName = "ModelName";
            this.colModelName.Name = "colModelName";
            this.colModelName.Visible = true;
            this.colModelName.VisibleIndex = 5;
            // 
            // colArtCode
            // 
            this.colArtCode.FieldName = "ArtCode";
            this.colArtCode.Name = "colArtCode";
            this.colArtCode.Visible = true;
            this.colArtCode.VisibleIndex = 6;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Delete";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEdit3;
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 87;
            // 
            // repositoryItemButtonEdit3
            // 
            this.repositoryItemButtonEdit3.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemButtonEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit3.Name = "repositoryItemButtonEdit3";
            this.repositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit3.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit3_ButtonClick);
            // 
            // repositoryItemButtonEdit4
            // 
            this.repositoryItemButtonEdit4.AutoHeight = false;
            this.repositoryItemButtonEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit4.Name = "repositoryItemButtonEdit4";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1417, 485);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.GridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1397, 465);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.Panel3);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(1417, 229);
            this.layoutControl2.TabIndex = 67;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.artIDLabel1);
            this.Panel3.Controls.Add(this.simpleButton1);
            this.Panel3.Controls.Add(this.TextEdit3);
            this.Panel3.Controls.Add(this.ModelIDLabel1);
            this.Panel3.Controls.Add(this.ClientNameComboBox);
            this.Panel3.Controls.Add(this.LabelControl8);
            this.Panel3.Controls.Add(this.CustomerOrderNoTextBox);
            this.Panel3.Controls.Add(this.SeparatorControl4);
            this.Panel3.Controls.Add(this.LabelControl7);
            this.Panel3.Controls.Add(this.LabelControl3);
            this.Panel3.Controls.Add(this.LabelControl2);
            this.Panel3.Controls.Add(this.LabelControl1);
            this.Panel3.Controls.Add(this.FectoryCodeEdit2);
            this.Panel3.Controls.Add(this.gridLookUpEdit1);
            this.Panel3.Location = new System.Drawing.Point(12, 12);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1393, 205);
            this.Panel3.TabIndex = 47;
            this.Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // artIDLabel1
            // 
            this.artIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_Pro_ArticleBindingSource, "ArtID", true));
            this.artIDLabel1.Location = new System.Drawing.Point(1155, 8);
            this.artIDLabel1.Name = "artIDLabel1";
            this.artIDLabel1.Size = new System.Drawing.Size(60, 21);
            this.artIDLabel1.TabIndex = 48;
            this.artIDLabel1.Text = "label15";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::ERP_Production.Properties.Resources.save_16x16;
            this.simpleButton1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.simpleButton1.Location = new System.Drawing.Point(1048, 107);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(122, 23);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Save Entry";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // TextEdit3
            // 
            this.TextEdit3.Location = new System.Drawing.Point(86, 70);
            this.TextEdit3.Name = "TextEdit3";
            this.TextEdit3.Size = new System.Drawing.Size(204, 22);
            this.TextEdit3.TabIndex = 1;
            // 
            // ModelIDLabel1
            // 
            this.ModelIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_Pro_ArticleBindingSource, "ModelID", true));
            this.ModelIDLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModelIDLabel1.Location = new System.Drawing.Point(1221, 10);
            this.ModelIDLabel1.Name = "ModelIDLabel1";
            this.ModelIDLabel1.Size = new System.Drawing.Size(117, 15);
            this.ModelIDLabel1.TabIndex = 49;
            this.ModelIDLabel1.Text = "Label22";
            // 
            // ClientNameComboBox
            // 
            this.ClientNameComboBox.DataSource = this.tbl_Pro_ClientBindingSource;
            this.ClientNameComboBox.DisplayMember = "ClientName";
            this.ClientNameComboBox.FormattingEnabled = true;
            this.ClientNameComboBox.Location = new System.Drawing.Point(86, 10);
            this.ClientNameComboBox.Name = "ClientNameComboBox";
            this.ClientNameComboBox.Size = new System.Drawing.Size(222, 23);
            this.ClientNameComboBox.TabIndex = 0;
            this.ClientNameComboBox.ValueMember = "ClientID";
            this.ClientNameComboBox.SelectedIndexChanged += new System.EventHandler(this.ClientNameComboBox_SelectedIndexChanged);
            // 
            // LabelControl8
            // 
            this.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LabelControl8.Appearance.Options.UseForeColor = true;
            this.LabelControl8.Location = new System.Drawing.Point(867, 73);
            this.LabelControl8.Name = "LabelControl8";
            this.LabelControl8.Size = new System.Drawing.Size(73, 15);
            this.LabelControl8.TabIndex = 90;
            this.LabelControl8.Text = "Cust. Order #:";
            // 
            // CustomerOrderNoTextBox
            // 
            this.CustomerOrderNoTextBox.Location = new System.Drawing.Point(946, 69);
            this.CustomerOrderNoTextBox.Name = "CustomerOrderNoTextBox";
            this.CustomerOrderNoTextBox.Size = new System.Drawing.Size(224, 23);
            this.CustomerOrderNoTextBox.TabIndex = 6;
            // 
            // SeparatorControl4
            // 
            this.SeparatorControl4.AutoSizeMode = true;
            this.SeparatorControl4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SeparatorControl4.LineAlignment = DevExpress.XtraEditors.Alignment.Far;
            this.SeparatorControl4.Location = new System.Drawing.Point(2, 40);
            this.SeparatorControl4.Name = "SeparatorControl4";
            this.SeparatorControl4.Padding = new System.Windows.Forms.Padding(10);
            this.SeparatorControl4.Size = new System.Drawing.Size(1386, 21);
            this.SeparatorControl4.TabIndex = 8;
            // 
            // LabelControl7
            // 
            this.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LabelControl7.Appearance.Options.UseForeColor = true;
            this.LabelControl7.Location = new System.Drawing.Point(8, 14);
            this.LabelControl7.Name = "LabelControl7";
            this.LabelControl7.Size = new System.Drawing.Size(69, 15);
            this.LabelControl7.TabIndex = 67;
            this.LabelControl7.Text = "Client Name:";
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LabelControl3.Appearance.Options.UseForeColor = true;
            this.LabelControl3.Location = new System.Drawing.Point(538, 73);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(56, 15);
            this.LabelControl3.TabIndex = 63;
            this.LabelControl3.Text = "Artical No.";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LabelControl2.Appearance.Options.UseForeColor = true;
            this.LabelControl2.Location = new System.Drawing.Point(300, 73);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(70, 15);
            this.LabelControl2.TabIndex = 2;
            this.LabelControl2.Text = "Fectory Code";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LabelControl1.Appearance.Options.UseForeColor = true;
            this.LabelControl1.Location = new System.Drawing.Point(37, 73);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(41, 15);
            this.LabelControl1.TabIndex = 61;
            this.LabelControl1.Text = "PO No.:";
            // 
            // FectoryCodeEdit2
            // 
            this.FectoryCodeEdit2.Location = new System.Drawing.Point(380, 70);
            this.FectoryCodeEdit2.Name = "FectoryCodeEdit2";
            this.FectoryCodeEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FectoryCodeEdit2.Properties.Items.AddRange(new object[] {
            "B34001",
            "B34002",
            "B34003",
            "B34004",
            "B34005",
            "B34006",
            "B34007"});
            this.FectoryCodeEdit2.Size = new System.Drawing.Size(149, 22);
            this.FectoryCodeEdit2.TabIndex = 3;
            this.FectoryCodeEdit2.SelectedIndexChanged += new System.EventHandler(this.FectoryCodeEdit2_SelectedIndexChanged);
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(603, 70);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.tbl_Pro_ArticleBindingSource;
            this.gridLookUpEdit1.Properties.DisplayMember = "ArtCode";
            this.gridLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
            this.gridLookUpEdit1.Properties.ValueMember = "ArtCode";
            this.gridLookUpEdit1.Size = new System.Drawing.Size(258, 22);
            this.gridLookUpEdit1.TabIndex = 4;
            this.gridLookUpEdit1.EditValueChanged += new System.EventHandler(this.gridLookUpEdit1_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.searchLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "ClientID";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "ModelID";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "ArtID";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "ArtCode";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "ModelName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "WorkNo";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "FactoryCode";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1417, 229);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Panel3;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1397, 209);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // TabNavigationPage6
            // 
            this.TabNavigationPage6.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.TabNavigationPage6.Appearance.Options.UseBackColor = true;
            this.TabNavigationPage6.Caption = "Line Aggregator";
            this.TabNavigationPage6.Controls.Add(this.PanelControl3);
            this.TabNavigationPage6.Controls.Add(this.panelControl1);
            this.TabNavigationPage6.Name = "TabNavigationPage6";
            this.TabNavigationPage6.Size = new System.Drawing.Size(1417, 714);
            this.TabNavigationPage6.Paint += new System.Windows.Forms.PaintEventHandler(this.TabNavigationPage6_Paint);
            // 
            // PanelControl3
            // 
            this.PanelControl3.AutoSize = true;
            this.PanelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl3.Location = new System.Drawing.Point(0, 710);
            this.PanelControl3.Name = "PanelControl3";
            this.PanelControl3.Size = new System.Drawing.Size(1417, 4);
            this.PanelControl3.TabIndex = 62;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl5);
            this.panelControl1.Controls.Add(this.layoutControl4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1417, 714);
            this.panelControl1.TabIndex = 63;
            // 
            // layoutControl5
            // 
            this.layoutControl5.Controls.Add(this.panelControl4);
            this.layoutControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl5.Location = new System.Drawing.Point(2, 398);
            this.layoutControl5.Name = "layoutControl5";
            this.layoutControl5.Root = this.layoutControlGroup4;
            this.layoutControl5.Size = new System.Drawing.Size(1413, 314);
            this.layoutControl5.TabIndex = 50;
            this.layoutControl5.Text = "layoutControl5";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.gridControl2);
            this.panelControl4.Location = new System.Drawing.Point(12, 12);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1389, 290);
            this.panelControl4.TabIndex = 1;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.view_PoNewLaBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 2);
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1385, 286);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // view_PoNewLaBindingSource
            // 
            this.view_PoNewLaBindingSource.DataMember = "View_PoNewLa";
            this.view_PoNewLaBindingSource.DataSource = this.dataSet1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPO1,
            this.colPOCode1,
            this.colLA_Name,
            this.colLine,
            this.colPlantCode,
            this.colCustReqDate,
            this.colCustomerOrderNo1,
            this.colShipMode,
            this.colArtCode1,
            this.colOrderQty,
            this.colClientName1,
            this.colTID,
            this.colFactoryCode1,
            this.colEntryDate,
            this.colExFactoryDate,
            this.colLPDate,
            this.colSecondConfDate,
            this.colLastEditDate,
            this.colCreationDate,
            this.colCurrentDate,
            this.colCancelDate,
            this.colIssueStatus,
            this.colIssueDate,
            this.colReceiveDate,
            this.colCustCode1,
            this.colCustID1,
            this.colCustomerName1,
            this.colCustomerNumber1,
            this.colCompanyCode1,
            this.colClientID1,
            this.colSize});
            this.gridView1.DetailHeight = 404;
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderQty", null, "(Order Qty: SUM={0:0.##})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPO1, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colPO1
            // 
            this.colPO1.FieldName = "PO";
            this.colPO1.Name = "colPO1";
            // 
            // colPOCode1
            // 
            this.colPOCode1.FieldName = "POCode";
            this.colPOCode1.Name = "colPOCode1";
            this.colPOCode1.Visible = true;
            this.colPOCode1.VisibleIndex = 0;
            // 
            // colLA_Name
            // 
            this.colLA_Name.FieldName = "LA_Name";
            this.colLA_Name.Name = "colLA_Name";
            this.colLA_Name.Visible = true;
            this.colLA_Name.VisibleIndex = 2;
            // 
            // colLine
            // 
            this.colLine.AppearanceCell.Options.UseTextOptions = true;
            this.colLine.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLine.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLine.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colLine.AppearanceHeader.Options.UseTextOptions = true;
            this.colLine.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLine.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLine.FieldName = "Line";
            this.colLine.Name = "colLine";
            this.colLine.Visible = true;
            this.colLine.VisibleIndex = 1;
            // 
            // colPlantCode
            // 
            this.colPlantCode.FieldName = "PlantCode";
            this.colPlantCode.Name = "colPlantCode";
            this.colPlantCode.Visible = true;
            this.colPlantCode.VisibleIndex = 3;
            // 
            // colCustReqDate
            // 
            this.colCustReqDate.FieldName = "CustReqDate";
            this.colCustReqDate.Name = "colCustReqDate";
            this.colCustReqDate.Visible = true;
            this.colCustReqDate.VisibleIndex = 5;
            this.colCustReqDate.Width = 93;
            // 
            // colCustomerOrderNo1
            // 
            this.colCustomerOrderNo1.AppearanceCell.Options.UseTextOptions = true;
            this.colCustomerOrderNo1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerOrderNo1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCustomerOrderNo1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCustomerOrderNo1.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerOrderNo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerOrderNo1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCustomerOrderNo1.FieldName = "CustomerOrderNo";
            this.colCustomerOrderNo1.Name = "colCustomerOrderNo1";
            this.colCustomerOrderNo1.Visible = true;
            this.colCustomerOrderNo1.VisibleIndex = 4;
            this.colCustomerOrderNo1.Width = 116;
            // 
            // colShipMode
            // 
            this.colShipMode.FieldName = "ShipMode";
            this.colShipMode.Name = "colShipMode";
            this.colShipMode.Visible = true;
            this.colShipMode.VisibleIndex = 8;
            // 
            // colArtCode1
            // 
            this.colArtCode1.FieldName = "ArtCode";
            this.colArtCode1.Name = "colArtCode1";
            this.colArtCode1.Visible = true;
            this.colArtCode1.VisibleIndex = 10;
            // 
            // colOrderQty
            // 
            this.colOrderQty.AppearanceCell.Options.UseTextOptions = true;
            this.colOrderQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderQty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colOrderQty.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colOrderQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrderQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderQty.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colOrderQty.FieldName = "OrderQty";
            this.colOrderQty.Name = "colOrderQty";
            this.colOrderQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderQty", "{0:0.##}")});
            this.colOrderQty.Visible = true;
            this.colOrderQty.VisibleIndex = 12;
            // 
            // colClientName1
            // 
            this.colClientName1.FieldName = "ClientName";
            this.colClientName1.Name = "colClientName1";
            // 
            // colTID
            // 
            this.colTID.FieldName = "TID";
            this.colTID.Name = "colTID";
            // 
            // colFactoryCode1
            // 
            this.colFactoryCode1.FieldName = "FactoryCode";
            this.colFactoryCode1.Name = "colFactoryCode1";
            this.colFactoryCode1.Visible = true;
            this.colFactoryCode1.VisibleIndex = 9;
            this.colFactoryCode1.Width = 88;
            // 
            // colEntryDate
            // 
            this.colEntryDate.FieldName = "EntryDate";
            this.colEntryDate.Name = "colEntryDate";
            this.colEntryDate.Visible = true;
            this.colEntryDate.VisibleIndex = 6;
            // 
            // colExFactoryDate
            // 
            this.colExFactoryDate.FieldName = "ExFactoryDate";
            this.colExFactoryDate.Name = "colExFactoryDate";
            this.colExFactoryDate.Visible = true;
            this.colExFactoryDate.VisibleIndex = 7;
            this.colExFactoryDate.Width = 101;
            // 
            // colLPDate
            // 
            this.colLPDate.FieldName = "LPDate";
            this.colLPDate.Name = "colLPDate";
            // 
            // colSecondConfDate
            // 
            this.colSecondConfDate.FieldName = "SecondConfDate";
            this.colSecondConfDate.Name = "colSecondConfDate";
            // 
            // colLastEditDate
            // 
            this.colLastEditDate.FieldName = "LastEditDate";
            this.colLastEditDate.Name = "colLastEditDate";
            // 
            // colCreationDate
            // 
            this.colCreationDate.FieldName = "CreationDate";
            this.colCreationDate.Name = "colCreationDate";
            // 
            // colCurrentDate
            // 
            this.colCurrentDate.FieldName = "CurrentDate";
            this.colCurrentDate.Name = "colCurrentDate";
            // 
            // colCancelDate
            // 
            this.colCancelDate.FieldName = "CancelDate";
            this.colCancelDate.Name = "colCancelDate";
            // 
            // colIssueStatus
            // 
            this.colIssueStatus.FieldName = "IssueStatus";
            this.colIssueStatus.Name = "colIssueStatus";
            // 
            // colIssueDate
            // 
            this.colIssueDate.FieldName = "IssueDate";
            this.colIssueDate.Name = "colIssueDate";
            // 
            // colReceiveDate
            // 
            this.colReceiveDate.FieldName = "ReceiveDate";
            this.colReceiveDate.Name = "colReceiveDate";
            // 
            // colCustCode1
            // 
            this.colCustCode1.FieldName = "CustCode";
            this.colCustCode1.Name = "colCustCode1";
            // 
            // colCustID1
            // 
            this.colCustID1.FieldName = "CustID";
            this.colCustID1.Name = "colCustID1";
            // 
            // colCustomerName1
            // 
            this.colCustomerName1.FieldName = "CustomerName";
            this.colCustomerName1.Name = "colCustomerName1";
            this.colCustomerName1.Visible = true;
            this.colCustomerName1.VisibleIndex = 13;
            // 
            // colCustomerNumber1
            // 
            this.colCustomerNumber1.FieldName = "CustomerNumber";
            this.colCustomerNumber1.Name = "colCustomerNumber1";
            this.colCustomerNumber1.Visible = true;
            this.colCustomerNumber1.VisibleIndex = 14;
            // 
            // colCompanyCode1
            // 
            this.colCompanyCode1.FieldName = "CompanyCode";
            this.colCompanyCode1.Name = "colCompanyCode1";
            this.colCompanyCode1.Visible = true;
            this.colCompanyCode1.VisibleIndex = 15;
            // 
            // colClientID1
            // 
            this.colClientID1.FieldName = "ClientID";
            this.colClientID1.Name = "colClientID1";
            // 
            // colSize
            // 
            this.colSize.FieldName = "Size";
            this.colSize.Name = "colSize";
            this.colSize.Visible = true;
            this.colSize.VisibleIndex = 11;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(1413, 314);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.panelControl4;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1393, 294);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControl4
            // 
            this.layoutControl4.Controls.Add(this.Panel1);
            this.layoutControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl4.Location = new System.Drawing.Point(2, 2);
            this.layoutControl4.Name = "layoutControl4";
            this.layoutControl4.Root = this.layoutControlGroup3;
            this.layoutControl4.Size = new System.Drawing.Size(1413, 396);
            this.layoutControl4.TabIndex = 49;
            this.layoutControl4.Text = "layoutControl4";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.comboBox1);
            this.Panel1.Controls.Add(label11);
            this.Panel1.Controls.Add(this.textEdit6);
            this.Panel1.Controls.Add(this.ComboBoxEdit2);
            this.Panel1.Controls.Add(this.ListBoxControl2);
            this.Panel1.Controls.Add(Label9);
            this.Panel1.Controls.Add(this.DataNavigator2);
            this.Panel1.Controls.Add(Label6);
            this.Panel1.Controls.Add(Label1);
            this.Panel1.Controls.Add(this.DataNavigator1);
            this.Panel1.Controls.Add(this.TextEdit4);
            this.Panel1.Controls.Add(this.POCodeComboBox);
            this.Panel1.Controls.Add(this.SeparatorControl1);
            this.Panel1.Controls.Add(Label14);
            this.Panel1.Controls.Add(Label13);
            this.Panel1.Controls.Add(Label12);
            this.Panel1.Controls.Add(Label7);
            this.Panel1.Controls.Add(Label5);
            this.Panel1.Controls.Add(this.DateEdit1);
            this.Panel1.Controls.Add(this.ComboBoxEdit1);
            this.Panel1.Controls.Add(Label4);
            this.Panel1.Controls.Add(Label3);
            this.Panel1.Controls.Add(Label2);
            this.Panel1.Controls.Add(this.TextEdit1);
            this.Panel1.Controls.Add(Label10);
            this.Panel1.Controls.Add(this.DateTimeOffsetEdit1);
            this.Panel1.Controls.Add(this.DateTimeOffsetEdit3);
            this.Panel1.Controls.Add(this.DateTimeOffsetEdit2);
            this.Panel1.Controls.Add(this.DateTimeOffsetEdit7);
            this.Panel1.Controls.Add(this.searchLookUpEdit1);
            this.Panel1.Controls.Add(Label8);
            this.Panel1.Controls.Add(this.TextEdit5);
            this.Panel1.Location = new System.Drawing.Point(12, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1389, 372);
            this.Panel1.TabIndex = 48;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tbl_PO_NewBindingSource;
            this.comboBox1.DisplayMember = "POCode";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(545, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 23);
            this.comboBox1.TabIndex = 112;
            this.comboBox1.ValueMember = "PO";
            // 
            // textEdit6
            // 
            this.textEdit6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_PO_New_SizeBindingSource, "OrderQty", true));
            this.textEdit6.Location = new System.Drawing.Point(500, 178);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(147, 22);
            this.textEdit6.TabIndex = 110;
            // 
            // ComboBoxEdit2
            // 
            this.ComboBoxEdit2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_PO_New_LABindingSource, "ShipMode", true));
            this.ComboBoxEdit2.EditValue = "By Sea";
            this.ComboBoxEdit2.Location = new System.Drawing.Point(986, 32);
            this.ComboBoxEdit2.Name = "ComboBoxEdit2";
            this.ComboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxEdit2.Properties.Items.AddRange(new object[] {
            "By Sea",
            "By Air",
            "By Sea/Air",
            "By Courier",
            "By Truck"});
            this.ComboBoxEdit2.Size = new System.Drawing.Size(139, 22);
            this.ComboBoxEdit2.TabIndex = 4;
            // 
            // ListBoxControl2
            // 
            this.ListBoxControl2.DataSource = this.tbl_PO_New_LABindingSource;
            this.ListBoxControl2.DisplayMember = "LA_Name";
            this.ListBoxControl2.Location = new System.Drawing.Point(5, 117);
            this.ListBoxControl2.Name = "ListBoxControl2";
            this.ListBoxControl2.Size = new System.Drawing.Size(140, 195);
            this.ListBoxControl2.TabIndex = 109;
            this.ListBoxControl2.ValueMember = "TID";
            // 
            // DataNavigator2
            // 
            this.DataNavigator2.Buttons.CancelEdit.Visible = false;
            this.DataNavigator2.Buttons.EndEdit.Visible = false;
            this.DataNavigator2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.DataNavigator2.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] {
            new DevExpress.XtraEditors.NavigatorCustomButton(9)});
            this.DataNavigator2.DataSource = this.tbl_PO_New_LABindingSource;
            this.DataNavigator2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.DataNavigator2.Location = new System.Drawing.Point(-1, -1);
            this.DataNavigator2.Name = "DataNavigator2";
            this.DataNavigator2.Size = new System.Drawing.Size(532, 24);
            this.DataNavigator2.TabIndex = 10;
            this.DataNavigator2.Text = "DataNavigator2";
            this.DataNavigator2.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.DataNavigator2.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.DataNavigator2_ButtonClick_1);
            this.DataNavigator2.Click += new System.EventHandler(this.DataNavigator2_Click);
            // 
            // DataNavigator1
            // 
            this.DataNavigator1.Buttons.CancelEdit.Visible = false;
            this.DataNavigator1.Buttons.EndEdit.Visible = false;
            this.DataNavigator1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.DataNavigator1.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] {
            new DevExpress.XtraEditors.NavigatorCustomButton(9)});
            this.DataNavigator1.DataSource = this.tbl_PO_New_SizeBindingSource;
            this.DataNavigator1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.DataNavigator1.Location = new System.Drawing.Point(150, 117);
            this.DataNavigator1.Name = "DataNavigator1";
            this.DataNavigator1.Size = new System.Drawing.Size(497, 25);
            this.DataNavigator1.TabIndex = 13;
            this.DataNavigator1.Text = "DataNavigator1";
            this.DataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.DataNavigator1.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.DataNavigator1_ButtonClick_1);
            this.DataNavigator1.Click += new System.EventHandler(this.DataNavigator1_Click);
            // 
            // TextEdit4
            // 
            this.TextEdit4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_PO_New_SizeBindingSource, "Line", true));
            this.TextEdit4.Location = new System.Drawing.Point(223, 150);
            this.TextEdit4.Name = "TextEdit4";
            this.TextEdit4.Size = new System.Drawing.Size(198, 22);
            this.TextEdit4.TabIndex = 12;
            // 
            // POCodeComboBox
            // 
            this.POCodeComboBox.DataSource = this.tbl_PO_NewBindingSource;
            this.POCodeComboBox.DisplayMember = "POCode";
            this.POCodeComboBox.FormattingEnabled = true;
            this.POCodeComboBox.Location = new System.Drawing.Point(66, 31);
            this.POCodeComboBox.Name = "POCodeComboBox";
            this.POCodeComboBox.Size = new System.Drawing.Size(146, 23);
            this.POCodeComboBox.TabIndex = 0;
            this.POCodeComboBox.ValueMember = "PO";
            this.POCodeComboBox.SelectedIndexChanged += new System.EventHandler(this.POCodeComboBox_SelectedIndexChanged);
            // 
            // SeparatorControl1
            // 
            this.SeparatorControl1.AutoSizeMode = true;
            this.SeparatorControl1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SeparatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.SeparatorControl1.Location = new System.Drawing.Point(3, 90);
            this.SeparatorControl1.Name = "SeparatorControl1";
            this.SeparatorControl1.Padding = new System.Windows.Forms.Padding(10);
            this.SeparatorControl1.Size = new System.Drawing.Size(1315, 21);
            this.SeparatorControl1.TabIndex = 85;
            // 
            // DateEdit1
            // 
            this.DateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbl_PO_New_LABindingSource, "EntryDate", true));
            this.DateEdit1.EditValue = new System.DateTime(2024, 7, 23, 15, 2, 46, 0);
            this.DateEdit1.Location = new System.Drawing.Point(545, 60);
            this.DateEdit1.Name = "DateEdit1";
            this.DateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit1.Size = new System.Drawing.Size(131, 22);
            this.DateEdit1.TabIndex = 7;
            // 
            // ComboBoxEdit1
            // 
            this.ComboBoxEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_PO_New_LABindingSource, "OT", true));
            this.ComboBoxEdit1.EditValue = "Original Order";
            this.ComboBoxEdit1.Location = new System.Drawing.Point(753, 32);
            this.ComboBoxEdit1.Name = "ComboBoxEdit1";
            this.ComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxEdit1.Properties.Items.AddRange(new object[] {
            "B-Grade Order",
            "Forcast Stock",
            "Original Order",
            "SMS Ball"});
            this.ComboBoxEdit1.Properties.NullText = "Original Order";
            this.ComboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxEdit1.Size = new System.Drawing.Size(139, 22);
            this.ComboBoxEdit1.TabIndex = 3;
            // 
            // TextEdit1
            // 
            this.TextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_PO_New_LABindingSource, "LA_Name", true));
            this.TextEdit1.Location = new System.Drawing.Point(318, 32);
            this.TextEdit1.Name = "TextEdit1";
            this.TextEdit1.Size = new System.Drawing.Size(146, 22);
            this.TextEdit1.TabIndex = 0;
            // 
            // DateTimeOffsetEdit1
            // 
            this.DateTimeOffsetEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbl_PO_New_LABindingSource, "CustReqDate", true));
            this.DateTimeOffsetEdit1.EditValue = new System.DateTime(2024, 7, 23, 15, 2, 46, 0);
            this.DateTimeOffsetEdit1.Location = new System.Drawing.Point(66, 60);
            this.DateTimeOffsetEdit1.Name = "DateTimeOffsetEdit1";
            this.DateTimeOffsetEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTimeOffsetEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTimeOffsetEdit1.Properties.DisplayFormat.FormatString = "";
            this.DateTimeOffsetEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateTimeOffsetEdit1.Properties.EditFormat.FormatString = "";
            this.DateTimeOffsetEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateTimeOffsetEdit1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.DateTimeOffsetEdit1.Properties.MaskSettings.Set("mask", "d");
            this.DateTimeOffsetEdit1.Properties.UseMaskAsDisplayFormat = true;
            this.DateTimeOffsetEdit1.Size = new System.Drawing.Size(146, 22);
            this.DateTimeOffsetEdit1.TabIndex = 5;
            // 
            // DateTimeOffsetEdit3
            // 
            this.DateTimeOffsetEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbl_PO_New_LABindingSource, "ExFactoryDate", true));
            this.DateTimeOffsetEdit3.EditValue = new System.DateTime(2024, 7, 23, 15, 2, 46, 0);
            this.DateTimeOffsetEdit3.Location = new System.Drawing.Point(318, 60);
            this.DateTimeOffsetEdit3.Name = "DateTimeOffsetEdit3";
            this.DateTimeOffsetEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTimeOffsetEdit3.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTimeOffsetEdit3.Properties.DisplayFormat.FormatString = "";
            this.DateTimeOffsetEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateTimeOffsetEdit3.Properties.EditFormat.FormatString = "";
            this.DateTimeOffsetEdit3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateTimeOffsetEdit3.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.DateTimeOffsetEdit3.Properties.MaskSettings.Set("mask", "d");
            this.DateTimeOffsetEdit3.Properties.UseMaskAsDisplayFormat = true;
            this.DateTimeOffsetEdit3.Size = new System.Drawing.Size(146, 22);
            this.DateTimeOffsetEdit3.TabIndex = 6;
            // 
            // DateTimeOffsetEdit2
            // 
            this.DateTimeOffsetEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbl_PO_New_LABindingSource, "LPDate", true));
            this.DateTimeOffsetEdit2.EditValue = new System.DateTime(2024, 7, 23, 15, 2, 46, 0);
            this.DateTimeOffsetEdit2.Location = new System.Drawing.Point(753, 60);
            this.DateTimeOffsetEdit2.Name = "DateTimeOffsetEdit2";
            this.DateTimeOffsetEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTimeOffsetEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTimeOffsetEdit2.Properties.DisplayFormat.FormatString = "";
            this.DateTimeOffsetEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateTimeOffsetEdit2.Properties.EditFormat.FormatString = "";
            this.DateTimeOffsetEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateTimeOffsetEdit2.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.DateTimeOffsetEdit2.Properties.MaskSettings.Set("mask", "d");
            this.DateTimeOffsetEdit2.Properties.MaskSettings.Set("useAdvancingCaret", null);
            this.DateTimeOffsetEdit2.Properties.UseMaskAsDisplayFormat = true;
            this.DateTimeOffsetEdit2.Size = new System.Drawing.Size(139, 22);
            this.DateTimeOffsetEdit2.TabIndex = 8;
            // 
            // DateTimeOffsetEdit7
            // 
            this.DateTimeOffsetEdit7.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbl_PO_New_LABindingSource, "SecondConfDate", true));
            this.DateTimeOffsetEdit7.EditValue = new System.DateTime(2024, 7, 23, 15, 2, 46, 0);
            this.DateTimeOffsetEdit7.Location = new System.Drawing.Point(986, 60);
            this.DateTimeOffsetEdit7.Name = "DateTimeOffsetEdit7";
            this.DateTimeOffsetEdit7.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTimeOffsetEdit7.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTimeOffsetEdit7.Properties.DisplayFormat.FormatString = "";
            this.DateTimeOffsetEdit7.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateTimeOffsetEdit7.Properties.EditFormat.FormatString = "";
            this.DateTimeOffsetEdit7.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateTimeOffsetEdit7.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.DateTimeOffsetEdit7.Properties.MaskSettings.Set("mask", "d");
            this.DateTimeOffsetEdit7.Properties.UseMaskAsDisplayFormat = true;
            this.DateTimeOffsetEdit7.Size = new System.Drawing.Size(139, 22);
            this.DateTimeOffsetEdit7.TabIndex = 9;
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbl_PO_New_SizeBindingSource, "Size", true));
            this.searchLookUpEdit1.Location = new System.Drawing.Point(223, 178);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClientID", "Client ID", 58, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModelID", "Model ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ArtID", "Art ID", 44, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ArtSize", "Art Size", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.searchLookUpEdit1.Properties.DataSource = this.tbl_Pro_Article_DBindingSource;
            this.searchLookUpEdit1.Properties.DisplayMember = "ArtSize";
            this.searchLookUpEdit1.Properties.ValueMember = "ArtSize";
            this.searchLookUpEdit1.Size = new System.Drawing.Size(198, 22);
            this.searchLookUpEdit1.TabIndex = 11;
            // 
            // TextEdit5
            // 
            this.TextEdit5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_PO_New_LABindingSource, "Line", true));
            this.TextEdit5.Location = new System.Drawing.Point(1416, 36);
            this.TextEdit5.Name = "TextEdit5";
            this.TextEdit5.Size = new System.Drawing.Size(41, 22);
            this.TextEdit5.TabIndex = 1;
            this.TextEdit5.Visible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1413, 396);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Panel1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1393, 376);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // TabNavigationPage3
            // 
            this.TabNavigationPage3.Caption = "TabNavigationPage3";
            this.TabNavigationPage3.Name = "TabNavigationPage3";
            this.TabNavigationPage3.Size = new System.Drawing.Size(1514, 753);
            // 
            // tbl_Pro_Customer_MultiLineBindingSource
            // 
            this.tbl_Pro_Customer_MultiLineBindingSource.DataMember = "tbl_Pro_Client_tbl_Pro_Customer_MultiLine";
            this.tbl_Pro_Customer_MultiLineBindingSource.DataSource = this.tbl_Pro_ClientBindingSource;
            // 
            // RepositoryItemButtonEdit1
            // 
            this.RepositoryItemButtonEdit1.AutoHeight = false;
            this.RepositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1";
            this.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // RepositoryItemButtonEdit2
            // 
            this.RepositoryItemButtonEdit2.AutoHeight = false;
            this.RepositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2";
            // 
            // view_PoNewTableAdapter
            // 
            this.view_PoNewTableAdapter.ClearBeforeFill = true;
            // 
            // view_PoNewLaTableAdapter1
            // 
            this.view_PoNewLaTableAdapter1.ClearBeforeFill = true;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TabPane1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1441, 771);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1441, 771);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TabPane1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1421, 751);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // tbl_Pro_Customer_MultiLineTableAdapter
            // 
            this.tbl_Pro_Customer_MultiLineTableAdapter.ClearBeforeFill = true;
            // 
            // frmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 771);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmPurchaseOrder";
            this.Text = "Production Order";
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Pro_ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_PO_NewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_PO_New_LABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_PO_New_SizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Pro_CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Pro_ArticleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Pro_Article_DBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabPane1)).EndInit();
            this.TabPane1.ResumeLayout(false);
            this.TabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_PoNewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FectoryCodeEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.TabNavigationPage6.ResumeLayout(false);
            this.TabNavigationPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl5)).EndInit();
            this.layoutControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_PoNewLaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).EndInit();
            this.layoutControl4.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeOffsetEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeOffsetEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeOffsetEdit3.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeOffsetEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeOffsetEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeOffsetEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeOffsetEdit7.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeOffsetEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Pro_Customer_MultiLineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        private void CheckButton1_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tbl_Pro_ClientBindingSource;
        private DataSet1TableAdapters.tbl_Pro_ClientTableAdapter tbl_Pro_ClientTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DataSet1TableAdapters.tbl_PO_NewTableAdapter tbl_PO_NewTableAdapter;
        private System.Windows.Forms.BindingSource tbl_PO_NewBindingSource;
        private DataSet1TableAdapters.tbl_PO_New_LATableAdapter tbl_PO_New_LATableAdapter;
        private System.Windows.Forms.BindingSource tbl_PO_New_LABindingSource;
        private DataSet1TableAdapters.tbl_PO_New_SizeTableAdapter tbl_PO_New_SizeTableAdapter;
        private System.Windows.Forms.BindingSource tbl_PO_New_SizeBindingSource;
        private DataSet1TableAdapters.tbl_Pro_CustomerTableAdapter tbl_Pro_CustomerTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Pro_CustomerBindingSource;
        private System.Windows.Forms.BindingSource tbl_Pro_ArticleBindingSource;
        private DataSet1TableAdapters.tbl_Pro_ArticleTableAdapter tbl_Pro_ArticleTableAdapter;
        private DataSet1TableAdapters.tbl_Pro_Article_DTableAdapter tbl_Pro_Article_DTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Pro_Article_DBindingSource;
        internal DevExpress.XtraBars.Navigation.TabPane TabPane1;
        internal DevExpress.XtraBars.Navigation.TabNavigationPage TabNavigationPage1;
        internal DevExpress.XtraBars.Navigation.TabNavigationPage TabNavigationPage2;
        internal System.Windows.Forms.Label ModelIDLabel1;
        internal System.Windows.Forms.Panel Panel3;
        internal DevExpress.XtraEditors.TextEdit TextEdit3;
        internal System.Windows.Forms.ComboBox ClientNameComboBox;
        internal DevExpress.XtraEditors.LabelControl LabelControl8;
        internal System.Windows.Forms.TextBox CustomerOrderNoTextBox;
        internal DevExpress.XtraEditors.SeparatorControl SeparatorControl4;
        internal DevExpress.XtraEditors.LabelControl LabelControl7;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.ComboBoxEdit FectoryCodeEdit2;
        internal DevExpress.XtraBars.Navigation.TabNavigationPage TabNavigationPage6;
        internal System.Windows.Forms.Panel Panel1;
        internal DevExpress.XtraEditors.ComboBoxEdit ComboBoxEdit2;
        internal DevExpress.XtraEditors.ListBoxControl ListBoxControl2;
        internal DevExpress.XtraEditors.TextEdit TextEdit5;
        internal DevExpress.XtraEditors.DataNavigator DataNavigator2;
        internal DevExpress.XtraEditors.DataNavigator DataNavigator1;
        internal DevExpress.XtraEditors.TextEdit TextEdit4;
        internal System.Windows.Forms.ComboBox POCodeComboBox;
        internal DevExpress.XtraEditors.SeparatorControl SeparatorControl1;
        internal DevExpress.XtraEditors.DateEdit DateEdit1;
        internal DevExpress.XtraEditors.ComboBoxEdit ComboBoxEdit1;
        internal DevExpress.XtraEditors.TextEdit TextEdit1;
        internal DevExpress.XtraEditors.DateEdit DateTimeOffsetEdit1;
        internal DevExpress.XtraEditors.DateEdit DateTimeOffsetEdit3;
        internal DevExpress.XtraEditors.DateEdit DateTimeOffsetEdit2;
        internal DevExpress.XtraEditors.DateEdit DateTimeOffsetEdit7;
        internal DevExpress.XtraEditors.PanelControl PanelControl3;
        internal DevExpress.XtraBars.Navigation.TabNavigationPage TabNavigationPage3;
        internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RepositoryItemButtonEdit1;
        internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RepositoryItemButtonEdit2;
        private DevExpress.XtraEditors.SearchLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        internal DevExpress.XtraGrid.GridControl GridControl1;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView3;
        internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit3;
        internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit4;
        private System.Windows.Forms.BindingSource view_PoNewBindingSource;
        private DataSet1TableAdapters.View_PoNewTableAdapter view_PoNewTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colPO;
        private DevExpress.XtraGrid.Columns.GridColumn colClientName;
        private DevExpress.XtraGrid.Columns.GridColumn colPOCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFactoryCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
        private DevExpress.XtraGrid.Columns.GridColumn colCustCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colClientID;
        private DevExpress.XtraGrid.Columns.GridColumn colModelName;
        private DevExpress.XtraGrid.Columns.GridColumn colArtCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource view_PoNewLaBindingSource;
        private DataSet1TableAdapters.View_PoNewLaTableAdapter view_PoNewLaTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colPO1;
        private DevExpress.XtraGrid.Columns.GridColumn colPOCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colLine;
        private DevExpress.XtraGrid.Columns.GridColumn colPlantCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustReqDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerOrderNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colShipMode;
        private DevExpress.XtraGrid.Columns.GridColumn colArtCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderQty;
        private DevExpress.XtraGrid.Columns.GridColumn colLA_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colClientName1;
        private DevExpress.XtraGrid.Columns.GridColumn colTID;
        private DevExpress.XtraGrid.Columns.GridColumn colFactoryCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colEntryDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExFactoryDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLPDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSecondConfDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLastEditDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCancelDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIssueStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colIssueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiveDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustID1;
        private DevExpress.XtraGrid.Columns.GridColumn colClientID1;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControl5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControl layoutControl4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        internal DevExpress.XtraEditors.TextEdit textEdit6;
        private System.Windows.Forms.Label artIDLabel1;
        private System.Windows.Forms.BindingSource tbl_Pro_Customer_MultiLineBindingSource;
        private DataSet1TableAdapters.tbl_Pro_Customer_MultiLineTableAdapter tbl_Pro_Customer_MultiLineTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerNumber1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyCode1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel2;
        internal System.Windows.Forms.ComboBox comboBox1;
    }
}