using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Access
    {
        //Fields
        protected string userName;
        protected string password;
        protected bool exitProgram;

        public bool ExitProgram { get; }


        //Constructore
        public Access()
        {
            //default constructor
        }

        public Access(string userName, string password, bool exitProgram)
        {
            this.userName = userName;
            this.password = password;
            this.exitProgram = exitProgram;

        }

        public bool GetExitProgram()
        {

            return exitProgram;
        }

        //methods

        public void CredentialsCheck()
        {
            int ctr = 0;
            Console.Clear();
            Console.Write("\n   Welcome to The Third National Bank of Uganda Online Banking Portal\n\n");
            Console.Write("\t\t     Your money is almost safe with us!\n\n");
            Console.Write("********************************************************************************\n\n");
            Console.Write("\n\n\n\nPlease please enter you username and password or quit to exit");
            Console.Write("n\n\nYou have three trys to enter the correct information after which the program ");
            Console.Write("n\n\nAfter three attempts the program will exit");

            while (exitProgram == true && ctr != 3)
            {
                ctr++;
               
                Console.Write("\n\nPlease enter your username: ");
                String userNameStr = Console.ReadLine().ToUpper();

                Console.Write("\n\nPlease enter your password: ");
                String passwordStr = Console.ReadLine().ToUpper();

                if (userName == userNameStr && password == passwordStr)
                {
                    exitProgram = false;
                    break;
                }

                if (ctr < 3 && userName != userNameStr || password != passwordStr)
                {
                    Console.Clear();
                    
                    Console.Write("\n\nYou have entered an invalid username or password");
                    Console.Write("\n\nYou have {0} attempts", Math.Abs(3 - ctr));


                }
                if ( Math.Abs(3 - ctr) == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for using The Third National Bank of Uganda Online Banking Portal");
                    Console.WriteLine("kwaheri");
                    System.Environment.Exit(1);


                }

                if (userNameStr == "QUIT")
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for using The Third National Bank of Uganda Online Banking Portal");
                    Console.WriteLine("kwaheri");
                    System.Environment.Exit(1);

                }



                

            }

            Console.WriteLine(exitProgram);
        }
    }

}
