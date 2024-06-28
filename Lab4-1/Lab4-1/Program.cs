



//Design and implement a program that asks the user to enter a number and determines if the number entered is a perfect number.
//A perfect number is a number that is equal to the sum of its factors excluding the number itself.
//6 is a perfect number because 1 + 2 + 3 = 6. 28 is the next perfect number. 




//IPO chart 

//Input 
//number

//processing


//Output 
//Message perfect or not perfect 

//Example
//6 // 6/1 6/2 6/3 6/4 6/5 
//sum 1 + 2 + 3 = 6
//8 8/1 8/2 8/3 8/4 8/5 8/6 8/7
//sum 1+2 +4 = 7

//Algorithm
//display instructions
//get number
//sum = 0 
//divisor = 1
//while divisor < number 
//if number is divisible by divisor 
//sum = sum + divisor 
// end if 
//divisor = divisor + 1 
//end while 
//if sum = number 
//message = perfect 
//else 
//message = not perfect 
//end if 
//display message 


using System;

public class Program
{
    public static void Main()
    {
        // Prompt user to enter a number to check for perfection
        Console.WriteLine("Please enter a number, and I'll tell you whether it's a perfect number.");

        // Reading the user's input and converting it to an integer
        Console.WriteLine("Number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Variables to track the sum of divisors and the current divisor
        int sum = 0;
        int divisor = 1;

        // Loop to find divisors and calculate their sum
        while (divisor < number)
        {
            // If the number is divisible by the current divisor, add it to the sum
            if (number % divisor == 0)
                sum = sum + divisor;

            // Move on to the next divisor
            divisor = divisor + 1;
        }

        // Message indicating whether the number is perfect or not
        string message;
        if (sum == number)
        {
            message = "perfect";
        }
        else
        {
            message = "not perfect";
        }

        // Displaying the result
        Console.WriteLine(number + " is " + message);
    }
}

