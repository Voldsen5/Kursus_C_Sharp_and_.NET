using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lektion03
{
    internal class Circle: Shape
    {
        private double radius;
        public Circle (double radius)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double value)
        {
            this.radius = value;
        }

        public override double Area() 
        {
            return radius * radius * Math.PI; 
        }
    }
}
