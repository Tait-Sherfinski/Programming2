using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pg498Payroll
{
    public partial class Form1 : Form
    {
        const decimal decHourlyPayRate = 6.0m;
        const int intMax_Employees = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] intHours = new int[intMax_Employees];
            int intCount = 0;
            int intEmpHours = 0;
            decimal decEmpPay = 0.0m;

            for (intCount = 0; intCount < intMax_Employees; intCount++)
            {
                while (int.TryParse(Interaction.InputBox("Enter the number of hours worked by employee #" +
                       (intCount+1).ToString(), "Need Hours Worked"),
                       out intEmpHours) == false) {
                    MessageBox.Show("Please enter an integer for hours worked");
                }
                intHours[intCount] = intEmpHours;
            }

            listBox1.Items.Clear();
            for (intCount = 0; intCount <= intMax_Employees; intCount++) {
                decEmpPay = intHours[intCount] * decHourlyPayRate;
                listBox1.Items.Add("Employee: " + (intCount + 1).ToString() + " earned " + decEmpPay.ToString("$.00"));
            }
        }
    }
}
