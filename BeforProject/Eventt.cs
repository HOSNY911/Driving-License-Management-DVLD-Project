using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeforProject
{
    public partial class Eventt : Form
    {
        public Eventt()
        {
            InitializeComponent();
        }

        private void ctrlSimpleCalcolator1_OnCalcolateCompleat(int obj)
        {
            int Result = obj;
            MessageBox.Show("Your Result is " + Result);
        }
    }
}
