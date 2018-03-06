using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HHMES.Library;
using HHMES.Library.UserControls;
using HHMES.Common;
using HHMES.ORM;
using HHMES.Business;

namespace HHMES.MonitorModule
{
    public partial class frmMonitorConveyor : HHMES.Library.frmBaseDataForm
    {
        DataTable dt;
        public frmMonitorConveyor()
        {
            InitializeComponent();
            
        }

        private void DrawUcConveyor(Panel p, int row, int column)
        {
          
            int w=p.Width/(column+7);
            int h=p.Height/(row+6);
            int l = p.Left +w;
            int t = p.Top +h;
            foreach (Control c in p.Controls)
            {
                if (c is ucConveryor)
                {
                    p.Controls.Remove(c);
                }
                if (c is ucConveryorV)
                {
                    p.Controls.Remove(c);
                }
                else
                {
                    c.Visible = true;
                }
            }
            for (int i = 1; i <= row; i++)
            {
                if (i == 1 || i == 4 || i == 7 || i == 10)
                {
                    for (int j = 1; j <= column; j++)
                    {
                        ucConveryor uc = new ucConveryor();
                        uc.Size = new Size(w, h);
                        uc.Name = string.Format("ucConveyor{0}{1}", i, j);
                        uc.Click += uc_Click;
                        if (dt == null)
                        {
                            if (j == 4 || j == 5 || j == 6 || j == 7 || j == 16)
                            {
                                uc.state = 1;
                            }
                            else
                            {
                                uc.state = 0;
                            }
                        }
                        else
                        {
                            string str=string.Format("cRow={0} and cColumn={1}", i, j);
                            try
                            {
                                uc.state = Convert.ToInt16(dt.Select(str)[0][2].ToString());
                            }
                            catch (Exception ex)
                            {
                                uc.state = 0;
                            }
                        }
                        uc.Left = l + j * w;
                        uc.Top = h + i * h;
                        p.Controls.Add(uc);
                    }
                }
                else if (i == 2 || i == 3 || i == 5 || i == 6 || i == 8 || i == 9)
                {
                    for (int j = 1; j <= column; j++)
                    {
                        
                        if (j == 4 || j == 5 || j == 6 || j == 7 || j == 16)
                        {
                            ucConveryorV uc = new ucConveryorV();
                            uc.Size = new Size(w, h);
                            uc.Name = string.Format("ucConveyor{0}{1}", i, j);
                            uc.Click+=uc_Click;
                            if (dt == null)
                            {
                                if (j == 4 || j == 5 || j == 6 || j == 7 || j == 16)
                                {
                                    uc.state = 1;
                                }
                                else
                                {
                                    uc.state = 0;
                                }
                            }
                            else
                            {
                                string str = string.Format("cRow={0} and cColumn={1}", i, j);
                                try
                                {
                                    uc.state = Convert.ToInt16(dt.Select(str)[0][2].ToString());
                                }
                                catch (Exception ex)
                                {
                                    uc.state = 0;
                                }
                            }
                            uc.Left = l + j * w;
                            uc.Top = h + i * h;
                            p.Controls.Add(uc);
                        }
                    }
                }
            }
        
        }

        void uc_Click(object sender, EventArgs e)
        {
            string txtName = sender.ToString();
            Msg.ShowInformation(txtName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetConveyorState();
            DrawUcConveyor(panel1, 10, 19);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                int x =Convert.ToInt16( textBox3.Text);
                int y = Convert.ToInt16(textBox2.Text);
                int state = Convert.ToInt16(textBox1.Text);
                SetUcConveyorState(x, y, state);
                string sql=string.Format(@"if (exists (select 1 from Tmp_ConveyorMonitor where cRow='{0}' and cColumn='{1}'))
 update Tmp_ConveyorMonitor set cState='{2}' where cRow='{3}' and cColumn='{4}';
 else
 insert into Tmp_ConveyorMonitor(cRow,cColumn,cState) values('{5}','{6}','{7}');
select * from Tmp_ConveyorMonitor;",x,y,state,x,y,x,y,state);
               dt= (new bllCommonDataDict()).ExecuteSqltext(sql,"ConveyorMonitor");
            }
            catch (Exception ex)
            { 
            
            }
        }

        private void SetUcConveyorState(int x, int y, int state)
        {
            try
            {
                if (x == 1 || x == 4 || x == 7||x==10)
                {
                    ucConveryor uc = panel1.Controls.Find(string.Format("ucConveyor{0}{1}", x, y), false)[0] as ucConveryor;
                    uc.state = state;
                }
                else
                {
                    ucConveryorV uc = panel1.Controls.Find(string.Format("ucConveyor{0}{1}", x, y), false)[0] as ucConveryorV;
                    uc.state = state;
                }
            }
            catch (Exception ex)
            { 
                
            }
        }

        private DataTable  GetConveyorState()
        {
            string sql = ("select * from Tmp_ConveyorMonitor ");
            dt = (new bllCommonDataDict()).ExecuteSqltext(sql,"ConveyorMonitor");
            return dt;
        }
    }
}
