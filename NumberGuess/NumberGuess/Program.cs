using System;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a variable so we know when the game is over
            bool gameOver = false;

            //This creates a random number for the game
            Random randomGenerator = new Random();
            int numberToGuess = randomGenerator.Next(1, 100);

            //Create a variable to keep track of the number of guesses
            int numberOfGuesses = 0;

            //We want to loop as long as the game is not over
            while(!gameOver)
            {
                //Call the method that gets the user's guess and put
                //  it into an int variable so we can use it later
                int guess = GetUserInput();

                //The user guessed a number so increment the counter
                numberOfGuesses++;

                //Call the method that checks to see if the users guessed the right number
                //  this method returns a bool so we need to put it into a bool variable
                //  so we can check to see if we need to stop looping
                gameOver = CorrectAnswer(numberToGuess, guess, numberOfGuesses);
            }//This is where we go back up to the while to check if the game is over

            //Prevent the application from closing until the user presses the enter key
            Console.ReadLine();
        }

        //This method takes no arguments from Main.
        //  it does return the number the user guessed as an int
        static int GetUserInput()
        {
            Console.WriteLine("Guess a number 1-100");

            //Get the user's guess. Since ReadLine always returns a string we have to store
            //  it in a string variable
            string userGuessAsString = Console.ReadLine();

            //Now convert the string into an int so we can compare it to the answer
            int userGuess = Convert.ToInt32(userGuessAsString);

            //Return the user's guess as a int
            return userGuess;
        }

        //This method takes 3 arguments from Main, the answer to the game that was generated in
        //  Main, the number the user guessed, and the number of times the user has guessed
        static bool CorrectAnswer(int answer, int usersGuess, int guessCount)
        {
            //Check to see if the user guessed the correct number
            if (answer == usersGuess)//The user's guess was correct
            {
                //Write to the screen that they guessed correctly and how try it took them
                Console.WriteLine(string.Format("You Guessed {0} correctly in {1} guesses!!", answer, guessCount));

                //The game is over so we return true
                return true;
            }
            else if (answer < usersGuess)//The user's guess too high
            {
                //Tell the user their guess was too high
                Console.WriteLine("Your guess was too high!");

                //Return false because the game is not over
                return false;
            }
            else//If the user's guess was not correct AND it was too high then it must be too low
            {
                //Tell the user their guess was too low
                Console.WriteLine("Your guess was too low!");

                //Return false because the game is not over yet
                return false;
            }
        }
    }
}
