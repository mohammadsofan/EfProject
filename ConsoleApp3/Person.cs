using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age {  get; set; }
        public Person(string name="UNSET", int age=0)
        {
            Name = name;
            Age = age;
        }
        public Person()
        {
            Console.WriteLine("i'am person");
        }
        public void Print()
        {
            Console.WriteLine(Name+" from person class");
        }
        
    }
}
