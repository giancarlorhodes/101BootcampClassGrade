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

        private char _letterGrade;
      

        //public char LetterGrade { get => _letterGrade; set => _letterGrade = value; }

        public char LetterGrade 
        { 
            get { return _letterGrade; } 
            set 
            {
                // add code to the calculation
               
                _letterGrade = value; 
                this.CalculateStudentAverage();
            } 
        }

        public Student(string inName)
        {
            this.Name = inName;
            this.Grades = new List<double>();
            this._letterGrade = '-';
        }

        public void CalculateStudentAverage()
        {
            Grader _grader = new Grader();
            this.StudentAverage = _grader.CalculateAverage(this.Grades);
            CalculcateLetterGrade();

        }

        private void CalculcateLetterGrade() 
        {

            switch (this.StudentAverage)
            {
                case  >= 90:
                    this._letterGrade = 'A';
                    break;
                case >= 80:
                    this._letterGrade = 'B';
                    break;
                case >= 70:
                    this._letterGrade = 'C';
                    break;
                case >= 60:
                    this._letterGrade = 'D';
                    break;
                default:
                    this._letterGrade = 'F';
                    break;
            }
        }

    }
}
