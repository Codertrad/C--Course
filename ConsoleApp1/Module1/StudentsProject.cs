﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module1
{
    internal class StudentsProject
    {
        public static void RunStudentsProject()
        {
            // Initialize variables - graded assignments

            int currentAssignments = 5;

            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;

            // Initialize variables - sum of graded assignments

            int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
            int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
            int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

            // Initialize variables - currentScore

            decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
            decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
            decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
            decimal jeongScore = (decimal)jeongSum / currentAssignments;

            // Output of graded assignments

            /*Console.WriteLine("Student\t\tGrade\n");
            Console.WriteLine($"Sophia:\t\t {sophiaScore} \tA");
            Console.WriteLine($"Nicolas:\t {nicolasScore} \tB");
            Console.WriteLine($"Zahira:\t\t {zahirahScore} \tB");
            Console.WriteLine($"Jeong:\t\t {jeongScore} \tA");*/
        }
    }
}
