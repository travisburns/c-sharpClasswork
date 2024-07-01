# Car Loan Calculator

This C# program calculates and displays monthly payments for car loans of different terms based on user input for loan amount and interest rate.

## Description

The program does the following:
1. Prompts the user to enter the loan amount.
2. Prompts the user to enter the annual interest rate.
3. Calculates monthly payments for 4-year, 5-year, and 6-year loan terms.
4. Displays the results in a formatted table.

## How to Use

1. Run the program.
2. When prompted, enter the loan amount as a positive number.
3. When prompted, enter the annual interest rate as a percentage (e.g., 5 for 5%).
4. The program will display a table showing monthly payments for 4, 5, and 6-year terms.

## Features

- Input validation for loan amount and interest rate.
- Calculation of monthly payments using the formula:
  payment = (monthly rate * loan amount) / (1 - (1 + monthly rate)^(-number of months))
- Formatted table output for easy reading of results.
