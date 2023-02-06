using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKeyword
{
    class Program
    {
        //Lecture 45: Params Keyword
        static void Main(string[] args)
        {
            int[] myArray = { 5, 6, 7, 8, 9, 10 };
            PrintArray(myArray);
            PrintArray(5, 6, 7, 8, 9, 10, 15, 26, 7, 4, 5, 6, 7, 8, 9);
        }

        // Allows to create methods with variable-length parameters. 
        public static void PrintArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
