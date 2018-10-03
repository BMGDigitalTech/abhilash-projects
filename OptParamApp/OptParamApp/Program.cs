using System;
using System.Runtime.InteropServices;

namespace OptParamApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(4, 5);
            AddNumbers(4, 5, new int[] { 5, 6 });

        
        }

        public static void AddNumbers(int a, int b,[Optional] int[] OtherNumbers)
        {
            int result = a + b;
            if(OtherNumbers != null)
            {
                foreach(int i in OtherNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum = " + result);
        }
    }
}
