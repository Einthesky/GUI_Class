using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N10310017_GUI_Class
{
    public partial class FotmTextBox : Form
    {
        public FotmTextBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            int sum = a + b;
            label3.Text = sum.ToString();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void FotmTextBox_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox3.Text);
            int b = Int32.Parse(textBox4.Text);
            int sum = a - b;
            label10.Text = sum.ToString();
        }
    }
}
