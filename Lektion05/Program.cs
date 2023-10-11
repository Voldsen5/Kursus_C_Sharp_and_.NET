using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lektion05
{
    internal class Program
    {
        public static List<Person> people1 { get; private set; }

        static void Main(string[] args)
        {
            List<int> list = new List<int>
            {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            11, 12, 13, 14, 15, 16, 17, 18
            };

            List<int> ligeTal = list.FindAll(x => x % 2 == 0);
            ligeTal.ForEach(x => Console.WriteLine(x));

            int sidsteTalOver_15 = list.FindLast(x => x >= 15);
            Console.WriteLine("Sidste tal over 15: " + sidsteTalOver_15);

            int sidsteTalsIndexOver_15 = list.FindLastIndex(x => x >= 15);
            Console.WriteLine("Index på sidste tal over 15: " + sidsteTalsIndexOver_15);

            IEnumerable<int> ints = list.Where(i => i % 2 == 0);
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

            IEnumerable<int> ints1 = list.Where(i => i.ToString().Length == 2);
            foreach (int i in ints1)
            {
                Console.WriteLine(i);
            }

            var s = from x in ints
                    where x % 2 == 0
                    select x;
            foreach (int i in s)
            {
                Console.WriteLine("*" + i);
            }


            Exercise1();
            List<Person> resultat = people1.FindAll(p => p.Score < 2);
            

            List<Person> resultat2 = people1.FindAll(p => p.Score % 2 == 0);

            List<Person> resultat3 = people1.FindAll(p => p.Score % 2 == 0 && p.Weight > 60);

            List<Person> resultat4 = people1.FindAll(p => p.Weight % 3 == 0);

            foreach (Person p in resultat) {
                Console.WriteLine(p.ToString());
            }

            int index = people1.FindIndex(people1 => people1.Score == 3);
            int index2 = people1.FindIndex(p => p.Score == 3 && p.Age < 10);
            List<Person> index3 = people1.FindAll(p => p.Age < 10 && p.Score == 3);
            int index4 = people1.FindIndex(p => p.Age < 8 && p.Score == 3);

            Console.WriteLine("Index: " + people1.ElementAt(index4));

            List<Person> Oevelse_5_6 = people1.SetAccepted(people1 => people1.Score >= 6 && people1.Age <= 40);


        }
        public static void Exercise1()
        {
            try
            {
                people1 = Person.ReadCSVFile(@"C:\Users\Volds\source\repos\Lektion1\Lektion05\data1.csv");
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION: " + ex.Message);
                Console.WriteLine("You should probably set the filename to the Person.ReadCSVFile method to something on your disk!");
            }


        }
    }
    public static class ExtensionMethod1
    {
        public static void SetAcceptedP(this List<Person> lst, Predicate<Person> pre)
        {
            foreach (Person p in lst)
            {
                if (pre(p) == true)
                {
                    p.Accepted = true;
                }
            }
        }
    }
}
