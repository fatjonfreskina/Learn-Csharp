using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        //Lecture 53: Constructors
        static void Main(string[] args)
        {
            Student s1 = new Student("Tom", 15, 75);
            s1.SayHello();

            Student s2 = new Student("Fred", 15, 90);
            s2.SayHello();

            Student s3 = new Student("Ted", 12, 70);
            s3.SayHello();

            Student s4 = new Student("Frank", 10);
            s4.SayHello();
        }
    }
}
