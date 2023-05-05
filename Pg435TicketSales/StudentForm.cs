using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lang366b
{
    public partial class StudentForm : Form
    {
        private Form myParent;
        public StudentForm(Form prt)
        {
            InitializeComponent();
            this.myParent = prt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.myParent.Show();
            this.Close();
        }

        decimal decTaxRate = 0.06m;
        private decimal CalcTax(decimal cost)
        {
            return cost * decTaxRate;
        }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.myParent.Show();
        }
    }
}
