//Edit your Rock Paper Scissors game from number 4 above to allow the user to play again.
//The program should keep track of how many times the user wins and the computer wins.  


//Edit your Rock Paper Scissors game from lab 3 to validate the user's input.
//When the user enters something other than Rock, Paper or Scissors he/she/they should be forced reenter a choice. 




/*Input:
User's move (Rock, Paper, or Scissors)

Processing:
Validate user input
Check if user's move is Rock, Paper, or Scissors
If not, display an error message and exit the program
Generate a random number for the computer's move (1 = Rock, 2 = Paper, 3 = Scissors)
Determine the winner
Compare user's move and computer's move
Display the result (tie, user wins, or computer wins)

Output:
Display user's move
Display computer's move
Display the winner or if it's a tie


Calculation:
Technically no calculation, but if the user’s move is equal to the computers random move it is a tie,
If user’s move beats computers random move, the user will win
If user’s move does not beat computers random move, the computer wins


PsuedoCode:

//Prompt user for their move (Rock, Paper, or Scissors)
Console.WriteLine("Rock, paper, or scissors:");

//Get user's move and store it in UserMove
string UserMove = Console.ReadLine()

//Validate user's move:
do
{
    //Get user's move
    Console.Write("Enter your move (Rock, Paper, or Scissors): ");
    userMove = Console.ReadLine().ToLower();

    //Validate user input
    if (userMove != "rock" && userMove != "paper" && userMove != "scissors")
    {
        Console.WriteLine("Invalid input. Please enter Rock, Paper, or Scissors.");
    }
} while (userMove != "rock" && userMove != "paper" && userMove != "scissors");

//Generate computer's move:
int computerMove = random.Next(1, 4);

//Determine the winner:
//If user's move equals computer's move:
Console.WriteLine("It's a tie!");

//If user's move beats the computer's move:
Console.WriteLine("You win!");
userWins++;

//If computer's move beats the user's move:
Console.WriteLine("Computer wins!");
computerWins++;

//Display the result (tie, user wins, or computer wins)
Console.WriteLine($"User Wins: {userWins}, Computer Wins: {computerWins}");

//Ask the user if they want to play again
Console.Write("Do you want to play again? (yes/no): ");

*/

//CODE:

using System;

public class RockPaperScissorsGame
{
    public static void Main()
    {
        // Initialize counters for tracking user and computer wins
        int userWins = 0;
        int computerWins = 0;

        // Keep prompting the user until they choose not to play again
        do
        {
            // Prompt the user to enter their move (Rock, Paper, or Scissors)
            string userMove;
            do
            {
                Console.Write("Enter your move (Rock, Paper, or Scissors): ");
                userMove = Console.ReadLine().ToLower();

                // Validate user input
                if (userMove != "rock" && userMove != "paper" && userMove != "scissors")
                {
                    Console.WriteLine("Invalid input. Please enter Rock, Paper, or Scissors.");
                }
            } while (userMove != "rock" && userMove != "paper" && userMove != "scissors");

            // Generate computer's move (1 = Rock, 2 = Paper, 3 = Scissors)
            Random random = new Random();
            int computerMove = random.Next(1, 4);

            // Convert computer's move number to string for display
            string computerMoveAsString;
            switch (computerMove)
            {
                case 1:
                    computerMoveAsString = "Rock";
                    break;
                case 2:
                    computerMoveAsString = "Paper";
                    break;
                case 3:
                    computerMoveAsString = "Scissors";
                    break;
                default:
                    computerMoveAsString = "Invalid";
                    break;
            }

            // Display user's and computer's moves
            Console.WriteLine($"Your move: {userMove}");
            Console.WriteLine($"Computer's move: {computerMoveAsString}");

            // Determine the winner
            if (userMove == computerMoveAsString.ToLower())
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((userMove == "rock" && computerMoveAsString == "Scissors") ||
                     (userMove == "paper" && computerMoveAsString == "Rock") ||
                     (userMove == "scissors" && computerMoveAsString == "Paper"))
            {
                Console.WriteLine("You win!");
                userWins++;
            }
            else
            {
                Console.WriteLine("Computer wins!");
                computerWins++;
            }

            // Display the number of wins for both user and computer
            Console.WriteLine($"User Wins: {userWins}, Computer Wins: {computerWins}");

            // Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
        } while (Console.ReadLine().ToLower() == "yes");
    }
}