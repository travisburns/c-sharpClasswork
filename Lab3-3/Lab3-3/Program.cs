using System;

public class AdditionPractice
{
    public static void Main()
    {
        // Create a random number generator
        Random generator = new Random();

        // Generate 2 random integers between 10 and 999
        int firstNumber = generator.Next(10, 1000);
        int secondNumber = generator.Next(10, 1000);

        // Display the addition problem
        Console.WriteLine($"Add the following two numbers: {firstNumber} + {secondNumber}");

        // Accept user input for their answer
        Console.Write("Your answer: ");
        int userAnswer;

        // Validate user input to ensure it's a valid integer
        while (!int.TryParse(Console.ReadLine(), out userAnswer))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Console.Write("Your answer: ");
        }

        // Calculate the correct answer
        int correctAnswer = firstNumber + secondNumber;

        // Verify if the user's answer is correct
        if (userAnswer == correctAnswer)
        {
            Console.WriteLine("Correct! Well done!");
        }
        else
        {
            Console.WriteLine($"Sorry, the correct answer is {correctAnswer}");
        }
    }
}