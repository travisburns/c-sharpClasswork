using System;

public class RockPaperScissorsGame
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Rock, Paper, Scissors!");

        // Get user's move
        Console.Write("Enter your move (Rock, Paper, or Scissors): ");
        string userMove = Console.ReadLine().ToLower();

        // Validate user input
        if (userMove != "rock" && userMove != "paper" && userMove != "scissors")
        {
            Console.WriteLine("Invalid input. Please enter Rock, Paper, or Scissors.");
            return;
        }

        // Generate computer's move (1 = Rock, 2 = Paper, 3 = Scissors)
        Random random = new Random();
        int computerMove = random.Next(1, 4);

        // Display user's and computer's moves
        Console.WriteLine($"Your move: {userMove}");
        Console.WriteLine($"Computer's move: {GetMoveName(computerMove)}");

        // Determine the winner
        DetermineWinner(userMove, computerMove);
    }

    // Helper method to convert computer's move number to move name
    private static string GetMoveName(int move)
    {
      /*if (move == 1)
        {
            return "Rock";
        }
        else if (move == 2)
        {
            return "Paper";
        }
        else if (move == 3)
        {
            return "Scissors";
        }
        else
        {
            return "Invalid";
        }
      */
      //Switch statement is technically 'better'
        switch (move)
        {
            case 1:
                return "Rock";
            case 2:
                return "Paper";
            case 3:
                return "Scissors";
            default:
                return "Invalid";
        }
    }

    // Helper method to determine the winner
    private static void DetermineWinner(string userMove, int computerMove)
    {
        string computerMoveName = GetMoveName(computerMove);

        if (userMove == computerMoveName.ToLower())
        {
            Console.WriteLine("It's a tie!");
        }
        else if (
            (userMove == "rock" && computerMoveName == "Scissors") ||
            (userMove == "paper" && computerMoveName == "Rock") ||
            (userMove == "scissors" && computerMoveName == "Paper")
        )
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("Computer wins!");
        }
    }
}