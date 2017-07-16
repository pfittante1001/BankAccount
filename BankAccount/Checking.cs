using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Checking : Account
    {
        //Fields
        protected double depositAmount;
        protected double withdrawAmount;

       //Properties
        public double DepositAmount { get; set; }//left to set because is used for making deposits
        public double WithdrawAmount { get; set; }//left to set because is used for making withdraws

        //Constructors
        public Checking()
        {
            //default constructor
        }

        public Checking(double checkBal, double depositAmount, int checkNum, double withdrawAmount, string acctType)
        {
            this.checkDepositAmt = depositAmount;
            this.checkAcctBalance = checkBal;
            this.checkNum = checkNum;//value inherited from Account class
            this.checkSubAmt = withdrawAmount;
            this.acctType = acctType;//value inherited from Account class
        }

        //Methods

        public override double GetCheckBalance()
        {
            return checkAcctBalance;
            
        }
        public override double GetCheckAddDeposit()
        {
            checkAcctBalance = depositAmount + checkAcctBalance;

            return checkAcctBalance;

        }

        public override double CheckAcctWithdraw()
        {
            checkAcctBalance = checkAcctBalance - withdrawAmount;
            return checkAcctBalance;
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
                Console.WriteLine("              {0} Account Information", acctType);//value inherited from Account class
                Console.WriteLine("Checking account number:  ${0}", checkNum);//value inherited from Account class
                Console.WriteLine("Checking account balance: ${0}", checkAcctBalance);
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
