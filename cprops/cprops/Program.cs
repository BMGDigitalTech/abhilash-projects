using System;

namespace cprops
{
    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box(3, 4, 5);
            Console.WriteLine("Length of box is {0}, height is {1}, width is {2} and the volume is {3}", b1.Length, b1.Height, b1.Width, b1.Volume);
            Console.WriteLine("Front surface of the box is " + b1.FrontSurface);
            b1.Width = 1;
            b1.Height = 2;
            b1.Length = 3;
            Console.WriteLine("Volume now is " + b1.Volume);
            Console.WriteLine("Front surface of the box is " + b1.FrontSurface);

            Members m1 = new Members();
            m1.Introducting(true);
            Console.Read();

        }
    }
}
