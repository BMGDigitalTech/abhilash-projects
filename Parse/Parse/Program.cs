using System;

namespace Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "34";
            string string2 = "45";
            string resultstring = string1 + string2;
            int num1 = Int32.Parse(string1);
            int num2 = Int32.Parse(string2);
            int sum = num1 + num2;
            Console.WriteLine(resultstring);
            Console.WriteLine(sum);
            Console.Read();
        }
    }
}
