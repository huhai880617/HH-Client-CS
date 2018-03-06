using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HHMES.Common;
using HHMES.Interfaces;

namespace HHMES.DataDictionary
{
    //继承框架的子窗体
    public partial class frmTestChild : HHMES.Library.frmBaseChild
    {
        public frmTestChild()
        {
            InitializeComponent();
        }

        private void frmTestChild_Load(object sender, EventArgs e)
        {
            this.InitButtons();
        }

        public override void InitButtons()
        {
            base.InitButtons();
            
            bool salaryRight = (Loginer.CurrentUser.IsAdmin()) || ((ButtonAuthority.EX_01 & this.FormAuthorities) == ButtonAuthority.EX_01);

            if (salaryRight)
            {
                //创建“查看工资”按钮
                IButtonInfo btnViewSalary = this.ToolbarRegister.CreateButton("btnViewSalary", "写面值卡",
                    Globals.LoadBitmap("24_DesignReport.ico"), new Size(57, 28), this.DoViewSalary);

                //在Toolbar上显示
                this._buttons.AddRange(new IButtonInfo[] { btnViewSalary });
            }
        }

        public void DoViewSalary(HHMES.Interfaces.IButtonInfo sender)
        {
            Msg.ShowInformation("打开窗体");
        }

     
    }
}
