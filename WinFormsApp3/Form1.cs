using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1;
        string oper;
        int zpt_count;
        private void Btn_num(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void Btn_oper(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                oper = ((Button)sender).Text;
                zpt_count = 0;
                textBox1.Clear();
            }
            catch { Console.WriteLine(e); }
        }

        private void Btn_res(object sender, EventArgs e)
        {
            try
            {
                double num2 = Convert.ToDouble(textBox1.Text);
                switch (oper)
                {
                    case "+":
                        textBox1.Text = Convert.ToString(num1 += num2);
                        break;
                    case "-":
                        textBox1.Text = Convert.ToString(num1 -= num2);
                        break;
                    case "*":
                        textBox1.Text = Convert.ToString(num1 *= num2);
                        break;
                    case "/":
                        textBox1.Text = Convert.ToString(num1 /= num2);
                        break;
                }
                oper = null;
                zpt_count = 0;
            }
            catch { Console.WriteLine(e); }
        }

        private void Btn_zpt(object sender, EventArgs e)
        {
            if ( zpt_count < 1)
            {
                textBox1.Text += ((Button)sender).Text;
                zpt_count++;
            }
        }
    }
}
