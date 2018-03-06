using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace HHMES.Library.UserControls
{
   

    public partial class ucCell : UserControl
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
        public string wareHouseName;

        public int btnHeight = 35;
        public int btnWidth = 35;
        public int stocker_type = 1;
        
        #endregion
        #region 私有变量

        Color clrUnActive = Color.FromName("Lime");
        Color clrActive = Color.FromName("Blue");
        Color clrLabel = Color.FromName("ActiveCaption");
        DevExpress.XtraEditors.SimpleButton[,] btnCells = null; //二维按钮数组
        #endregion
        
        
        public ucCell(string WareHouseName,  int irow, int ilayer, int icolumn )
        {
            InitializeComponent();
            Row = irow;
            Layer = ilayer;
            Column = icolumn;
            wareHouseName = WareHouseName;
          //  UI_Init();
            this.panelCell.MouseWheel += new MouseEventHandler(FormSample_MouseWheel);
            this.panelCell.Click += new EventHandler(panelCell_Click);
            this.panelCell.Parent = this.panel2;
            //CreateCellButtons(wareHouseName, panelCell, column, layer);
        }
        void FormSample_MouseWheel(object sender, MouseEventArgs e)
        {
            //获取光标位置
            Point mousePoint = new Point(e.X, e.Y);
            //换算成相对本窗体的位置
            mousePoint.Offset(this.Location.X, this.Location.Y);
            //判断是否在panel内
            if (this.panelCell.RectangleToScreen(
              panelCell.DisplayRectangle).Contains(mousePoint))
            {
                //滚动
                panelCell.AutoScrollPosition = new Point(0, panelCell.VerticalScroll.Value - e.Delta);
            }
        }
        void panelCell_Click(object sender,EventArgs  e)
        {
            this.panelCell.Focus();
        }

        private bool CreateCellButtons(string sWHId, Panel pnlCs, int nCols, int nLayers)
        {
            Cursor curOld = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            pnlCs.Controls.Clear();

            int nSpace = 2;//间隔距离
            int lblW = 28;
            int lblLR_W = 20;
            int lblTB_H = 15;
            bool bOK = false;
            int nR = row;
            int nC = 0;
            int nL = 0;
            int nX = 0;
            //
            int nLeft = 0;
            int nTop = 0;
            DevExpress.XtraEditors.SimpleButton btnX = null;
            try
            {
                //steo1: 计算绘制需要的宽度
                pnlCs.Width = (lblLR_W + nSpace + 1) * 2 + (btnWidth + nSpace) * nCols + nSpace;
                pnlCs.Height = (lblTB_H + nSpace + 1) * 2 + (btnHeight + nSpace) * nLayers + nSpace;
                if (pnlCs.Width < panel2.Width)
                {
                    pnlCs.Left = (int)(panel2.Width - pnlCs.Width) / 2;
                }
                else pnlCs.Left = 0;
                if (pnlCs.Height < panel2.Height)
                {
                    pnlCs.Top = (int)(panel2.Height - pnlCs.Height) / 2;
                }
                else pnlCs.Top = 0;

                //添加四条边框 lbl
                Label lblLeft = new Label();
                Label lblRight = new Label();
                Label lblTop = new Label();
                Label lblButtom = new Label();
                lblLeft.AutoSize = false;
                lblRight.AutoSize = false;
                lblTop.AutoSize = false;
                lblButtom.AutoSize = false;
                //绘制左右的线边框 
                lblLeft.Height = pnlCs.Height;
                lblRight.Height = pnlCs.Height;
                lblLeft.Width = 1;
                lblRight.Width = 1;
                //
                lblTop.Width = pnlCs.Width;
                lblButtom.Width = pnlCs.Width;
                lblTop.Height = 1;
                lblButtom.Height = 1;
                //
                lblLeft.BackColor = clrLabel;
                lblRight.BackColor = clrLabel;
                lblTop.BackColor = clrLabel;
                lblButtom.BackColor = clrLabel;
                //

                lblLeft.Top = 0;
                lblRight.Top = 0;
                lblLeft.Left = lblLR_W + 2;
                lblRight.Left = pnlCs.Width - lblLR_W - 2 + 1;
                //
                lblTop.Top = lblTB_H + 2;
                lblButtom.Top = pnlCs.Height - lblTB_H - 2;
                lblTop.Left = 0;
                lblButtom.Left = 0;
                pnlCs.Controls.Add(lblTop);
                pnlCs.Controls.Add(lblButtom);
                pnlCs.Controls.Add(lblLeft);
                pnlCs.Controls.Add(lblRight);
                //绘制的开始高度
                nTop = lblTop.Top + (nLayers) * (btnHeight + 2) + 5;
                btnCells = new DevExpress.XtraEditors.SimpleButton [nLayers, nCols];
                for (nL = 0; nL < nLayers; nL++)
                {
                    nLeft = lblLeft.Left + -1 * btnWidth;
                    nTop = nTop - btnHeight - 2;
                    Label lblL = new Label();
                    lblL.Name = "blLeft" + (nL + 1).ToString();
                    lblL.Left = 0;
                    lblL.Width = lblLR_W;
                    lblL.Height = lblTB_H;
                    lblL.ForeColor = clrLabel;
                    lblL.Text = (nL + 1).ToString("D2");
                    lblL.Top = nTop + (btnHeight - lblTB_H);
                    Label lblR = new Label();
                    lblR.Name = "blRight" + (nL + 1).ToString();
                    lblR.Left = lblRight.Left + 2;
                    lblR.Width = lblW;
                    lblR.Height = lblW;
                    lblR.ForeColor = clrLabel;
                    lblR.Text = (nL + 1).ToString("D2");
                    lblR.Top = lblL.Top;
                    nLeft = lblLeft.Left - btnWidth;
                    pnlCs.Controls.Add(lblL);
                    pnlCs.Controls.Add(lblR);
                    for (nC = 0; nC < nCols; nC++)
                    {
                        nX++;
                        nLeft = nLeft + 2 + btnWidth;
                        //
                        if (nL == 0) //只能循环一次
                        {
                            Label lblT = new Label();
                            Label lblB = new Label();
                            lblT.Width = lblW;
                            lblT.Height = lblTB_H;
                            lblB.Width = lblW;
                            lblB.Height = lblTB_H;
                            lblT.ForeColor = clrLabel;
                            lblB.ForeColor = clrLabel;
                            lblB.Left = nLeft + btnHeight - lblLR_W - 5;
                            lblT.Left = lblB.Left;
                            lblT.Top = 0;
                            lblB.Top = lblButtom.Top + 1;
                            lblT.Text = (nC + 1).ToString("D3");
                            lblB.Text = lblT.Text;
                            pnlCs.Controls.Add(lblT);
                            pnlCs.Controls.Add(lblB);
                        }
                        btnX = new DevExpress.XtraEditors.SimpleButton();
                        btnCells[nL, nC] = btnX;
                        btnX.Name =string.Format("btnR{0:D3}C{1:D3}L{2:D3}" ,row, nC+1,nL+1);
                        btnX.ImageList = imageList1;
                        btnX.ImageIndex = 0;
                        btnX.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
                        btnX.Width = btnWidth;
                        btnX.Height = btnHeight;
                        btnX.Left = nLeft;
                        btnX.Top = nTop;
                        btnX.Click += new EventHandler(sbt_Click);
                        string str = sWHId + '-' + (nR).ToString("D3") + "-" + (nC + 1).ToString("D3") + "-" + (nL + 1).ToString("D3");
                        btnX.Tag = str;
                        toolTip.SetToolTip(btnX, GetStateToolTip(str, "", row, (nC + 1), (nL + 1), 0, 0));
                        //btnX.BackColor = Color.Yellow;
                        pnlCs.Controls.Add(btnX);
                    }
                }
                Cursor.Current = curOld;
                bOK = true;
            }
            catch (Exception err)
            {
                bOK = false;
                Cursor.Current = curOld;
                MessageBox.Show(err.Message);
            }
            bOK = true;
            return (bOK);
        }
        private string GetStateToolTip(string sCellId, string sPalletNo, int nR, int nC, int nL, int palletState, int WarecellState)
        {
            
            string sState = "";
            switch (palletState)
            {
                case 0:
                    sState = "存货状态： 空位";
                    break;
                case 1:
                    sState = "存货状态： 空盘";
                    break;
                case 2:
                    sState = "存货状态： 半盘";
                    break;
                case 3:
                    sState = "存货状态： 满盘";
                    break;
                default:
                    sState = "";
                    break;
            }
            switch (WarecellState)
            {
                case 0:
                    sState = sState + "   使用状态： 空闲";
                    break;
                case 1:
                    sState = sState + "   使用状态： 预定";
                    break;
                case 2:
                    sState = sState + "   使用状态： 工作";
                    break;
                case 8:
                    sState = sState + "   使用状态： 锁定";
                    break;
                case 9:
                    sState = sState + "   使用状态： 禁用";
                    break;
                default:
                    break;
            }
            string sX = "";
            sX = "货位号：" + sCellId + "  托盘号：" + sPalletNo + "\n" +
                "行/排：" + nR.ToString() + "  列：" + nC.ToString() + "  层：" + nL.ToString() + "\n" + sState;
            return (sX);
        }

        private void sbt_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton sbt = (DevExpress.XtraEditors.SimpleButton)sender;
            string row = sbt.Name.ToString().Substring(4, 3);
            string column = sbt.Name.ToString().Substring(8, 3);
            string layer = sbt.Name.ToString().Substring(12, 3);
            MessageBox.Show(sbt.Name.ToString());
        }

        public bool CreateButtons()
        {
           return CreateCellButtons(wareHouseName, panelCell, column, layer);
        }

        public bool SetCellState(DataTable dt)
        {
            bool flag = false;
            string pallet = "";
            string warecell = "";
            int palletState = 0;
            int warecellState = 0;
            string state = "";
            int row,column,layer;
            try{
            if (dt != null && dt.Rows.Count > 0 && dt.Columns.Count == 5)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    warecell = dr[0].ToString();
                    pallet = dr[1].ToString();
                    warecellState = int.Parse(dr[2].ToString());
                    palletState = int.Parse(dr[3].ToString());
                    state = dr[4].ToString();
                    string[] s1=warecell.Split('-');
                    row=int.Parse(s1[1]);
                    column=int.Parse(s1[2]);
                    layer=int.Parse(s1[3]);
                    SimpleButton sbt = this.panelCell.Controls.Find(string.Format("btnR{0:D3}C{1:D3}L{2:D3}", s1[1], s1[2], s1[3]), false)[0] as SimpleButton;
                    sbt.ImageIndex = GetImageListIndex(state);
                    toolTip.SetToolTip(sbt,GetStateToolTip(warecell,pallet,row,column,layer,palletState,warecellState));
                }
            }
            }
            catch (Exception ex)
            {
            
            }
            return flag;
        }

        private int GetImageListIndex(string state)
        {
            int index = -1;
            switch (state)
            {
                case "00":
                    {
                        index = 0;
                        break;
                    }
                case "01":
                    {
                        index = 1;
                        break;
                    }
                case "02":
                    {
                        index = 2;
                        break;
                    }
                case "10":
                    {
                        index = 3;
                        break;
                    }
                case "11":
                    {
                        index = 4;
                        break;
                    }
                case "12":
                    {
                        index = 5;
                        break;
                    }
                case "20":
                    {
                        index = 6;
                        break;
                    }
                case "21":
                    {
                        index = 7;
                        break;
                    }
                case "22":
                    {
                        index = 8;
                        break;
                    }
                case "30":
                    {
                        index = 9;
                        break;
                    }
                case "31":
                    {
                        index = 10;
                        break;
                    }
                case "32":
                    {
                        index = 11;
                        break;
                    }
                case "08":
                    {
                        index = 12;
                        break;
                    }
                case "09":
                    {
                        index = 13;
                        break;
                    }
                case "18":
                    {
                        index = 12;
                        break;
                    }
                case "19":
                    {
                        index = 13;
                        break;
                    }
                case "28":
                    {
                        index = 12;
                        break;
                    }
                case "29":
                    {
                        index = 13;
                        break;
                    }
                case "38":
                    {
                        index = 12;
                        break;
                    }
                case "39":
                    {
                        index = 13;
                        break;
                    }
                default: { break; }
            }
            return index;
        }
    }
}
