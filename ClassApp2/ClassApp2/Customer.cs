using System;
using System.Collections.Generic;
using System.Text;

namespace ClassApp2
{
    class Customer
    {
        private string _firstName;
        private string _lastName;

        public Customer() : this("Firstname not assigned", "Lastname not assigned")
        {

        }

        public Customer(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public void FullName()
        {
            Console.WriteLine("fullname is " + this._firstName + " " + this._lastName);
        }

        ~Customer()
        {

        }
    }
}
