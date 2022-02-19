using System;

namespace Week5Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemOne();
            ProblemThree();
            ProblemFour();
        }
        static void ProblemOne()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void ProblemThree()
        {
            int x;
            Console.WriteLine("Please enter a number: ");
            string userChoice = Console.ReadLine();
            int number = int.Parse(userChoice);

            for (x = number - 1; x >= 1; x--)
            {
                number = number * x;

                if (x == 1)
                {
                    Console.WriteLine(userChoice + "! = " + number);
                }

            }
        }
        public static Random random;
        static void ProblemFour()
        {
            random = new Random();
            int min = 1;
            int max = 10;
            int myGuess;
            int correctNumber = random.Next(min, max);
            int tries = 4;
            do
            {
                Console.WriteLine("Please enter your guess");
                string guess = Console.ReadLine();
                myGuess = int.Parse(guess);
                tries--;
                Console.WriteLine("You have " + tries + " tries left until you lose.");


            } while (myGuess != correctNumber && tries > 0);

            if(tries == 0)
            {
                Console.WriteLine("you lose :(");
            }
            if (myGuess == correctNumber)
            {
                Console.WriteLine("YOU WIN!!!");
            }
        }

        
        
    }
}
