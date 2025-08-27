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
    public partial class Form3 : Form
    {

        public delegate void SenBackData(int PersonID);

        public event SenBackData DataBack;


        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(textBox1.Text);

            DataBack?.Invoke(PersonID);

            this.Close();

        }
    }
}
