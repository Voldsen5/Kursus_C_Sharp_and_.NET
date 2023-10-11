using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion03_1
{
    internal class Vaerkfoerer: Mekanikere
    {
        private int udnaevnelsenTilVaerkfoerer;
        private int tillæg;

        public Vaerkfoerer(CprNr cprNr, string medarbejdernummer, string navn, string adresse, int svendeproeveAar, int timeloen,int udnaevnelsenTilVaerkfoerer, int tillæg):
            base(cprNr, medarbejdernummer, navn, adresse, svendeproeveAar, timeloen)
        {
            this.udnaevnelsenTilVaerkfoerer = udnaevnelsenTilVaerkfoerer;
            this.tillæg = tillæg;
        }
        public override double BeregnUgeLoen()
        {
            return base.BeregnUgeLoen() + this.tillæg;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
