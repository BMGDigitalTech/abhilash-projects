using System;
using AssemblyOne;
using AssemblyTwo;

namespace AssesMod
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            c.Print();
            AssemblyTwoClass a2c = new AssemblyTwoClass();
            a2c.Print();
        }
    }
}
