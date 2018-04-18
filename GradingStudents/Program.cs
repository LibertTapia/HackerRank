﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    class Program
    {
        static int[] solve(int[] grades)
        {
            for(int i = 0 ; i < grades.Length; i++)
            {
                if (grades[i] >= 38)
                {
                    int rem = grades[i] % 5;
                    if (rem >= 3 && rem > 0)
                    {
                        grades[i] = grades[i] - rem + 5;
                    }
                }
            }
            return grades;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] grades = new int[n];
            for (int grades_i = 0; grades_i < n; grades_i++)
            {
                grades[grades_i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] result = solve(grades);
            Console.WriteLine(String.Join("\n", result));


        }
    }
}
