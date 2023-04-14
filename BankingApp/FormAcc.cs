using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class FormAcc : Form
    {
        //*** set the culture info to English -ireland (en-IE)
        private static System.Globalization.CultureInfo cult = new System.Globalization.CultureInfo("en-IE");
        // *** Field Property to hold reference to the account passed in the form
        //    the log in form ***
        private UserAcc TheAccount;

        public FormAcc(UserAcc userAcc)
        {         
            InitializeComponent();
        // *** assign the passed in account to the Account field
            TheAccount = userAcc;
        }

        private void FormAcc_Load(object sender, EventArgs e)
        {
             lblAccNo.Text = TheAccount.AccountNumber;
             lblBalance.Text = TheAccount.Balance.ToString();

            ActiveControl = txtAmount;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        // *** method to show new cleared form '  ResetSeedAccNo() in UserAcc.cs'
        private void FormAcc_FormClosed(object sender, FormClosedEventArgs e)
        {
        //  //  new FormLogin().Show();
        }

        private void NumButton_Click(object sender, EventArgs e)
        {
            txtAmount.Text += ((Button)sender).Text; 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
        }

        private void btnProceedTransaction_Click(object sender, EventArgs e)
        {
            
            bool amountVerified = false;
                // ***  get the value form the textbox
                decimal amount = 0.00M;
                if (decimal.TryParse(txtAmount.Text, out amount))
                {
                    amountVerified = true;
                }
            try
            {
                if (amountVerified)
                {
                    //*** 
                    string amt = string.Format(cult, "{0:C2}", amount);
                    if (rbDeposit.Checked)
                    {
                        lblMessage.ForeColor = Color.Blue;
                        // *** Call the deposit method and pass in the amount value
                        TheAccount.TransDeposit(amount);

                        lblMessage.Text = $"{amt} lodged successfully !";

                    }
                    else
                    {
                        //***   Withdrawal ***
                        TheAccount.TransWithdraw(amount);
                        lblMessage.Text = $"{amt} withdrawn successfully !";
                    }
                    txtAmount.Clear();
                    LogTransaction();

                }

                else
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "Invalid amount, Please check and try again!";
                }
                // *** Update the balance textBox/label
                lblBalance.Text = string.Format(cult, "{0:C2}", TheAccount.Balance);
            }
            catch(ArgumentOutOfRangeException aoore)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = aoore.Message;
            }
            catch(InvalidOperationException ioe)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = ioe.Message;
            }
            catch(Exception ex)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = ex.Message;
            }
            
        }
        private void LogTransaction()
        {
            string trans = $"\nTime:{DateTime.Now} - Acc Number: {TheAccount.AccountNumber} - " +
                $"Info: {lblMessage.Text} - Amount: €{txtAmount} - Balance: €{TheAccount.Balance}";
            File.AppendAllText("TransactionLog.txt", trans);
        }

    }

}
