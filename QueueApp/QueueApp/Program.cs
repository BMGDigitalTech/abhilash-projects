using System;
using System.Collections.Generic;

namespace QueueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer()
            {
                ID = 1,
                Name = "Abhilash",
                Gender = "male"
            };

            Customer c2 = new Customer() { ID = 2, Name = "Abhishek", Gender = "male" };

            Customer c3 = new Customer() { ID = 3, Name = "Arjun", Gender = "Male" };

            Customer c4 = new Customer() { ID = 4, Name = "Anushka", Gender = "Female" };

            Queue<Customer> queueCustomers = new Queue<Customer>();

            queueCustomers.Enqueue(c1);
            queueCustomers.Enqueue(c2);
            queueCustomers.Enqueue(c3);
            queueCustomers.Enqueue(c4);

            foreach(Customer c in queueCustomers)
            {
                Console.WriteLine(c.ID + " - " + c.Name);
                //Console.WriteLine("Total Items in the Queue = " + queueCustomers.Count);
            }

           

        }
    }
}
