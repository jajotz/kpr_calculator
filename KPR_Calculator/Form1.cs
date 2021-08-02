using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPR_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Calculate();
        }

        const string  _FORMAT_AMOUNT= "#,##0.##";

        private void Calculate()
        {
            try
            {


                var loanAmount = numLoanAmount.Value;
                var totalLoanTermMonth = (numLoanTermYear.Value * 12) + numLoanTermMonths.Value;

                var tenorInMonth = (numLoanTermYear.Value * 12) + numLoanTermMonths.Value;
                var tenorInYear = numLoanTermYear.Value + (numLoanTermMonths.Value / 12);

                var fixedInterestTerm = numFixedInterestTerm.Value;
                var fixedInterest = new Decimal(0);
                var fixedInterestRate = numInterestRate.Value;

                /*
                    FORMULA monthly payment:
                    monthlyPayment = P x (i/12) : (1-(1+(i/12) ^ (-t)).
                    P = plafon. i = interest. t = tenor in month
                */
                var interestPerMo = fixedInterestRate / 100 / 12;
                var pow = Math.Pow(Convert.ToDouble(1 + interestPerMo), Convert.ToDouble(tenorInMonth * -1));
                var monthlyPayment = (loanAmount * interestPerMo) / (1 - Convert.ToDecimal(pow));
               
                txtMonthlyPayment.Text = monthlyPayment.ToString(_FORMAT_AMOUNT);
                
            }
            catch { }
        }
        private void txtBankName_TextChanged(object sender, EventArgs e)
        {
            var bankName = String.IsNullOrEmpty(txtBankName.Text) ? "" : " - " + txtBankName.Text;
            groupCalculated.Text = "Calculated" + bankName;
        }
        private void num_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBankName.Text = "";
            numLoanAmount.Value = 0;
            numMortgageConstant.Value = 0;
            numInterestRate.Value = 0;
            numFixedInterestTerm.Value = 0;
            numLoanTermYear.Value = 0;
            numLoanTermMonths.Value = 0;
            numExtraPaymentPerMonth.Value = 0;

            txtMonthlyPayment.Text = "";
            txtTotalPayment.Text = "";
            txtTotalInterest.Text = "";
            txtTotalPayment.Text = "";
            txtMortgageConstant.Text = "";
        }
    }
}
