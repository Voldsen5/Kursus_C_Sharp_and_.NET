using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Lektion04.Program;

namespace Lektion04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Længde.OverLængde("Hej", 7));
            Console.ReadLine();

            PowerPlant p1 = new PowerPlant(20);
            
            Console.WriteLine(p1.HeatUp());

        }

        public static void warningToConsole()
        {
            Console.WriteLine("Warning, To Hot");
        }

    }
    public delegate void Warning(Warning wa);
    public class PowerPlant
    {
        public int Heat { get; set; }
        private Warning _warning;
        
        public PowerPlant(int heat)
        {
            this.Heat = heat;
        }

        Random r = new Random();

        public void SetWarning(Warning wa)
        {

        }

        public int HeatUp()
        {
            this.Heat = r.Next(1, 101);

            if (Heat > 50)
            {
                warningToConsole();
                return Heat;
            }
            else
            {
                Console.WriteLine("Warmen er under 50");
                return Heat;
            }
        }
    }
}
