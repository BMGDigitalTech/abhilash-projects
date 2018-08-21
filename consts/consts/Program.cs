using System;

namespace consts
{
    class Program
    {
        //constants as fields
        const double PI = 3.142;
        const int weeks = 52, months = 12;
        //create a constant of type string with your birthday as its value
        const string dob = "13-10-1988";

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be {0}", dob);
        }
    }
}
