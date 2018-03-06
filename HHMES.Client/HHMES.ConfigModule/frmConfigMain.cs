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

namespace HHMES.ConfigModule
{
    public partial class frmConfigMain : HHMES.Library.frmModuleBase
    {

        public frmConfigMain()
        {
            InitializeComponent();

            _ModuleID = ModuleID.ConfigModule; //设置模块编号
            _ModuleName = ModuleNames.ConfigModule;//设置模块名称
            menuStrip1.Text = ModuleNames.ConfigModule; //与AssemblyModuleEntry.ModuleName定义相同

            this.MainMenuStrip = this.menuStrip1;

            this.SetMenuTag();
        }

        public override MenuStrip GetModuleMenu()
        {
            return this.menuStrip1;
        }

        private void SetMenuTag()
        {
            menuConfigMain.Tag = new MenuItemTag(MenuType.ItemOwner, (int)ModuleID.ConfigModule, AuthorityCategory.NONE);
            menuItemConfigIn.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.ConfigModule, AuthorityCategory.BUSINESS_ACTION_VALUE);
            menuItemConfigOut.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.ConfigModule, AuthorityCategory.BUSINESS_ACTION_VALUE);
            menuItemConfigTask.Tag = new MenuItemTag(MenuType.Dialog, (int)ModuleID.ConfigModule, AuthorityCategory.NONE);
        }

        public override void SetSecurity(object securityInfo)
        {
            base.SetSecurity(securityInfo);

            if (securityInfo is ToolStrip)
            {
                //this.LoadReportList(menuItemRF, listReports);
            }
        }

        private void menuItemAR_Click(object sender, EventArgs e)
        {
            //MdiTools.OpenChildForm(this.MdiParent as IMdiForm, typeof(frmAR), menuItemAR);
        }

        private void menuItemAP_Click(object sender, EventArgs e)
        {
            //MdiTools.OpenChildForm(this.MdiParent as IMdiForm, typeof(frmAP), menuItemAP);
        }

        private void menuItemOutstanding_Click(object sender, EventArgs e)
        {
            //frmQueryOutstanding.Execute_Query(OutstandingType.None);
        }

        private void menuARRpt_Click(object sender, EventArgs e)
        {
           // HHMES.ReportsFastReport.frmReportAR.Execute("", "");
        }

        private void menuAPRpt_Click(object sender, EventArgs e)
        {
          // HHMES.ReportsFastReport.frmReportAP.Execute("", "");
        }

    }
}
