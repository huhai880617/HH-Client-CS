using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HHMES.Common;
using HHMES.Library;
using HHMES.Interfaces;

namespace HHMES.InventoryModule
{
    /// <summary>
    /// 库存模块主窗体
    /// </summary>
    public partial class frmInventoryMain : HHMES.Library.frmModuleBase
    {
        public frmInventoryMain()
        {
            InitializeComponent();

            _ModuleID = ModuleID.InventoryModule; //设置模块编号
            _ModuleName = ModuleNames.InventoryModule;//设置模块名称
            menuStrip1.Text = ModuleNames.InventoryModule; //与AssemblyModuleEntry.ModuleName定义相同

            this.MainMenuStrip = this.menuStrip1;

            this.SetMenuTag();
        }

        public override MenuStrip GetModuleMenu()
        {
            return this.menuStrip1;
        }

        private void SetMenuTag()
        {
            menuMainInventory.Tag = new MenuItemTag(MenuType.ItemOwner, (int)ModuleID.InventoryModule, AuthorityCategory.DATA_ACTION_VALUE);
            MenuItemInventorySee.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.InventoryModule, AuthorityCategory.DATA_ACTION_VALUE);
            MenuItemInventoryAccount.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.InventoryModule, AuthorityCategory.DATA_ACTION_VALUE);
            MenuItemInventoryAlarm.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.InventoryModule, AuthorityCategory.DATA_ACTION_VALUE);
            MenuItemInventoryHistory.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.InventoryModule, AuthorityCategory.DATA_ACTION_VALUE);
            
        }

        public override void SetSecurity(object securityInfo)
        {
            base.SetSecurity(securityInfo);

            if (securityInfo is ToolStrip)
            {
                //设置按钮权限
                //btnAdj.Enabled = menuItemStockLock.Enabled;
                //btnCheck.Enabled = menuItemStockCheck.Enabled;
                //btnStockIn.Enabled = menuItemStockSee.Enabled;
                //btnStockOut.Enabled = menuItemStockAccounts.Enabled;
            }

             //this.LoadReportList(menuItemReports, lbReports);
        }

        private void MenuItemInventorySee_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.MdiParent as IMdiForm, typeof(frmWMSInventorySee), MenuItemInventorySee);
        }

        private void MenuItemInventoryHistory_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.MdiParent as IMdiForm, typeof(frmWMSInventoryHistory), MenuItemInventoryHistory);
        }

        

    }
}

