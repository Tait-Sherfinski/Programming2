using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lang54b
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
            int num3 = int.Parse(textBox3.Text);
            int num4 = int.Parse(textBox4.Text);

            int sum = num1 + num2 + num3 + num4;
            int average = sum / 4;
            label2.Text = sum.ToString();
            label3.Text = average.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
