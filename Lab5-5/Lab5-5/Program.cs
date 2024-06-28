/*Design and implement an application that allows the user to play a simple dice game.  The game begins by allowing the user to pick a number between 2 and 12 
 * (the possible sum of 2 dice).  The computer will then roll 2 dice up to 3 times.  If the number chosen by the user comes up, the user wins and the game ends.  
 * If the number does not come up within 3 tries, the computer wins.  After the game has completed the program should allow the user to play again.  
 * The program should keep track of how many times the user wins and the computer wins.  */



/*input:

    userInput

Processing:

    Welcome: The program displays a welcome message and explains the game rules.
    User Input: The program prompts the user to choose a number between 2 and 12 (inclusive).
    Play Game:
        The program initializes a loop that runs up to 3 times.
        In each iteration:
            The program rolls two dice (simulated with random numbers) and stores the values in separate variables.
            The program calculates the sum of the dice rolls.
            The program calls a function to determine the winner based on the user's chosen number and the sum of the rolls.
                If the sum matches the chosen number, the user wins.
                If the sum doesn't match and it's the third attempt, the computer wins.
        If the user wins before the third attempt, the loop exits.
    Display Results: The program displays a message announcing the winner and the current win counts for both the user and the computer.
    Play Again: The program prompts the user to choose whether they want to play again.
    Repeat: If the user chooses to play again, the program restarts from step 2. Otherwise, the program terminates.

Output:

        Welcome message and game rules.
        Results after each round, announcing the winner and displaying win counts.
        Prompt to play again.

 */


//psuedoCode 

/*
 1. Initialization:

    Initialize variables:
        userWins: Integer to store user wins count (set to 0).
        computerWins: Integer to store computer wins count (set to 0).
        MIN_NUMBER: Integer constant representing the minimum allowed number (2).
        MAX_NUMBER: Integer constant representing the maximum allowed number (12).
        MAX_ATTEMPTS: Integer constant representing the maximum number of attempts (3).
        USER: String constant representing user name ("User").
        COMPUTER: String constant representing computer name ("Computer").

2. Main Loop:

    Welcome and Explain Rules:
        Call DisplayWelcomeAndRules function.
    Get User Input:
        Call GetInt function to get user's chosen number between MIN_NUMBER and MAX_NUMBER.
        Store the input in the number variable.
    Play the Game:
        Call PlayGame function with number as input.
        Store the returned winner (1 for user, 2 for computer) in the winner variable.
    Display Results:
        Call DisplayResults function with winner, userWins, and computerWins.
    Update Scores:
        Call IncrementScores function with winner, userWins, and computerWins.
    Play Again:
        Call GetPlayAgain function to ask user if they want to play again.
        If the user chooses not to play again, exit the loop.

3. End Game:

    Display a message saying "Final score:"
    Display the final win counts:
        "User wins: {userWins}"
        "Computer wins: {computerWins}"

4. Function Definitions:

    GetInt(label, min, max):
        Prompts user for input with the given label.
        Loops until the user enters a valid integer within the min and max range.
        Returns the entered integer.
    PlayGame(number, in/out dice1, in/out dice2):
        Initializes a loop that runs for a maximum of MAX_ATTEMPTS:
            Roll the Dice:
                Generate two random integers between 1 and 6 (inclusive) and store them in dice1 and dice2.
            Determine Winner:
                Call DetermineWinner function with number, dice1, and dice2.
                If the returned winner is 1 (user wins), exit the loop.
                If this is the last attempt (attempt == MAX_ATTEMPTS), set the winner to 2 (computer wins).
            Increase the attempt counter (attempt++).
        Return the winner (1 for user, 2 for computer).
    DetermineWinner(number, d1, d2):
        Calculate the sum of the dice rolls (d1 + d2) and store it in rollSum.
        If rollSum is equal to number, return 1 (user wins).
        If this is the last attempt, return 2 (computer wins).
        Otherwise, return 0 (tie, not applicable in this game).
    DisplayResults(winner, userWins, computerWins):
        If winner is 1, display message "You win!".
        If winner is 2, display message "The computer wins!".
        Display current win counts: "User wins: {userWins}", "Computer wins: {computerWins}".
    IncrementScores(winner, in/out userWins, in/out computerWins):
        If winner is 1, increment userWins.
        If winner is 2, increment computerWins.
    GetPlayAgain():
        Ask the user if they want to play again (e.g., "Play again? (yes/no):")
        Read the user's input (converted to lowercase).
        Return "yes" if the user wants to play again, otherwise return "no".
 
  
 
 */





//Code 
using System;

class Program
{
    const string USER = "User";
    const string COMPUTER = "Computer";
    const int MIN_NUMBER = 2;
    const int MAX_NUMBER = 12;
    const int MAX_ATTEMPTS = 3;

    static void Main()
    {
        int userWins = 0;
        int computerWins = 0;

        do
        {
            DisplayWelcomeAndRules();

            int number = GetInt($"Enter a number between {MIN_NUMBER} and {MAX_NUMBER}: ", MIN_NUMBER, MAX_NUMBER);

            int winner = PlayGame(number, out int dice1, out int dice2);

            DisplayResults(winner, userWins, computerWins);

            IncrementScores(winner, ref userWins, ref computerWins);

        } while (GetPlayAgain());

        Console.WriteLine($"Final score:\nUser wins: {userWins}\nComputer wins: {computerWins}");
    }

    static void DisplayWelcomeAndRules()
    {
        Console.WriteLine("Welcome to the Dice Game!");
        Console.WriteLine("You will choose a number between 2 and 12.");
        Console.WriteLine("The computer will roll 2 dice up to 3 times.");
        Console.WriteLine("If your chosen number comes up, you win!");
        Console.WriteLine("If not, and after 3 tries, the computer wins.");
    }

    static int GetInt(string label, int min, int max)
    {
        int input;
        do
        {
            Console.Write(label);
            if (int.TryParse(Console.ReadLine(), out input) && input >= min && input <= max)
                return input;

            Console.WriteLine($"Please enter a valid number between {min} and {max}.");
        } while (true);
    }
    static int PlayGame(int number, out int dice1, out int dice2)
    {
        Random random = new Random();
        int winner = 0;

        dice1 = 0;
        dice2 = 0;

        for (int attempt = 1; attempt <= MAX_ATTEMPTS; attempt++)
        {
            dice1 = random.Next(1, 7);
            dice2 = random.Next(1, 7);

            winner = DetermineWinner(number, dice1, dice2, attempt);

            if (winner == 0)
                continue; // Continue the loop if no winner yet

            // If we're here, a winner has been determined, so break out of the loop
            break;
        }

        return winner;
    }
    static int DetermineWinner(int number, int d1, int d2, int attempt)
    {
        int rollSum = d1 + d2;

        if (rollSum == number)
            return 1; // User wins

        if (attempt == MAX_ATTEMPTS)
            return 2; // Computer wins after 3 attempts

        return 0; // Tie (not applicable in this game)
    }




    static void DisplayResults(int winner, int userWins, int computerWins)
    {
        if (winner == 1)
            Console.WriteLine("You win!");
        else
            Console.WriteLine("The computer wins!");

        Console.WriteLine($"User wins: {userWins}\nComputer wins: {computerWins}");
    }

    static void IncrementScores(int winner, ref int userWins, ref int computerWins)
    {
        if (winner == 1)
            userWins++;
        else if (winner == 2)
            computerWins++;
    }

    static bool GetPlayAgain()
    {
        Console.Write("Play again? (yes/no): ");
        return Console.ReadLine().Trim().ToLower() == "yes";
    }
}