namespace HHMES.ReportModule
{
    partial class frmReportMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuReportMain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReportIn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReportOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReportCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportMove = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReportAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReportAdjust = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReportStock = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReportMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReportCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReportEquipment = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pnlContainer.Size = new System.Drawing.Size(814, 631);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReportMain});
            this.menuStrip1.Location = new System.Drawing.Point(2, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(810, 30);
            this.menuStrip1.TabIndex = 63;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // menuReportMain
            // 
            this.menuReportMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemReportIn,
            this.menuItemReportOut,
            this.menuItemReportCheck,
            this.menuReportMove,
            this.MenuItemReportAccount,
            this.MenuItemReportAdjust,
            this.MenuItemReportStock,
            this.MenuItemReportMaterial,
            this.MenuItemReportCustomer,
            this.MenuItemReportEquipment});
            this.menuReportMain.Name = "menuReportMain";
            this.menuReportMain.Size = new System.Drawing.Size(81, 24);
            this.menuReportMain.Text = "报表管理";
            // 
            // menuItemReportIn
            // 
            this.menuItemReportIn.Name = "menuItemReportIn";
            this.menuItemReportIn.Size = new System.Drawing.Size(152, 24);
            this.menuItemReportIn.Text = "入库报表";
            this.menuItemReportIn.Click += new System.EventHandler(this.menuItemAR_Click);
            // 
            // menuItemReportOut
            // 
            this.menuItemReportOut.Name = "menuItemReportOut";
            this.menuItemReportOut.Size = new System.Drawing.Size(152, 24);
            this.menuItemReportOut.Text = "出库报表";
            this.menuItemReportOut.Click += new System.EventHandler(this.menuItemAP_Click);
            // 
            // menuItemReportCheck
            // 
            this.menuItemReportCheck.Name = "menuItemReportCheck";
            this.menuItemReportCheck.Size = new System.Drawing.Size(152, 24);
            this.menuItemReportCheck.Text = "质检报表";
            this.menuItemReportCheck.Click += new System.EventHandler(this.menuItemOutstanding_Click);
            // 
            // menuReportMove
            // 
            this.menuReportMove.Name = "menuReportMove";
            this.menuReportMove.Size = new System.Drawing.Size(152, 24);
            this.menuReportMove.Text = "移库报表";
            // 
            // MenuItemReportAccount
            // 
            this.MenuItemReportAccount.Name = "MenuItemReportAccount";
            this.MenuItemReportAccount.Size = new System.Drawing.Size(152, 24);
            this.MenuItemReportAccount.Text = "盘点报表";
            // 
            // MenuItemReportAdjust
            // 
            this.MenuItemReportAdjust.Name = "MenuItemReportAdjust";
            this.MenuItemReportAdjust.Size = new System.Drawing.Size(152, 24);
            this.MenuItemReportAdjust.Text = "调整报表";
            // 
            // MenuItemReportStock
            // 
            this.MenuItemReportStock.Name = "MenuItemReportStock";
            this.MenuItemReportStock.Size = new System.Drawing.Size(152, 24);
            this.MenuItemReportStock.Text = "库存报表";
            // 
            // MenuItemReportMaterial
            // 
            this.MenuItemReportMaterial.Name = "MenuItemReportMaterial";
            this.MenuItemReportMaterial.Size = new System.Drawing.Size(152, 24);
            this.MenuItemReportMaterial.Text = "物料报表";
            // 
            // MenuItemReportCustomer
            // 
            this.MenuItemReportCustomer.Name = "MenuItemReportCustomer";
            this.MenuItemReportCustomer.Size = new System.Drawing.Size(152, 24);
            this.MenuItemReportCustomer.Text = "客户报表";
            // 
            // MenuItemReportEquipment
            // 
            this.MenuItemReportEquipment.Name = "MenuItemReportEquipment";
            this.MenuItemReportEquipment.Size = new System.Drawing.Size(152, 24);
            this.MenuItemReportEquipment.Text = "设备报表";
            // 
            // frmReportMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.ClientSize = new System.Drawing.Size(814, 631);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmReportMain";
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuReportMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemReportIn;
        private System.Windows.Forms.ToolStripMenuItem menuItemReportOut;
        private System.Windows.Forms.ToolStripMenuItem menuItemReportCheck;
        private System.Windows.Forms.ToolStripMenuItem menuReportMove;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReportAccount;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReportAdjust;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReportStock;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReportMaterial;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReportCustomer;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReportEquipment;

    }
}
