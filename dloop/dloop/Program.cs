using System;

namespace dloop
{
    class Program
    {
        static void Main(string[] args)
        {
            //string friends;
            //int charlength = 0;
            //do
            //{
            //    Console.WriteLine("Please enter your friends name");
            //    friends = Console.ReadLine();
            //    charlength += friends.Length;
            //} while (charlength < 20);
            //Console.WriteLine("Ok thats enough");
            //Console.Read();

            /*int counter = 0;
            string input = "";
            Console.WriteLine("Please enter enter to count or any key to quit");
            
            while (input.Equals(""))
            {
                input = Console.ReadLine();
                counter++;
                Console.WriteLine(counter);
            }
            Console.WriteLine("Your count is " + counter);
            Console.Read();*/

            //for(int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //        break;
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
