using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion1
{
    internal class MyList: List<int>
    {
        public void add(int x)
        {
            this.Add(x);
        }

        public void printNumbers()
        {
            for (int i = 0; i < this.Count; i++)
            {
                Console.WriteLine(this[i]);
            }
        }

        public void CreateRandomList(int size)
        {
            var random = new Random();
            for (int i = 0;i < size;  i++) 
            {
                this.add(random.Next(0,101));
            }
        }
    }
}
