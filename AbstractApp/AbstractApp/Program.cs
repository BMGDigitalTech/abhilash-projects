using System;

namespace AbstractApp
{
    public abstract class AbsClass
    {
        public void print()
        {
            Console.WriteLine("Hello from abstract class method");
        }

        public abstract void print2();
    }
    class Program: AbsClass
    {
        public override void print2()
        {
            Console.WriteLine("Print 2 method of Abstract class");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.print();
            p.print2();
        
        }
    }
}
