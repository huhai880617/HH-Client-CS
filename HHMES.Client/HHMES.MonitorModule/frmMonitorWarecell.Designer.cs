namespace HHMES.MonitorModule
{
    partial class frmMonitorWarecell
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gcSummary = new DevExpress.XtraGrid.GridControl();
            this.gvSummary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.StockPositionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StockPalletId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StockDtlMaterialCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StockDtlMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StockDtlMaterialQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StockStockType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.StockStockStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.StockCheckStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StockDtlBillNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StockDtlItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StockDtlIsLock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpSummary.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcBusiness)).BeginInit();
            this.tcBusiness.SuspendLayout();
            this.tpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNavigator)).BeginInit();
            this.gcNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // tpSummary
            // 
            this.tpSummary.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control;
            this.tpSummary.Appearance.PageClient.Options.UseBackColor = true;
            this.tpSummary.Controls.Add(this.splitContainer1);
            this.tpSummary.Size = new System.Drawing.Size(844, 483);
            this.tpSummary.Text = "监控界面";
            // 
            // pnlSummary
            // 
            this.pnlSummary.Size = new System.Drawing.Size(851, 513);
            // 
            // tcBusiness
            // 
            this.tcBusiness.Size = new System.Drawing.Size(851, 513);
            // 
            // tpDetail
            // 
            this.tpDetail.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control;
            this.tpDetail.Appearance.PageClient.Options.UseBackColor = true;
            this.tpDetail.Controls.Add(this.gcSummary);
            // 
            // gcNavigator
            // 
            this.gcNavigator.Size = new System.Drawing.Size(851, 26);
            // 
            // controlNavigatorSummary
            // 
            this.controlNavigatorSummary.Buttons.Append.Visible = false;
            this.controlNavigatorSummary.Buttons.CancelEdit.Visible = false;
            this.controlNavigatorSummary.Buttons.Edit.Visible = false;
            this.controlNavigatorSummary.Buttons.EndEdit.Visible = false;
            this.controlNavigatorSummary.Buttons.NextPage.Visible = false;
            this.controlNavigatorSummary.Buttons.PrevPage.Visible = false;
            this.controlNavigatorSummary.Buttons.Remove.Visible = false;
            this.controlNavigatorSummary.Location = new System.Drawing.Point(673, 2);
            // 
            // lblAboutInfo
            // 
            this.lblAboutInfo.Location = new System.Drawing.Point(476, 2);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(844, 483);
            this.splitContainer1.SplitterDistance = 29;
            this.splitContainer1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1号巷道",
            "2号巷道",
            "3号巷道",
            "4号巷道",
            "5号巷道",
            "6号巷道",
            "7号巷道",
            "8号巷道"});
            this.comboBox1.Location = new System.Drawing.Point(716, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(442, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "仓库监控平面图";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 450);
            this.panel1.TabIndex = 1;
            // 
            // gcSummary
            // 
            this.gcSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSummary.Location = new System.Drawing.Point(0, 0);
            this.gcSummary.MainView = this.gvSummary;
            this.gcSummary.Name = "gcSummary";
            this.gcSummary.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2});
            this.gcSummary.Size = new System.Drawing.Size(775, 483);
            this.gcSummary.TabIndex = 4;
            this.gcSummary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSummary});
            // 
            // gvSummary
            // 
            this.gvSummary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.StockPositionId,
            this.StockPalletId,
            this.StockDtlMaterialCode,
            this.StockDtlMaterialName,
            this.StockDtlMaterialQty,
            this.StockStockType,
            this.StockStockStatus,
            this.StockCheckStatus,
            this.StockDtlBillNo,
            this.StockDtlItem,
            this.StockDtlIsLock,
            this.colCreationDate,
            this.colCreatedBy});
            this.gvSummary.GridControl = this.gcSummary;
            this.gvSummary.Name = "gvSummary";
            this.gvSummary.OptionsView.ColumnAutoWidth = false;
            this.gvSummary.OptionsView.ShowFooter = true;
            this.gvSummary.OptionsView.ShowGroupPanel = false;
            // 
            // StockPositionId
            // 
            this.StockPositionId.Caption = "货柜编号";
            this.StockPositionId.FieldName = "Stock_PositionId";
            this.StockPositionId.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.StockPositionId.Name = "StockPositionId";
            this.StockPositionId.SummaryItem.DisplayFormat = "记录：{0}";
            this.StockPositionId.SummaryItem.FieldName = "DocNo";
            this.StockPositionId.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.StockPositionId.Visible = true;
            this.StockPositionId.VisibleIndex = 0;
            this.StockPositionId.Width = 120;
            // 
            // StockPalletId
            // 
            this.StockPalletId.Caption = "托盘编号";
            this.StockPalletId.FieldName = "Stock_PalletId";
            this.StockPalletId.Name = "StockPalletId";
            this.StockPalletId.Visible = true;
            this.StockPalletId.VisibleIndex = 1;
            this.StockPalletId.Width = 120;
            // 
            // StockDtlMaterialCode
            // 
            this.StockDtlMaterialCode.Caption = "物料编码";
            this.StockDtlMaterialCode.FieldName = "StockDtl_MaterialCode";
            this.StockDtlMaterialCode.Name = "StockDtlMaterialCode";
            this.StockDtlMaterialCode.Visible = true;
            this.StockDtlMaterialCode.VisibleIndex = 2;
            this.StockDtlMaterialCode.Width = 120;
            // 
            // StockDtlMaterialName
            // 
            this.StockDtlMaterialName.Caption = "物料名称";
            this.StockDtlMaterialName.FieldName = "StockDtl_MaterialName";
            this.StockDtlMaterialName.Name = "StockDtlMaterialName";
            this.StockDtlMaterialName.Visible = true;
            this.StockDtlMaterialName.VisibleIndex = 3;
            this.StockDtlMaterialName.Width = 120;
            // 
            // StockDtlMaterialQty
            // 
            this.StockDtlMaterialQty.Caption = "数量";
            this.StockDtlMaterialQty.FieldName = "StockDtl_MaterialQty";
            this.StockDtlMaterialQty.Name = "StockDtlMaterialQty";
            this.StockDtlMaterialQty.Visible = true;
            this.StockDtlMaterialQty.VisibleIndex = 4;
            // 
            // StockStockType
            // 
            this.StockStockType.Caption = "库存类型";
            this.StockStockType.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.StockStockType.FieldName = "StockDtl_Type";
            this.StockStockType.Name = "StockStockType";
            this.StockStockType.Visible = true;
            this.StockStockType.VisibleIndex = 5;
            this.StockStockType.Width = 80;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // StockStockStatus
            // 
            this.StockStockStatus.Caption = "库存状态";
            this.StockStockStatus.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.StockStockStatus.FieldName = "StockDtl_Status";
            this.StockStockStatus.Name = "StockStockStatus";
            this.StockStockStatus.Visible = true;
            this.StockStockStatus.VisibleIndex = 6;
            this.StockStockStatus.Width = 80;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            // 
            // StockCheckStatus
            // 
            this.StockCheckStatus.Caption = "质检状态";
            this.StockCheckStatus.FieldName = "StockDtl_IsCheck";
            this.StockCheckStatus.Name = "StockCheckStatus";
            this.StockCheckStatus.Visible = true;
            this.StockCheckStatus.VisibleIndex = 9;
            this.StockCheckStatus.Width = 80;
            // 
            // StockDtlBillNo
            // 
            this.StockDtlBillNo.Caption = "单据单号";
            this.StockDtlBillNo.FieldName = "StockDtl_BillNo";
            this.StockDtlBillNo.Name = "StockDtlBillNo";
            this.StockDtlBillNo.Visible = true;
            this.StockDtlBillNo.VisibleIndex = 7;
            this.StockDtlBillNo.Width = 120;
            // 
            // StockDtlItem
            // 
            this.StockDtlItem.Caption = "单据项次";
            this.StockDtlItem.FieldName = "StockDtl_Item";
            this.StockDtlItem.Name = "StockDtlItem";
            this.StockDtlItem.Visible = true;
            this.StockDtlItem.VisibleIndex = 8;
            // 
            // StockDtlIsLock
            // 
            this.StockDtlIsLock.Caption = "锁定";
            this.StockDtlIsLock.FieldName = "StockDtl_IsLock";
            this.StockDtlIsLock.Name = "StockDtlIsLock";
            this.StockDtlIsLock.Visible = true;
            this.StockDtlIsLock.VisibleIndex = 10;
            // 
            // colCreationDate
            // 
            this.colCreationDate.Caption = "日期";
            this.colCreationDate.FieldName = "CreationDate";
            this.colCreationDate.Name = "colCreationDate";
            this.colCreationDate.Visible = true;
            this.colCreationDate.VisibleIndex = 11;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.Caption = "制单人";
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.Visible = true;
            this.colCreatedBy.VisibleIndex = 12;
            // 
            // frmMonitorWarecell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(851, 539);
            this.Name = "frmMonitorWarecell";
            this.Text = "仓库仓位监控";
            this.tpSummary.ResumeLayout(false);
            this.pnlSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcBusiness)).EndInit();
            this.tcBusiness.ResumeLayout(false);
            this.tpDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNavigator)).EndInit();
            this.gcNavigator.ResumeLayout(false);
            this.gcNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraGrid.GridControl gcSummary;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSummary;
        private DevExpress.XtraGrid.Columns.GridColumn StockPositionId;
        private DevExpress.XtraGrid.Columns.GridColumn StockPalletId;
        private DevExpress.XtraGrid.Columns.GridColumn StockDtlMaterialCode;
        private DevExpress.XtraGrid.Columns.GridColumn StockDtlMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn StockDtlMaterialQty;
        private DevExpress.XtraGrid.Columns.GridColumn StockStockType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn StockStockStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn StockCheckStatus;
        private DevExpress.XtraGrid.Columns.GridColumn StockDtlBillNo;
        private DevExpress.XtraGrid.Columns.GridColumn StockDtlItem;
        private DevExpress.XtraGrid.Columns.GridColumn StockDtlIsLock;
        private DevExpress.XtraGrid.Columns.GridColumn colCreationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
    }
}
