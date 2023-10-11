using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion03_1
{
    internal class Synesmand: Mekanikere
    {
        private int antalSyn;

        public Synesmand(CprNr cprNr, string medarbejdernummer, string navn, string adresse, int svendeproeveAar, int timeloen, int antalSyn) :
            base(cprNr, medarbejdernummer, navn, adresse, svendeproeveAar, timeloen)
        {
            this.antalSyn = antalSyn;
        }
        public override double BeregnUgeLoen()
        {
            return TimerPrUge * timeloen + (290 * this.antalSyn);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
