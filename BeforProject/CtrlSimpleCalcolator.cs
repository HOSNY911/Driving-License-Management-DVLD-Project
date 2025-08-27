using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeforProject
{
    public partial class CtrlSimpleCalcolator : UserControl
    {

        public event Action<int> OnCalcolateCompleat;

        protected virtual void CalcolateCompleat (int Result)
        {
            Action<int> hander = OnCalcolateCompleat;
            if (hander != null)
            {
                hander(Result);
            }
        }

        public CtrlSimpleCalcolator()
        {
            InitializeComponent();
        }

        public float Result
        {
             get { return (float)Convert.ToDouble(lblResult.Text); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Result; 

            Result = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text));
            lblResult.Text = Result.ToString();

            if(OnCalcolateCompleat!=null)
                CalcolateCompleat(Result);
        }
    }
}
