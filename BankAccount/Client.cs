using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client : ClientAbstract
    {

        //Fields
        protected string firstName;
        protected string lastName;
        protected string address;
        protected string emailAddress;
        protected string phoneNumber;

        //Properties

        public string FirstName { get; }
        public string LastName { get; }
        public string Address { get; }
        public string EmailAddress { get; }
        public string PhoneNumber { get; }


        //Constructors

        public Client()
        {
            //default constructor
        }

        public Client(string firstNameConst, string lastNameConst, string addressConst, string emailConst, string phoneConst)
        {
            this.firstName = firstNameConst;
            this.lastName = lastNameConst;
            this.address = addressConst;
            this.emailAddress = emailConst;
            this.phoneNumber = phoneConst;
        }

        //methods
        public override string FirstNameMethod()
        {
            string fName = firstName;
            return fName;
        }

        public override string LastNameMethod()
        {
            string lName = lastName;
            return lName;
        }

        public override string AddressMethod()
        {
            string custaddress = address;
            return custaddress;
        }

        public override string EmailAddressMethod()
        {
            string custEmail = emailAddress;
            return custEmail;
        }

        public override string PhoneNumberMethod()
        {
            string custPhone = phoneNumber;
            return custPhone;
        }
        public override void InformationMenuMethod()
        {
            bool menuReturn = false;

            string fName = firstName;
            string lName = lastName;
            string custaddress = address;
            string custPhone = phoneNumber;
            string custEmail = emailAddress;

            while (menuReturn == false)
            {
                Console.WriteLine();
                Console.WriteLine("\n\n***************************************************************\n\n");
                Console.WriteLine("              Customer Information");
                Console.WriteLine("Customer Firstnamexxx: {0}", fName);
                Console.WriteLine("Customer Lastname:     {0}", lName);
                Console.WriteLine("Customer Address:      {0}", custaddress);
                Console.WriteLine("Customer Phone:        {0}", custPhone);
                Console.WriteLine("Customer Email:        {0}", custEmail);
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