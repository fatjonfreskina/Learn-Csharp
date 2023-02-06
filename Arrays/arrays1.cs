using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAnArray
{
    class Program
    {
        //Lecture 32: Creating an Array
        static void Main(string[] args)
        {	
		// Boring initialization
            int[] myArray = new int[3];
            myArray[0] = 5;
            myArray[1] = 6;
            myArray[2] = 7;
		
		// Better, but you need to have the values!
            int[] myArray2 = new int[3] { 5, 6, 7 };
            int[] myArray3 = new int[] { 5, 6, 7 };
            int[] myArray4 = { 5, 6, 7 };
		
		// Index access
            Console.WriteLine(myArray4[1]);
		
		// Another array of integers
		int[] grades = { 55, 78, 86, 99, 100,66 };
		
		// Change the value of grades with for loop
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] += 3;
                Console.WriteLine(grades[i]);
            }

		// For each loop and format output string
		string output;
            foreach (int score in grades)
            {
                	output = String.Format("Looping with for each, value: {0}", score);
			Console.WriteLine(output);
            }

        }
    }
}