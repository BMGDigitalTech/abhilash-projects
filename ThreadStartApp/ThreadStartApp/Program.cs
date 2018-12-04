using System;
using System.Threading;

namespace ThreadStartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the target");
            int target = Int32.Parse(Console.ReadLine());
            Number number = new Number();
            Thread T1 = new Thread(() => { number.PrintNumbers(target); });
            T1.Start();
            
        }
    }

    class Number
    {
        public void PrintNumbers(int target)
        {
            for(int i = 1; i <= target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
