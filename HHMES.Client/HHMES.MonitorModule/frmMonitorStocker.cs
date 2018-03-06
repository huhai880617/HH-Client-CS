using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HHMES.Library;
using HHMES.Common;
using HHMES.Core;
using HHMES.Library.UserControls;

namespace HHMES.MonitorModule
{
    public partial class frmMonitorStocker : HHMES.Library.frmBaseDataForm
    {
        public frmMonitorStocker()
        {
            InitializeComponent();
            //UI_Init();
        }

        private void UI_Init()
        {
            panel1.Controls.Clear();
            ucWareCell uc = new ucWareCell(8,6,40);
            uc.Size = this.panel1.Size;
            uc.Parent = this.panel1;
            uc.Dock = DockStyle.Fill;
            uc.UI_Init();
        }

        private void btnTaskAllIn_Click(object sender, EventArgs e)
        {
            UI_Init();
        }
    }
}
