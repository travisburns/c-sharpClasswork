using System;

public class ColorMixingProgram
{
    public static void Main()
    {
        // Display instructions
        Console.WriteLine("Enter two of the 3 primary colors: Red, Yellow, or Blue.");

        // Input
        Console.Write("Color 1: ");
        string color1 = Console.ReadLine().ToLower(); // Convert to lowercase for case-insensitivity
        Console.Write("Color 2: ");
        string color2 = Console.ReadLine().ToLower(); // Convert to lowercase for case-insensitivity

        // Processing
        string secondaryColor = "";

        // Validate input and calculate secondary color
        if ((color1 == "red" && color2 == "yellow") || (color1 == "yellow" && color2 == "red"))
        {
            secondaryColor = "Orange";
        }
        else if ((color1 == "red" && color2 == "blue") || (color1 == "blue" && color2 == "red"))
        {
            secondaryColor = "Purple";
        }
        else if ((color1 == "yellow" && color2 == "blue") || (color1 == "blue" && color2 == "yellow"))
        {
            secondaryColor = "Green";
        }
        else
        {
            // Invalid color choices
            Console.WriteLine("Invalid color choice. Please enter valid colors.");
            return;
        }

        // Output
        Console.WriteLine($"The combination of {color1} and {color2} is {secondaryColor}.");
    }
}