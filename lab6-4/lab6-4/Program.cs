using System;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define an array containing 20 pre-programmed responses
            string[] responses = {
                "It is certain",
                "It is decided",
                "Without a doubt",
                "Yes",
                "100%",
                "possible",
                "Most likely",
                "Outlook good",
                "Yes in some way",
                "Signs point to yes",
                "Reply hazy, try again",
                "Ask again later",
                "Better not tell you now",
                "Cannot predict now",
                "Concentrate and ask again",
                "Don't count on it",
                "My reply is no",
                "My sources say no",
                "Outlook not so good",
                "Very doubtful"
            };

            // Create a loop that continues until the user decides to quit
            while (true)
            {
                // Prompt the user to ask a question
                Console.WriteLine("Ask the Magic 8-Ball a question (or type 'exit' to quit):");
                string question = Console.ReadLine();

                // Check if the user wants to exit
                if (question.ToLower() == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                // Generate a random number between 0 and 19
                Random random = new Random();
                int index = random.Next(0, responses.Length);

                // Select the response from the array using the random number as the index
                string response = responses[index];

                // Display the selected response
                Console.WriteLine("Magic 8-Ball says: " + response);
            }
        }
    }
}