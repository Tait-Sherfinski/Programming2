using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lang88a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int sum = num1 + num2;
            int product = num1 * num2;
            double average = (double)sum / 2.0;
            int diff = num1 - num2;
            int abs = Math.Abs(diff);
            int max = 0;
            int min = 0;
            
            if (num1 > num2) {
                max = num1;
            } else {
                max = num2;
            }

            if (num1 <= num2)
            {
                min = num1;
            }
            else
            {
                min = num2;
            }

            label8.Text = sum.ToString();
            label9.Text = diff.ToString();
            label10.Text = product.ToString();
            label11.Text = average.ToString();
            label12.Text = abs.ToString();
            label13.Text = max.ToString();
            label14.Text = min.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
