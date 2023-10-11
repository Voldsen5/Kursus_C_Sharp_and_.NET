using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion02
{
    internal class Fibonacci
    {
        public Fibonacci() { }


           
        public List<int> fibonacciUdregner(int input) 
        {
            List<int> values = new List<int>();
            values.Add(0);
            int sideValue = 1;
            int latestValue = 0;
            int crazyValue = 0;

            if (input <= 0) 
            {
            return values;
            }
            else if (input > 0)
            {
                for (int i = 0; i < input; i++)
                {
                    values.Add(sideValue);
                    crazyValue = sideValue;
                    sideValue = sideValue + latestValue;
                    latestValue = crazyValue;
                    

                }
            }

            return values;
        }

    }
}
