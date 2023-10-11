using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            List<int> list1 = new List<int>();

            Fibonacci fib1 = new Fibonacci();

            list1 = fib1.fibonacciUdregner(15);

            while (list1.Count > 1)
            {
                Console.WriteLine("Du slipper først med 0");
                var input = Console.ReadLine();
                int input_Tal = int.Parse(input);

                list1 = fib1.fibonacciUdregner(input_Tal);

                foreach (int i in list1)
                {
                    Console.WriteLine(i);
                }
            }

            Program p  = new Program();

            Console.WriteLine(p.beregnAlder(2000));

            DateTime date1 = new DateTime(2000, 09, 19);

            int age;

            CalculateAge(date1,out age);

            Console.WriteLine(age);
            
        }

        public int beregnAlder(int fødselsÅr) 
        { 
            int b = 0;
            b = DateTime.Now.Year - fødselsÅr;
            return b; 
        }

        static void CalculateAge(DateTime BirthDateInput, out int age)
        {
            age = DateTime.Now.Year - BirthDateInput.Date.Year;
        }

        static private void MyMethodWithError(int num = 0)
        {

        }

    }
}
