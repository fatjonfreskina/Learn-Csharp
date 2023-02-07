using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Student
    {
        private string name;
        private int age;
        private double finalGrade;

        public Student(string name, int age, double finalGrade)
        {
            this.name = name;
            this.age = age;
            this.finalGrade = finalGrade;
        }
        public Student(string name, int age) : this(name, age, 0)
        {

        }

        public void SayHello()
        {
            Console.WriteLine("Hello from {0}", name);
        }
    }
}
