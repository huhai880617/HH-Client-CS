
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HHMES.Library
{
    /// <summary>
    ///  对话框窗体基类. 
    /// </summary>
    public partial class frmBaseDialog : frmBase
    {
        public frmBaseDialog()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
