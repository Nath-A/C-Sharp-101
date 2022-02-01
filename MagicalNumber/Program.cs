using System;

namespace MagicalNumber
{
    class Program
    {
        static int AskNumber()
        {
            int IntNumber = 0;

            while (IntNumber == 0)
            {
                Console.Write("Give me a number : ");
                string StringNumber = Console.ReadLine();

                try
                {
                    IntNumber = int.Parse(StringNumber);

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
            

            int ShowNumber = AskNumber();
            Console.WriteLine($"Here is your number : {ShowNumber}");

        }
    }
}