using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101BootcampClassGradeLibrary
{
    public class Student
    {
        public string Name { get; set; }
        public double StudentAverage { get; set; }

        public List<double> Grades { get; set; }

        public Student(string inName)
        {
            this.Name = inName;
            this.Grades = new List<double>();
        }

        public void CalculateStudentAverage()
        {
            Grader _grader = new Grader();
            this.StudentAverage = _grader.CalculateAverage(this.Grades);

        }

    }
}
