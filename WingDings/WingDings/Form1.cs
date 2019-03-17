using System;
using System.Windows.Forms;

namespace WingDings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }
    }
}
