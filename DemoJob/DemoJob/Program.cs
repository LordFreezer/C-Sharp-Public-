using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using static System.Console;
namespace DemoJobs
{
    class program
    {
        static void Main(string[] args)
        {
            Job job1 = new Job("Hero Work", 23, 0.5);
            Job job2 = new Job("Washing the poop sticks", 76, 0.5);
            Job job3 = job1 + job2;
            WriteLine("The {0} job will take {1} hours, costing {2} per hour with a total of {3}",
                job1.Description, job1.Time, job1.Rate.ToString("C"), job1.Total.ToString("C"));
            WriteLine("The {0} job will take {1} hours, costing {2} per hour with a total of {3}",
                job2.Description, job2.Time, job2.Rate.ToString("C"), job2.Total.ToString("C"));
            WriteLine("The {0} job will take {1} hours, costing {2} per hour with a total of {3}",
                job3.Description, job1.Time + job2.Time, job1.Rate + job2.Rate, job1.Total + job2.Total);
            ReadLine();
        }
        public class Job
        {       
            private double time, rate, total;private string description;
            public string Description
            {
                get { return description; }
                set { description = value; }
            }
            public double Time
            {
                get { return time; }
                set { time = value; CalcTotal(); }
            }

            public double Rate
            {
                get { return rate; }
                set { rate = value; CalcTotal(); }
            }
            public double Total
            {
                get { return total; }
            }
            public double CalcTotal()
            {
                total = rate * time;
                return total;
            }
            public Job(string description, double time, double rate)
            {
                Description = description; Time = time; Rate = rate;
            }

            public static Job operator +(Job job1, Job job2)/// i stole this part from Stephan..
            {
                string newDescription = job1.Description + " and " + job2.Description;
                double newTime = job1.Time + job2.Time;
                double newRate = (job1.Rate + job2.Rate) / 2;
                double newTotalFee = newRate * newTime;
                return (new Job(newDescription, newTime, newRate));
            }
        }
    }
}
