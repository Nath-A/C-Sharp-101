using System;
using CSharp101_Tools;

namespace PasswordGenerator
{
    class Program
    {
        const int NB_PASSWORD = 10;
        enum PasswordChooseEnum
        {
            LOWERCASES = 1,
            LOWERCASES_AND_UPPERCASES = 2,
            LOWERCASES_UPPERCASES_AND_NUMBERS = 3,
            LOWERCASES_UPPERCASES_NUMBERS_AND_STUFF = 4
        }
        static void Main(String[] args)
        {
            int PasswordLength = AskANumber.AskPositiveTo0Number("How many characters ? ");
            Console.WriteLine();
            int PasswordType = AskANumber.AskNumberBetween("Choose your type of password between those\n" +
                "1 : lowercases\n" +
                "2 : lowercases and uppercases\n" +
                "3 : lowercases, uppercases and numbers\n" +
                "4 : lowercases, uppercases, numbers and other stuff\n", 1, 5);

            string lowercases = "azertyuiopqsdfghjklmwxcvbn";
            string uppercases = lowercases.ToUpper();
            string numbers = "1234567890";
            string nonAlphanumericstuff = "&é'(§è!çà)-_^$ùµ;:=/%£*";
            string alphabet = "";

            switch (PasswordType)
            {
                case (int)PasswordChooseEnum.LOWERCASES:
                    alphabet = lowercases;
                    break;

                case (int)PasswordChooseEnum.LOWERCASES_AND_UPPERCASES:
                    alphabet = lowercases + uppercases;
                    break;

                case (int)PasswordChooseEnum.LOWERCASES_UPPERCASES_AND_NUMBERS:
                    alphabet = lowercases + uppercases + numbers;

                    break;

                case (int)PasswordChooseEnum.LOWERCASES_UPPERCASES_NUMBERS_AND_STUFF:
                    alphabet = lowercases + uppercases + numbers + nonAlphanumericstuff;
                    break;

                default:
                    break;
            }


            int l = alphabet.Length;

            Random random = new Random();
            for (int j = 0; j < NB_PASSWORD; j++)
            {
                string password = "";
                for (int i = 0; i < PasswordLength; i++)
                {
                    int index = random.Next(0, l);
                    password += alphabet[index];
                }
                Console.WriteLine($"Here is your {j+1}st password : {password}");
            }
        }
    }
}