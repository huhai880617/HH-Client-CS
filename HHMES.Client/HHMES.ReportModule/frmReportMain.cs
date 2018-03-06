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

namespace HHMES.ReportModule
{
    public partial class frmReportMain : HHMES.Library.frmModuleBase
    {

        public frmReportMain()
        {
            InitializeComponent();

            _ModuleID = ModuleID.ReportModule; //设置模块编号
            _ModuleName = ModuleNames.ReportModule;//设置模块名称
            menuStrip1.Text = ModuleNames.ReportModule; //与AssemblyModuleEntry.ModuleName定义相同

            this.MainMenuStrip = this.menuStrip1;

            this.SetMenuTag();
        }

        public override MenuStrip GetModuleMenu()
        {
            return this.menuStrip1;
        }

        private void SetMenuTag()
        {
            menuReportMain.Tag = new MenuItemTag(MenuType.ItemOwner, (int)ModuleID.ReportModule, AuthorityCategory.NONE);
            menuItemReportIn.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.ReportModule, AuthorityCategory.BUSINESS_ACTION_VALUE);
            menuItemReportOut.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.ReportModule, AuthorityCategory.BUSINESS_ACTION_VALUE);
            menuItemReportCheck.Tag = new MenuItemTag(MenuType.Dialog, (int)ModuleID.ReportModule, AuthorityCategory.NONE);
        }

        public override void SetSecurity(object securityInfo)
        {
            base.SetSecurity(securityInfo);

            if (securityInfo is ToolStrip)
            {
                //this.LoadReportList(menuReportMove, listReports);
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
            //HHMES.ReportsFastReport.frmReportAR.Execute("", "");
        }

        private void menuAPRpt_Click(object sender, EventArgs e)
        {
           //HHMES.ReportsFastReport.frmReportAP.Execute("", "");
        }

    }
}
