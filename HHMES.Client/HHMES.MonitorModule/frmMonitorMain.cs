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

namespace HHMES.MonitorModule
{
    public partial class frmMonitorMain : HHMES.Library.frmModuleBase
    {

        public frmMonitorMain()
        {
            InitializeComponent();

            _ModuleID = ModuleID.MonitorModule; //设置模块编号
            _ModuleName = ModuleNames.MonitorModule;//设置模块名称
            menuStrip1.Text = ModuleNames.MonitorModule; //与AssemblyModuleEntry.ModuleName定义相同

            this.MainMenuStrip = this.menuStrip1;

            this.SetMenuTag();
        }

        public override MenuStrip GetModuleMenu()
        {
            return this.menuStrip1;
        }

        private void SetMenuTag()
        {
            menuMonitorMain.Tag = new MenuItemTag(MenuType.ItemOwner, (int)ModuleID.MonitorModule, AuthorityCategory.NONE);
            menuItemMonitorStack.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.MonitorModule, AuthorityCategory.NONE);
            menuItemMonitorWarehouse.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.MonitorModule, AuthorityCategory.NONE);
            menuItemMonitorTask.Tag = new MenuItemTag(MenuType.Dialog, (int)ModuleID.MonitorModule, AuthorityCategory.NONE);
            menuItemMonitorAgv.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.MonitorModule, AuthorityCategory.NONE);
            menuItemMonitorCatebin.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.MonitorModule, AuthorityCategory.NONE);
            menuItemMonitorConvylor.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.MonitorModule, AuthorityCategory.NONE);
            menuItemMonitorException.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.MonitorModule, AuthorityCategory.NONE);
            menuItemMonitorInOutPort.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.MonitorModule, AuthorityCategory.NONE);
            
        }

        public override void SetSecurity(object securityInfo)
        {
            base.SetSecurity(securityInfo);

            if (securityInfo is ToolStrip)
            {
                //this.LoadReportList(menuReports, listReports);
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

        /// <summary>
        /// 仓位监控
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemMonitorWarehouse_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.MdiParent as IMdiForm, typeof(frmMonitorWarecell), menuItemMonitorWarehouse);
            //frmMonitorWarecell item = new frmMonitorWarecell();
            //item.Show();
        }

        /// <summary>
        /// 堆垛机监控
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemMonitorStack_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.MdiParent as IMdiForm, typeof(frmMonitorStocker), menuItemMonitorStack);
        }

        private void menuItemMonitorConvylor_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.MdiParent as IMdiForm, typeof(frmMonitorConveyor), menuItemMonitorConvylor);
        }


        
    }
}
