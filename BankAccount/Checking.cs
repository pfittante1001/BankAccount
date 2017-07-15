using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Checking : Account
    {
        protected double checkingBalance;
        protected double depositAmount;
        protected double withdrawAmount;
       
        public double DepositAmount { get; set; }
        public double CheckingBalance { get; set; }
        public double WithdrawAmount { get; set; }

        public Checking()
        {
            //default constructor
        }

        public Checking(double checkBal, double depositAmount, int checkNum, double withdrawAmount)
        {
            this.depositAmount = depositAmount;
            this.checkingBalance = checkBal;
            this.checkNum = checkNum;
            this.withdrawAmount = withdrawAmount;
        }

        //Methods
        public override double GetCheckAddDeposit()
        {
            checkingBalance = depositAmount + checkingBalance;
            return checkingBalance;
        }

        public override double CheckAcctWithdraw()
        {
            checkingBalance = checkingBalance - withdrawAmount;
            return checkingBalance;
        }

        public  double SetDepositAmt()
        {           
            depositAmount = DepositAmount;
            return depositAmount;
        }

        public double SetWithdrawAmt()
        {
            withdrawAmount = WithdrawAmount;
            return withdrawAmount;
        }
        public override void InformationMenuMethod()
        {
            bool menuReturn = false;
            
            while (menuReturn == false)
            {
                Console.WriteLine();
                Console.WriteLine("\n\n***************************************************************\n\n");
                Console.WriteLine("              Checking Account Information");
                Console.WriteLine("Checking account number:  ${0}", checkNum);
                Console.WriteLine("Checking account balance: ${0}", checkingBalance);
                Console.WriteLine("Last Deposit Amount:      ${0}", depositAmount);
                Console.WriteLine("Last Withdraw Amount:     ${0}", withdrawAmount);
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
