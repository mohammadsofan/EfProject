using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public string name { get; set; }
        public int age { get; set; }
        public int[] numbers { get; set; }

        public void print()
        {
            Console.WriteLine($"your name is {name} and your age is {age}");
        }

    }
}
