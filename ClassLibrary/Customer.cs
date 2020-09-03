using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Customer 
    {
        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInformation { get; set; }

        public Customer(string customerID, string firstName, string lastName, ContactInfo contactInformation)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;
        }

        public Customer() { }

        public override string ToString()
        {
            return string.Format("Customer ID: {0}\n First Name: {1}\n Last Name: {2}\nContact Information: {3}",
                CustomerID,
                FirstName,
                LastName,
                ContactInformation.ToString());
        }



    }
}
