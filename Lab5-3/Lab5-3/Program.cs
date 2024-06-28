
//Design and implement a program that asks the user to enter a non-zero positive number and determines if a number entered by the user is a prime number.
//A prime number is a number that is divisible only by 1 and itself.  2, 3, 5 and 7 are prime numbers.  4 and 9 are not prime numbers.  The program should
//validate the input in a reasonable way.
//The program should ask the user if he/she/they want to check another number after the result has been displayed and should repeat the process as long as the user enters yes.





/*Input:

number(int): A positive integer entered by the user.

Processing:
Validate input: Ensure the entered number is positive and greater than zero.
    Check for the number being prime:
    Iterate through potential divisors from 2 to the square root of the number.
     If any divisor divides the number evenly (excluding 1 and itself), the number is not prime.
     If no such divisor is found, the number is prime.
    Display result: Inform the user whether the entered number is prime or not.
    Repeat prompt: Ask the user if they want to check another number.
        If yes, repeat the entire process.
        If no, exit the program.

Output:
Indicates whether the entered number is a prime number or not.
*/


//PsuedoCode 


/*
Get a positive integer (store in number)
    Check if number is prime (store result in isPrime)
    Display the primality of number
    Ask if the user wants to check another number:
        If yes, set user wants to continue to true
        Else, set user wants to continue to false

Function GetPositiveNumber():


Display: "Enter a positive integer: "
    Read user's input
    If the input is not a positive integer, display: "Invalid input. Please enter a positive integer."

Return: User's input

Function CheckPrimality(int number):

    Set isPrime to true
    For each integer from 2 to the square root of number:
        If number is divisible by the current number (excluding 1 and itself):
            Set isPrime to false
            Break the loop
    Return isPrime

Function DisplayResult(bool isPrime):

    If isPrime is true:
        Display: "The number is prime."
    Else:
Display: "The number is not prime."*/




//code 

using System;

namespace PrimeNumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Call GetPositiveNumber to get a valid integer
                int number = GetPositiveNumber();

                // Call CheckPrimality to check if the number is prime
                bool isPrime = CheckPrimality(number);

                // Call DisplayResult to show the primality status
                DisplayResult(isPrime);

                Console.Write("Do you want to check another number? (yes/no): ");
                string choice = Console.ReadLine().ToLower();
                if (choice != "yes")
                {
                    break;
                }
            }
        }

        static int GetPositiveNumber()
        {
            while (true)
            {
                Console.Write("Enter a positive integer: ");
                string input = Console.ReadLine();
                int number;
                if (int.TryParse(input, out number) && number > 0)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
            }
        }

        static bool CheckPrimality(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

        static void DisplayResult(bool isPrime)
        {
            if (isPrime)
            {
                Console.WriteLine("The number is prime.");
            }
            else
            {
                Console.WriteLine("The number is not prime.");
            }
        }
    }
}