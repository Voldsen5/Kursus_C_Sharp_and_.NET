using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion03_1
{
    internal class Adresse
    {
        public int vejNr { get; set; }
        public string vejNavn { get; set; }
        public Adresse(string vejNavn, int vejNr) 
        {
            this.vejNavn = vejNavn;
            this.vejNr = vejNr;
        }
    }
}
