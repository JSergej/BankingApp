using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    /// <summary>
    /// This class represents a bank account and its 
    /// </summary>
    public class UserAcc
    {
        // *** 
        public static int SeedAccountNumber = 111111 ;
        public string AccountNumber { get; } 
        public decimal Balance { get; set; }
        private string PIN { get; set; }
        public string Name { get; set; }

        //*** Methods
        public void TransDeposit(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Cannot deposit 0 or less!");
            }
            else
            {
                Balance += amount;
                //  Balance = Balance + amount;
            }
        }
        //*** Withdraw()
        public void TransWithdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Cannot withdraw €0.00 or less!");
            }
            else if((Balance - amount) < 0 )
            {
                throw new InvalidOperationException("Insufficient Funds, transaction cannot be completed");
            }
            else
            {
                Balance -= amount;
                //  Balance = Balance - amount;
            }

        }
        //*** Deposit()

        public string GetPin()
        {
            return PIN; 
        }

        //*** Constructors
        public UserAcc()
        {

        }
        public UserAcc(string name, string pin, decimal initBal )
        {
            Name = name;
            PIN = pin;
            Balance = initBal;

            AccountNumber = SeedAccountNumber.ToString();
            SeedAccountNumber++;
          
        }
        //*** Another method to reset SeedAccount
        public static void ResetSeedAccNo()
        {
        //    SeedAccountNumber = 111111;
        }
        //       ***
    }
}
