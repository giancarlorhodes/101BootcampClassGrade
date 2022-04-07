using System;
using System.Collections.Generic;
using System.Linq;

namespace _101BootcampClassGradeLibrary
{
    public class ClassRoom
    {
        public List<Student> ListOfStudents { get; set; }

        public ClassRoom()
        {
            this.ListOfStudents = new List<Student>();

        }

        public bool IsStudentInClass(string inNameToSearchOn)
        {

            if (this.ListOfStudents.Where(x => x.Name == inNameToSearchOn).Count() != 0)
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
