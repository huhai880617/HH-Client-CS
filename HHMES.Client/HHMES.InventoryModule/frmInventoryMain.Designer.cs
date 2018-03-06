namespace HHMES.InventoryModule
{
    partial class frmInventoryMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInventorySee = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInventoryAlarm = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInventoryAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInventoryHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStockSee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStockCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStockLock = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStockAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStockMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnInvSee = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilReports
            // 
            this.ilReports.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilReports.ImageStream")));
            this.ilReports.Images.SetKeyName(0, "16_ArrayWhite.bmp");
            // 
            // pnlContainer
            // 
            this.pnlContainer.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainer.Appearance.Options.UseBackColor = true;
            this.pnlContainer.Controls.Add(this.panelControl3);
            this.pnlContainer.Controls.Add(this.simpleButton3);
            this.pnlContainer.Controls.Add(this.panelControl2);
            this.pnlContainer.Controls.Add(this.simpleButton2);
            this.pnlContainer.Controls.Add(this.panelControl1);
            this.pnlContainer.Controls.Add(this.simpleButton1);
            this.pnlContainer.Controls.Add(this.panelControl6);
            this.pnlContainer.Controls.Add(this.btnInvSee);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlContainer.Size = new System.Drawing.Size(857, 474);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemInventory});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(857, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "存库模块";
            // 
            // MenuItemInventory
            // 
            this.MenuItemInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemInventorySee,
            this.MenuItemInventoryAlarm,
            this.MenuItemInventoryAccount,
            this.MenuItemInventoryHistory});
            this.MenuItemInventory.Name = "MenuItemInventory";
            this.MenuItemInventory.Size = new System.Drawing.Size(68, 21);
            this.MenuItemInventory.Text = "库存管理";
            // 
            // MenuItemInventorySee
            // 
            this.MenuItemInventorySee.Name = "MenuItemInventorySee";
            this.MenuItemInventorySee.Size = new System.Drawing.Size(124, 22);
            this.MenuItemInventorySee.Text = "库存查看";
            this.MenuItemInventorySee.Click += new System.EventHandler(this.MenuItemInventorySee_Click);
            // 
            // MenuItemInventoryAlarm
            // 
            this.MenuItemInventoryAlarm.Name = "MenuItemInventoryAlarm";
            this.MenuItemInventoryAlarm.Size = new System.Drawing.Size(124, 22);
            this.MenuItemInventoryAlarm.Text = "库存预警";
            // 
            // MenuItemInventoryAccount
            // 
            this.MenuItemInventoryAccount.Name = "MenuItemInventoryAccount";
            this.MenuItemInventoryAccount.Size = new System.Drawing.Size(124, 22);
            this.MenuItemInventoryAccount.Text = "库存结算";
            // 
            // MenuItemInventoryHistory
            // 
            this.MenuItemInventoryHistory.Name = "MenuItemInventoryHistory";
            this.MenuItemInventoryHistory.Size = new System.Drawing.Size(124, 22);
            this.MenuItemInventoryHistory.Text = "库存历史";
            this.MenuItemInventoryHistory.Click += new System.EventHandler(this.MenuItemInventoryHistory_Click);
            // 
            // menuMainInventory
            // 
            this.menuMainInventory.Name = "menuMainInventory";
            this.menuMainInventory.Size = new System.Drawing.Size(81, 24);
            this.menuMainInventory.Text = "库存管理";
            // 
            // menuItemStockSee
            // 
            this.menuItemStockSee.Name = "menuItemStockSee";
            this.menuItemStockSee.Size = new System.Drawing.Size(32, 19);
            // 
            // menuItemStockCheck
            // 
            this.menuItemStockCheck.Name = "menuItemStockCheck";
            this.menuItemStockCheck.Size = new System.Drawing.Size(32, 19);
            // 
            // menuItemStockLock
            // 
            this.menuItemStockLock.Name = "menuItemStockLock";
            this.menuItemStockLock.Size = new System.Drawing.Size(32, 19);
            // 
            // menuItemStockAccounts
            // 
            this.menuItemStockAccounts.Name = "menuItemStockAccounts";
            this.menuItemStockAccounts.Size = new System.Drawing.Size(32, 19);
            // 
            // MenuItemStockMaterial
            // 
            this.MenuItemStockMaterial.Name = "MenuItemStockMaterial";
            this.MenuItemStockMaterial.Size = new System.Drawing.Size(32, 19);
            // 
            // panelControl6
            // 
            this.panelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl6.Controls.Add(this.label11);
            this.panelControl6.Controls.Add(this.label12);
            this.panelControl6.Location = new System.Drawing.Point(126, 42);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(271, 84);
            this.panelControl6.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 14);
            this.label11.TabIndex = 27;
            this.label11.Text = "库存查看\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.OrangeRed;
            this.label12.Location = new System.Drawing.Point(3, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 14);
            this.label12.TabIndex = 26;
            this.label12.Text = "库存查看";
            // 
            // btnInvSee
            // 
            this.btnInvSee.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnInvSee.Location = new System.Drawing.Point(22, 42);
            this.btnInvSee.Name = "btnInvSee";
            this.btnInvSee.Size = new System.Drawing.Size(80, 72);
            this.btnInvSee.TabIndex = 70;
            this.btnInvSee.Text = "库存查看";
            this.btnInvSee.Click += new System.EventHandler(this.MenuItemInventorySee_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Location = new System.Drawing.Point(126, 163);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(271, 84);
            this.panelControl1.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 27;
            this.label1.Text = "库存结算";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 26;
            this.label2.Text = "库存结算";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(22, 163);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(80, 72);
            this.simpleButton1.TabIndex = 72;
            this.simpleButton1.Text = "库存结算";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Location = new System.Drawing.Point(563, 42);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(271, 84);
            this.panelControl2.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 14);
            this.label3.TabIndex = 27;
            this.label3.Text = "库存水位上下限管制,库存保质期,库龄等";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 14);
            this.label4.TabIndex = 26;
            this.label4.Text = "库存预警";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(459, 42);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(80, 72);
            this.simpleButton2.TabIndex = 74;
            this.simpleButton2.Text = "库存预警";
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.label5);
            this.panelControl3.Controls.Add(this.label6);
            this.panelControl3.Location = new System.Drawing.Point(563, 163);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(271, 84);
            this.panelControl3.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 14);
            this.label5.TabIndex = 27;
            this.label5.Text = "库存出入库历史记录";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 14);
            this.label6.TabIndex = 26;
            this.label6.Text = "库存历史";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton3.Location = new System.Drawing.Point(459, 163);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(80, 72);
            this.simpleButton3.TabIndex = 76;
            this.simpleButton3.Text = "库存历史";
            this.simpleButton3.Click += new System.EventHandler(this.MenuItemInventoryHistory_Click);
            // 
            // frmInventoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(857, 474);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmInventoryMain";
            this.Controls.SetChildIndex(this.pnlContainer, 0);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.panelControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMainInventory;
        private System.Windows.Forms.ToolStripMenuItem menuItemStockCheck;
        private System.Windows.Forms.ToolStripMenuItem menuItemStockSee;
        private System.Windows.Forms.ToolStripMenuItem menuItemStockAccounts;
        private System.Windows.Forms.ToolStripMenuItem menuItemStockLock;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStockMaterial;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.SimpleButton btnInvSee;
       
        private System.Windows.Forms.ToolStripMenuItem MenuItemInventory;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInventorySee;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInventoryAlarm;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInventoryAccount;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInventoryHistory;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
