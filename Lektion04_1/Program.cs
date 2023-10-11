using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion04_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(13.0.Factorial());
            Console.WriteLine(2.Power(4));
        }

    }
    public static class ExtendMat
    {
        public static double Factorial(this double n)
        {
            if (n == 0)
            { return 1; }
            else
            { return n * Factorial(n - 1); }
        }

        public static int Power(this int n, int p)
        {
            if ( p <= 0) 
            { 
                return 1; 
            }
            else 
            {
                return n * n.Power(p - 1);
            }

        }
    }
}
