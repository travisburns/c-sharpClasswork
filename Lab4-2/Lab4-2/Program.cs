//Modify your solution to the problem above to display all of the perfect numbers between 1 and 1000.  

//IPO
//nothing

//PROCCESSING




//OUTPUT 
//perfect numbers between 1 and 1000 - 6 and 28 

//ALOGIRTHM 
//display instructions
//for each number between 1 and 1000 
//sum = 0 
//divisor = 1 
//while divisor < number 
//if number is divisible by divisor 
//sum = sum + divisor 
//end if 
//divisor = divisor + 1 
//end while 
//if sum = number 
//display value in variable number + is perfect 
//end if 
//end for 

//number          sum                              divisor                      display 
//1, 2, 6,7         0, 1,1,3,6, reset to 0     1,2,1,2,4,5,6, reset to 1         //6

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Here's a list of perfect numbers between 1 and 1000");
        for (int number = 1; number <= 1000; number++)
        {
            int sum = 0;
            int divisor = 1;

            while (divisor < number)
            {
                if (number % divisor == 0)
                    sum = sum + divisor;

                divisor = divisor + 1;
            }

            if (sum == number)
                Console.WriteLine(number + " is perfect");
        }
    }
}

