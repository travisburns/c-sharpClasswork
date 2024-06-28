using System;

public class CountChangeProgram
{
    public static void Main()
    {
        // Display instructions
        Console.WriteLine("Enter the number of quarters, dimes, nickels, and pennies to make exactly one dollar.");

        // Input
        Console.Write("Number of quarters: ");
        int quarters = int.Parse(Console.ReadLine());

        Console.Write("Number of dimes: ");
        int dimes = int.Parse(Console.ReadLine());

        Console.Write("Number of nickels: ");
        int nickels = int.Parse(Console.ReadLine());

        Console.Write("Number of pennies: ");
        int pennies = int.Parse(Console.ReadLine());

        // Processing
        int totalValue = (quarters * 25) + (dimes * 10) + (nickels * 5) + pennies;

        // Output
        Console.WriteLine($"The total value of the change is ${(totalValue / 100.0):F2}");

        // Check if the total value is exactly one dollar
        if (totalValue == 100)
        {
            Console.WriteLine("Congratulations! The total value is exactly one dollar.");
        }
    }
}


