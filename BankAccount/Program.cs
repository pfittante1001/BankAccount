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
            Dictionary<string, int> account = new Dictionary<string, int>();
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
                        Client client1 = new Client("Pete", "Fittante", "3256 W82nd Cleveland", "pfittante@yahoo.com", "696-kids");
                        client1.InformationMenuMethod();
                        break;
                    case 2:
                        Console.Clear();
                        AcctBalanceWindow(menuSel);
                        break;
                    case 3:
                        Console.Clear();
                        
                        Checking firstDep = new Checking(400, 100, 111,0);
                        firstDep.GetAcctNumber();
                        //firstDep.AcctWithdraw();
                        firstDep.GetBalance();
                        firstDep.InformationMenuMethod();
                        break;
                    case 4:
                        Console.Clear();
                        Checking firstSav = new Checking(400, 3000, 111, 0);
                        firstSav.GetAcctNumber();
                        //firstDep.AcctWithdraw();
                        firstSav.GetBalance();
                        firstSav.InformationMenuMethod();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("case five");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a number between 1-5");
                        break;
                }
            }
        }
        //public static void CustomerInformation(string fname, string lname)
        //{
        //    Console.Clear();
        //    Console.WriteLine();
        //    Console.WriteLine("Customer Firstname: {0}", fname);
        //    Console.WriteLine("Customer Lastname:  {0}", lname);

        //}
        public static void AcctBalanceWindow(int menuSel)
        {
            int tempParse;
            int menuSelBalance;
            Console.Write("\n\t\tPlease select 1-2 from the following menu items\n\n");
            Console.Write("\n1. View checking account balance\n");
            Console.Write("\n2. View savings account Balance\n");
            Console.Write("\n3. Return to main menu\n\n");
            String menuSelStr = Console.ReadLine().ToUpper();
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
                    Console.WriteLine("case one");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("case two");
                    break;
                default:
                    Console.Clear();
                    break;
            }
            Console.Clear();
        }
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
