using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter your annual Salary and the number of years you have worked at your current job. I’ll determine if you qualify for a loan.");
        Console.Write("Annual Salary:");
        decimal salary = decimal.Parse(Console.ReadLine());
        Console.Write("Years on the Job:");
        double yearsOnJob = double.Parse(Console.ReadLine());
        string message;

        // Write an If Statement - the logical operator AND is &&
        if (salary >= 40000 && yearsOnJob >= 1)
        {
            message = "You qualify";
        }
        else
        {
            message = "You DON'T Qualify";
        }

        Console.WriteLine(message);
    }
}


