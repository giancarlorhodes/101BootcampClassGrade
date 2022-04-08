using _101BootcampClassGradeLibrary;
using System;
using System.Linq;

namespace _101BootcampClassGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            //bool IsMoreStudents = true;
            int _studentCounter = 0;
            const int maxStudents = 8; // TODO - use of a constant
            string _yesno = "";
            ClassRoom _classroom = new ClassRoom();

            while ((_studentCounter < maxStudents))
            {
                Console.WriteLine("Do you want to add a new student (YES) " +
                    "and are you done adding students (DONE)");
                _yesno = Console.ReadLine().ToUpper();

                if (_yesno == "YES")
                {
                    Console.WriteLine("Name of student");
                    string _name = Console.ReadLine();
                    Student _student = new Student(_name);
                  

                    _classroom.ListOfStudents.Add(_student);
                    _studentCounter++;
                }

                if (_yesno.ToUpper() == "DONE") break;
              
            }

            bool IsContinue = true;
            while (IsContinue)
            {
                Console.WriteLine("MAIN MENU (L) List Student Names (P) Print Grades (A) Add grade for particular student (D) Done");
                string _menu = Console.ReadLine().ToUpper();

                switch (_menu.ToUpper())
                {

                    case "P":
                        Program.PrintClassGrades(_classroom);
                        break;
                    case "L":
                        Program.PrintStudents(_classroom);
                        break;
                    case "A":
                        Console.WriteLine("Please enter student name you want to enter a grade for");
                        string _name = Console.ReadLine();
                        bool _IsFound = _classroom.IsStudentInClass(_name);
                        // if student is found, get the grade and add it to their grade list
                        if (_IsFound)
                        {
                            // get the grade
                            Console.WriteLine("Enter the grade");
                            double _grade = Convert.ToDouble(Console.ReadLine());
                            _classroom.ListOfStudents.Where(x => x.Name == _name).FirstOrDefault().Grades.Add(_grade);
                            _classroom.ListOfStudents.Where(x => x.Name == _name).FirstOrDefault().CalculateStudentAverage();
                        }
                        else   // else print a message
                        {
                            Console.WriteLine("Student with that name does not exist.");
                        }

                        break;
                    default:
                        IsContinue = false;
                        break;
                }
            }


            Console.WriteLine("Done!!!!");
            Console.ReadLine();

        }

        private static void PrintStudents(ClassRoom inClassroom)
        {
            Console.WriteLine();
            Console.WriteLine("Name".PadRight(60));
            Console.WriteLine("----".PadRight(60));
            foreach (var _student in inClassroom.ListOfStudents)
            {
                Console.WriteLine(_student.Name.PadRight(60));
            }
            Console.WriteLine();
        }



        private static void PrintClassGrades(ClassRoom inClassroom)
        {

            // example print
            // Name                 Grade                     Average
            // --------------------------------------------------------------------------------------
            // Giancarlo            
            //                      87.23
            //                      64.45
            //                      82.43
            //                      90.30
            //                      91.23
            //                                                 80.23                    
            // --------------------------------------------------------------------------------------
            // Adam                 
            //                      100.00
            //                      92.23 
            //                                                 96.99


            // print the header
            Console.WriteLine("Student Name".PadRight(20) + "Grade".PadRight(20) + "Average".PadRight(20) + "Letter Grade".PadRight(20));
            Console.WriteLine("------".PadRight(80, '-'));

            // print each student name once on it's own line
            foreach (var _student in inClassroom.ListOfStudents)
            {
                Console.WriteLine(_student.Name.PadRight(80));

                // write each grade on it's own line, pad 20 before printing then pad 40
                foreach (var _grade in _student.Grades)
                {
                    Console.WriteLine("".PadRight(20) + _grade.ToString().PadRight(60));
                }

                // average line
                Console.WriteLine("".PadRight(40) + _student.StudentAverage.ToString().PadRight(40));

                // letter
                Console.WriteLine("".PadRight(60) + _student.LetterGrade.ToString().PadRight(20));

                // footer line
                Console.WriteLine("-------".PadRight(80, '-'));

                // continue to the next student
            }

        }

    }

}
