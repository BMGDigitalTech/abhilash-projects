using System;

namespace dataIFD
{
    class Program
    {
        static void Main(string[] args)
        {
            int inum1 = 54;
            int inum2 = 51;
            int isum = inum1 + inum2;

            double d1 = 3.51;
            double d2 = 5.65;
            double dsum = d1 + d2;

            float f1 = 5.51F;
            float f2 = 6.52F;
            float fsum = f1 + f2;

            Console.WriteLine("Sum of integers " + inum1 + " and " + inum2 + " is " + isum);
            Console.WriteLine("Sum of double " + d1 + " and " + d2 + " is " + dsum);
            Console.WriteLine("Sum of float " + f1 + " and " + f2 + " is " + fsum);
            Console.Read();

        }
    }
}
