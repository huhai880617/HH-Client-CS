namespace HHMES.DataDictionary
{
    partial class frmROADWAY
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
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkInUse = new DevExpress.XtraEditors.CheckEdit();
            this.gcDetailEditor = new DevExpress.XtraEditors.GroupControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelSearch = new DevExpress.XtraEditors.PanelControl();
            this.btnEmpty = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txt_CODE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.R_ROADWAYID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gvSummary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colENABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATEBY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATETIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFYBY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFYTIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSummary = new DevExpress.XtraGrid.GridControl();
            this.tpSummary.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcBusiness)).BeginInit();
            this.tcBusiness.SuspendLayout();
            this.tpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNavigator)).BeginInit();
            this.gcNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkInUse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetailEditor)).BeginInit();
            this.gcDetailEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSearch)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CODE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_ROADWAYID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // tpSummary
            // 
            this.tpSummary.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control;
            this.tpSummary.Appearance.PageClient.Options.UseBackColor = true;
            this.tpSummary.Controls.Add(this.splitContainer1);
            this.tpSummary.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tpSummary.Size = new System.Drawing.Size(932, 566);
            // 
            // tcBusiness
            // 
            this.tcBusiness.SelectedTabPage = this.tpSummary;
            // 
            // tpDetail
            // 
            this.tpDetail.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control;
            this.tpDetail.Appearance.PageClient.Options.UseBackColor = true;
            this.tpDetail.Controls.Add(this.gcDetailEditor);
            this.tpDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpDetail.Size = new System.Drawing.Size(932, 566);
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
            // 
            // txtFocusForSave
            // 
            this.txtFocusForSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(128, 50);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(163, 20);
            this.txtCode.TabIndex = 52;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(75, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 51;
            this.labelControl1.Text = "编码：";
            // 
            // chkInUse
            // 
            this.chkInUse.Location = new System.Drawing.Point(128, 125);
            this.chkInUse.Name = "chkInUse";
            this.chkInUse.Properties.Caption = "";
            this.chkInUse.Size = new System.Drawing.Size(121, 19);
            this.chkInUse.TabIndex = 58;
            // 
            // gcDetailEditor
            // 
            this.gcDetailEditor.Controls.Add(this.txtName);
            this.gcDetailEditor.Controls.Add(this.labelControl2);
            this.gcDetailEditor.Controls.Add(this.labelControl4);
            this.gcDetailEditor.Controls.Add(this.txtCode);
            this.gcDetailEditor.Controls.Add(this.labelControl1);
            this.gcDetailEditor.Controls.Add(this.chkInUse);
            this.gcDetailEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDetailEditor.Location = new System.Drawing.Point(0, 0);
            this.gcDetailEditor.Name = "gcDetailEditor";
            this.gcDetailEditor.Size = new System.Drawing.Size(932, 566);
            this.gcDetailEditor.TabIndex = 61;
            this.gcDetailEditor.Text = "明细数据";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 20);
            this.txtName.TabIndex = 65;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(75, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 64;
            this.labelControl2.Text = "名称：";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(75, 126);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 61;
            this.labelControl4.Text = "启用：";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcSummary);
            this.splitContainer1.Size = new System.Drawing.Size(932, 566);
            this.splitContainer1.SplitterDistance = 49;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 12;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.btnEmpty);
            this.panelSearch.Controls.Add(this.btnQuery);
            this.panelSearch.Controls.Add(this.pictureBox3);
            this.panelSearch.Controls.Add(this.txt_CODE);
            this.panelSearch.Controls.Add(this.labelControl27);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(932, 49);
            this.panelSearch.TabIndex = 12;
            // 
            // btnEmpty
            // 
            this.btnEmpty.Location = new System.Drawing.Point(829, 8);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(76, 36);
            this.btnEmpty.TabIndex = 21;
            this.btnEmpty.Text = "清空(&E)";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(745, 8);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(73, 37);
            this.btnQuery.TabIndex = 20;
            this.btnQuery.Text = "查询(&S)";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HHMES.DataDictionary.Properties.Resources.find50x50;
            this.pictureBox3.Location = new System.Drawing.Point(5, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // txt_CODE
            // 
            this.txt_CODE.Location = new System.Drawing.Point(143, 11);
            this.txt_CODE.Name = "txt_CODE";
            this.txt_CODE.Size = new System.Drawing.Size(100, 20);
            this.txt_CODE.TabIndex = 14;
            // 
            // labelControl27
            // 
            this.labelControl27.Location = new System.Drawing.Point(99, 13);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(36, 14);
            this.labelControl27.TabIndex = 16;
            this.labelControl27.Text = "编号：";
            // 
            // R_ROADWAYID
            // 
            this.R_ROADWAYID.AutoHeight = false;
            this.R_ROADWAYID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.R_ROADWAYID.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE", "编码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "标识")});
            this.R_ROADWAYID.Name = "R_ROADWAYID";
            // 
            // gvSummary
            // 
            this.gvSummary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODE,
            this.colNAME,
            this.colENABLE,
            this.colCREATEBY,
            this.colCREATETIME,
            this.colMODIFYBY,
            this.colMODIFYTIME});
            this.gvSummary.GridControl = this.gcSummary;
            this.gvSummary.Name = "gvSummary";
            this.gvSummary.OptionsView.ColumnAutoWidth = false;
            this.gvSummary.OptionsView.ShowFooter = true;
            this.gvSummary.OptionsView.ShowGroupPanel = false;
            // 
            // colCODE
            // 
            this.colCODE.Caption = "编码";
            this.colCODE.FieldName = "CODE";
            this.colCODE.Name = "colCODE";
            this.colCODE.Visible = true;
            this.colCODE.VisibleIndex = 0;
            this.colCODE.Width = 105;
            // 
            // colNAME
            // 
            this.colNAME.Caption = "名称";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 1;
            // 
            // colENABLE
            // 
            this.colENABLE.Caption = "启用";
            this.colENABLE.FieldName = "ENABLE";
            this.colENABLE.Name = "colENABLE";
            this.colENABLE.Visible = true;
            this.colENABLE.VisibleIndex = 2;
            // 
            // colCREATEBY
            // 
            this.colCREATEBY.Caption = "创建者";
            this.colCREATEBY.FieldName = "CREATEBY";
            this.colCREATEBY.Name = "colCREATEBY";
            this.colCREATEBY.Visible = true;
            this.colCREATEBY.VisibleIndex = 6;
            // 
            // colCREATETIME
            // 
            this.colCREATETIME.Caption = "创建时间";
            this.colCREATETIME.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss.fff";
            this.colCREATETIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCREATETIME.FieldName = "CREATETIME";
            this.colCREATETIME.Name = "colCREATETIME";
            this.colCREATETIME.Visible = true;
            this.colCREATETIME.VisibleIndex = 4;
            // 
            // colMODIFYBY
            // 
            this.colMODIFYBY.Caption = "修改者";
            this.colMODIFYBY.FieldName = "MODIFYBY";
            this.colMODIFYBY.Name = "colMODIFYBY";
            this.colMODIFYBY.Visible = true;
            this.colMODIFYBY.VisibleIndex = 3;
            // 
            // colMODIFYTIME
            // 
            this.colMODIFYTIME.Caption = "修改时间";
            this.colMODIFYTIME.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss.fff";
            this.colMODIFYTIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colMODIFYTIME.FieldName = "MODIFYTIME";
            this.colMODIFYTIME.Name = "colMODIFYTIME";
            this.colMODIFYTIME.Visible = true;
            this.colMODIFYTIME.VisibleIndex = 5;
            // 
            // gcSummary
            // 
            this.gcSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSummary.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcSummary.Location = new System.Drawing.Point(0, 0);
            this.gcSummary.MainView = this.gvSummary;
            this.gcSummary.Name = "gcSummary";
            this.gcSummary.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.R_ROADWAYID});
            this.gcSummary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gcSummary.Size = new System.Drawing.Size(932, 514);
            this.gcSummary.TabIndex = 11;
            this.gcSummary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSummary});
            // 
            // frmROADWAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(938, 621);
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Name = "frmROADWAY";
            this.Text = "堆垛机资料";
            this.Load += new System.EventHandler(this.frmROADWAY_Load);
            this.tpSummary.ResumeLayout(false);
            this.pnlSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcBusiness)).EndInit();
            this.tcBusiness.ResumeLayout(false);
            this.tpDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNavigator)).EndInit();
            this.gcNavigator.ResumeLayout(false);
            this.gcNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkInUse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetailEditor)).EndInit();
            this.gcDetailEditor.ResumeLayout(false);
            this.gcDetailEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelSearch)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CODE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_ROADWAYID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.CheckEdit chkInUse;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl gcDetailEditor;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.PanelControl panelSearch;
        private DevExpress.XtraEditors.SimpleButton btnEmpty;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DevExpress.XtraEditors.TextEdit txt_CODE;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gcSummary;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSummary;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colENABLE;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATEBY;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATETIME;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFYBY;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFYTIME;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit R_ROADWAYID;
    }
}
