using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            int checkNum = 10021;
            int saveNum = 10022;
            string firstName = "Pete";
            String lastName = "Fittante";
            string address = "111 Kremlin dr";
            string emailAddress = "yeah@yahoo.com";
            string phone = "696-kidz";
            double checkBal = 1000.00;
            double savingBal = 500.00;
            double checkDep = 0.00;
            double savingDep = 0;
            double savingWD = 0;
            double checkingWD = 0;
            Dictionary<string, int> account = new Dictionary<string, int>();
            Client client1 = new Client(firstName, lastName, address, emailAddress, phone);
            Checking firstDep = new Checking(checkBal, checkDep, checkNum, checkingWD);
            Saving firstSav = new Saving(savingBal, savingDep, saveNum, savingWD);
            int tempParse;
            int menuSel;
            bool exitProgram = false;
            
            while (exitProgram == false)
            {
                Console.Write("\n\t\tWelcome to The Third National Bank of Uganda\n\n");
                Console.Write("\t\t     Your money is almost safe with us!\n\n");
                Console.Write("********************************************************************************\n\n");

                Console.Write("\n\t\tPlease select 1-5 from the following menu items\n\n");
                Console.Write("\n1. View Client Information\n");
                Console.Write("\n2. View Account Balance\n");
                Console.Write("\n3. Deposit Funds\n");
                Console.Write("\n4. Withdraw Funds\n");
                Console.Write("\n5. Exit\n\n");
                String menuSelStr = Console.ReadLine().ToUpper();
                while (int.TryParse(menuSelStr, out tempParse) == false)
                {
                    Console.Write("Please enter a valid number or quit to exit: ");
                    menuSelStr = Console.ReadLine().ToUpper();

                    ExitMethod(menuSelStr);

                    if (int.TryParse(menuSelStr, out tempParse) == true)
                    {
                        menuSel = tempParse;
                    }
                }
                
                menuSel = int.Parse(menuSelStr);
                switch (menuSel)
                {
                    case 1:
                        Console.Clear();
                        client1.InformationMenuMethod();
                        break;
                    case 2:                       
                        Console.Clear();
                        int menuSelAccountInfo;
                        Console.Write("\n\t\tAccount information Menu\n\n");
                        Console.Write("\n\t\tPlease select 1-2 from the following menu items\n\n");
                        Console.Write("\n1. Checking information\n");
                        Console.Write("\n2. Saving Information\n");
                        Console.Write("\n3. Return to main menu\n\n");
                        menuSelStr = Console.ReadLine().ToUpper();
                        while (int.TryParse(menuSelStr, out tempParse) == false)
                        {

                            Console.Write("Please enter a valid number or quit to exit: ");
                            menuSelStr = Console.ReadLine().ToUpper();

                            ExitMethod(menuSelStr);

                            if (int.TryParse(menuSelStr, out tempParse) == true)
                            {
                                menuSelAccountInfo = tempParse;
                            }
                        }
                        menuSelAccountInfo = int.Parse(menuSelStr);
                        switch (menuSelAccountInfo)
                        {
                            case 1:
                                Console.Clear();
                                firstDep.InformationMenuMethod();

                                break;
                            case 2:
                                Console.Clear();
                                firstSav.InformationMenuMethod();
                                break;

                            default:
                                Console.Clear();
                                break;
                        }
                        Console.Clear();

                        
                        break;
                    case 3:
                        Console.Clear();

                        int menuSelBalance;
                        Console.Write("\n\t\tAccount Deposit Menu\n\n");
                        Console.Write("\n\t\tPlease select 1-2 from the following menu items\n\n");
                        Console.Write("\n1. Deposit into checking\n");
                        Console.Write("\n2. Deposit into savings\n");
                        Console.Write("\n3. Return to main menu\n\n");
                        menuSelStr = Console.ReadLine().ToUpper();
                        while (int.TryParse(menuSelStr, out tempParse) == false)
                        {

                            Console.Write("Please enter a valid number or quit to exit: ");
                            menuSelStr = Console.ReadLine().ToUpper();

                            ExitMethod(menuSelStr);

                            if (int.TryParse(menuSelStr, out tempParse) == true)
                            {
                                menuSelBalance = tempParse;
                            }
                        }
                        menuSelBalance = int.Parse(menuSelStr);
                        switch (menuSelBalance)
                        {
                            case 1:
                                Console.Clear();
                                string menuSelectStrDbl;
                                double tryParseDbl;
                                double menuSelBalDbl = 0.00;
                                Console.Write("\n\t\tAccount Deposit Menu\n\n");
                                Console.Write("\n\t\tEnter the amount you would like to deposit into checking\n\n");
                                menuSelectStrDbl = Console.ReadLine().ToUpper();
                                while (double.TryParse(menuSelectStrDbl, out tryParseDbl) == false)
                                {

                                    Console.Write("Please enter a valid number or quit to exit: ");
                                    menuSelectStrDbl = Console.ReadLine().ToUpper();

                                    ExitMethod(menuSelectStrDbl);

                                    if (double.TryParse(menuSelectStrDbl, out tryParseDbl) == true)
                                    {
                                        menuSelBalDbl = double.Parse(menuSelectStrDbl);
                                    }
                                    
                                }
                                menuSelBalDbl = double.Parse(menuSelectStrDbl);
                                checkDep = menuSelBalDbl;
                                Console.Write(checkDep);
                                firstDep.DepositAmount = checkDep;
                                firstDep.SetDepositAmt();
                                Console.Write(checkDep);                        
                                firstDep.GetCheckAddDeposit();
                                firstDep.InformationMenuMethod();

                                break;
                            case 2:
                                Console.Clear();
                                string menuSelectStrDblSav;
                                double tryParseDblSav;
                                double menuSelBalDblSav = 0.00;
                                Console.Write("\n\t\tAccount Deposit Menu\n\n");
                                Console.Write("\n\t\tEnter the amount you would like to deposit into savings\n\n");
                                menuSelectStrDblSav = Console.ReadLine().ToUpper();
                                while (double.TryParse(menuSelectStrDblSav, out tryParseDblSav) == false)
                                {

                                    Console.Write("Please enter a valid number or quit to exit: ");
                                    menuSelectStrDblSav = Console.ReadLine().ToUpper();

                                    ExitMethod(menuSelectStrDblSav);

                                    if (double.TryParse(menuSelectStrDblSav, out tryParseDblSav) == true)
                                    {
                                        menuSelBalDbl = double.Parse(menuSelectStrDblSav);
                                    }
                                    
                                }
                                menuSelBalDblSav = double.Parse(menuSelectStrDblSav);
                                savingDep = menuSelBalDblSav;
                                
                                firstSav.SavingDepositAmount = savingDep;
                                firstSav.SetDepositAmt();
                                                 
                                firstSav.GetSaveAddDeposit();
                                firstSav.InformationMenuMethod();
                                break;
                                
                            default:
                                Console.Clear();
                                break;
                        }
                        Console.Clear();
                                        
                        break;
                    case 4:
                        Console.Clear();

                        //int menuSelWithdrawInfo;
                        Console.Write("\n\t\tAccount withdraw Menu\n\n");
                        Console.Write("\n\t\tPlease select 1-2 from the following menu items\n\n");
                        Console.Write("\n1. Withdraw from checking\n");
                        Console.Write("\n2. Withdraw from savings\n");
                        Console.Write("\n3. Return to main menu\n\n");
                        menuSelStr = Console.ReadLine().ToUpper();
                        while (int.TryParse(menuSelStr, out tempParse) == false)
                        {

                            Console.Write("Please enter a valid number or quit to exit: ");
                            menuSelStr = Console.ReadLine().ToUpper();

                            ExitMethod(menuSelStr);

                            if (int.TryParse(menuSelStr, out tempParse) == true)
                            {
                                menuSelBalance = tempParse;
                            }
                        }
                        menuSelBalance = int.Parse(menuSelStr);
                        switch (menuSelBalance)
                        {
                            case 1:
                                Console.Clear();
                                string menuSelectStrDbl;
                                double tryParseDbl;
                                double menuSelBalDbl = 0.00;
                                Console.Write("\n\t\tAccount withdraw Menu\n\n");
                                Console.Write("\nEnter the amount you would like to withdraw from checking:  ");
                                menuSelectStrDbl = Console.ReadLine().ToUpper();
                                while (double.TryParse(menuSelectStrDbl, out tryParseDbl) == false)
                                {

                                    Console.Write("Please enter a valid number or quit to exit: ");
                                    menuSelectStrDbl = Console.ReadLine().ToUpper();

                                    ExitMethod(menuSelectStrDbl);

                                    if (double.TryParse(menuSelectStrDbl, out tryParseDbl) == true)
                                    {
                                        menuSelBalDbl = double.Parse(menuSelectStrDbl);
                                    }

                                }
                                menuSelBalDbl = double.Parse(menuSelectStrDbl);
                                while(menuSelBalDbl > checkBal)
                                {
                                    Console.Clear();
                                    Console.Write("\n\nYou do not have enough funds in your checking account\n\n");
                                    Console.Write("\nYour current checking account balance is: " +firstDep.CheckAcctWithdraw());
                                    Console.Write("\n\n\nPlease select an amount less then: " + firstDep.CheckAcctWithdraw()+ "  : ");
                                    menuSelectStrDbl = Console.ReadLine().ToUpper();
                                    while (double.TryParse(menuSelectStrDbl, out tryParseDbl) == false)
                                    {

                                        Console.Write("Please enter a valid number or quit to exit: ");
                                        menuSelectStrDbl = Console.ReadLine().ToUpper();

                                        ExitMethod(menuSelectStrDbl);

                                        if (double.TryParse(menuSelectStrDbl, out tryParseDbl) == true)
                                        {
                                            menuSelBalDbl = double.Parse(menuSelectStrDbl);
                                        }

                                    }
                                    menuSelBalDbl = double.Parse(menuSelectStrDbl);
                                    

                                }
                                Console.Clear();
                                checkingWD = menuSelBalDbl;                           
                                firstDep.WithdrawAmount = checkingWD;
                                firstDep.SetWithdrawAmt();                               
                                firstDep.CheckAcctWithdraw();
                                firstDep.InformationMenuMethod();
                                
                                break;
                            case 2:
                                Console.Clear();
                                string menuSelectStrDblSav;
                                double tryParseDblSav;
                                double menuSelBalDblSav = 0.00;
                                Console.Write("\n\t\tAccount withdraw Menu\n\n");
                                Console.Write("\nEnter the amount you would like to withdraw from savings:  ");
                                menuSelectStrDblSav = Console.ReadLine().ToUpper();
                                while (double.TryParse(menuSelectStrDblSav, out tryParseDblSav) == false)
                                {

                                    Console.Write("Please enter a valid number or quit to exit: ");
                                    menuSelectStrDblSav = Console.ReadLine().ToUpper();

                                    ExitMethod(menuSelectStrDblSav);

                                    if (double.TryParse(menuSelectStrDblSav, out tryParseDblSav) == true)
                                    {
                                        menuSelBalDblSav = double.Parse(menuSelectStrDblSav);
                                    }

                                }
                                menuSelBalDblSav = double.Parse(menuSelectStrDblSav);
                                while (menuSelBalDblSav > savingBal)
                                {
                                    Console.Clear();
                                    Console.Write("\n\nYou do not have enough funds in your saving account\n\n");
                                    Console.Write("\nYour current checking account balance is: " + firstDep.CheckAcctWithdraw());
                                    Console.Write("\n\n\nPlease select an amount less then: " + firstDep.CheckAcctWithdraw() + "  : ");
                                    menuSelectStrDbl = Console.ReadLine().ToUpper();
                                    while (double.TryParse(menuSelectStrDbl, out tryParseDblSav) == false)
                                    {

                                        Console.Write("Please enter a valid number or quit to exit: ");
                                        menuSelectStrDbl = Console.ReadLine().ToUpper();

                                        ExitMethod(menuSelectStrDbl);

                                        if (double.TryParse(menuSelectStrDbl, out tryParseDblSav) == true)
                                        {
                                            menuSelBalDblSav = double.Parse(menuSelectStrDbl);
                                        }

                                    }
                                    menuSelBalDblSav = double.Parse(menuSelectStrDbl);

                                   
                                }
                                Console.Clear();
                                savingWD = menuSelBalDblSav;
                                firstSav.SavingWithdrawAmount = savingWD;
                                firstSav.SetWithdrawAmt();
                                firstSav.SaveAcctWithdraw();
                                firstSav.SaveAcctWithdraw();
                                firstSav.InformationMenuMethod();

                                break;
                            default:
                                Console.Clear();
                                break;
                        }
                        Console.Clear();

                        break;
                    case 5:
                        Console.Clear();
                        exitProgram = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a number between 1-5");
                        break;
                }
            }
        }
        
        //public static void AcctBalanceWindow(int menuSel)
        //{
            
        //    int tempParse;
        //    int menuSelBalance;
        //    Console.Write("\n\t\tPlease select 1-2 from the following menu items\n\n");
        //    Console.Write("\n1. View checking account balance\n");
        //    Console.Write("\n2. View savings account Balance\n");
        //    Console.Write("\n3. Return to main menu\n\n");
        //    String menuSelStr = Console.ReadLine().ToUpper();
        //    while (int.TryParse(menuSelStr, out tempParse) == false)
        //    {

        //        Console.Write("Please enter a valid number or quit to exit: ");
        //        menuSelStr = Console.ReadLine().ToUpper();

        //        ExitMethod(menuSelStr);

        //        if (int.TryParse(menuSelStr, out tempParse) == true)
        //        {
        //            menuSelBalance = tempParse;
        //        }
        //    }
        //    menuSelBalance = int.Parse(menuSelStr);
        //    switch (menuSelBalance)
        //    {
        //        case 1:
                    
        //            Console.Clear();
        //            break;
        //        case 2:
        //            Console.Clear();
        //            Console.WriteLine("case two");
        //            break;
        //        default:
        //            Console.Clear();
        //            break;
        //    }
        //    Console.Clear();
        //}
        public static void ExitMethod(string exitPro)
        {
            if (exitPro == "QUIT")
            {
                Console.Clear();
                Console.Write("\n\n\n\n\n\n                         No one likes a quitter\n\n");
                Console.Write("                             Bye Felicia!\n\n\n\n");
                System.Environment.Exit(1);
            }
        }
    }

}
