using System;

namespace OverrideToStringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.firstName = "Abhilash";
            c.lastName = "N";
            Console.WriteLine(c.ToString());
        }
    }

    public class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public override string ToString()
        {
            return this.firstName + ' ' + this.lastName;
        }
    }
}
