﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            //var p = new Program();
            //Program.Main(args);
            var book = new Book("Choubidou");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var grades = new List<double> { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);
            var result = 0.0;
            var hightGrade = double.MinValue;

            result = grades.Average();

            Console.WriteLine($"The average grade is {result:N2}");
        }
    }
}
