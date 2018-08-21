using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string f1, f2, f3;
            f1 = "Abhishek";
            f2 = "Raj";
            f3 = "Sachin";

            WriteSomething();
            WriteSomethingSpecific("I am an argument and am called from a method");
            GreetFriend(f1);
            GreetFriend(f2);
            GreetFriend(f3);
            Console.WriteLine(Calculate());
            Console.Read();
        }

        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string secondInput = Console.ReadLine();
            int n1 = Int32.Parse(firstInput);
            int n2 = Int32.Parse(secondInput);
            int result = n1 + n2;
            return result;
        }

        public static void GreetFriend(string friendname)
        {
            Console.WriteLine("Hi {0} my friend", friendname);
        }

        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a methods");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
    }
}
