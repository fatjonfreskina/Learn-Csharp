using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        //Lecture 61: Exercise 2
        /*
         * 
         *  Create a class named Taxpayer. 
            
            Data fields for Taxpayer objects include the Social Security number,
            the yearly gross income, and the tax owed. 
            
            Include a property with get and set accessors for the first two
            data fields, but make the tax owed a read-only property.

            The tax should be calculated whenever the income
            is set. 
            
            Assume the tax is 15 % of income for incomes
            under $30,000 and 28 % for incomes that are $30,000
            or higher. 
            
            Write a program that declares an array of ten
            Taxpayer objects. Prompt the user for data for each
            object and display the ten objects.
         * 
         * 
         * */
        static void Main(string[] args)
        {
            Taxpayer[] taxpayersArr = new Taxpayer[10];
            string inputSSN;
            double inputYearlyGrossIncome;
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Give me the SSN for Tax Payer number {0}:", i);
                inputSSN = Console.ReadLine();

                Console.WriteLine("Give me the Yearly Gross Income for Tax Payer number {0}:", i);
                if (!double.TryParse(Console.ReadLine(), out inputYearlyGrossIncome))
                {
                    Console.WriteLine("Tax payer number {0} has not been instantiated because of error while parsing parameter", i);
                }
                else
                {
                    taxpayersArr[i] = new Taxpayer(inputSSN, inputYearlyGrossIncome);
                }

            }
        }
    }
}
