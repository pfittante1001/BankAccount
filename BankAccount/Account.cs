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
        protected double acctBalance;
        protected int accountNumber;
        

        //Properties

        public int CheckNum { get; set; }
        public int SaveNum { get; set; }
        public string AcctType { get; set; }
        public double AcctBalance { get;  }
        public int AccountNumber { get; set; }

        //Constructors

        public Account()
        {
            //Default Constructor
        }

        public Account(int checkNumConst, int saveNumConst, string acctTypeConst, double acctbal, int accountNumber)
        {
            this.checkNum = checkNumConst;
            this.saveNum = saveNumConst;
            this.acctType = acctTypeConst;
            this.acctBalance = acctbal;
            this.accountNumber = accountNumber;
        }

       //Methods

        public virtual double GetBalance()
        {
            return acctBalance;
        }

        public virtual int GetAcctNumber()
        {
            return checkNum;
        }
        public virtual void InformationMenuMethod()
        {
            //not sure what I should have put in here. All the info is in the child
        }
        public virtual double AcctWithdraw()
        {
            return acctBalance;
        }
        
    }
}
