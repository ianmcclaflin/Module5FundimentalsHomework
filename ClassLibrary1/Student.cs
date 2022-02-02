using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        private string _fName;
        private string _lName;
        private string _iD;
        private float _gPa;

        public string FirstName
        {
            get { return _fName; }
            set { _fName = value; }
        }

        public string LastName
        {
            get { return _lName; }
            set { _lName = value; }
        }

        public string IdNumber
        {
            get { return _iD; }
            set { _iD = value; }
        }

        public float GPA
        {
            get { return _gPa; }
            set { _gPa = value; }
        }

        public Student(string firstname, string lastname, string idnumber, float gpa)
        {
            FirstName = firstname;
            LastName = lastname;
            IdNumber = idnumber;
            GPA = gpa;
        }

        public Student() { }

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("First Name {0}\n" +
                "Last Name {1}\n" +
                "idnumber {2}\n" +
                "gpa {3}\n",
                FirstName,
                LastName,
                IdNumber,
                GPA);
        }
















    }
}
