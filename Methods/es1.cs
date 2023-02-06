using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        //Lecture 48: Exercise 1
        /*
         * 
         *  Create a console-based application whose Main() method
            asks the user to input an integer and then calls a method
            named MultiplicationTable(), which displays the
            results of multiplying the integer by each of the numbers
            2 through 10
         * 
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string userInput = Console.ReadLine();
            int castInput;

            if (int.TryParse(userInput, out castInput)){
                MultiplicationTable(castInput);
            } else {
                Console.WriteLine("Error parsing");
            }

        }

        public static void MultiplicationTable(int input)
        {
            for (int i = 2; i < 11 ; i++)
            {
                input *= i;
            }
            Console.WriteLine("Result is: {0}", input);
        }
        
    }
}
