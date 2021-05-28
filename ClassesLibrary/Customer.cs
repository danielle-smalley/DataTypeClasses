using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        //fields
        //NA

        //props
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInfo { get; set; }

        //ctors
        public Customer(string customerId, string firstName, string lastName, ContactInfo contactInfo)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            ContactInfo = contactInfo;
        }

        public Customer()
        {

        }
        //methods

        public override string ToString()
        {
            return string.Format("Customer ID = {0}\nFirst Name: {1}\n" +
                "Last Name: {2}\nContact Info: {3}\n", CustomerId, FirstName, LastName, ContactInfo);
        }
    }//end class
}//end namespace
