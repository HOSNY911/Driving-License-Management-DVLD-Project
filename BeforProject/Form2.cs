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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();

            frm.DataBack += ShowPersonData;

            frm.ShowDialog();
        }

        private void ShowPersonData(int PersonID)
        {
            textBox1.Text = PersonID.ToString();
        }
    }
}
