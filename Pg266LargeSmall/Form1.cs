using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pg266LargeSmall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numA = int.Parse(textBox1.Text);
            int numB = int.Parse(textBox2.Text);

            if (numA > numB)
            {
                label4.Text = "Value A is greater than Value B";
            }
            if (numB > numA)
            {
                label4.Text = "Value B is greater than Value A";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
