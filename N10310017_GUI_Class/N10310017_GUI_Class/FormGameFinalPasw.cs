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
    public partial class FormGameFinalPasw : Form
    {
        int min = 0, max = 0;
        int result;

        public FormGameFinalPasw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            result = r.Next(100);
            MessageBox.Show(result.ToString());
            label1.Text = "已隨機產生0~100的數字，請在下方做答";
            label2.Text = string.Format("請輸入(0)~(1)之間的數值", min, max);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                int answer = result;

                int input = Int32.Parse(textBox1.Text);
                if (input == answer)
                {
                    MessageBox.Show("恭喜答對");
                }
                else if(input < answer)
                {
                    this.min = input;
                }
                else if(input > answer)
                {
                    this.max = input;
                }
                label2.Text = String.Format("請輸入{0}~{1}之間的數值", min, max);
            } 
            
            catch(Exception) {
                MessageBox.Show("輸入錯誤，請輸入數字");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
