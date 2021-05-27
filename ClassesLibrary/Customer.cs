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
        //no fields needed

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
        //methods

        public override string ToString()
        {
            return string.Format("Customer ID = {0}\t\tFirst Name: {1}\n" +
                "Last Name: {2}\t\tContact Info: {3}", CustomerId, FirstName, LastName, ContactInfo);
        }
    }//end class
}//end namespace
