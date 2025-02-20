using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module2
{
    internal class StudentGrading
    {
        public static void RunStudentApp()
        {
            // initialize variables - graded assignments 
            int examAssignments = 5;

            string[] studentsName = ["Sophia", "Andrew", "Emma", "Logan"];
            int[] studentsScores = new int[10];
            string currentStudentLetterGrade = "";

            int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
            int[] andrewScores = [92, 89, 81, 96, 90, 89];
            int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
            int[] loganScores = [90, 95, 87, 88, 96, 96];


            Console.WriteLine("Student\t\tGrade\n");

            foreach (string student in studentsName)
            {
                string currentStudent = student;

                if (currentStudent == "Sophia")
                {
                    studentsScores = sophiaScores;
                }
                else if (currentStudent == "Andrew")
                {
                    studentsScores = andrewScores;
                }
                else if (currentStudent == "Emma")
                {
                    studentsScores = emmaScores;
                }
                else if (currentStudent == "Logan")
                {
                    studentsScores = loganScores;
                }

                int sumAssignmentScores = 0;
                decimal currentStudentGrade;
                int gradedAssignments = 0;

                foreach (int score in studentsScores)
                {
                    gradedAssignments += 1;
                    if (gradedAssignments <= examAssignments)
                    { 
                        sumAssignmentScores += score;
                    }
                    else
                    {
                        sumAssignmentScores += score / 10;
                    }
                }

                currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

                if (currentStudentGrade >= 97)
                    currentStudentLetterGrade = "A+";

                else if (currentStudentGrade >= 93)
                    currentStudentLetterGrade = "A";

                else if (currentStudentGrade >= 90)
                    currentStudentLetterGrade = "A-";

                else if (currentStudentGrade >= 87)
                    currentStudentLetterGrade = "B+";

                else if (currentStudentGrade >= 83)
                    currentStudentLetterGrade = "B";

                else if (currentStudentGrade >= 80)
                    currentStudentLetterGrade = "B-";

                else if (currentStudentGrade >= 77)
                    currentStudentLetterGrade = "C+";

                else if (currentStudentGrade >= 73)
                    currentStudentLetterGrade = "C";

                else if (currentStudentGrade >= 70)
                    currentStudentLetterGrade = "C-";

                else if (currentStudentGrade >= 67)
                    currentStudentLetterGrade = "D+";

                else if (currentStudentGrade >= 63)
                    currentStudentLetterGrade = "D";

                else if (currentStudentGrade >= 60)
                    currentStudentLetterGrade = "D-";

                else
                    currentStudentLetterGrade = "F";

                Console.WriteLine($"{currentStudent}:\t\t {currentStudentGrade} \t{currentStudentLetterGrade}");
            }

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();
        }
    }
}
