using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace HHMES.Library.UserControls
{
   

    public partial class ucStocker : UserControl
    {
        #region
        private int row;
        public int Row
        {
            get { return row; }
            set
            {
                if (value > 0 && value != row)
                { row = value; }
            }
        }
        private int column;
        public int Column
        {
            get { return column; }
            set
            {
                if (value > 0 && value != column)
                { column = value; }
            }
        }
        private int layer;
        public int Layer
        {
            get { return layer; }
            set
            {
                if (value > 0 && value != layer)
                { layer = value; }
            }
        }

        public int stocker_type = 1;

        #endregion
         
        public ucStocker(int r, int c,int type )
        {
            InitializeComponent();
            Row = r;
            Column = c;
            stocker_type = type;
          //  UI_Init();
            
        }
        /// <summary>
        /// 
        /// </summary>
        private void UI_Init()
        {
            try
            {
                int tRow = row + row / 2 + 3;
                int tColumn = column + stocker_type + 2;
                TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
                tableLayoutPanel1.Dock = DockStyle.Fill;
                tableLayoutPanel1.Margin = new Padding(1, 1, 1, 1);
                this.Controls.Add(tableLayoutPanel1);
                //tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
                tableLayoutPanel1.Controls.Clear();
                DynamicLayout(tableLayoutPanel1, tRow, tColumn);


                for (int i = 1; i <= row; i++)
                {
                    int r = r = i + i / 2 + 1; ;
                    //绘制站台
                    if (stocker_type == 1)
                    {
                        DevExpress.XtraEditors.SimpleButton sbt = new DevExpress.XtraEditors.SimpleButton();
                        sbt.Name = string.Format("btnS{0:D3}C1", i);
                        sbt.Dock = DockStyle.Fill;
                        sbt.Click += new EventHandler(sbt_Click);
                        tableLayoutPanel1.Controls.Add(sbt, 1, r);
                    }
                    else if (stocker_type == 2)
                    {
                        DevExpress.XtraEditors.SimpleButton sbt = new DevExpress.XtraEditors.SimpleButton();
                        sbt.Name = string.Format("btnS{0:D3}C1", i);
                        sbt.Dock = DockStyle.Fill;
                        sbt.ButtonStyle = BorderStyles.Style3D;
                        sbt.Click += new EventHandler(sbt_Click);
                        tableLayoutPanel1.Controls.Add(sbt, 1, r);
                        DevExpress.XtraEditors.SimpleButton sbt2 = new DevExpress.XtraEditors.SimpleButton();
                        sbt2.Name = string.Format("btnS{0:D3}C2", i);
                        sbt2.Dock = DockStyle.Fill;
                        sbt2.ButtonStyle = BorderStyles.Style3D;
                        sbt2.Click += new EventHandler(sbt_Click);
                        tableLayoutPanel1.Controls.Add(sbt2, 2, r);
                    }

                    //货柜绘制
                    for (int j = stocker_type; j < column + stocker_type; j++)
                    {
                        DevExpress.XtraEditors.SimpleButton sbt = new DevExpress.XtraEditors.SimpleButton();
                        sbt.Name = string.Format("btnR{0:D3}C{1:D3}", i, j - stocker_type + 1);
                        sbt.Dock = DockStyle.Fill;
                        sbt.Click += new EventHandler(sbt_Click);
                        tableLayoutPanel1.Controls.Add(sbt, j + 1, r);
                    }
                    //绘制堆垛机
                    if (i % 2 == 1 && i < row)
                    {
                        if (stocker_type == 1)
                        {
                            DevExpress.XtraEditors.SimpleButton sbt = new DevExpress.XtraEditors.SimpleButton();
                            sbt.Name = string.Format("btnL{0:D3}", i % 2);
                            sbt.Dock = DockStyle.Fill;
                            sbt.ButtonStyle = BorderStyles.Office2003;
                            sbt.Click += new EventHandler(sbt_Click);
                            r = i + i / 2 + 2;
                            tableLayoutPanel1.Controls.Add(sbt, 3, r);
                        }
                        if (stocker_type == 2)
                        {
                            DevExpress.XtraEditors.SimpleButton sbt = new DevExpress.XtraEditors.SimpleButton();
                            sbt.Name = string.Format("btnL{0:D3}R0", i % 2);
                            sbt.Dock = DockStyle.Fill;
                            sbt.ButtonStyle = BorderStyles.Office2003;
                            sbt.Click += new EventHandler(sbt_Click);
                            DevExpress.XtraEditors.SimpleButton sbt2 = new DevExpress.XtraEditors.SimpleButton();
                            sbt2.Name = string.Format("btnL{0:D3}R1", i % 2);
                            sbt2.Dock = DockStyle.Fill;
                            sbt2.ButtonStyle = BorderStyles.Office2003;
                            sbt2.Click += new EventHandler(sbt_Click);
                            r = i + i / 2 + 2;
                            tableLayoutPanel1.Controls.Add(sbt, 3, r);
                            tableLayoutPanel1.Controls.Add(sbt2, 4, r);
                        }
                    }
                }



                //设置大小
                tableLayoutPanel1.Size = this.Size;
                tableLayoutPanel1.Location = this.Location;
                tableLayoutPanel1.Update();
            }
            catch (Exception ex)
            { 
            
            }
        }

        private void sbt_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton sbt = (DevExpress.XtraEditors.SimpleButton)sender;
            MessageBox.Show(sbt.Name.ToString());
        }

        protected override void OnParentChanged(EventArgs e)
        {
            UI_Init();
            base.OnParentChanged(e);
        }

        private void InitLayoutDemo()
        {
            TableLayoutPanel demoLayoutPanel = new TableLayoutPanel();
            demoLayoutPanel.Dock = DockStyle.Fill;
            this.Controls.Add(demoLayoutPanel);
            int row = 3, col = 3;
            DynamicLayout(demoLayoutPanel, row, col);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Button btn = new Button();
                    btn.Text = string.Format("({0},{1})", i, j);
                    btn.Dock = DockStyle.Fill;
                    demoLayoutPanel.Controls.Add(btn);
                    demoLayoutPanel.SetRow(btn, i);
                    demoLayoutPanel.SetColumn(btn, j);
                }
            }
        }

        /// <summary>  
        /// 动态布局  
        /// </summary>  
        /// <param name="layoutPanel">布局面板</param>  
        /// <param name="row">行</param>  
        /// <param name="col">列</param>  
        private void DynamicLayout(TableLayoutPanel layoutPanel, int row, int col)
        {
            layoutPanel.RowCount = row;    //设置分成几行  
            for (int i = 0; i < row; i++)
            {
                layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            }
            layoutPanel.ColumnCount = col;    //设置分成几列  
            for (int i = 0; i < col; i++)
            {
                layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            }
        }  
    }
}
