using System;

namespace MagicalNumber
{
    class Program
    {


        static int AskNumber(int Min, int Max, int Magical)
        {
            int IntNumber = 0;

            bool CorrectNumber = false;

            while (CorrectNumber == false)
            {
                Console.Write($"Give me a number between {Min} and {Max}: ");
                string StringNumber = Console.ReadLine();

                try
                {
                    IntNumber = int.Parse(StringNumber);
                    if (IntNumber < Min || IntNumber > Max)
                    {
                        Console.WriteLine($"Wroooong ! The number needs to be between {Min} and {Max}");

                    }
                    else
                    {
                        CorrectNumber = true;
                    }

                }

                catch
                {
                    Console.WriteLine("That's bullshit ! Try with a valid number");
                }
            }


            //if (Number == 0)
            //{
            //    Console.WriteLine("Error, 0 is not a valid number...");
            //    Console.WriteLine("Give me a correct number");
            //    StringNumber = Console.ReadLine();
            //}

            //Console.WriteLine(StringNumber);
            //return Number;
            return IntNumber;
        }
        static void Main(String[] args)
        {
            const int MinNumber = 1;
            const int MaxNumber = 10;

            Random random = new Random();
            int MagicalNumber = random.Next(MinNumber, MaxNumber + 1);

            int Attempt = 4;

            int ShowNumber = AskNumber(MinNumber, MaxNumber, MagicalNumber);

            while (Attempt > 0)
            {
                
                if (ShowNumber > MagicalNumber)
                {
                    Console.WriteLine("This is too much");
                    
                }

                else if (ShowNumber < MagicalNumber)
                {
                    Console.WriteLine("This is not Enough");
                }

                else
                {
                    break;
                }
                Attempt--;
                Console.WriteLine($"You have {Attempt} attempt(s) left");
                ShowNumber = AskNumber(MinNumber, MaxNumber, MagicalNumber);
                

            }
            if (ShowNumber == MagicalNumber)
            {
                Console.WriteLine("Great ! That's it !");

            }
            else
            {
                Console.WriteLine($"Epic looser ! The correct number was {MagicalNumber} !!!");
            }




        }
    }
}