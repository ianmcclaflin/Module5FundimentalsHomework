using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Customer
    {

        private string _customerID;
        private string _firstName;
        private string _lastName;
        private ContactInfo _contactInformation;

        public string CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private ContactInfo ContactInformation
        {
            get { return _contactInformation; }
            set { _contactInformation = value; }
        }

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
            return string.Format("CustomerID: {0}\n" +
                "First name: {1}\n" +
                "Last name: {2}\n" +
                "Contact information: {3}\n",
                CustomerID,
                FirstName,
                LastName,
                ContactInformation);
        }




    }
}
