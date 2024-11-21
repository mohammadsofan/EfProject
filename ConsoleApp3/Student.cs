using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student:Person
    {
        public int[] Marks { get; set; } 
        public Student(string name,int age,int[] marks):base(name,age)
        {
            Marks = marks;
        }

        public Student()
        {
            Console.WriteLine("iam student ");
        }
       

        public void printData()
        {
            Console.WriteLine($"name is {Name}");
            Console.WriteLine($"age is {Age}");
            foreach(var s in Marks) Console.WriteLine(s);
        }
        public new void Print()
        {
            Console.WriteLine(Name + " from student class");
        }
    }
}
