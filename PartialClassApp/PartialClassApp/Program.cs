using System;

namespace PartialClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialCustomer c1 = new PartialCustomer();
            c1.FirstName = "Abhilash";
            c1.LastName = "N";
            c1.PrintFullName();
        }
    }
}
