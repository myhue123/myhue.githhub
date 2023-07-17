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
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            int with = this.Size.Width;
            int height = this.Size.Height;
            this.Text = with.ToString() +"-" +height.ToString();
        }

        private void Form_ResizeEnd(object sender, EventArgs e)
        {
            int with = this.Size.Width;
            int height = this.Size.Height;
            this.Text = with.ToString() + "-" + height.ToString();
        }
    }
}
