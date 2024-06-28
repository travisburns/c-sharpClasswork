using System;


class Program
{



    //1.
    // Design and implement a program that asks the user to enter a temperature in degrees fahrenheit,
    //calculates and displays the same temperature in degrees celsius.c = 5/9 * (f - 32).  

    //IPO chart 


    //Input: 
    //Temperature, measured in fahrenheit


    //Processing: 
    //Take temperature in fahrenheit and convert it to celsius using 
    //C = 5 / 9 * (f - 32)


    //outPut:
    //Temperature measured in Celsius





    /*
    public static void Main()
    {
        Console.WriteLine("Please Enter a temperature in degrees fahrenheit. I will convert it to degrees celsuis for you. ");

        Console.Write("Degrees Fahrenheit: ");
       // write a statement that declares a cariable tempF and assigns it to the value entered from the keyboad. What's an appropriate data type? 
     int tempF = int.Parse(Console.ReadLine());


    //   // Write a statement that declares a tempC and assigns it to results of the expression 5 / 9 * (f - 32)
     int tempC = (int)(5.0 / 9 * (tempF - 32));
    //   // used casting to solve this the double variable type issue.
    //// When you run it you will not get the right answer.Remember that an int / int is an int so 5 / 9 is 0.

    ////Write a statement that displays an appropriate message to the user as well as the value in the variable c
     Console.WriteLine("Your temperature in celcuis is " + tempC);





    }


    */







    //2.
    //Design and implement a program that can be used with elementary school children to teach about change.
    //The program should ask the student to enter a price that is less than 1 dollar. The program will calculate
    //and display the amount of change due as well as the number of quarters, dimes, nickels and pennies.  


    //IPO chart 

    //Input 
    // - Amount measured in change (less than a dollar) = decimal


    //Processing: 

    // - Calculate the change due: changeDue = totalPrice - amoungGiven
    // - Determine the number of quarters, dimes, nickels, and pennies with the change due
    // - Output: 
    // - Display the change due:
    // - Display the number of quarters (25 cents each)
    // - Display the number of dimes (10 cents each)
    // - Display the number of nickels (5 cents each)
    // - Display the number of quarters (1 cent each)

    /*
    public static void Main()
    {
       Console.WriteLine("please enter a price (less than 1 dollar or 100 cents). i will calculate the change for you.");

      Console.Write("price: ");
       int price = int.Parse(Console.ReadLine());
       Console.WriteLine();

        int change = 100 - price;
       int quarters = change / 25;
       change = change - quarters * 25;
       int dimes = change / 10;
       change = change - dimes * 10;
       int nickels = change / 5;
       change = change - nickels * 5;
       int pennies = change;

       Console.WriteLine($"total: {price} your change due: quarters:{quarters}, dimes:{dimes}, nickels:{nickels}, pennies:{pennies}");
    }

    */

    //3.
    //Design and implement a program that asks the user to enter a US dollar amount and calculates the value of that
    //dollar amount in Euros, Canadian Dollars and Mexican Pesos.  The current exchange rates can be found on the internet.  

    //IPO 

    //    Input:
    //  - US Dollar Amount

    //Processing:
    //  - Calculate Euro Conversion: EuroConversion = USDollarAmount* 0.92
    //  - Calculate Canadian Conversion: CanadianConversion = USDollarAmount* 1.35
    //  - Calculate Mexican Pesos Conversion: PesosConversion = USDollarAmount* 17.24

    //Output:
    //  - Display Euro Conversion
    //  - Display Canadian Conversion
    //  - Display Mexican Pesos Conversion

    /*
     public static void Main()
     {
        Console.WriteLine("Please Enter US dollar amount: ");

       Console.Write("US dollar amount: ");
       int usDollar = int.Parse(Console.ReadLine());
       Console.WriteLine();

       Double euro = usDollar * (0.92);
       Double canadian = usDollar * (1.35);
       Double peso = usDollar * (17.24);


       Console.WriteLine($"Us Dollar: {usDollar}, Euro:{euro}, Canadian:{canadian}, Peso:{peso}");
       }

    */

    // Design and implement a program that asks the user to enter the number of programming majors and the total number of
    // students in a class. The program should display that percentage of the class that is majoring in programming.  



