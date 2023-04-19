using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pg535CatchMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You got me!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            int IntIndex = rand.Next(strCaption.Length);
            button1.Text = strCaption[index];
            button1.Left = rand.Next(this.Width - button1.Width);
            button1.Top = rand.Next(this.Height - button1.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {}
            private string[] strCaption = {"Click here", "try harder", "try again", "not even close", "where are you?", "i'm over here", "slow, aren't you?"};
            private Random rand = new Random();
        }
    }

