using System;
using System.Collections.Generic;
using System.Text;

namespace classApp
{
    class Person
    {
        private string firstname;
        private string lastname;
        private DateTime dob;

        public Person(string fname, string lname, string dob)
        {
            this.firstname = fname;
            this.lastname = lname;
            this.dob = DateTime.Parse(dob);
        }

        public void Intro()
        {
            Console.WriteLine("Hello I am {0} {1}", this.firstname, this.lastname);
        }

        public void CalculateAge()
        {
          
            DateTime cdate = DateTime.Now;
            int yeardiff =  int.Parse(cdate.Year.ToString()) - int.Parse(dob.Year.ToString());
            Console.WriteLine("Age: " + yeardiff);

        }

        private string checkDateUnit(string dayMonth)
        {
            if(int.Parse(dayMonth) < 10)
            {
                return "0" + dayMonth;
            }
            return dayMonth;
        }
    }
}
