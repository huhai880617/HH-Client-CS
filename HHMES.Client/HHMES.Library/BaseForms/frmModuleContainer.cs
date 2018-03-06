
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using HHMES.Interfaces;

namespace HHMES.Library
{
    /// <summary>
    /// 模块主窗体容器
    /// </summary>
    public partial class frmModuleContainer : HHMES.Library.frmBaseChild
    {
        public frmModuleContainer()
        {
            InitializeComponent();
        }

        private void frmModuleContainer_Load(object sender, EventArgs e)
        {
            //
        }

        /// <summary>
        /// 显示模块主窗体容器的按钮
        /// </summary>
        public override void InitButtons()
        {
            IMdiForm mdi = (IMdiForm)this.MdiParent;
            _buttons.AddRange(mdi.MdiButtons);

            _buttons.GetButtonByName("btnClose").Enable = false;
            this.ControlBox = false;
        }
    }
}
