namespace HHMES.InterfaceModule
{
    partial class frmInterfaceMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInterfaceMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuInterfaceMain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDPS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPLC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRFID = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScanSick = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScanDataLogic = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScanLeuze = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPLCSimens = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPLCOrmon = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPLCMitsubishi = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilReports
            // 
            this.ilReports.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilReports.ImageStream")));
            this.ilReports.Images.SetKeyName(0, "16_ArrayWhite.bmp");
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.menuStrip1);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlContainer.Size = new System.Drawing.Size(943, 631);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInterfaceMain});
            this.menuStrip1.Location = new System.Drawing.Point(2, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(939, 30);
            this.menuStrip1.TabIndex = 63;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // menuInterfaceMain
            // 
            this.menuInterfaceMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDPS,
            this.menuItemPLC,
            this.menuItemRFID,
            this.menuScan,
            this.MenuItemDB});
            this.menuInterfaceMain.Name = "menuInterfaceMain";
            this.menuInterfaceMain.Size = new System.Drawing.Size(81, 24);
            this.menuInterfaceMain.Text = "接口管理";
            // 
            // menuItemDPS
            // 
            this.menuItemDPS.Name = "menuItemDPS";
            this.menuItemDPS.Size = new System.Drawing.Size(173, 24);
            this.menuItemDPS.Text = "电子拣货DPS";
            // 
            // menuItemPLC
            // 
            this.menuItemPLC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemPLCSimens,
            this.MenuItemPLCOrmon,
            this.MenuItemPLCMitsubishi});
            this.menuItemPLC.Name = "menuItemPLC";
            this.menuItemPLC.Size = new System.Drawing.Size(173, 24);
            this.menuItemPLC.Text = "控制系统PLC";
            // 
            // menuItemRFID
            // 
            this.menuItemRFID.Name = "menuItemRFID";
            this.menuItemRFID.Size = new System.Drawing.Size(173, 24);
            this.menuItemRFID.Text = "无线射频RFID";
            // 
            // menuScan
            // 
            this.menuScan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuScanSick,
            this.menuScanDataLogic,
            this.menuScanLeuze});
            this.menuScan.Name = "menuScan";
            this.menuScan.Size = new System.Drawing.Size(173, 24);
            this.menuScan.Text = "条形码阅读器";
            // 
            // menuScanSick
            // 
            this.menuScanSick.Name = "menuScanSick";
            this.menuScanSick.Size = new System.Drawing.Size(196, 24);
            this.menuScanSick.Text = "Sick阅读器";
            // 
            // menuScanDataLogic
            // 
            this.menuScanDataLogic.Name = "menuScanDataLogic";
            this.menuScanDataLogic.Size = new System.Drawing.Size(196, 24);
            this.menuScanDataLogic.Text = "DataLogic阅读器";
            // 
            // MenuItemDB
            // 
            this.MenuItemDB.Name = "MenuItemDB";
            this.MenuItemDB.Size = new System.Drawing.Size(173, 24);
            this.MenuItemDB.Text = "数据库接口DB";
            // 
            // menuScanLeuze
            // 
            this.menuScanLeuze.Name = "menuScanLeuze";
            this.menuScanLeuze.Size = new System.Drawing.Size(196, 24);
            this.menuScanLeuze.Text = "Leuze阅读器";
            // 
            // MenuItemPLCSimens
            // 
            this.MenuItemPLCSimens.Name = "MenuItemPLCSimens";
            this.MenuItemPLCSimens.Size = new System.Drawing.Size(180, 24);
            this.MenuItemPLCSimens.Text = "SimensPLC";
            // 
            // MenuItemPLCOrmon
            // 
            this.MenuItemPLCOrmon.Name = "MenuItemPLCOrmon";
            this.MenuItemPLCOrmon.Size = new System.Drawing.Size(180, 24);
            this.MenuItemPLCOrmon.Text = "OmronPLC";
            // 
            // MenuItemPLCMitsubishi
            // 
            this.MenuItemPLCMitsubishi.Name = "MenuItemPLCMitsubishi";
            this.MenuItemPLCMitsubishi.Size = new System.Drawing.Size(180, 24);
            this.MenuItemPLCMitsubishi.Text = "MitsubishiPLC";
            // 
            // frmInterfaceMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.ClientSize = new System.Drawing.Size(943, 631);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmInterfaceMain";
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuInterfaceMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemDPS;
        private System.Windows.Forms.ToolStripMenuItem menuItemPLC;
        private System.Windows.Forms.ToolStripMenuItem menuItemRFID;
        private System.Windows.Forms.ToolStripMenuItem menuScan;
        private System.Windows.Forms.ToolStripMenuItem menuScanSick;
        private System.Windows.Forms.ToolStripMenuItem menuScanDataLogic;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDB;
        private System.Windows.Forms.ToolStripMenuItem menuScanLeuze;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPLCSimens;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPLCOrmon;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPLCMitsubishi;

    }
}
