using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAClass
{
    class Program
    {
        //Lecture 52: Creating a Class
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Bob";
            s1.Age = 15;
            s1.FinalGrade = 65;
            s1.SayHello();

            Student s2 = new Student();
            s2.Name = "Frank";
            s2.Age = 12;
            s2.FinalGrade = 90;
            s2.SayHello();

            Student s3 = new Student();
            s3.Name = "Ted";
            s3.Age = 15;
            s3.FinalGrade = 95;
            s3.SayHello();



        }
    }
}
