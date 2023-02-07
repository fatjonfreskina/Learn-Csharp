using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAndSetMethods
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
        public Student(string name, int age)
            : this(name, age, 0) // This calls the main constructor passing these values
        {

        }

        public void SayHello()
        {
            Console.WriteLine("Hello from {0}", name);
        }
        public string GetName()
        {
            if (age >= 18)
            {
                return name;
            }
            else
            {
                return "This student is too young";
            }
        }
        public void SetName(string newName)
        {
            if (newName != "")
            {
                name = newName;
            }
        }
        public int GetAge()
        {
            if (age >= 18)
            {
                return age;
            }
            else
            {
                return -1;
            }
        }
        public void SetAge(int newAge)
        {
            if (newAge != 0)
            {
                age = newAge;
            }
        }
        public double GetFinalGrade()
        {
            return finalGrade;
        }
        public void SetFinalGrade(double newFinalGrade)
        {
            if (newFinalGrade < 65)
            {
                newFinalGrade = 65;
            }
            else if (newFinalGrade > 100)
            {
                newFinalGrade = 100;
            }
            finalGrade = newFinalGrade;
        }
    }
}
