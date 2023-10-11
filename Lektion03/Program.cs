using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5.0);
            Rectangle r1 = new Rectangle(7, 5);
            Circle c2 = new Circle(0.5);
            Rectangle r2 = new Rectangle(2, 6);

            List<Shape> list = new List<Shape>();
            list.Add(r1);
            list.Add(r2);
            list.Add(c1);
            list.Add(c2);

            

            foreach (Shape s in list)
            {
                Console.WriteLine(s.Area());
            }
            Console.ReadLine();
        }
    }
}
