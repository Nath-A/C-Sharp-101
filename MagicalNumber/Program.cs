using System;

namespace MagicalNumber
{
    class Program
    {
        static int AskNumber()
        {


            Console.Write("Give me a number");
            string StringNumber = Console.ReadLine();

            try
            {
                int IntNumber = int.Parse(StringNumber);

            }

            catch
            {

            }

            //if (Number == 0)
            //{
            //    Console.WriteLine("Error, 0 is not a valid number...");
            //    Console.WriteLine("Give me a correct number");
            //    StringNumber = Console.ReadLine();
            //}

            //Console.WriteLine(StringNumber);
            //return Number;

        }
        static void Main(String[] args)
        {
            

            AskNumber();
        }
    }
}