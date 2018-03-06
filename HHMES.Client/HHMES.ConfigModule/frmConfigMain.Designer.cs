namespace HHMES.ConfigModule
{
    partial class frmConfigMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuConfigMain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConfigIn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConfigOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConfigTask = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRF = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConfigPrinter = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConfigDispatch = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConfigWave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConfigExcept = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuConfigMain});
            this.menuStrip1.Location = new System.Drawing.Point(2, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(810, 30);
            this.menuStrip1.TabIndex = 63;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // menuConfigMain
            // 
            this.menuConfigMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemConfigIn,
            this.menuItemConfigOut,
            this.MenuItemConfigWave,
            this.menuItemConfigTask,
            this.MenuItemConfigDispatch,
            this.menuItemRF,
            this.MenuItemConfigPrinter,
            this.MenuItemConfigExcept});
            this.menuConfigMain.Name = "menuConfigMain";
            this.menuConfigMain.Size = new System.Drawing.Size(81, 24);
            this.menuConfigMain.Text = "配置管理";
            // 
            // menuItemConfigIn
            // 
            this.menuItemConfigIn.Name = "menuItemConfigIn";
            this.menuItemConfigIn.Size = new System.Drawing.Size(168, 24);
            this.menuItemConfigIn.Text = "入库配置";
            this.menuItemConfigIn.Click += new System.EventHandler(this.menuItemAR_Click);
            // 
            // menuItemConfigOut
            // 
            this.menuItemConfigOut.Name = "menuItemConfigOut";
            this.menuItemConfigOut.Size = new System.Drawing.Size(168, 24);
            this.menuItemConfigOut.Text = "出库配置";
            this.menuItemConfigOut.Click += new System.EventHandler(this.menuItemAP_Click);
            // 
            // menuItemConfigTask
            // 
            this.menuItemConfigTask.Name = "menuItemConfigTask";
            this.menuItemConfigTask.Size = new System.Drawing.Size(168, 24);
            this.menuItemConfigTask.Text = "任务配置";
            this.menuItemConfigTask.Click += new System.EventHandler(this.menuItemOutstanding_Click);
            // 
            // menuItemRF
            // 
            this.menuItemRF.Name = "menuItemRF";
            this.menuItemRF.Size = new System.Drawing.Size(168, 24);
            this.menuItemRF.Text = "RF终端配置";
            // 
            // MenuItemConfigPrinter
            // 
            this.MenuItemConfigPrinter.Name = "MenuItemConfigPrinter";
            this.MenuItemConfigPrinter.Size = new System.Drawing.Size(168, 24);
            this.MenuItemConfigPrinter.Text = "打印机配置";
            // 
            // MenuItemConfigDispatch
            // 
            this.MenuItemConfigDispatch.Name = "MenuItemConfigDispatch";
            this.MenuItemConfigDispatch.Size = new System.Drawing.Size(168, 24);
            this.MenuItemConfigDispatch.Text = "调度配置";
            // 
            // MenuItemConfigWave
            // 
            this.MenuItemConfigWave.Name = "MenuItemConfigWave";
            this.MenuItemConfigWave.Size = new System.Drawing.Size(168, 24);
            this.MenuItemConfigWave.Text = "波次配置";
            // 
            // MenuItemConfigExcept
            // 
            this.MenuItemConfigExcept.Name = "MenuItemConfigExcept";
            this.MenuItemConfigExcept.Size = new System.Drawing.Size(168, 24);
            this.MenuItemConfigExcept.Text = "异常处理配置";
            // 
            // frmConfigMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.ClientSize = new System.Drawing.Size(814, 631);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmConfigMain";
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuConfigMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemConfigIn;
        private System.Windows.Forms.ToolStripMenuItem menuItemConfigOut;
        private System.Windows.Forms.ToolStripMenuItem menuItemConfigTask;
        private System.Windows.Forms.ToolStripMenuItem menuItemRF;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConfigPrinter;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConfigWave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConfigDispatch;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConfigExcept;

    }
}
