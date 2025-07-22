using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Variables
            double numberOfHouerWork, payRate, grossPay, otPay, otHouers, basePay;

            //inputs
            numberOfHouerWork = double.Parse(numberOfHourTexBox.Text);
            payRate = double.Parse(payRateTexBox.Text);

            //If__else operator
            if(numberOfHouerWork>40)
            {
                basePay = payRate * 40;
                otHouers = numberOfHouerWork - 40;
                otPay = otHouers * payRate * 1.5;
                grossPay = basePay + otPay;
            }
            else
            {
                grossPay = numberOfHouerWork * payRate;
            }
            // Output
            grossPayTexBox.Text = "Rs. " + grossPay.ToString();
                 
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear button operations
            numberOfHourTexBox.Clear();
            payRateTexBox.Clear();
            grossPayTexBox.Clear();
            numberOfHourTexBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit button operation
            this.Close(); 
        } 
    }
}
