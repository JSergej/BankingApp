using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class FormLogin : Form
    {
        //*** Create a testmode flag
      private readonly bool testMode = Properties.Settings.Default.TestMode;
        
    
                 // ****delegate
 
                  //*** Declared event1 
  
        // event2

        // *** Property to hold the reference to the currently focused textBox.***
        private TextBox focusText;

        // *** 
        private static List<UserAcc> acc = new List<UserAcc>();
        private string loginFile = "login.txt";

        public FormLogin()
        {
          
            InitializeComponent();
            //  *** Set (focusText) ***
            focusText = txtAccountNo;
            // *** Set Focus on that textBox ***

            ActiveControl = txtAccountNo;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
           UserAcc acc1 = new UserAcc("Joe Hopkins", "1234", 23000.00M );
           UserAcc acc2 = new UserAcc("Brenda dickens", "4534", 89540.00M);
           UserAcc acc3 = new UserAcc("Mary Lynch", "2233", 148570.00M);
           UserAcc acc4 = new UserAcc("Benn Stones", "3434", 1860.00M);
          
            // Add the account items to the list
            acc.Add(acc1);
            acc.Add(acc2);
            acc.Add(acc3);  
            acc.Add(acc4);


            //*** If in testmode , add a test account to list 
           
            if (testMode)
            {
                UserAcc testAccount = new UserAcc("test Account", "9999", 1350457.00M);
                acc.Add(testAccount);
                // *** Automatically populate the fields  test account credentials
                txtAccountNo.Text = testAccount.AccountNumber;
                txtPinNo.Text = testAccount.GetPin();

                //*** Automatically login
                btnLogin_Click(btnLogin, null);
            }
        }

        private void txtAccountNo_Enter(object sender, EventArgs e)
        {
            //*** 1st method to set focus on textBox ***
            focusText = (TextBox)sender;
        }

        private void txtPinNo_Enter(object sender, EventArgs e)
        {
            //*** 2nd method to set focus on textBox ***
            focusText = txtPinNo;
        }

        private void tblPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void KeyPadNum_Click(object sender, EventArgs e)
        {
            //*** Append the text from clicked keypad button
            string num =  ((Button)sender).Text;
            focusText.Text += num;
            //*** 2nd method***
          //***  focusText.Text = focusText + num;***
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            focusText.Clear();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            // *** Use custom event to add a custom line of text to the 'login.txt'
            // file to show that we are logging in with a test account and the following
            // transactions are 'Test' transactions ***
            if (testMode)
            {
                WriteToTestLogsOut();
            }

            //*** Exit App ***
            Application.Exit();
        }
        private void txtPinNo_TextChanged(object sender, EventArgs e)
        {
            // *** Set max length for pin ***
            TextBox txb = (TextBox)sender;
            if(txb.Text.Length >= txb.MaxLength)
            {
                txb.Text = txb.Text.Substring(0, txb.MaxLength);
            }
        }

        private void txtBoxAcc_TextChanged(object sender, EventArgs e)
        { 
            //*** Set max length for 
            TextBox txb = (TextBox)sender;
            if (txb.Text.Length >= txb.MaxLength)
            {
                txb.Text = txb.Text.Substring(0, txb.MaxLength);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool success = true;
            UserAcc userAccount = authenticateUserAcc();

            //*** If they do ***

            if (userAccount != null)
            {
                success = true;
                if (testMode)
                {
                    UserLogs u = new UserLogs();

                    this.Subscribe(u);       // Subscribe the subscription object to the publisher 

                    u.RecordLog();
                }
                //*** Write to the login File 
                WriteToLogs(success);
                             
                //*** Open the next form with their account details populated ***
                this.Hide();

                FormAcc accForm = new FormAcc(userAccount);
                accForm.ShowDialog();
                accForm = null;
                // Clear the form before reshowing it .
                ResetForm();
                this.Show();
                
                // *** Use custom event to add a custom line of text to the 'login.txt'
                // file to show that we are logging in with a test account and the following
                // transactions are 'Test' transactions ***

            }
            else
            {
                MessageBox.Show("Invalid acc number or PIN , please enter again");
                WriteToLogs(success);

                ResetForm();
            }
        }
        // Event action for test method 
        private void WriteToTestLogs()
        {
            string msg = $"\n                     " + $"\nTime:{DateTime.Now} - " + $"   *** Test Account Login *** ";
            File.AppendAllText(loginFile, msg);
           
        }
        private void WriteToTestLogsOut()
        {
            string msg =  $"\nTime:{DateTime.Now} - " + $"   *** Test Account Logout *** ";
            File.AppendAllText(loginFile, msg);

        }

        // ***   Define Event handler
        public void Subscribe(UserLogs ul)
            {
                // Binding the event to the delegate

                ul.ev_recLog += new UserLogs.dg_recLog(WriteIn);             

            }
            //*** Create Method to cal when the event is Raised 
            private void WriteIn(UserLogs ul, EventArgs e)
            {
                 WriteToTestLogs();
            }


    //*** writes text to logs record list
    private void WriteToLogs(bool successful)
        {
            string msg = $"\nTime:{DateTime.Now} - Account Number: {txtAccountNo.Text}, success: {successful}.";
            File.AppendAllText(loginFile, msg);
        }
        private UserAcc authenticateUserAcc()
        {
            string inputAccNum = txtAccountNo.Text;
            string inputPIN = txtPinNo.Text;
            // *** Verify the account and PIN number match

            //***  Loop through list of accounts to verify if an account with the input account
            //     number has a pin to match the pin number entered by user ***

            foreach (UserAcc account in acc)
            {
                if (inputAccNum == account.AccountNumber)
                {
                    if (inputPIN == account.GetPin())
                    {
                        return account;
                    }
                }
            }
            return null;
        }
        private void ResetForm()
        {
            txtAccountNo.Text = "";
            txtPinNo.Clear();

            ActiveControl = txtAccountNo;
        }
    }
}
