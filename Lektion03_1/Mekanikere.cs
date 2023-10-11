using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion03_1
{
    internal class Mekanikere : Medarbejder
    {
        public int svendeproeveAar;
        public int timeloen;

        public Mekanikere(CprNr cprNr, string medarbejdernummer, string navn, string adresse, int svendeproeveAar, int timeloen)
            : base(cprNr, medarbejdernummer, navn, adresse)
        {
            this.svendeproeveAar = svendeproeveAar;
            this.timeloen = timeloen;
        }

        public override double BeregnUgeLoen()
        {
            return TimerPrUge * timeloen;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
