using System;

namespace LotterySimulation
{
    class Program
    {
        // Global Constants
        const int Size = 5;
        const int Min = 1;
        const int Max = 69;
        const int PB_index = 5;
        const int PB_Min = 1;
        const int PB_Max = 26;

        static void Main(string[] args)
        {
            // Get user's ticket
            int[] userTicket = GetTicket("user");

            // Get winning ticket
            int[] winningTicket = GetWinningTicket();

            // Display user's ticket
            DisplayTicket("User's Ticket", userTicket);

            // Display winning ticket
            DisplayTicket("Winning Ticket", winningTicket);

            // Count matches
            int matches = CountMatches(userTicket, winningTicket);
            int powerballMatches = userTicket[PB_index] == winningTicket[PB_index] ? 1 : 0;

            // Get ticket value
            decimal prize = GetTicketValue(matches, powerballMatches);

            // Display results
            DisplayResults(matches, powerballMatches, prize);
        }

        static int[] GetTicket(string label)
        {
            Console.WriteLine($"Enter {label}'s ticket (5 numbers between 1 and 69 and 1 number between 1 and 26):");

            int[] ticket = new int[Size + 1]; // Extra space for Powerball
            for (int i = 0; i < Size; i++)
            {
                ticket[i] = GetInt($"Ticket number {i + 1}", Min, Max);
            }

            // Get Powerball number
            ticket[PB_index] = GetInt("Powerball number", PB_Min, PB_Max);

            return ticket;
        }

        static int GetInt(string label, int min, int max)
        {
            int number;
            do
            {
                Console.Write($"Enter {label} ({min}-{max}): ");
            } while (!int.TryParse(Console.ReadLine(), out number) || number < min || number > max);
            return number;
        }

        static int[] GetWinningTicket()
        {
            Random rand = new Random();
            int[] winningTicket = new int[Size + 1]; // Extra space for Powerball
            for (int i = 0; i < Size; i++)
            {
                winningTicket[i] = rand.Next(Min, Max + 1);
            }
            // Get random Powerball number
            winningTicket[PB_index] = rand.Next(PB_Min, PB_Max + 1);

            return winningTicket;
        }

        static void DisplayTicket(string label, int[] ticket)
        {
            Console.WriteLine($"\n{label}:");
            for (int i = 0; i < Size; i++)
            {
                Console.Write(ticket[i] + " ");
            }
            Console.WriteLine("Powerball: " + ticket[PB_index]);
        }

        static int CountMatches(int[] ticket, int[] winningTicket)
        {
            int matches = 0;
            for (int i = 0; i < Size; i++)
            {
                if (HasNumber(ticket[i], winningTicket))
                {
                    matches++;
                }
            }
            return matches;
        }

        static bool HasNumber(int ticketNumber, int[] winningTicket)
        {
            for (int i = 0; i < Size; i++)
            {
                if (ticketNumber == winningTicket[i])
                {
                    return true;
                }
            }
            return false;
        }

        static decimal GetTicketValue(int matches, int powerballMatches)
        {
            decimal prize = 0;

            if (matches == 5 && powerballMatches == 1)
            {
                prize = 1000000;
            }
            else if (matches == 5)
            {
                prize = 50000;
            }
            else if (matches == 4 && powerballMatches == 1)
            {
                prize = 100;
            }
            else if (matches == 4)
            {
                prize = 100;
            }
            else if (matches == 3 && powerballMatches == 1)
            {
                prize = 7;
            }
            else if (matches == 3)
            {
                prize = 7;
            }
            else if (matches == 2 && powerballMatches == 1)
            {
                prize = 4;
            }
            else if (powerballMatches == 1)
            {
                prize = 4;
            }

            return prize;
        }

        static void DisplayResults(int matches, int powerballMatches, decimal prize)
        {
            Console.WriteLine($"\nMatches: {matches}, Powerball Matches: {powerballMatches}, Prize: ${prize}");
        }
    }
}