using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion03_1
{
    internal class Firma: IharAdresse
    {
        public Adresse Adresse { get; }
        public Firma(Adresse adresse) 
        {
        this.Adresse = adresse;
        }

    }
}
