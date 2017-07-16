using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Pete Fittante
 * WeCanCodeITBootCamp First Project
 * 6/30/2017
 * A online console banking application that will allow the use to perform the following transactions.
 * 
 *  1. View user information
 *  2. View account information
 *  3. Make withdraws
 *  4. Make deposits
 *  
 * This program also requires a user login name and password. 
 * 
 * USERNAME = admin
 * PASSWORD = admin
 * 
 * 
 * This program receives the following intial input from global variables. 
 * 
 * 1. First Name
 * 2. Last Name
 * 3. Address
 * 4. Phone Number
 * 5. Email Address
 * 6. Username
 * 7. Password
 * 8. Account Type
 * 7. Account inital balances 
 *
 * This program utilizes the following classes.
 *  
 *  1. Access Class - This class performs the user login authorization
 *  2. ClientAbstract Class - This abstract class provides six abstact methods to the Client class
 *  3. Client Class - This class inherits methods from the ClientAbstract class, and provides user information
 *                    output to the console
 *  4. Account Class - This calss is the Parent of the Checking and Saving class.  This class provides eleven
 *                      virtual methods to both Checking and Savings classes.
 *  5. Checking Class - This class is a child of the Account class. This class receives user input and provides
 *                      the following functions.
 *                          
 *                          1. Calulates checking account balances
 *                          2. Performs checking account withdraw
 *                          3. Performs checking account deposit
 *                          4. Provides checking account information to the user at the end of each transaction
 * 
 * 5. Saving Class - This class is a child of the Account class. This class receives user input and provides
 *                      the following functions.
 *                          
 *                          1. Calulates saving account balances
 *                          2. Performs saving account withdraw
 *                          3. Performs saving account deposit
 *                          4. Provides saving account information to the user at the end of each transaction
 * 
 * 6. Program Class - This class is used as the interface between all classes. This class provides the user
 *                    interface which allows access to the five other classes. This class also performs the 
 *                    following functions.
 *                    
 *                      1. Checks current checking and saving account values for sufficient funds (checking)
 *                         or required minimum balance (savings) before each withdraw transaction.
 * 
 * This program utilizes the following to sucessfully complete a user transaction
 *  
 *                      1. Instantiates one Client class object
                        2. Instantiate one Checking class object
                        3. Instantiate one Savings class object  
                        4. Instantiate one Access class object
 *                      5. Uitilizes abstract methods provided in the AbstractClient class
 *                      6. Uitlizes virtual methods provided in the Account class
 *                      7. Uitlizes override methods provided in the Checking and Saving classes
 *                      8. Uitlizes multiple constructors in Client, Access, Account, Checking and Savings classes
 *                      9. Uitlizes multiple properties in Client, Access, Account, Checking and Savings classes
 *                    10. Uitlizes multiple methods in Client, Access, Account, Checking and Savings classes
 *                    11. Runs until the user has three failed login attempts or the user types exit at the main menu
 *                       
 * 
 * I used the following to complete this project:
 * If statements
 * If Else Statements
 * While Loops
 * Global Variables
 * int.TryParse() to correct the fatal exception when the wrong input was given by the user
 * Inheritance between Parent and Child classes
 * Polymorphism
 * 
 * Things I would like to have done to complete this project
 *  1. Utilize a class for the intial user interface outside of the program class
 *  2. Checked the user information to see which account the user hads and diplaying the interface
 *     based on the number and types of accounts.
 *  3. Tried to utilize more generic methods and less in the parent Account class. I could not get the
 *     application to function without each class used.
 *  
 */

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Global Variables
            int checkNum = 10021;
            int saveNum = 10022;
            int tempParse;
            int menuSel;
            string firstName = "Pete";
            string lastName = "Fittante";
            string address = "111 Kremlin dr";
            string emailAddress = "yeah@yahoo.com";
            string phone = "696-kidz";
            string password = "ADMIN";
            string username = "ADMIN";
            string acctTypeCheck = "Checking";
            string acctTypeSaveing = "Saving";
            double checkBal = 1000.00;
            double savingBal = 500.00;
            double checkDep = 0.00;
            double savingDep = 0;
            double savingWD = 0;
            double checkingWD = 0;
            bool exitProgram = true;
            
            // Class objects instantiated
            Client client1 = new Client(firstName, lastName, address, emailAddress, phone);
            Account client01 = new Account(checkNum, saveNum, acctTypeCheck, savingBal, checkBal, checkDep, checkingWD, savingDep, savingWD);
            Checking firstDep = new Checking(checkBal, checkDep, checkNum, checkingWD, acctTypeCheck);
            Saving firstSav = new Saving(savingBal, savingDep, saveNum, savingWD, acctTypeSaveing);
            Access firstAccess = new Access(password, username, exitProgram);

           //Call Access method to validate user crendentials
            firstAccess.CredentialsCheck();

            //Sets the exitProgram = to false.  Not sure why I had to do this. I thought returning
            //the value in a get method would work.
            exitProgram = firstAccess.GetExitProgram();
            
            Console.Clear();


            //Begginning of Part One project requirements

            //This while loop controls the entire application. Next time I would have created a menu object
            //but just didnt have the time.
            while (exitProgram == false)
            {
                //This first section will solicit buisness from the user

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
                    Console.Write("Please enter a valid number or exit to quit: ");
                    menuSelStr = Console.ReadLine().ToUpper();

                    ExitMethod(menuSelStr);

                    if (int.TryParse(menuSelStr, out tempParse) == true)
                    {
                        menuSel = tempParse;
                    }
                }
                
                menuSel = int.Parse(menuSelStr);

                //Submenu for customer information
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

                            Console.Write("Please enter a valid number or exit to quit: ");
                            menuSelStr = Console.ReadLine().ToUpper();

                            ExitMethod(menuSelStr);

                            if (int.TryParse(menuSelStr, out tempParse) == true)
                            {
                                menuSelAccountInfo = tempParse;
                            }
                        }
                        menuSelAccountInfo = int.Parse(menuSelStr);

                        //Calls information method based on selection from sub menu above
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
                        //Subment for account deposit
                        int menuSelBalance;
                        Console.Write("\n\t\tAccount Deposit Menu\n\n");
                        Console.Write("\n\t\tPlease select 1-2 from the following menu items\n\n");
                        Console.Write("\n1. Deposit into checking\n");
                        Console.Write("\n2. Deposit into savings\n");
                        Console.Write("\n3. Return to main menu\n\n");
                        menuSelStr = Console.ReadLine().ToUpper();
                        while (int.TryParse(menuSelStr, out tempParse) == false)
                        {

                            Console.Write("Please enter a valid number or exit to quit: ");
                            menuSelStr = Console.ReadLine().ToUpper();

                            ExitMethod(menuSelStr);

                            if (int.TryParse(menuSelStr, out tempParse) == true)
                            {
                                menuSelBalance = tempParse;
                            }
                        }
                        menuSelBalance = int.Parse(menuSelStr);

                        //Calls deposit method based on selection from sub menu above
                        switch (menuSelBalance)
                        {
                            case 1:
                                Console.Clear();
                                string menuSelectStrDbl;
                                double tryParseDbl;
                                double menuSelBalDbl = 0.00;
                                Console.Write("\n\t\tChecking Account Deposit Menu\n\n");
                                Console.Write("\nEnter the amount you would like to deposit into checking: $ ");
                                menuSelectStrDbl = Console.ReadLine().ToUpper();
                                while (double.TryParse(menuSelectStrDbl, out tryParseDbl) == false)
                                {

                                    Console.Write("Please enter a valid number or exit to quit: ");
                                    menuSelectStrDbl = Console.ReadLine().ToUpper();

                                    ExitMethod(menuSelectStrDbl);

                                    if (double.TryParse(menuSelectStrDbl, out tryParseDbl) == true)
                                    {
                                        menuSelBalDbl = double.Parse(menuSelectStrDbl);
                                    }
                                    
                                }
                                Console.Clear();
                                menuSelBalDbl = double.Parse(menuSelectStrDbl);
                                checkDep = menuSelBalDbl;  
                                firstDep.DepositAmount = checkDep;
                                firstDep.SetDepositAmt();                                                      
                                firstDep.GetCheckAddDeposit();
                                firstDep.InformationMenuMethod();

                                break;
                            case 2:
                                Console.Clear();
                                string menuSelectStrDblSav;
                                double tryParseDblSav;
                                double menuSelBalDblSav = 0.00;
                                Console.Write("\n\t\tSaving Account Deposit Menu\n\n");
                                Console.Write("\nEnter the amount you would like to deposit into savings: $ ");
                                menuSelectStrDblSav = Console.ReadLine().ToUpper();
                                while (double.TryParse(menuSelectStrDblSav, out tryParseDblSav) == false)
                                {

                                    Console.Write("Please enter a valid number or exit to quit: ");
                                    menuSelectStrDblSav = Console.ReadLine().ToUpper();

                                    ExitMethod(menuSelectStrDblSav);

                                    if (double.TryParse(menuSelectStrDblSav, out tryParseDblSav) == true)
                                    {
                                        menuSelBalDbl = double.Parse(menuSelectStrDblSav);
                                    }
                                    
                                }
                                Console.Clear();
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

                        //Sub menu for account withdraw
                        Console.Write("\n\t\tAccount withdraw Menu\n\n");
                        Console.Write("\n\t\tPlease select 1-2 from the following menu items\n\n");
                        Console.Write("\n1. Withdraw from checking\n");
                        Console.Write("\n2. Withdraw from savings\n");
                        Console.Write("\n3. Return to main menu\n\n");
                        menuSelStr = Console.ReadLine().ToUpper();
                        while (int.TryParse(menuSelStr, out tempParse) == false)
                        {

                            Console.Write("Please enter a valid number or exit to quit: ");
                            menuSelStr = Console.ReadLine().ToUpper();

                            ExitMethod(menuSelStr);

                            if (int.TryParse(menuSelStr, out tempParse) == true)
                            {
                                menuSelBalance = tempParse;
                            }
                        }
                        menuSelBalance = int.Parse(menuSelStr);

                        //Calls deposit method based on selection from sub menu above
                        switch (menuSelBalance)
                        {
                            case 1:
                                Console.Clear();
                                string menuSelectStrDbl;
                                double tryParseDbl;
                                double menuSelBalDbl = 0.00;
                                Console.Write("\n\t\tAccount withdraw Menu\n\n");
                                Console.Write("\nEnter the amount you would like to withdraw from checking: $ ");
                                menuSelectStrDbl = Console.ReadLine().ToUpper();
                                while (double.TryParse(menuSelectStrDbl, out tryParseDbl) == false)
                                {

                                    Console.Write("Please enter a valid number or exit to quit: ");
                                    menuSelectStrDbl = Console.ReadLine().ToUpper();

                                    ExitMethod(menuSelectStrDbl);

                                    if (double.TryParse(menuSelectStrDbl, out tryParseDbl) == true)
                                    {
                                        menuSelBalDbl = double.Parse(menuSelectStrDbl);
                                    }

                                }
                                menuSelBalDbl = double.Parse(menuSelectStrDbl);
                                //while loop ensures enough funds in the account to withdraw request funds
                                while(menuSelBalDbl > checkBal)
                                {
                                    Console.Clear();
                                    Console.Write("\n\nYou do not have enough funds in your checking account\n\n");
                                    Console.Write("\nYour current checking account balance is: $ " +firstDep.CheckAcctWithdraw());
                                    Console.Write("\n\n\nPlease select an amount less then: $ " + firstDep.CheckAcctWithdraw()+ "  : ");
                                    menuSelectStrDbl = Console.ReadLine().ToUpper();
                                    while (double.TryParse(menuSelectStrDbl, out tryParseDbl) == false)
                                    {

                                        Console.Write("Please enter a valid number or exit to quit: ");
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
                                Console.Write("\nEnter the amount you would like to withdraw from savings: $  ");
                                menuSelectStrDblSav = Console.ReadLine().ToUpper();
                                while (double.TryParse(menuSelectStrDblSav, out tryParseDblSav) == false)
                                {

                                    Console.Write("Please enter a valid number or exit to quit: ");
                                    menuSelectStrDblSav = Console.ReadLine().ToUpper();

                                    ExitMethod(menuSelectStrDblSav);

                                    if (double.TryParse(menuSelectStrDblSav, out tryParseDblSav) == true)
                                    {
                                        menuSelBalDblSav = double.Parse(menuSelectStrDblSav);
                                    }

                                }
                                Console.Clear();
                                //if statement and while loop ensures request withdraw funds from the saving
                                //account are sufficient and do not exceed the minium balance requirement

                                menuSelBalDblSav = double.Parse(menuSelectStrDblSav);
                                if (savingBal == 150 || (savingBal - menuSelBalDblSav) <= 150)
                                {
                                    Console.Clear();
                                    Console.Write("\n\nA withdraw from your saving account in the amount of: ${0} \n\n", menuSelBalDblSav);
                                    Console.Write("\nwill place your saving account balance below the minimum balance limit of $150.00");
                                    Console.Write("\nYour current saving account balance is: $" + firstSav.SaveAcctWithdraw());
                                    Console.Write("\n\n\nPlease select an amount less then or equal to:${0}  :", Math.Abs(150-menuSelBalDblSav));
                                    menuSelectStrDbl = Console.ReadLine().ToUpper();
                                    while (double.TryParse(menuSelectStrDbl, out tryParseDblSav) == false)
                                    {

                                        Console.Write("Please enter a valid number or exit to quit: ");
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
                                firstSav.InformationMenuMethod();

                                break;
                            default:
                                Console.Clear();
                                break;
                        }
                        Console.Clear();

                        break;
                    //Allows user exit code based on selection from sub menu above
                    case 5:
                        Console.Clear();
                        Console.Write("Are you sure you want to exit? Please type exit to confirm: ");
                        string confirm = Console.ReadLine().ToUpper();
                        if (confirm == "EXIT")
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n\nThank you for using The Third National Bank of Uganda Online Banking Portal");
                            Console.WriteLine("\n\n                              KWAHERI\n\n\n\n\n\n\n\n");
                            exitProgram = true;
                            break;
                        }else
                        {
                            Console.Clear();
                            continue;
                        }
                            
                        
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a number between 1-5");
                        break;
                }
            }
        }
        //Allows user exit from 
        public static void ExitMethod(string exitPro)
        {
            if (exitPro == "EXIT")
            {
                Console.Clear();
                Console.WriteLine("Thank you for using The Third National Bank of Uganda Online Banking Portal");
                Console.WriteLine("kwaheri");
                System.Environment.Exit(1);
            }
        }
    }

}
