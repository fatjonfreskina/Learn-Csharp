using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        //Lecture 55: Properties
        static void Main(string[] args)
        {
            Student s1 = new Student("Tom", "Bob", 15, 75);
            s1.Name = "";
            Console.WriteLine(s1.Name);
            s1.FinalGrade = 105;
            Console.WriteLine(s1.FinalGrade);
            Console.WriteLine(s1.LastName);
        }
    }
}
