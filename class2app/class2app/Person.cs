using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2app
{
    class Person
    {
        private string firstName, lastName;
        private DateTime dob;

        public Person()
        {
            Console.WriteLine("Hi");
        }

        public Person(string fname, string lname, string dob)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.dob = DateTime.Parse(dob);
        }

        public void Intro()
        {
            Console.WriteLine("My name is {0} {1}", this.firstName, this.lastName);
        }

        public void CalculateAge()
        {
            Console.WriteLine(this.dob);
        }
    }
}
