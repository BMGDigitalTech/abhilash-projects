using System;

namespace ImpExpConv
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit conversion
            int num = 1234567890;
            long bigNum = num;

            Console.WriteLine("small int can be converted to long int implicitly and the value is " + bigNum);

            float myFloat = 13.37F;
            double myDouble = myFloat;

            Console.WriteLine("float value converted to double implicitly and value is " + myDouble);


            Console.Read();
        }
    }
}
