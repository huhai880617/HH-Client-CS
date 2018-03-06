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

namespace HHMES.TaskModule
{
    public partial class frmTaskMain : HHMES.Library.frmModuleBase
    {

        public frmTaskMain ()
        {
            InitializeComponent();

            _ModuleID = ModuleID.TaskModule; //设置模块编号
            _ModuleName = ModuleNames.TaskModule;//设置模块名称
            menuStrip1.Text = ModuleNames.TaskModule; //与AssemblyModuleEntry.ModuleName定义相同

            this.MainMenuStrip = this.menuStrip1;

            this.SetMenuTag();
        }

        public override MenuStrip GetModuleMenu()
        {
            return this.menuStrip1;
        }

        private void SetMenuTag()
        {
            menuTaskMain.Tag = new MenuItemTag(MenuType.ItemOwner, (int)ModuleID.TaskModule, AuthorityCategory.NONE);
            MenuItemTaskAllIn.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.TaskModule, AuthorityCategory.NONE);
            MenuItemTaskAllOut.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.TaskModule, AuthorityCategory.NONE);
            MenuItemTaskSortOut.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.TaskModule, AuthorityCategory.NONE);
            MenuItemTaskSee.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.TaskModule, AuthorityCategory.NONE);
            MenuItemTaskEmptyIn.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.TaskModule, AuthorityCategory.NONE);
            MenuItemTaskAccount.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.TaskModule, AuthorityCategory.NONE);
            MenuItemTaskEmptyOut.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.TaskModule, AuthorityCategory.NONE);
            MenuItemTaskAppendIn.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.TaskModule, AuthorityCategory.NONE);
            MenuItemTaskCheck.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.TaskModule, AuthorityCategory.NONE);
            MenuItemTaskMove.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.TaskModule, AuthorityCategory.NONE);
            MenuItemTaskAdjust.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.TaskModule, AuthorityCategory.NONE);
        }

        public override void SetSecurity(object securityInfo)
        {
            base.SetSecurity(securityInfo);

            if (securityInfo is ToolStrip)
            {
                //this.LoadReportList(menuReports, listReports);
            }
        }

        private void MenuItemTaskSee_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.ParentForm as IMdiForm, typeof(frmTaskSee), MenuItemTaskSee);
            
        }

        private void MenuItemTaskAllOut_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.ParentForm as IMdiForm, typeof(frmTaskAllOut), MenuItemTaskAllOut);
        }

        private void MenuItemTaskAllIn_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.ParentForm as IMdiForm, typeof(frmTaskAllIn), MenuItemTaskAllIn);
        }

        private void MenuItemTaskAppendIn_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.ParentForm as IMdiForm, typeof(frmTaskAppendIn), MenuItemTaskAppendIn);
        }

        private void MenuItemTaskSortOut_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.ParentForm as IMdiForm, typeof(frmTaskSortOut), MenuItemTaskSortOut);
        }

        private void MenuItemTaskEmptyIn_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.ParentForm as IMdiForm, typeof(frmTaskEmptyIn), MenuItemTaskEmptyIn);
        }

        private void MenuItemTaskEmptyOut_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.ParentForm as IMdiForm, typeof(frmTaskEmptyOut), MenuItemTaskEmptyOut);
        }

        private void MenuItemTaskAccount_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.ParentForm as IMdiForm, typeof(frmTaskAccount), MenuItemTaskAccount);
        }

        private void MenuItemTaskMove_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.ParentForm as IMdiForm, typeof(frmTaskMove), MenuItemTaskMove);
        }

        private void MenuItemTaskAdjust_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.ParentForm as IMdiForm, typeof(frmTaskAdjust), MenuItemTaskAdjust);
        }

        private void MenuItemTaskCheck_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.ParentForm as IMdiForm, typeof(frmTaskCheck), MenuItemTaskCheck);
        }

       

    }
}
