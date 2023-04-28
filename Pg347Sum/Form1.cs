using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pg347Sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label1.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            textBox1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            textBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = 3;
            label2.Text = "The sum of numbers 1 through " + num1 + " is " + num2;
            button1.Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            textBox1.Visible = false;
            button5.Visible = true;
            label2.Visible = true;
        }
    }
}
