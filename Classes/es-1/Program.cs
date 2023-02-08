using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        //Lecture 60: Exercise 1
        /*
         * 
         *  Create a class named Square that contains fields for area and
            the length of a side and whose constructor requires a parameter
            for the length of one side of a Square. The constructor
            assigns its parameter to the length of the Square’s side field
            and calls a private method that computes the area field. Also
            include read-only properties to get a Square’s side and area.
            In the main method create an array of ten Square objects with sides that 
         *  have values of 1 through 10. Display the values for each Square
         * 
         * 
         * */
        static void Main(string[] args)
        {
            Square square1 = new Square(10);
            float one = square1.SideLength;
            float two = square1.Area;
            Console.WriteLine("Side: {0}, Area: {1}", one, two);

            Square[] squareArr = new Square[10];
            for (int i = 1; i < 11; i++)
            {
                squareArr[i-1] = new Square((float)i);
                Console.WriteLine("{0}",squareArr[i-1].PrintSquare());
            }
        }
    }
}