    //4. 
    // Design and implement a program that asks the user to enter the number of programming majors and the total number of
    // students in a class. The program should display that percentage of the class that is majoring in programming. 
    //IPO 
    //Input 
    //    User entered Number of programming majors(int)
    //User entered Number of students in a class(int)

    //processing
    // Proportion of programming majors: proportion = programmingMajors / totalStudents
    //Calculate the percentage: percentage = proportion* 100

    //output
    //Percent that is programming major, relative to the total of class





    /*
    public static void Main()
     {
        Console.WriteLine("Number of Programming Majors: ");
        int programmingMajors = int.Parse(Console.ReadLine());
        Console.WriteLine("Number of student in class: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        double programmingMajorPercent = (double)programmingMajors / numberOfStudents;
        Console.WriteLine($"Percent of programming Majors relative to the class:{programmingMajorPercent}%");

      }
    */
    //    Input:
    //- Generate 2 random integers between 10 and 999
    //- Accept user input for the sum of the 2 random integers, entered by the user

    //Processing:
    //- Generate 2 random integers using the Random class
    //-Add the two random integers to create an addition problem
    //- Accept user input for their answer
    //- Verify if the user's answer is correct
    //- Display the correct answer

    //Output:
    //-Display the two random integers for the addition problem
    //- Display the user's input for the sum
    //- Display whether the user's answer is correct or not
    //- Display the correct answer



    // student programm 
    /*
      static void Main()
      {
      Random generator = new Random();

    // Generate 2 random integers between 10 and 999
     int firstNumber = generator.Next(10, 1000);
      int secondNumber = generator.Next(10, 1000);

    // Display the addition problem
       Console.WriteLine($"Add the following two numbers: {firstNumber} + {secondNumber}");

    // Accept user input for their answer
       Console.Write("Your answer: ");
       int userAnswer = int.Parse(Console.ReadLine());

    // Calculate the correct answer
       int correctAnswer = firstNumber + secondNumber;

    // Verify if the user's answer is correct
       if (userAnswer == correctAnswer)
        {
          Console.WriteLine("Correct! Well done!");
        }
        else
       {
          Console.WriteLine($"Sorry, the correct answer is {correctAnswer}");
      }
     }

    */

    //Design and implement a program that asks the user to enter how many cookies he/she/they want to create and then displays the quantity of each of the ingredients the user will need.  


    //    Input:
    //- Accept user input for the number of cookies the user wants to create

    //Processing:
    //- Use the provided recipe to calculate the quantity of each ingredient needed based on the desired number of cookies
    //- Display the calculated quantities of each ingredient

    //Output:
    //- Display the quantity of each ingredient needed for the specified number of cookies


    static void Main()
    {
        Console.WriteLine("Enter the number of cookies you want to create: ");
        int numberOfCookies = int.Parse(Console.ReadLine());

        // Calculate ingredient quantities based on the provided recipe for 60 cookies
        double factor = (double)numberOfCookies / 60;

        double flour = 2.25 * factor;
        double bakingSoda = 1 * factor;
        double salt = 1 * factor;
        double butter = 1 * factor; // 1 cup = 1 stick
        double granulatedSugar = 0.75 * factor;
        double brownSugar = 0.75 * factor;
        double vanillaExtract = 1 * factor;
        double eggs = 2 * factor;
        double chocolateMorsels = 2 * factor; // 2 cups
        double nuts = 1 * factor; // 1 cup

        // Display the calculated quantities of each ingredient
        Console.WriteLine($"Ingredients needed for {numberOfCookies} cookies:");
        Console.WriteLine($"All-Purpose Flour: {flour} cups");
        Console.WriteLine($"Baking Soda: {bakingSoda} teaspoon");
        Console.WriteLine($"Salt: {salt} teaspoon");
        Console.WriteLine($"Butter: {butter} cups");
        Console.WriteLine($"Granulated Sugar: {granulatedSugar} cups");
        Console.WriteLine($"Brown Sugar: {brownSugar} cups");
        Console.WriteLine($"Vanilla Extract: {vanillaExtract} teaspoon");
        Console.WriteLine($"Eggs: {eggs} units");
        Console.WriteLine($"NESTLÉ® TOLL HOUSE® Semi-Sweet Chocolate Morsels: {chocolateMorsels} cups");
        Console.WriteLine($"Chopped Nuts: {nuts} cups");
    }
   



}


