using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion01
{
    internal class Person
    {
        private String name
        { get; set; }
        private int age
        { get; set; }
        public Person(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return "Name is: " + name + ", Age is: " + age;
        }
    }
}
