using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompoundInterestCalculator
{
    public partial class compoundInterestCalculatorForm : Form
    {
        public compoundInterestCalculatorForm()
        {
            InitializeComponent();
            amountLbl.Text = "Ensure you enter valid numbers for all text fields.\nEnsure you enter a decimal for the interest rate.";
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtain variables
                double principal = Convert.ToDouble(principalTxtBox.Text);
                double interestRate = Convert.ToDouble(interestRateTxtBox.Text);
                double compoundingsPerYear = Convert.ToDouble(compoundingsPerYearTxtBox.Text);
                double numberOfYears = Convert.ToDouble(numberOfYearsTxtBox.Text);

                double firstOrder = (interestRate / compoundingsPerYear);
                double secondOrder = (compoundingsPerYear * numberOfYears);
                double thirdOrder = (1 + firstOrder);
                double fourthOrder = Math.Pow(thirdOrder,secondOrder);
                double fifthOrder = principal * fourthOrder;

                amountLbl.Text = "Total: ";
                amountValueLbl.Text = "" + fifthOrder;

            }
            catch (Exception)
            {
                amountValueLbl.Text = "";
                amountLbl.Text = "You entered invalid information.\nEnsure you enter numbers for all text fields.\nEnsure you enter a decimal for the interest rate.";
            }


                        
            

        }
    }
}
