using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Job
    {
        private string jobDescription;
        private float timeToComplete;
        private float perHourFee;
        private float totalFee;

        public Job(string newJobDescription, float newTimeToComplete, float newPerHourFee)
        {
            JobDescription = newJobDescription;
            TimeToComplete = newTimeToComplete;
            PerHourFee = newPerHourFee;
            totalFee = calcTotalFee();
        }

        public string JobDescription
        {
            get 
            {
                return jobDescription;
            }
            set
            {
                jobDescription = value;
            }
        }

        public float TimeToComplete
        {
            get
            {
                return timeToComplete;
            }
            set
            {
                timeToComplete = value;
                this.totalFee = calcTotalFee();
            }
        }

        public float PerHourFee
        {
            get
            {
                return perHourFee;
            }
            set
            {
                perHourFee = value;
                this.totalFee = calcTotalFee();
            }
        }

        public float calcTotalFee()
        {
            return timeToComplete * perHourFee;
        }

        public float TotalFee
        {
            get
            {
                return totalFee;
            }
        }

        public static Job operator +(Job firstJob, Job secondJob)
        {
            string newJobDescription = firstJob.JobDescription + " and " + secondJob.JobDescription;
            float newTimeToComplete = firstJob.TimeToComplete + secondJob.TimeToComplete;
            float newPerHourFee = (firstJob.PerHourFee + secondJob.PerHourFee)/2;

            return new Job(newJobDescription,newTimeToComplete, newPerHourFee);
        }

        public void print()
        {
            Console.WriteLine("Description: {0}, Time to complete: {1}, Per hour fee: {2}", JobDescription, TimeToComplete, PerHourFee);
        }

    }
}