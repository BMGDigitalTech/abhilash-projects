using System;

namespace NullsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 1337;

            double? num3 = new Double?();
            double? num4 = 3.142;

            bool? boolval = new bool?();

            Console.WriteLine("Our nullables numbers are: {0}, {1}, {2}, {3}", num1, num2, num3, num4);

            bool? isMale = null;
            if(isMale == true)
            {
                Console.WriteLine("User is Male");
            } else if(isMale == false)
            {
                Console.WriteLine("User is Female");
            }
            else
            {
                Console.WriteLine("No Gender Choosed");
            }

            double? num6 = 13.1;
            double? num7 = null;
            double num8;

            if(num6 == null)
            {
                num8 = 0.0;
            } else
            {
                num8 = (double)num6;
            }

            Console.WriteLine("Value of num8 is {0}", num8);


            // Shorter: The NULL Coalescing operator ??
            num8 = num6 ?? 8.53;
            Console.WriteLine("Value of num8 is {0}", num8);
            num8 = num7 ?? 8.53;
            Console.WriteLine("Value of num8 is {0}", num8);
        }
    }
}
