using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysOfObjects
{
    class Program
    {
        //Lecture 58: Arrays of Objects
        static void Main(string[] args)
        {
            int[] myArray = new int[2];
            myArray[0] = 5;
            myArray[1] = 10;

            Person[] peopleArray = new Person[2];
            peopleArray[0] = new Person("bob", 5); // instantiate each object in the array
            peopleArray[1] = new Person("test", 6);

            for (int i = 0; i < peopleArray.Length; i++)
            {
                Console.WriteLine("{0}, {0}",peopleArray[i].Name,peopleArray[i].Age);
            }
        }
    }
}
