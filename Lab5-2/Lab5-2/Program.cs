

/*Design and implement a program that can be used to provide users with information about the monthly payment for a car loan.  
 * The program should allow a user to enter the amount of the loan and the annual interest rate.  The program should validate 
 * data entered by the user in a reasonable way and should force the user to reenter until the data is correct.  The program 
 * should display the monthly payment for a 4 year loan, a 5 year loan and a 6 year loan in an attractively formatted table.  
 * The formula for calculating the payment is:
 * 
payment = (monthly rate* loan amount) / ( 1- (1 + monthly rate) ^ - number of months).  See the illustration at the right. 
 HINT:  Math.Pow can be used for exponentiation in C#.  double fourSquared = Math.Pow( 4, 2);  for example.
*/



/*Input:

loanAmount: The total amount of the car loan (double)
annualInterestRate: The annual interest rate for the loan (double)

Processing:
Get user input
Prompt the user to enter the loanAmount.
Validate the input:
Check if it's a positive number (greater than zero).
 If invalid, display an error message and repeat step 1.
 
Prompt the user to enter the annualInterestRate.
Validate the input:
Check if it's a positive number (greater than zero).
 If invalid, display an error message and repeat step 1.
    
Calculate monthly interest rate
 monthlyInterestRate = annualInterestRate / 12
 Calculate number of payments for each loan term
  numberOfPayments4Years = 4 * 12 (months in a year)
  numberOfPayments5Years = 5 * 12
  numberOfPayments6Years = 6 * 12
  Calculate monthly payment for each loan term
  Use the formula: payment = (monthlyInterestRate * loanAmount) / (1 - (1 + monthlyInterestRate) ^ -numberOfPayments)
  Calculate fourYearMonthlyPayment using numberOfPayments4Years.
  Calculate fiveYearMonthlyPayment using numberOfPayments5Years.
  Calculate sixYearMonthlyPayment using numberOfPayments6Years.

Output:
Display a table with headers "Term (Years)", "Monthly Payment"
For each loan term (4, 5, and 6 years): Display a row in the table with the term and its corresponding calculated monthly payment.






//example calcualtion


//psuedoCode

  Main Function:

1. Prompt user to enter loan amount (positive number).
2. Call GetLoanAmount function to get validated loan amount.
3. Prompt user to enter annual interest rate (positive number).
4. Call GetInterestRate function to get validated interest rate.
5. Calculate monthly interest rate = annualInterestRate / 12.
6. Define:
    - numberOfPayments4Years = 4 * 12
    - numberOfPayments5Years = 5 * 12
    - numberOfPayments6Years = 6 * 12
7. For each term (4, 5, 6 years):
    - Call CalculatePayment function with loan amount, monthly interest rate, and number of payments as arguments.
    - Store the returned monthly payment in a corresponding variable (e.g., fourYearMonthlyPayment).
8. Display table header: "Term (Years)" | "Monthly Payment"
9. For each term (4, 5, 6 years):
    - Display table row: term | formatted monthly payment

GetLoanAmount Function:

1. Prompt user to enter loan amount.
2. Loop until a valid positive number is entered:
    - Try converting input to a double.
    - If successful and positive:
        - Return the loan amount.
    - Otherwise, display an error message and prompt again.

GetInterestRate Function:

1. Prompt user to enter annual interest rate.
2. Loop until a valid positive number is entered:
    - Try converting input to a double.
    - If successful and positive:
        - Return the interest rate.
    - Otherwise, display an error message and prompt again.

CalculatePayment Function:

1. Take loan amount, monthly interest rate, and number of payments as arguments.
2. Calculate monthly payment using formula: payment = (monthlyInterestRate * loanAmount) / (1 - (1 + monthlyInterestRate) ^ -numberOfPayments).
3. Return the calculated monthly payment.      
*/


//code 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




class CarLoanCalculator
{
    static void Main(string[] args)
    {
        decimal loanAmount = GetLoanAmount();
        double annualInterestRate = GetInterestRate();

        // Calculate monthly interest rate
        double monthlyInterestRate = annualInterestRate / 12;

        // Define number of payments for each term
        int numberOfPayments4Years = 4 * 12;
        int numberOfPayments5Years = 5 * 12;
        int numberOfPayments6Years = 6 * 12;

        // Calculate monthly payments for each term
        double fourYearPayment = CalculatePayment(loanAmount, annualInterestRate, numberOfPayments4Years);
        double fiveYearPayment = CalculatePayment(loanAmount, annualInterestRate, numberOfPayments5Years);
        double sixYearPayment = CalculatePayment(loanAmount, annualInterestRate, numberOfPayments6Years);

        // Display table header
        Console.WriteLine("Term (Years) | Monthly Payment");
        Console.WriteLine("------------|----------------");

        // Display table rows for each term and corresponding payment
        Console.WriteLine($"4             | ${fourYearPayment:0.00}");
        Console.WriteLine($"5             | ${fiveYearPayment:0.00}");
        Console.WriteLine($"6             | ${sixYearPayment:0.00}");
    }

    static decimal GetLoanAmount()
    {
        decimal input;
        while (true)
        {
            Console.Write("Enter loan amount (positive number): ");
            if (decimal.TryParse(Console.ReadLine(), out input) && input > 0)
            {
                return input;
            }
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }

    static double GetInterestRate()
    {
        double input;
        while (true)
        {
            Console.Write("Enter annual interest rate (as a percentage): ");
            if (double.TryParse(Console.ReadLine(), out input) && input > 0)
            {
                return input / 100; // Convert percentage to decimal
            }
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }

    static double CalculatePayment(decimal loanAmount, double annualInterestRate, int numberOfPayments)
    {
        double monthlyInterestRate = annualInterestRate / 12;
        return (monthlyInterestRate * (double)loanAmount) / (1 - Math.Pow(1 + monthlyInterestRate, -numberOfPayments)); // Cast loanAmount to double for calculation
    }
}