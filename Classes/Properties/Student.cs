using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Student
    {
        private string name;
        private int age;
        private double finalGrade;
        //Auto-Implemented Property
        public string LastName { get; private set; } // This    

        /*
            The LastName property in the Student class is an example of an 
            auto-implemented property in C#. This type of property automatically 
            generates a private backing field to store the value. The property
            has a get accessor that returns the value of the backing field and 
            a private set accessor that sets the value of the backing field.

            In this example, LastName is a read-only property, meaning that the value 
            of the property can only be read and not set from outside the class.
        */

        public Student(string name, string lastName,int age, double finalGrade)
        {
            this.name = name;
            this.LastName = lastName;
            this.age = age;
            this.finalGrade = finalGrade;
        }
        public Student(string name,string lastName, int age)
            : this(name, lastName,age, 0)
        {

        }

        public void SayHello()
        {
            Console.WriteLine("Hello from {0}", name);
        }

        // Upper case for property
        public string Name
        {
            get
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
            set
            {
                if (value != "")
                {
                    name = value;
                }
            }
        }
        public int Age
        {
            get
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
            set
            {
                if (value != 0)
                {
                    age = value;
                }
            }
        }
        public double FinalGrade
        {
            get
            {
                return finalGrade;
            }
            set
            {
                if (value < 65)
                {
                    value = 65;
                }
                else if (value > 100)
                {
                    value = 100;
                }
                finalGrade = value;
            }
        }
    }
}
