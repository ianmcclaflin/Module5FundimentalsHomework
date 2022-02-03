﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ContactInfo
    {
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;
        private string _phone;
        private string _email;

        public string StreetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }



        public ContactInfo(string streetaddress, string city, string state, string zip, string phone, string email)
        {
            StreetAddress = streetaddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }

        public ContactInfo() { }

        public override string ToString()
        {
            return string.Format("Street Address {0}\n" +
                "City {1}\n" +
                "State {2}\n" +
                "Zip {3}\n" +
                "Phone {4}\n" +
                "Email {5}\n",
                StreetAddress,
                City,
                State,
                Zip,
                Phone,
                Email);
        }


    }
}
