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


Prompt user for their move (Rock, Paper, or Scissors)
    Console.WriteLine(Rock, paper, or scissors:)
 Get user's move and store it in UserMove
    string UserMove = Console.ReadLine()

Validate user's move:
    if userMove is not "Rock and Not "Paper" and/or "scissors":
    use do while loop to validate user input 
    within the do while have a if statement where if not scissors, rock, or paper.
    Console.WriteLine("That is not a valid choice. Please re-enter")
    


Generate computer's move:
Generate a random number between 1 and 3 (1 = Rock, 2 = Paper, 3 = Scissors)
  int computerMove = random.Next(1, 4);
Determine the winner:
If user's move equals computer's move:
Display "It's a tie!"
If user's move beats the computer's move:
Display "You win!"
If computer's move beats the user's move:
Display "Computer wins!"

Display the result (tie, user wins, or computer wins)

*/

//CODE:

using System;

public class RockPaperScissorsGame
{
    public static void Main()
    {
        // Printing a welcome message to the user
        Console.WriteLine("Welcome to Rock, Paper, Scissors!");

        // A variable to store the user's move
        string userMove;

        // Repeatedly asking the user for their move until they enter a valid one
        do
        {
            // Prompting the user to enter their move
            Console.Write("Enter your move (Rock, Paper, or Scissors): ");

            // Getting the user's move and making it lowercase for simplicity
            userMove = Console.ReadLine().ToLower();

            // Checking if the user's input is not a valid move
            if (userMove != "rock" && userMove != "paper" && userMove != "scissors")
            {
                // Displaying an error message for invalid input
                Console.WriteLine("Invalid input. Please enter Rock, Paper, or Scissors.");
            }
        } while (userMove != "rock" && userMove != "paper" && userMove != "scissors");

        // Generating the computer's move (1 = Rock, 2 = Paper, 3 = Scissors)
        Random random = new Random();
        int computerMove = random.Next(1, 4);

        // Converting the computer's move number to a string for display
        string computerMoveAsString;
        switch (computerMove)
        {
            // Assigning the corresponding move based on the random number
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

        // Displaying the user's and computer's moves
        Console.WriteLine($"Your move: {userMove}");
        Console.WriteLine($"Computer's move: {computerMoveAsString}");

        // Determining the winner of the game
        if (userMove == computerMoveAsString.ToLower())
        {
            // Displaying a message for a tie
            Console.WriteLine("It's a tie!");
        }
        else if ((userMove == "rock" && computerMoveAsString == "Scissors") ||
                 (userMove == "paper" && computerMoveAsString == "Rock") ||
                 (userMove == "scissors" && computerMoveAsString == "Paper"))
        {
            // Displaying a message for the user winning
            Console.WriteLine("You win!");
        }
        else
        {
            // Displaying a message for the computer winning
            Console.WriteLine("Computer wins!");
        }
    }
}