///chad marshall you do it 1 8/30/26
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace YouDoIt1
{
    class CreateStudents
    {
        static void Main()
        {
            Student first = new Student();
            Student second = new Student();
            first.IdNumber = 123;
            first.LastName = "Anderson";
            first.GradePointAverage = 3.5;
            second.IdNumber = 789;
            second.LastName = "Jane";
            second.GradePointAverage = 2.3;
            Display(first);
            Display(second);
            ReadLine();
        }
        static void Display (Student stu)
        {
            WriteLine("{0, 5} {1, -10} {2, 6}", stu.IdNumber,
                stu.LastName, stu.GradePointAverage.ToString("F1"));
        }
    }

    class Student
    {
        private int idNumber;
        private string lastName;
        private double gradePointAverage;
        public const double HIGHEST_GPA = 4.0;
        public const double LOWEST_GPA = 0.0;
        public int IdNumber { get; set; }
        public string LastName { get; set; }
        /*public int IdNumber
        {
            get
            {
                return idNumber;
            }
            set                                               wow...
            {
                idNumber = value;
            }    
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }*/
        public double GradePointAverage
        {
            get
            {
                return gradePointAverage;
            }
            set
            {
                if (value >= LOWEST_GPA && value <= HIGHEST_GPA)
                    gradePointAverage = value;
                else
                    gradePointAverage = LOWEST_GPA;
            }
        }
    }
}
