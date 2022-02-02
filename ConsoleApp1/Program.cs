using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
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

            

        }
    }
}
