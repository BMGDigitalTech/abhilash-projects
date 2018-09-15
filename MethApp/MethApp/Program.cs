using System;

namespace MethApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = 0;
            int sum = 0;
            int prod = 0;

            SomeMethod(ref i);
            Console.WriteLine(i);
            AddProduct(10, 20, out sum,out prod);
            Console.WriteLine("Sum = {0} and Product = {1}" , sum, prod);

            int[] numArray = new int[] { 101, 102, 103 };
            AddArray(numArray);
        }

        // Reference parameter
        public static void SomeMethod(ref int j)
        {
            j = 101;
        }

        // Returning 2 output from a single function using out parameters
        public static void AddProduct(int a, int b, out int sum, out int prod)
        {
            sum = a + b;
            prod = a * b;
        }

        // param method
        public static void AddArray(params int[] Numbers)
        {
            Console.WriteLine("Length of array is {0}", Numbers.Length);

            foreach(int item in Numbers)
            {
                Console.WriteLine(item);
            }
        }

    }
}
