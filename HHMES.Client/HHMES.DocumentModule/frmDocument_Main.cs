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

namespace HHMES.DocumentModule
{
    public partial class frmDocument_Main : HHMES.Library.frmModuleBase
    {
        public frmDocument_Main()
        {
            InitializeComponent();
            _ModuleID = ModuleID.DocumentModule; //设置模块编号
            _ModuleName = ModuleNames.DocumentModule;//设置模块名称
            menuStrip1.Text = ModuleNames.DocumentModule; //与AssemblyModuleEntry.ModuleName定义相同

            this.MainMenuStrip = this.menuStrip1;

            this.SetMenuTag();
        }

        public override MenuStrip GetModuleMenu()
        {
            return this.menuStrip1;
        }

        private void SetMenuTag()
        {
             menuItemWMSBillIn.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.DocumentModule, AuthorityCategory.BUSINESS_ACTION_VALUE + ButtonAuthority.GENERATE);//入库管理
             menuItemWMSBillOut.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.DocumentModule, AuthorityCategory.BUSINESS_ACTION_VALUE + ButtonAuthority.GENERATE);//出库管理
             menuItemWMSCheck.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.DocumentModule, AuthorityCategory.BUSINESS_ACTION_VALUE + ButtonAuthority.GENERATE);//质检管理
             menuItemWMSAccount.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.DocumentModule, AuthorityCategory.BUSINESS_ACTION_VALUE + ButtonAuthority.GENERATE);
             menuItemWMSMove.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.DocumentModule, AuthorityCategory.BUSINESS_ACTION_VALUE + ButtonAuthority.GENERATE);
             menuItemWMSAdjust.Tag = new MenuItemTag(MenuType.DataForm, (int)ModuleID.DocumentModule, AuthorityCategory.BUSINESS_ACTION_VALUE + ButtonAuthority.GENERATE);

        }

        public override void SetSecurity(object securityInfo)
        {
            base.SetSecurity(securityInfo);

            if (securityInfo is ToolStrip)
            {
                //设置按钮权限
                btnCheck.Enabled = menuItemWMSAccount.Enabled;
                btnStockIn.Enabled = menuItemWMSBillIn.Enabled;
                btnStockOut.Enabled = menuItemWMSBillOut.Enabled;
                btnQcCheck.Enabled = menuItemWMSCheck.Enabled;
                btnStockMove.Enabled = menuItemWMSMove.Enabled;
                btnAdjust.Enabled = menuItemWMSAdjust.Enabled;
            }

           //  this.LoadReportList(menuItemWMSReports, lbReports);
        }

        private void menuItemWMSBillIn_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.MdiParent as IMdiForm, typeof(frmWMS_BillIn), menuItemWMSBillIn);
        }

        private void menuItemWMSBillOut_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.MdiParent as IMdiForm, typeof(frmWMS_BillOut), menuItemWMSBillOut);
        }

        private void menuItemWMSAccount_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.MdiParent as IMdiForm, typeof(frmWMS_BillAccount), menuItemWMSAccount);
        }

        private void menuItemWMSCheck_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.MdiParent as IMdiForm, typeof(frmWMS_BillCheck), menuItemWMSCheck);
        }

        private void menuItemWMSMove_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.MdiParent as IMdiForm, typeof(frmWMS_BillMove), menuItemWMSMove);
        }


        private void menuItemWMSAdjust_Click(object sender, EventArgs e)
        {
            MdiTools.OpenChildForm(this.MdiParent as IMdiForm, typeof(frmWMS_BillAdjust), menuItemWMSAdjust);
        }

     
    }
}
