using System;

namespace ConcentrationStart
{
    class Program
    {
        // Constants for defining the game board size
        const int ROWS = 4;
        const int COLUMNS = 5;
        const int SIZE = 20;
        const int PAUSE = 2; // Pause duration between turns

        static void Main(string[] args)
        {
            string[] board;
            string[] words = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            string[] matchingWords = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            int matchesRemaining = 10;

            // Create and initialize the game board
            board = CreateBoard(words, matchingWords);

            // Shuffle the board to randomize the card positions
            Shuffle(board);

            int index1, index2;

            do
            {
                index1 = -1;
                index2 = -1;

                // Draw the game board
                DrawBoard(board, index1, index2);

                // Get the index of the first card from the player
                index1 = GetIndex(board, index2);

                // Draw the game board again with the first card revealed
                DrawBoard(board, index1, index2);

                // Get the index of the second card from the player
                index2 = GetIndex(board, index1);

                // Draw the game board again with both cards revealed
                DrawBoard(board, index1, index2);

                // Pause briefly to let the player see the cards
                Pause();

                // Check if the two revealed cards match
                if (IsMatch(board, words, matchingWords, index1, index2))
                {
                    Console.WriteLine("Match found!");
                    matchesRemaining--;

                    // Remove the matched cards from the board
                    board[index1] = "";
                    board[index2] = "";
                }

                // Pause again before starting the next turn
                Pause();

            } while (matchesRemaining > 0);

            // Game over message
            Console.WriteLine("Congratulations! You've matched all pairs!");
        }

        // Method to create and initialize the game board
        static string[] CreateBoard(string[] words, string[] matches)
        {
            string[] board = new string[SIZE];
            Array.Copy(words, board, words.Length);
            Array.Copy(matches, 0, board, words.Length, matches.Length);
            return board;
        }

        // Method to shuffle the game board
        static void Shuffle(string[] board)
        {
            Random rand = new Random();
            int n = board.Length;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                string temp = board[k];
                board[k] = board[n];
                board[n] = temp;
            }
        }

        // Method to get an integer input from the player
        static int GetInt(string label, int min, int max)
        {
            int number;
            bool isValid;
            do
            {
                Console.Write($"Enter {label} ({min}-{max}): ");
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out number);
                if (!isValid || number < min || number > max)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    isValid = false;
                }
            } while (!isValid);
            return number;
        }

        // Method to get the index of the card selected by the player
        static int GetIndex(string[] board, int otherIndex)
        {
            int index;
            do
            {
                index = GetInt("card number", 1, SIZE);
            } while (index == otherIndex || board[index - 1] == "");
            return index - 1;
        }

        // Method to check if the two revealed cards match
        static bool IsMatch(string[] board, string[] words, string[] matchingWords, int index1, int index2)
        {
            string word1 = board[index1];
            string word2 = board[index2];
            int idx1 = Array.IndexOf(words, word1);
            int idx2 = Array.IndexOf(words, word2);
            if (idx1 == -1)
            {
                idx1 = Array.IndexOf(matchingWords, word1);
                return matchingWords[idx1] == word2;
            }
            else
            {
                return words[idx1] == word2;
            }
        }

        // Method to add a pause between turns
        static void Pause()
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(PAUSE));
        }

        // Method to center text on the console window
        public static String Center(String text, int len)
        {
            if (len <= text.Length)
                return text.Substring(0, len);
            int before = (len - text.Length) / 2;
            int after = len - text.Length - before;
            return new String(' ', before) + text + new String(' ', after);
        }

        // Method to draw the game board on the console window
        static void DrawBoard(string[] board, int index1, int index2)
        {
            Console.Clear();
            int index = 0;
            string top = ".=============";
            string second = "|             ";
            string middle = "|";
            string output;
            for (int r = 0; r < ROWS; r++)
            {
                for (int c = 0; c < COLUMNS; c++)
                    Console.Write(top);
                Console.Write(".\n");
                for (int c = 0; c < COLUMNS; c++)
                    Console.Write(second);
                Console.Write("|\n");

                for (int c = 0; c < COLUMNS; c++)
                {
                    if (index == index1 || index == index2)
                        output = board[index];
                    else if (board[index] == "")
                        output = "";
                    else
                        output = "?" + (index + 1) + "?";
                    output = Center(output, 13);
                    Console.Write(middle + output);
                    index++;
                }
                Console.Write("|\n");

                for (int c = 0; c < COLUMNS; c++)
                    Console.Write(second);
                Console.Write("|\n");
            }
            for (int c = 0; c < COLUMNS; c++)
                Console.Write(top);
            Console.Write(".\n");
        }
    }
}