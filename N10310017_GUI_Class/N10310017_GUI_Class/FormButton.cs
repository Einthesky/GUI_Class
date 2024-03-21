using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N10310017_GUI_Class
{
    public partial class FormButton : Form
    {
        public FormButton()
        {
            InitializeComponent();
        }

        private void FormButton_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnClick.Text == "請按我一下")
                btnClick.Text = "我已經被按過了";
            else if (btnClick.Text == "我已經被按過了")
                btnClick.Text = "請按我一下";
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "可以再多一點嗎";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tmp = label2.Text;
            int sum = Int32.Parse(tmp)+1;
            label2.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tmp = label2.Text;
            int sum = Int32.Parse(tmp)-1;
            label2.Text = sum.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
