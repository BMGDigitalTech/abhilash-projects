using System;
using System.Collections.Generic;
using System.Text;

namespace cprops
{
    class Box
    {
        private string color = "white";
        private int length;
        private int height;
        private int width;
        private int volume;

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
        }

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                this.length = value;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                this.height = value;
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                this.width = value;
            }
        }
        public int Volume {
            get {
                return Length * Width * Height;
            } set
            {
                volume = value;
            }
        }

        public int FrontSurface
        {
            get { return length * height;  }
        }
    }
}
