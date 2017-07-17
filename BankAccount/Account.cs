using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        //Fields
        protected int checkNum;
        protected int saveNum;
        protected string acctType;
        protected double checkAcctBalance;
        protected double saveAcctBalance;
        protected int accountNumber;
        protected double checkDepositAmt;
        protected double checkSubAmt;
        protected double saveDepositAmt;
        protected double saveSubAmt;


        //Properties

        public int CheckNum { get; set; }
        public int SaveNum { get; set; }
        public string AcctType { get; set; }
        public double CheckAcctBalance { get; set; }
        public double SaveAcctBalance { get; set; }
        public int AccountNumber { get; set; }
        public double CheckDepositAmt { get; set; }
        public double CheckSubAmt { get; set; }
        public double SaveDepositAmt { get; set; }
        public double SaveSubAmt { get; set; }

        //Constructors

        public Account()
        {
            //Default Constructor
        }

        public Account(int checkNumConst, int saveNumConst, string acctTypeConst, double saveAcctbal, double checkAcctbal, double checkDepAmt, double checkSubAmt, double saveDepAmt, double saveSubAmt)
        {
            this.checkNum = checkNumConst;
            this.saveNum = saveNumConst;
            this.acctType = acctTypeConst;
            this.checkAcctBalance = checkAcctbal;
            this.saveAcctBalance = saveAcctbal;
            this.checkDepositAmt = checkDepAmt;
            this.checkSubAmt = checkSubAmt;
            this.saveDepositAmt = saveDepAmt;
            this.saveSubAmt = saveSubAmt;
        }

       //Methods
       // Do I really need all these methods? Can I just have a few templates like the information method?
       //I was thinking of just have generic methods for withdraw deposit balane and overiding them in 
       //the child classes.
        public virtual double GetCheckAddDeposit()
        {
            return checkDepositAmt;
        }

        public virtual double GetCheckSubWithdraw()
        {
            return checkSubAmt;
        }
        public virtual double GetCheckBalance()
        {
            return checkAcctBalance;
        }

        public virtual double GetSaveBalance()
        {
            return saveAcctBalance;
        }
        public virtual double GetSaveAddDeposit()
        {
            return saveAcctBalance;
        }
        public virtual double GetSaveSubWithdraw()
        {
            return checkSubAmt;
        }
        public virtual int GetAcctNumber()
        {
            return checkNum;
        }

        public virtual string GetAcctType()
        {
            return acctType;
        }

        public virtual int GetsaveAcctNumber()
        {
            return saveNum;
        }
        public virtual void InformationMenuMethod()
        {
            Console.WriteLine();
            Console.WriteLine("\n\n***************************************************************\n\n");
            Console.WriteLine("              {0} Account Information", acctType);
            Console.WriteLine("\n\n***************************************************************\n\n");

            Console.Write("\n\n\n\n\nPlease hit enter to return to the main menu");

        }

        public virtual double CheckAcctWithdraw()
        {
            return checkAcctBalance;
        }
        public virtual double SaveAcctWithdraw()
        {
            return saveAcctBalance;
        }

    }
}
