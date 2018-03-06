using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HHMES.Library.UserControls
{
    public partial class ucConveryorV : UserControl
    {
        private float zoomX;
        private float zoomY;
        private Point Old1 ;
        private Point Old2;
        private Point Old3;
        private Point New1;
        public ucConveryorV()
        {
            InitializeComponent();
            Old1 = new Point(this.Width, this.Height);
            Old2 = new Point(this.pictureBox1.Width, this.pictureBox1.Height);
            Old3 = pictureBox1.Location;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            try
            {
                New1 = new Point(this.Width, this.Height);
                zoomX = (float)New1.X / Old1.X;
                zoomY = (float)New1.Y / Old1.Y;
                if (zoomX >= zoomY)
                {
                    pictureBox1.Width =Convert.ToInt32( Old2.X * zoomY);
                    pictureBox1.Height =Convert.ToInt32( Old2.Y * zoomY);
                    pictureBox1.Location = new Point(Convert.ToInt32( Old3.X * zoomY),Convert.ToInt32( Old3.Y * zoomY));
                }
                else
                {
                    pictureBox1.Width =Convert.ToInt32( Old2.X * zoomX);
                    pictureBox1.Height =Convert.ToInt32( Old2.Y * zoomX);
                    pictureBox1.Location = new Point(Convert.ToInt32( Old3.X * zoomX),Convert.ToInt32( Old3.Y * zoomX));
                }
            }
            catch (Exception ex)
            { 
            
            }

        }

        private int _state;
        public int state
        {
            set
            {
               // if (_state != value)
                {
                    if (value == 0)
                    {
                        pictureBox1.Visible = false;

                        pictureBox2.Size=this.panel1.Size;
                        pictureBox2.Parent = panel1;
                        pictureBox2.Dock = DockStyle.Fill;

                        pictureBox3.Size = new Size(0, 0);
                        pictureBox3.Parent = null;
                        pictureBox3.Dock = DockStyle.None;

                        pictureBox4.Size = new Size(0, 0);
                        pictureBox4.Parent = null;
                        pictureBox4.Dock = DockStyle.None;
                    }
                    else if (value == 1)
                    {
                        pictureBox1.Visible = false;

                        pictureBox3.Size = this.panel1.Size;
                        pictureBox3.Parent = panel1;
                        pictureBox3.Dock = DockStyle.Fill;

                        pictureBox2.Size = new Size(0, 0);
                        pictureBox2.Parent = null;
                        pictureBox2.Dock = DockStyle.None;

                        pictureBox4.Size = new Size(0, 0);
                        pictureBox4.Parent = null;
                        pictureBox4.Dock = DockStyle.None;
                    }
                    else if (value == 2)
                    {
                        pictureBox1.Visible = false;

                        pictureBox4.Size = this.panel1.Size;
                        pictureBox4.Parent = panel1;
                        pictureBox4.Dock = DockStyle.Fill;

                        pictureBox2.Size = new Size(0, 0);
                        pictureBox2.Parent = null;
                        pictureBox2.Dock = DockStyle.None;

                        pictureBox3.Size = new Size(0, 0);
                        pictureBox3.Parent = null;
                        pictureBox3.Dock = DockStyle.None;
                    }
                    else if (value == 3)
                    {
                        pictureBox1.Visible = true;

                        pictureBox2.Size = this.panel1.Size;
                        pictureBox2.Parent = panel1;
                        pictureBox2.Dock = DockStyle.Fill;

                        pictureBox3.Size = new Size(0, 0);
                        pictureBox3.Parent = null;
                        pictureBox3.Dock = DockStyle.None;

                        pictureBox4.Size = new Size(0, 0);
                        pictureBox4.Parent = null;
                        pictureBox4.Dock = DockStyle.None;
                    }
                    else if (value == 4)
                    {
                        pictureBox1.Visible = true;

                        pictureBox3.Size = this.panel1.Size;
                        pictureBox3.Parent = panel1;
                        pictureBox3.Dock = DockStyle.Fill;

                        pictureBox2.Size = new Size(0, 0);
                        pictureBox2.Parent = null;
                        pictureBox2.Dock = DockStyle.None;

                        pictureBox4.Size = new Size(0, 0);
                        pictureBox4.Parent = null;
                        pictureBox4.Dock = DockStyle.None;
                    }
                    else if (value == 5)
                    {
                        pictureBox1.Visible = true;

                        pictureBox4.Size = this.panel1.Size;
                        pictureBox4.Parent = panel1;
                        pictureBox4.Dock = DockStyle.Fill;

                        pictureBox2.Size = new Size(0, 0);
                        pictureBox2.Parent = null;
                        pictureBox2.Dock = DockStyle.None;

                        pictureBox3.Size = new Size(0, 0);
                        pictureBox3.Parent = null;
                        pictureBox3.Dock = DockStyle.None;
                    }
                    _state = value;
                }
            }
            get { return _state; }
        }
    }
}
