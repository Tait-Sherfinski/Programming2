using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lang122d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int x = -12; x <= 16; x += 1)
            {
                int y = x*x*x*x*x*x - (3 * x*x*x*x*x) - (93 * x*x*x*x) + (87 * x*x*x) + (1596 * x*x) - (1380 * x) - 2800;
                listBox1.Items.Add(x + "\t\t" + y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
