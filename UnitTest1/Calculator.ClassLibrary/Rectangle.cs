using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.ClassLibrary
{
    public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Perimeter()
        {
            return 2 * (this.Length + this.Width);
        }

        public double Area()
        {
            return this.Length * this.Width;
        }
    }
}
