using System;
using System.Collections.Generic;

namespace StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer { ID = 1, Name = "Abhilash", Gender = "Male" };
            Customer c2 = new Customer { ID = 2, Name = "Abhishek", Gender = "Male" };
            Customer c3 = new Customer { ID = 3, Name = "Arjun", Gender = "Male" };
            Customer c4 = new Customer { ID = 4, Name = "Ashish", Gender = "Male" };

            Stack<Customer> stackCollection = new Stack<Customer>();
            stackCollection.Push(c1);
            stackCollection.Push(c2);
            stackCollection.Push(c3);
            stackCollection.Push(c4);

            /*Customer stk1 = stackCollection.Pop();
            Console.WriteLine(stk1.ID + " : " + stk1.Name + " : " + stk1.Gender);
            Console.WriteLine("Stack total count = " + stackCollection.Count);
            Customer stk2 = stackCollection.Pop();
            Console.WriteLine(stk2.ID + " : " + stk2.Name + " : " + stk2.Gender); ;
            Console.WriteLine("Stack total count = " + stackCollection.Count);
            */

            foreach(Customer c in stackCollection)
            {
                Console.WriteLine(c.ID + " " + c.Name + " " + c.Gender);
            }

        }
    }
}
