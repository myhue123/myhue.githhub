using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                Form4 form4 = new Form4();
                form4.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form0 = new Form0();
            form0.ShowDialog();
        }
    }
}
