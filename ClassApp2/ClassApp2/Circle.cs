using System;
using System.Collections.Generic;
using System.Text;

namespace ClassApp2
{
    class Circle
    {
        private const float PI = 3.142F;
        private int radius;

        public Circle(int r)
        {
            this.radius = r;
        }

        public void GetCircleArea()
        {
            double area = PI * Math.Pow(this.radius, 2);
            Console.WriteLine("Circle Area = {0}", Math.Round(area, 2));
        }

    }
}
