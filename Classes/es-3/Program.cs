using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        //Lecture 62: Exercise 3
        /*
         * 
         *  Design a Job class for Harold’s Home Services. The class
            contains four data fields
            
            —Job description (for example, “wash windows”), 
            - time in hours to complete the Job (for example, 3.5), 
            - per-hour rate charged for the Job (for example, $25.00), 
            - and total fee for the Job (hourly rate times hours). 
            
            Include properties to get and set each field
            except the total fee—that field will be read-only, and
            its value is calculated each time either the hourly fee
            or the number of hours is set. 
            
            Overload the + operator
            so that two Jobs can be added. The sum of two Jobs is
            a new Job containing the descriptions of both original
            Jobs (joined by “and”), the sum of the time in hours for
            the original Jobs, and the average of the hourly rate for
            the original Jobs. 
            
            Write a Main() function that demonstrates
            all the methods work correctly
         * 
         * 
         * */
        static void Main(string[] args)
        {
            Job testJob = new Job("Laundry", 20.0f, 10.50f);
            Job secondTestJob = new Job("Making the bed", 0.5f, 10.0f);
            Console.WriteLine(testJob.JobDescription);
            Console.WriteLine(testJob.PerHourFee);
            Console.WriteLine(testJob.TotalFee);

            //testJob.PerHourFee = 30.0f;
            //Console.WriteLine(testJob.TotalFee);

            Job sumOperatorTest = testJob + secondTestJob;
            sumOperatorTest.print();

        }
    }
}
