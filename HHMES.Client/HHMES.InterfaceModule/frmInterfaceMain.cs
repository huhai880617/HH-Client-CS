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

namespace HHMES.InterfaceModule
{
    public partial class frmInterfaceMain : HHMES.Library.frmModuleBase
    {

        public frmInterfaceMain()
        {
            InitializeComponent();

            _ModuleID = ModuleID.InterfaceModule; //设置模块编号
            _ModuleName = ModuleNames.InterfaceModule;//设置模块名称
            menuStrip1.Text = ModuleNames.InterfaceModule; //与AssemblyModuleEntry.ModuleName定义相同

            this.MainMenuStrip = this.menuStrip1;

            this.SetMenuTag();
        }

        public override MenuStrip GetModuleMenu()
        {
            return this.menuStrip1;
        }

        private void SetMenuTag()
        {
            menuInterfaceMain.Tag = new MenuItemTag(MenuType.ItemOwner, (int)ModuleID.InterfaceModule, AuthorityCategory.NONE);
            menuItemPLC.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.InterfaceModule, AuthorityCategory.DATA_ACTION_VALUE);
            MenuItemPLCMitsubishi.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.InterfaceModule, AuthorityCategory.DATA_ACTION_VALUE);
            MenuItemPLCOrmon.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.InterfaceModule, AuthorityCategory.DATA_ACTION_VALUE);
            MenuItemPLCSimens.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.InterfaceModule, AuthorityCategory.DATA_ACTION_VALUE);
            menuItemDPS.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.InterfaceModule, AuthorityCategory.DATA_ACTION_VALUE);
            MenuItemDB.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.InterfaceModule, AuthorityCategory.DATA_ACTION_VALUE);
            menuItemRFID.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.InterfaceModule, AuthorityCategory.DATA_ACTION_VALUE);
            menuScan.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.InterfaceModule, AuthorityCategory.DATA_ACTION_VALUE); ;
            menuScanDataLogic.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.InterfaceModule, AuthorityCategory.DATA_ACTION_VALUE);
            menuScanLeuze.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.InterfaceModule, AuthorityCategory.DATA_ACTION_VALUE);
            menuScanSick.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.InterfaceModule, AuthorityCategory.DATA_ACTION_VALUE); ;
            //menuAccountMain.Tag = new MenuItemTag(MenuType.ItemOwner, (int)ModuleID.InterfaceModule, AuthorityCategory.NONE);
            //menuItemAR.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.InterfaceModule, AuthorityCategory.BUSINESS_ACTION_VALUE);
            //menuItemAP.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.InterfaceModule, AuthorityCategory.BUSINESS_ACTION_VALUE);
            //menuItemOutstanding.Tag = new MenuItemTag(MenuType.Dialog, (int)ModuleID.InterfaceModule, AuthorityCategory.NONE);
        }

        public override void SetSecurity(object securityInfo)
        {
            base.SetSecurity(securityInfo);

            if (securityInfo is ToolStrip)
            {
               // this.LoadReportList(menuReports, listReports);
            }
        }

    }
}
