using System;
using System.Collections.Generic;
using System.Linq;

namespace _101BootcampClassGradeLibrary
{
    // container class that has all students
    // students has all their own grades
    // so by logic, if you have a ClassRoom object, you have everything you need to do 
    // need calculations
    public class ClassRoom
    {
        public List<Student> ListOfStudents { get; set; }

        public ClassRoom()
        {
            this.ListOfStudents = new List<Student>();
        }

        public bool IsStudentInClass(string inNameToSearchOn)
        {
            if (this.ListOfStudents.Where(x => x.Name.ToUpper() == inNameToSearchOn.ToUpper()).Count() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
