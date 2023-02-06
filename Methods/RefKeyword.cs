using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefKeyword
{
    class Program
    {
        //Lecture 43: Ref Keyword
        static void Main(string[] args)
        {
            int studentGrade = 75;
            GiveExtraCredit(ref studentGrade);
            Console.WriteLine(studentGrade);
        }

        // You can force the "pass by reference"
        // The value must be initialized though!
        public static void GiveExtraCredit(ref int studentGrade)
        {
            studentGrade += 3;
        }
    }
}
