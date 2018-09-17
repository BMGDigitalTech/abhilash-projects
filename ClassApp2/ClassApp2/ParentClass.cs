using System;
using System.Collections.Generic;
using System.Text;

namespace ClassApp2
{
    class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent default constructor called");
        }

        public ParentClass(string message)
        {
            Console.WriteLine(message);
        }

        public virtual void print()
        {
            Console.WriteLine("Print method from the parent class");
        }
    }

    class ChildClass:ParentClass
    {
        
        public ChildClass():base("Message from child")
        {
            Console.WriteLine("Child class constructor called");
        }

        public override void print()
        {
            Console.WriteLine("Print method called from child class");
        }
    }
}
