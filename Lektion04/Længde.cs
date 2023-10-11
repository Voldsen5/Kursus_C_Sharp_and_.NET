using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion04
{
    internal static class Længde
    {
        public static Boolean OverLængde(String str, int i)
        {
            if (str.Length > i)
            {
                return true;
            }
            return false;
        }
    }
}
