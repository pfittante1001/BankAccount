﻿using System;
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
        

        //Properties

        public int CheckNum { get; set; }
        public int SaveNum { get; set; }
        public string AcctType { get; set; }
        public double CheckAcctBalance { get; set; }
        public double SaveAcctBalance { get; set; }
        public int AccountNumber { get; set; }
        public double CheckDepositAmt { get; set; }
        public double CheckSubAmt { get; set; }

        //Constructors

        public Account()
        {
            //Default Constructor
        }

        public Account(int checkNumConst, int saveNumConst, string acctTypeConst, double saveAcctbal, double checkAcctbal, int accountNumber, double checkDepAmt, double checkSubAmt)
        {
            this.checkNum = checkNumConst;
            this.saveNum = saveNumConst;
            this.acctType = acctTypeConst;
            this.checkAcctBalance = checkAcctbal;
            this.saveAcctBalance = saveAcctbal;
            this.accountNumber = accountNumber;
            this.checkDepositAmt = checkDepAmt;
            this.checkSubAmt = checkSubAmt;
        }

       //Methods

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

        public virtual int GetAcctNumber()
        {
            return checkNum;
        }
        public virtual void InformationMenuMethod()
        {
            //not sure what I should have put in here. All the info is in the child
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
