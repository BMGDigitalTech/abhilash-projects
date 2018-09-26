using System;
using Calculator.ClassLibrary;

namespace UnitTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.ClassLibrary.Calculator.divide(20, 0));
        }
    }
}
