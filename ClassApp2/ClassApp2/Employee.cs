using System;
using System.Collections.Generic;
using System.Text;

namespace ClassApp2
{
    class Employee
    {
        public string firstName;
        public string lastName;

        public void GetFullName()
        {
            Console.WriteLine(this.firstName + " " + this.lastName);
        }
    }

    class FullTimeEmployee:Employee
    {
        double salary = 0.0;

        public new void GetFullName()
        {
            Console.WriteLine("Fulltime emp name: " + firstName + " " + lastName);
        }
    }

    class PartTimeEmployee:Employee
    {
        double hourly_rate = 0.0;
    }
}
