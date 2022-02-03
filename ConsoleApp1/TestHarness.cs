using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class TestHarness
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is my CSF2 Week Homework Packet");
            Console.Title = "CSF2 Week Homework Packet";

            Student stu1 = new Student();
            stu1.FirstName = "Steve";
            stu1.LastName = "Stevenson";
            stu1.IdNumber = "123";
            stu1.GPA = 3.4f;

            Console.WriteLine("Students firstname {0}\n" +
                "Students lastname {1}\n" +
                "Students idnumber {2}\n" +
                "Students GPA {3}", stu1.FirstName, stu1.LastName, stu1.IdNumber, stu1.GPA);

            Vehicle vec1 = new Vehicle("kia", "Sodona", 1988, 98.23f);

            Console.WriteLine(vec1);

            Login log1 = new Login("Username", "password");

            Console.WriteLine(log1);

            ContactInfo person = new ContactInfo("1234 E 54st", "Hellosville", "HI", "84975", "849-984-8875", "hello@hi.com");
            Console.WriteLine(person);
            

        }
    }
}
