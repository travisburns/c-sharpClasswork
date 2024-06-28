using System;

public class romanNumeral
{
    public static void Main()
    {
        Console.WriteLine("Enter a Roman numeral between I and V, and I'll display its decimal value");

        Console.Write("Roman Numeral: ");
        string romanNumeral = Console.ReadLine().ToUpper();
        int decimalValue;

        switch (romanNumeral)
        {
            case "I":
                decimalValue = 1;
                break;
            case "II":
                decimalValue = 2;
                break;
            case "III":
                decimalValue = 3;
                break;
            case "IV":
                decimalValue = 4;
                break;
            case "V":
                decimalValue = 5;
                break;
            default:
                decimalValue = 0;
                Console.WriteLine("Invalid input");
                break;
        }

        if (decimalValue != 0)
        {
            Console.WriteLine("Decimal value: " + decimalValue);
        }
    }
}