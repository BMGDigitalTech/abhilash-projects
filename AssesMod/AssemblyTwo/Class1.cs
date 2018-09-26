using System;
using AssemblyOne;


namespace AssemblyTwo
{
    public class AssemblyTwoClass:Class1
    {
       public AssemblyTwoClass()
        {
            this.Name = "Nike";
        }

        public new void Print()
        {
            Console.WriteLine("Hello from AssemblyTwoClass");
        }
    }
}
