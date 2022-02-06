namespace MathematicsGame
{
    class Program
    {
        enum e_Operator
        {
            ADDITION = 1,
            MULTIPLICATION = 2,
            SUBSTRACTION = 3,
            DIVISION = 4
        }
        static bool AskQuestion(int min, int max)
        {
            Random random = new Random();
            int A = random.Next(min, max + 1);
            int B = random.Next(min, max + 1);
            e_Operator O = (e_Operator) random.Next(1, 4);
            int CorrectResult;
            bool ValidAnswer = false;
            while (ValidAnswer == false)
            //while (true)
            {
                switch (O)
                {
                    case e_Operator.ADDITION:
                        Console.Write($"{A} + {B} = ");
                        CorrectResult = A + B;
                        break;

                    case e_Operator.MULTIPLICATION:
                        Console.Write($"{A} * {B} = ");
                        CorrectResult = A * B;
                        break;

                    case e_Operator.SUBSTRACTION:
                        Console.Write($"{A} - {B} = ");
                        CorrectResult = A - B;
                        break;

                    case e_Operator.DIVISION:
                        Console.Write($"{A} / {B} = ");
                        CorrectResult = A / B;
                        break;

                    default:
                        Console.WriteLine("Error");
                        return false;
                        break;
                }
                
                string Answer = Console.ReadLine();
                try
                {
                    int AnswerInt = int.Parse(Answer);
                    ValidAnswer = true;

                    if (AnswerInt == CorrectResult)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                }
                catch
                {
                    Console.WriteLine("You need to enter a number !");

                }
            }
            return false;

            
        }
        static void Main(String[] args)
        {
            const int MIN_NUMBER = 1;
            const int MAX_NUMBER = 10;
            const int NB_QUESTIONS = 10;

            int points = 0;
            for (int i = 0; i < NB_QUESTIONS; i++)
            {
                Console.WriteLine($"Question n°{i + 1} / {NB_QUESTIONS}");
                bool CorrectAnswer = AskQuestion(MIN_NUMBER, MAX_NUMBER);
                if (CorrectAnswer == true)
                {
                    Console.WriteLine("Congratulation, It is the correct answer !");
                    points++;
                }
                else
                {
                    Console.WriteLine($"Nope...");
                }
                Console.WriteLine("__");
            }
            Console.WriteLine($"You have {points} / {NB_QUESTIONS}");

            float average = NB_QUESTIONS / 2f;
            if (points == NB_QUESTIONS)
            {
                Console.WriteLine("Excellent ! 100% ! ");
            }
            else if (points == 0)
            {
                Console.WriteLine("Quel est le fuck !?");
            }
            else if (points > average)
            {
                Console.WriteLine("That's okay, I guess");
            }
            else
            {
                Console.WriteLine("Boarf...");

            }

        }
    }
}