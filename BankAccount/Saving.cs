using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount 
{
    class Saving : Account
    {
        //Fields
        
        protected double savingDepositAmount;
        protected double savingWithdrawAmount;

        //Properties
        public double SavingDepositAmount { get; set; }//left to set because is used for making deposits
        public double SavingBalance { get; }
        public double SavingWithdrawAmount { get; set; }//left to set because is used for making withdraws

        //Constructors
        public Saving()
        {
            //default constructor
        }

        public Saving(double savBal, double depositAmount, int savNum, double withdrawAmount, string acctType)
        {
            this.saveDepositAmt = depositAmount;
            this.saveAcctBalance = savBal;
            this.saveNum = savNum;//value taken from Account Class
            this.saveSubAmt = withdrawAmount;
            this.acctType = acctType;//value taken from Account Class
        }

        //Methods

        public override double GetSaveBalance()
        {
            return saveAcctBalance;
        }
        public override double GetSaveAddDeposit()
        {
            saveAcctBalance = savingDepositAmount + saveAcctBalance;
            return  saveAcctBalance;
        }

        public override double SaveAcctWithdraw()
        {
            saveAcctBalance =   saveAcctBalance - savingWithdrawAmount;
            return saveAcctBalance;
        }

        public double SetDepositAmt()
        {
            savingDepositAmount = SavingDepositAmount;
            return savingDepositAmount;
        }

        public double SetWithdrawAmt()
        {
            savingWithdrawAmount = SavingWithdrawAmount;
            return savingWithdrawAmount;
        }

        public override void InformationMenuMethod()
        {
            bool menuReturn = false;

            while (menuReturn == false)
            {
                Console.WriteLine();
                Console.WriteLine("\n\n***************************************************************\n\n");
                Console.WriteLine("              {0} Account Information", acctType);//value inherited from Account class
                Console.WriteLine("Saving account number:     {0}", saveNum);//value inherited from Account class
                Console.WriteLine("Saving account balance:   ${0}", saveAcctBalance);//value inherited from Account class
                Console.WriteLine("Last Deposit Amount:      ${0}", savingDepositAmount);
                Console.WriteLine("Last Withdraw Amount:     ${0}", savingWithdrawAmount);
                Console.WriteLine("\n\n***************************************************************\n\n");

                Console.Write("\n\n\n\n\nPlease hit enter to return to the main menu");
                string menuReturnStr = Console.ReadLine();
                if (menuReturnStr == "")
                {
                    menuReturn = true;
                    Console.Clear();

                }

            }
        }
    }
}
