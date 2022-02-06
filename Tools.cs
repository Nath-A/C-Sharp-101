using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public static class Tools
    {
        static int AskPositiveTo0Number(string question)
        {
            return AskNumberBetween(question, 1, int.MaxValue);
        }

        static int AskNumberBetween(string question, int min, int max)
        {

            int number = AskNumber("How many characters ?");
            if (number >= min && number <= max)
            {
                return number;

            }
            else
            {
                Console.WriteLine($"Error : Password length needs to be between {min} & {max}.");
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
                }
            }

            return 0;
        }
    }
}

