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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Kiểm tra thông tin đăng nhập
            if (username == "myhue" && password == "12345")
            {
             Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại thông tin!");
            }
        }
    }
}
