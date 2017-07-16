using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class ClientAbstract
    {
        //Abstract Constructors
        public abstract string FirstNameMethod();
        public abstract string LastNameMethod();
        public abstract void InformationMenuMethod();
        public abstract string AddressMethod();
        public abstract string PhoneNumberMethod();
        public abstract string EmailAddressMethod();
    }
}
