using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion03
{
    internal abstract class Shape
    {
        public double x;
        public double y;
        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Shape()
        {
            this.x = 1;
            this.y = 1;
        }

        public double getX() {
            return x;
        }
        public double getY() {
            return y;
        }

        public void setX(double value) {
            this.x = value;
        }

        public void setY(double value) {
            this.y = value;
        }

        public abstract double Area();
    }
}
