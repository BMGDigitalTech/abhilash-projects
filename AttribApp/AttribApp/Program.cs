using System;
using System.Collections.Generic;

namespace AttribApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum = " + Calculator.Add(2,4));

            List<int> addnums = new List<int>() { 2, 4, 5, 6 }; 
            Console.WriteLine("Sum = " + Calculator.Add(addnums));
        }
    }

    class Calculator
    {
        [Obsolete("Please use Add(List<int> Numbers) method")]
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(List<int> Numbers)
        {
            int sum = 0;
            foreach(int num in Numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}