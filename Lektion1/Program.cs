using Lektion1;
using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Kristoffer", 23);
            Person p2 = new Person("Lars", 99);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Animal a1 = new Animal("dog");
            Animal a2 = new Animal("Kat");

            Console.WriteLine(a1.isDog());
            Console.WriteLine(a2.isDog());

            Console.WriteLine("Hvad skal race skal dyret være:");
            Animal a3 = new Animal(Console.ReadLine());

            while (!a3.isDog())
            {
                Console.WriteLine("Hvad skal race skal dyret være:");
                a3.race = (""+ Console.ReadLine());
            } 

            Console.WriteLine(a3.isDog());

            var list = new MyList();

            list.add(1);
            list.add(10);
            list.add(100);
            list.printNumbers();

            var list2 = new MyList();
            list2.CreateRandomList(10);
            list2.printNumbers();
        }
    }
}
