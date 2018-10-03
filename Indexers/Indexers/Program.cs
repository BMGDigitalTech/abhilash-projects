using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {

            AddNumbers(4, 5);
            AddNumbers(4, 5, 8);
            AddNumbers(4, 5, 8, 3);
            AddNumbers(4, 5, new object[] { 8, 3, 5 });
            Console.WriteLine("--------------------------------------------------");
            Test(1, c: 5);
        }

        public static void Test(int a, int b=10, int c= 20)
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
        }

        public static void AddNumbers(int a, int b, params object[] restOfNumbers)
        {
            int result = a + b;
            if(restOfNumbers != null)
            {
                foreach(int i in restOfNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum = " + result);
        }
    }
}
