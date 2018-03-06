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
    public partial class ucConveyorG : UserControl
    {
        public ucConveyorG()
        {
            InitializeComponent();
        }

        private int[] _StateValue=new int[19];
        public int[] StateValue
        {
            get { return _StateValue; }
            set
            { 
                if(_StateValue.Length==value.Length)
                {
                    for (int i = 0; i < _StateValue.Length; i++)
                    {
                        _StateValue[i] = value[i];
                        ucConveryor uc = panel1.Controls.Find(string.Format("ucConveyor{0}", i + 1), false)[0] as ucConveryor;
                        uc.state = _StateValue[i];
                    }
                }
            }
        }
    }
}
