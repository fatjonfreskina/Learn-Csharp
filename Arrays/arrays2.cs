using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethods
{
    class Program
    {
        //Lecture 35: Useful Array Methods
        static void Main(string[] args)
        {
            //BinarySearch
            int[] myArray = { 10, 15, 20, 30, 35, 40, 45 };
            Console.WriteLine("Enter number to check if it exists");
            int number = int.Parse(Console.ReadLine());

            int answer = Array.BinarySearch(myArray, number);
            if (answer < 0)
            {
                Console.WriteLine("The number does not exist");
            }
            else
            {
                Console.WriteLine("The numbers position in the array is {0}",answer);
            }

            //Sorting an array
            int[] anotherArray = { 10, 5, 7, 2, 55 };
		string output;
		output = String.Format("Array before sorting algorithm: {0}", string.Join(", ", anotherArray.Select(x => x.ToString()).ToArray()));
		Console.WriteLine(output);
            Array.Sort(anotherArray);
            output = String.Format("Array after sorting algorithm: {0}", string.Join(", ", anotherArray.Select(x => x.ToString()).ToArray()));
		Console.WriteLine(output);


		
            //Reverse
            int[] revArray = { 10, 5, 7, 2, 55 };
		output = String.Format("Array before reverse algorithm: {0}", string.Join(", ", revArray.Select(x => x.ToString()).ToArray()));
		Console.WriteLine(output);
            Array.Reverse(revArray);
            output = String.Format("Array after reverse algorithm: {0}", string.Join(", ", revArray.Select(x => x.ToString()).ToArray()));
		Console.WriteLine(output);

        }
    }
}
