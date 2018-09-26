using System;

namespace InterfaceApp
{
    public interface IEmployee
    {
        void print();
    }

    public class Employee: IEmployee
    {
        public void print()
        {
            Console.WriteLine("Print method from IEmployee interface");
        }
    }

    interface I1
    {
        void InterfaceMethod();
    }
    interface I2
    {
        void InterfaceMethod();
    }

    interface I3
    {
        void InterfaceMethod();
    }

    class Program: I1, I2, I3
    {
        public void InterfaceMethod()
        {
            Console.WriteLine("Default Interface method");
        }
        void I1.InterfaceMethod()
        {
            Console.WriteLine("Interface I1 method");
        }

        void I2.InterfaceMethod()
        {
            Console.WriteLine("Interface I2 method");
        }

        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.print();
            Program p = new Program();
            ((I1)p).InterfaceMethod();
            ((I2)p).InterfaceMethod();
            p.InterfaceMethod();

        }
    }
}
