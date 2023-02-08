using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyword
{
    class Program
    {
        //Lecture 59: Static Keyword
        // Anything you mark static is shared among the class objects
        // And it can be called on the class itself. 
        // Example Console.WriteLine("Hello"); Console is a class!
        static void Main(string[] args)
        {
            Person p1 = new Person("ted", 5);
            Person p2 = new Person("fred", 5);

            Console.WriteLine(Person.Count);

            Test();

        }
        public static void Test() // Since main is static it can only see static methods. Test needs to be static
        {
            Console.WriteLine("test");
        }
    }
}
