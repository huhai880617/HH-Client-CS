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
   

    public partial class ucWareCell : UserControl
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
        
        
        public ucWareCell(int irow, int ilayer, int icolumn )
        {
            InitializeComponent();
            Row = irow;
            Layer = ilayer;
            Column = icolumn;
          //  UI_Init();
            
        }
        /// <summary>
        /// 
        /// </summary>
        public void UI_Init()
        {
            try
            {
                TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
                //tableLayoutPanel1.Parent = panel1;
                panel2.Parent = panel1;
                tableLayoutPanel1.Parent = panel2;
                tableLayoutPanel1.Dock = DockStyle.Fill ;
               // tableLayoutPanel1.Margin = new Padding(1, 1, 1, 1);
                this.panel2.Controls.Add(tableLayoutPanel1);
                //tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
                tableLayoutPanel1.Controls.Clear();
                DynamicLayout(tableLayoutPanel1, row, Column);
                tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                ////设置大小
                

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
            //layoutPanel.RowCount = row;    //设置分成几行  
            //for (int i = 0; i < row; i++)
            //{
            //    layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            //}
            //layoutPanel.ColumnCount = col;    //设置分成几列  
            //for (int i = 0; i < col; i++)
            //{
            //    layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            //}
            int s = 30;
            int space = 3;
            int height = (row + row / 2) * s + (row + row / 2 + 2) * space; 
            int width = (col+2) * s + (col+3)*space;
            int cRow = 3 * row + 2;
            int cColumn =2 * col + 5;

            panel2.Height = height;
            panel2.Width = width;

            layoutPanel.RowCount = cRow;    //设置分成几行  
            for (int i = 0; i < cRow; i++)
            {
                if (i == 0 ||i==cRow-1)
                {
                    if (height < panel1.Height)
                    {
                        int p = (panel1.Height - height)/2;
                        layoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, p+space));
                    }
                    else
                    {
                        layoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, space));
                    }
                }
                else if (i%2 ==0)
                {
                    layoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, space));
                }
                else
                {
                    layoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, s));
                }
            }
            layoutPanel.ColumnCount = cColumn;    //设置分成几列  
            for (int i = 0; i < cColumn; i++)
            {
                if (i == 0||i==cColumn-1)
                {
                    if (width < panel1.Width)
                    {
                        int p = (panel1.Width - width)/2;
                        layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, p + space));
                    }
                    else
                    {
                        layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, space));
                    }
                }
                else if (i %2==0)
                {
                    layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, space));
                }
                else
                {
                    layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, s));
                }
            }
        }  

       
    }
}
