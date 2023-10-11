using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion03
{
    internal class Rectangle: Shape
    {
        private double width;
        private double length;

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public double getWidth()
        {
            return width;
        }

        public double getLength() 
        {
            return length;
        }

        public void setWidth(double value) 
        {
            this.width = value;
        }
        public void setLength(double value)
        {
            this.length = value;
        }

        public override double Area()
        {
            return length * width;
        }

    }
}
