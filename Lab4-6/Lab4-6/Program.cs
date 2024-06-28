// Design and implement a program that allows the user to play a "Guess My Number" game with the computer.
// When the game starts the program will generate a random number between 1 and 50.  The user should be prompted to guess the number and to enter a number from the keyboard.
// The program will display one of the following messages when the user's guess is incorrect:  "Too high" or "Too low".  The user should be allowed to continue guessing until
// he/she/they guess correctly.
// The program should keep track of number of guesses that the user makes and should display the
// number of guesses along with a congratulatory message at the end of the game.



//INPUT
//userNumber

//Proccessing

//OUTPUT
//to high display
//to low display
//guess again display 
//display the number of guesses that the user has made
//display a congragulations at the end of the game


//PSEUDOCODE

//random number generated that is between 1 - 50 
//int targetNumber = random.Next(1, 51);
//Initialize a variable to store user's guess count
//Int guessCount = 0;
// prompt the user to make a guess between numbers 1 and 50 
//Console.WriteLine("Guess a number between 1 and 50:")

//store results of number in a variable 
//int userGuess = int.Parse(Console.ReadLine())
//while (userGuess != targetNumber)
// Increment the guess count
//guessCount++;

// Check if the guess is too high or too low
//if (userGuess > targetNumber)
//{
//Console.WriteLine("Too high! Guess again:");
//}
//else
//{
//    Console.WriteLine("Too low! Guess again:");
// }

// Prompt the user to continue guessing
//userGuess = int.Parse(Console.ReadLine());
//}

// Display the number of guesses that the user has made
//Console.WriteLine($"Congratulations! You guessed the number in {guessCount} guesses.");

using System;

public class GuessMyNumberGame
{
    public static void Main()
    {
        // Generate a random number between 1 and 50 as the target number
        int targetNumber = new Random().Next(1, 51);

        // Initialize a variable to keep track of the user's guess count
        int guessCount = 0;

        // Display a welcome message for the Guess My Number game
        Console.WriteLine("Welcome to Guess My Number Game!");

        // Prompt the user to guess a number between 1 and 50
        Console.WriteLine("Guess a number between 1 and 50:");

        // Declare a variable to store the user's guess
        int userGuess;

        // Start an infinite loop for the game
        while (true)
        {
            // Validate user input
            // Continue prompting the user until a valid number between 1 and 50 is entered
            while (!int.TryParse(Console.ReadLine(), out userGuess) || userGuess < 1 || userGuess > 50)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 50.");
                Console.Write("Guess again: ");
            }

            // Increment the guess count for each valid guess
            guessCount++;

            // Check if the user's guess is too high, too low, or correct
            if (userGuess > targetNumber)
            {
                Console.WriteLine("Too high! Guess again:");
            }
            else if (userGuess < targetNumber)
            {
                Console.WriteLine("Too low! Guess again:");
            }
            else
            {
                // Display the number of guesses and congratulate the user for guessing correctly
                Console.WriteLine($"Congratulations! You guessed the number in {guessCount} guesses.");
                break; // Exit the loop when the correct guess is made
            }
        }
    }
}