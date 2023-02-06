using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        //Lecture 50: Exercise 3
        /*
         * 
         *  Create a method named Sum() that accepts any number of
            integer parameters and displays their sum. Write a Main()
            method that demonstrates the Sum() method works correctly
            when passed one, three, or five integers, or an array of ten
            integers
         * 
         * 
         * */
        static void Main(string[] args)
        {
            int[] test1 = {1,2,3};
            int[] test2 = {1,2,3,4};
            int[] test4 = {1,2,3,6,3};
            int[] test3 = {1,2,3,5,1,2};

            Sum(test1);
            Sum(test4);
            Sum(test3);
            Sum(test2);
        }

        public static void Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("Sum : {0}", sum);
        }
    }
}
