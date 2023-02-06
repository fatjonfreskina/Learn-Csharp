using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        //Lecture 49: Exercise 2
        /*
         * 
         *  Create a console-based program whose Main() method
            prompts the user for an integer value and, in turn, passes
            the value to a method that squares the number and to
            a method that cubes the number. The Cube() method
            should call the Square() method. The Main() method
            displays the results returned from each of the other methods.
         * 
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number dude:");
            string userInput = Console.ReadLine();
            int castInput;

            if (int.TryParse(userInput, out castInput)){
                double squareResult = (int)castInput;
                double cubeResult = Cube(ref squareResult);
                Console.WriteLine("Cube Result: {0}, Square Result: {1}", cubeResult, squareResult);
            } else {
                Console.WriteLine("Error");
            }
            
        }

        public static double Cube(ref double num){
            double input_number = num;
            Square(ref num);
            return Math.Pow(input_number, 3);
        }

        public static void Square(ref double myNum){
            myNum = Math.Pow(myNum, 2);
        }


    }
}
