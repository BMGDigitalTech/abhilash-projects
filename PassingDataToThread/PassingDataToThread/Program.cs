using System;
using System.Threading;

namespace PassingDataToThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the target");
            int target = Int32.Parse(Console.ReadLine());
            Number num = new Number(target);
            Thread t1 = new Thread(num.PrintNumbers);
            t1.Start();

        }
    }

    class Number
    {
        private int _target;

        public Number(int target)
        {
            this._target = target;
        }

        public void PrintNumbers()
        {
            for(int i = 0; i < this._target; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
