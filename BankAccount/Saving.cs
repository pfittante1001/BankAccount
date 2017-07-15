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
        protected double depositAmount;
        protected double withdrawAmount;

        public double DepositAmount { get; set; }
        public double SavingBalance { get; set; }
        public double WithdrawAmount { get; set; }

        public Saving()
        {
            //default constructor
        }

        public Saving(double saveBal, double depositAmount, int saveNum, double withdrawAmount)
        {
            this.depositAmount = depositAmount;
            this.savingBalance = saveBal;
            this.saveNum = saveNum;
            this.withdrawAmount = withdrawAmount;
        }

        //Methods
        public override double GetSaveBalance()
        {
            savingBalance = depositAmount + savingBalance;

            return savingBalance;
        }

        public override double SaveAcctWithdraw()
        {
            savingBalance = savingBalance - withdrawAmount;
            return savingBalance;
        }
        public override int GetAcctNumber()
        {
            return saveNum;
        }
        public override void InformationMenuMethod()
        {
            bool menuReturn = false;

            while (menuReturn == false)
            {
                Console.WriteLine();
                Console.WriteLine("\n\n***************************************************************\n\n");
                Console.WriteLine("              Savings Account Information");
                Console.WriteLine("Saving account number:  {0}", saveNum);
                Console.WriteLine("Saving account balance: {0}", savingBalance);
                Console.WriteLine("Deposit Amount:           {0}", depositAmount);
                //Console.WriteLine("Customer Phone:        {0}", custPhone);
                //Console.WriteLine("Customer Email:        {0}", custEmail);
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

