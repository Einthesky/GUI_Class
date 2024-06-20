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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button按我一下_Click(object sender, EventArgs e)
        {
            //button按鈕.Text = "我已經被按過了";
            Form form = new FormButton();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new FotmTextBox();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Main_Form();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new TryCatch();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new FormTimer();
            form.Show();
        }

        private void btnGameFinalPasw_Click(object sender, EventArgs e)
        {
            Form form = new FormGameFinalPasw();
            form.Show(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new FormFinal();
            form.Show();
        }
    }
}
