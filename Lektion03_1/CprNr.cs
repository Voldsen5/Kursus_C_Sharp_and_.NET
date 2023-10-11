using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion03_1
{
    internal class CprNr
    {
        public string BirthDate { get; set;}

        public string SequenceNumber { get; set; }

        public CprNr(String bDate, String sNumber)
        {
            BirthDate = bDate;
            SequenceNumber = sNumber;
        }
    }
}
