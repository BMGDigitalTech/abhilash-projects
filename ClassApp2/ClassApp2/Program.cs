using System;

namespace ClassApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.FullName();
            Customer c2 = new Customer("Abhilash", "Narayan");
            c2.FullName();

            Circle c3 = new Circle(5);
            c3.GetCircleArea();

            Circle c4 = new Circle(6);
            c4.GetCircleArea();

            ChildClass cc = new ChildClass();

            FullTimeEmployee fte = new FullTimeEmployee();
            fte.firstName = "Abhilash";
            fte.lastName = "N";
            // Gets Child class Method 
            fte.GetFullName();
            // Gets Parent Class Method
            ((Employee)fte).GetFullName();

            PartTimeEmployee pte = new PartTimeEmployee();
            pte.firstName = "Abhishek";
            pte.lastName = "Kulkarni";
            pte.GetFullName();

            ParentClass p = new ChildClass();
            p.print();
            ParentClass p2 = new ParentClass();
            p2.print();

            ChildClass p3 = new ChildClass();
            p3.print();

        }
    }
}
