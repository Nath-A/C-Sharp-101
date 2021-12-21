using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new double[3];
            numbers[0] = 6.66;
            numbers[1] = 66.6;
            numbers[2] = 666;

            
            
            
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]} !");
            }
            else
            {
                Console.WriteLine("Hello Choubidou !");
            }

        }
    }
}
