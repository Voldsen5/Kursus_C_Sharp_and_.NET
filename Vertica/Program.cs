using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vertica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = GenerateRandomCode(100);
            Console.WriteLine(x.Length);
            Console.WriteLine(x);

        }

        public static string GenerateRandomCode(int length)
        {
            string code = null;
            int x;
            var random = new Random();

            for (int i = 0; i < length; i++)
            {
                x = random.Next(1,3);
                if (x == 1) 
                { 
                    code += random.Next(0,10);
                }
                else if (x == 2)
                {
                    char y = (char)random.Next(65,91);
                    code += y;
                }
            }

            if (code.Length > 100)
            {
                throw new ArgumentException("Koden er uden for grænsen på 0 til 100");
            }

            return code;
        }
    }
}
