using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp101_Tools
{
    public static class AskANumber
    {

        public static int AskPositiveTo0Number(string question)
        {
            return AskNumberBetween(question, 1, int.MaxValue, "Error : Number need to be higther to 0");
            
        }

        public static int AskNumberBetween(string question, int min, int max, string errormessage = null)
        {

            int number = AskNumber(question);
            if (number >= min && number <= max)
            {
                return number;

            }
            else
            {
                if (errormessage == null)
                {
                    Console.WriteLine($"Error : Password length needs to be between {min} & {max}.");

                }
                else
                {
                    Console.WriteLine(errormessage);
                }

                Console.WriteLine();
                return AskNumberBetween(question, min, max);
            }
        }
        static int AskNumber(string question)
        {
            bool correctAnswer = false;
            while (correctAnswer == false)
            {
                Console.Write(question);
                string answer = Console.ReadLine();
                try
                {
                    int answerInt = int.Parse(answer);
                    correctAnswer = true;
                    return answerInt;
                }
                catch
                {
                    Console.WriteLine("You need to enter a number !");
                    Console.WriteLine();

                }
            }

            return 0;
        }
    }
}
