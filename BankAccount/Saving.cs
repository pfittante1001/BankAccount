using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount 
{
    class Saving : Account
    {
        protected double savingBalance;
        protected double savingDepositAmount;
        protected double savingWithdrawAmount;

        public double SavingDepositAmount { get; set; }
        public double SavingBalance { get; set; }
        public double SavingWithdrawAmount { get; set; }

        public Saving()
        {
            //default constructor
        }

        public Saving(double savBal, double depositAmount, int savNum, double withdrawAmount)
        {
            this.savingDepositAmount = depositAmount;
            this.savingBalance = savBal;
            this.saveNum = savNum;
            this.savingWithdrawAmount = withdrawAmount;
        }

        //Methods
        public override double GetSaveAddDeposit()
        {
            savingBalance = savingDepositAmount + savingBalance;
            return savingBalance;
        }

        public override double SaveAcctWithdraw()
        {
            savingBalance = savingBalance - SavingWithdrawAmount;
            return savingBalance;
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
                Console.WriteLine("              Saving Account Information");
                Console.WriteLine("Saving account number:    ${0}", saveNum);
                Console.WriteLine("Saving account balance:   ${0}", savingBalance);
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
