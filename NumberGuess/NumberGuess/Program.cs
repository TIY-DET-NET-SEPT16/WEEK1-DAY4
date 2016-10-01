using System;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;
            Random randomGenerator = new Random();
            int numberToGuess = randomGenerator.Next(1, 100);
            int numberOfGuesses = 0;

            while(!gameOver)
            {
                int guess = GetUserInput();
                numberOfGuesses++;
                gameOver = CorrectAnswer(numberToGuess, guess, numberOfGuesses);
            }
            Console.ReadLine();
        }

        static int GetUserInput()
        {
            Console.WriteLine("Guess a number 1-100");
            string userGuessAsString = Console.ReadLine();
            int userGuess = Convert.ToInt32(userGuessAsString);
            return userGuess;
        }

        static bool CorrectAnswer(int answer, int usersGuess, int guessCount)
        {
            if (answer == usersGuess)
            {
                Console.WriteLine(string.Format("You Guessed {0} correctly in {1} guesses!!", answer, guessCount));
                return true;
            }
            else if (answer < usersGuess)
            {
                Console.WriteLine("Your guess was too high!");
                return false;
            }
            else
            {
                Console.WriteLine("Your guess was too low!");
                return false;
            }
        }
    }
}
