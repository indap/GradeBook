using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // var p = new Program();
            // Program.Main(args); 

            var book = new Book("Indap's grade book");
            book.AddGrade(6.2);
            book.AddGrade(24.8);
            book.AddGrade(35.6);

            var stats = book.GetStatistics();
            Console.WriteLine($"Average result is {stats.Average:N1}.");
            Console.WriteLine($"Highest grade is {stats.High}.");
            Console.WriteLine($"Lowest grade is {stats.Low}.");

           /*
            double x = 21;
            double y = 2;
            double result = x * y;
            Console.WriteLine(result); */ 

            //var numbers = new double[] {2.1, 4.4, 5.6}; //
            /* OR var numbers = new[]  */
            // var grades = new List<double> () {2.1, 4.4, 5.6};
            // grades.Add(21.43);


            /*
            var result = numbers[0];
            result = result + numbers[1]; // OR result += numbers[1] //
            result = result + numbers[2];
            Console.WriteLine(result);
            */

            // For large input numbers //
            // var result = 0.0;
            // var highGrade = double.MinValue;
            // var lowGrade = double.MaxValue;
            // foreach(double number in grades)
            // {
            //     /* OR
            //     if(number > highGrade)
            //     {
            //         highGrade = number;
            //     }
            //     */
            //     highGrade = Math.Max(number, highGrade);
            //     lowGrade = Math.Min(number, lowGrade);
            //     result += number;
            // }
            // result /= grades.Count;
            // Console.WriteLine($"Average result is {result:N2}.");
            // Console.WriteLine($"Highest grade is {highGrade}.");
            // Console.WriteLine($"Lowest grade is {lowGrade}.");


        }
    }
}
