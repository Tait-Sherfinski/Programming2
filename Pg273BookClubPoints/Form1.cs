using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pg273BookClubPoints
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

            if (num1 < 1)
            {
                label2.Text = "You have earned 0 points";
            }
            if (num1 > 0 && num1 < 2);
            {
                label2.Text = "You have earned 5 points";
            } if (num1 > 1 && num1 < 3);
            {
                label2.Text = "You have earned 15 points";
            } if (num1 > 2 && num1 < 4);
            {
                label2.Text = "You have earned 30 points";
            } if (num1 > 4);
            {
                label2.Text = "You have earned 60 points";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
