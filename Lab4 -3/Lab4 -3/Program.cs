//Design and implement a program that asks the user to enter a number and determines if a number entered by the user is a prime number.
//A prime number is a number that is divisible only by 1 and itself.  2, 3, 5 and 7 are prime numbers.  4 and 9 are not prime numbers. 

//INPUT
//number 
//nothing

//PROCCESSING




//OUTPUT 
//number isPrime

//ALOGIRTHM 
//user enters number
//determine if number is divisible by 1 and itself
//display if number entered is prime
//if number is not divisble by 1 and itself
//display number is not prime 

//number         isPrime                    Display
//1             //   1/1 = isPrime           1 is a Prime number
//2             // 2/1, 2/2 = isPrime        2 is a Prime number
//4             // 4/1, 4/2, 4/4 = notPrime  4 is not a Prime number(due to 4 being divisble by more then 1 and itself)


//PsuedoCode 

//Get User input for number(user enters number)
// isPrime = true;
// if the number is less than 2 
// isPrime = false
//else 
//for i from 2 to square root of number
//if number is divisible by i 
//isPrime = false 
//end loop
// if isPrime is true 
//Display "It's a prime number
//else 
//display "It's not a prime number"

using System;

public class Program
{
    public static void Main()
    {
        // Prompting the user to enter a number for prime check
        Console.WriteLine("Enter a number, and I will determine if it is Prime for you.");

        // Reading the user's input and converting it to an integer
        int number = Convert.ToInt32(Console.ReadLine());

        // Assuming the number is prime until proven otherwise
        bool isPrime = true;

        // Special case: Numbers less than 2 are not prime
        if (number < 2)
        {
            isPrime = false;
        }
        // Special case: 2 is the only even prime number
        else if (number == 2)
        {
            isPrime = true;
        }
        else
        {
            // Loop to check divisibility from 2 to the square root of the number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                // If the number is divisible, it's not prime
                if (number % i == 0)
                {
                    isPrime = false;
                    // Break the loop since the number is not prime
                    break;
                }
            }
        }

        // Displaying the result based on primality
        if (isPrime)
        {
            Console.WriteLine("It's a Prime Number!");
        }
        else
        {
            Console.WriteLine("It's not a Prime Number!");
        }
    }
}