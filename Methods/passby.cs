using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Everything is a Struct in c# is a value type
    Everything is a Class is a reference type

    C# Data types are: Value types (int bool float..), Reference types (class, string, dynamic), Pointer types (pointers)
*/

namespace PassByRefVal
{
    class Program
    {
        //Lecture 42: Pass by Reference vs Pass by Value
        static void Main(string[] args)
        {
            //Pass by value
            int student1Grade = 75;
            Console.WriteLine("Students grade before extra credit {0}",student1Grade);
            GiveExtraCredit(student1Grade);
            Console.WriteLine("Students grade AFTER extra credit {0}", student1Grade);

            //Pass by reference
            int[] grades = new int[1];
            grades[0] = 75;
            Console.WriteLine("Student array grade before extra credit {0}",grades[0]);
            GiveExtraCreditArray(grades);
            Console.WriteLine("Student array grade AFTER extra credit {0}", grades[0]);

        }
		
		// "Small" types are passed by value
        public static void GiveExtraCredit(int studentsGrade)
        {
            studentsGrade += 3;
            //Console.WriteLine("Students grade after extra credit inside function {0}", studentsGrade);
        }
		
		// Big types passed by reference
        public static void GiveExtraCreditArray(int[] grades)
        {
            grades[0] += 3;
        }
    }
}
