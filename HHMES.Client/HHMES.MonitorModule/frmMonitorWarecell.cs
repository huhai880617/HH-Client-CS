using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HHMES.Library.UserControls;
using HHMES.Common;
using HHMES.Business;
using HHMES.Core;
using HHMES.Models;
using HHMES.Library;
using HHMES.ORM;

namespace HHMES.MonitorModule
{
    public partial class frmMonitorWarecell : HHMES.Library.frmBaseDataForm
    {
        public frmMonitorWarecell()
        {
            InitializeComponent();
            //UI_Init();
        }

        private void UI_Init()
        {
            int row = 1;
            if (comboBox1.SelectedIndex >= 0)
            {
                row = comboBox1.SelectedIndex + 1;
            }
            Cursor curOld = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            panel1.Controls.Clear();
            ucCell uc = new ucCell("自动化仓库",row, 6, 40);
            uc.Size = this.panel1.Size;
            uc.Dock = DockStyle.Fill;
            uc.Parent = this.panel1;
            
            uc.CreateButtons();
            DataTable dt = GetTable(row);
            if (dt != null && dt.Rows.Count > 0)
            {
                uc.SetCellState(dt);
            }
            Cursor.Current = curOld;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UI_Init();
        }

        private DataTable  GetTable(int Row)
        {

            string Sql = string.Format(@"select  cell.WareCell_Name,ISNULL( cell.WareCell_PalletId,'') ,cell.WareCell_State,ISNULL( plt.pallet_status,'0'),   isnull(Pallet_Status,0)+cell.WareCell_State as 'state'
from WMS_WareCell cell LEFT JOIN  WMS_Pallet plt on cell.WareCell_PalletId=plt.Pallet_No where cell.Warecell_Row={0}", Row);
            DataTable dt = (new bllWMS_Stock()).ExecuteSqltext(Sql,"MonitoryWareCell");
            return dt;
        }
    }
}
