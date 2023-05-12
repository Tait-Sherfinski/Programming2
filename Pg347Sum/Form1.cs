using Microsoft.VisualBasic;
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
            int num1 = int.Parse(Interaction.InputBox("Enter a positive integer value: ", "Input Needed"));
            int num2 = 0;
            for (num1 < 10; num1++)
            {
                num2 += num1;
                MessageBox.Show("The sum of numbers 1 to " + num1 + " is " + num2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
