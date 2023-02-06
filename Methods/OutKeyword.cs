using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutKeyword
{
    class Program
    {
        //Lecture 44: Out Keyword:  It allows a method to return multiple values through its parameters.
        static void Main(string[] args)
        {
            string personName;
            int personAge;
            // The passed-by-"out" variable is updated
            GetPersonDetails(1, out personName, out personAge);
            Console.WriteLine("Name: " + personName);
            Console.WriteLine("Age: " + personAge);
        }
        public static void GetPersonDetails(int id, out string name, out int age)
        {
            switch (id)
            {
                case 1:
                    name = "John Doe";
                    age = 30;
                    break;
                case 2:
                    name = "Jane Doe";
                    age = 25;
                    break;
                default:
                    name = "Unknown";
                    age = 0;
                    break;
            }
        }

    }
}
