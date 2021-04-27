using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program. \nLet's get the first person's information. Please press enter.");
            Console.ReadLine(); // PAUSE AFTER THE INTRODUCTION
            Console.WriteLine("What is your hourly rate?");
            decimal hourPerson1 = Convert.ToDecimal(Console.ReadLine()); // USER INPUT HOUR RATE SAVED
            Console.WriteLine("How many hours do you work per week?");
            decimal weekPerson1 = Convert.ToDecimal(Console.ReadLine()); // USER INPUT HOURS A WEEK SAVED

            Console.WriteLine("Thank you. Now we will get the second person's information. Please press enter.");
            Console.ReadLine(); // PAUSE BEFORE GETTING USER INPUT TWO
            Console.WriteLine("What is your hourly rate?");
            decimal hourPerson2 = Convert.ToDecimal(Console.ReadLine()); // SECOND HOUR RATE SAVED
            Console.WriteLine("How many hours do you work per week?");
            decimal weekPerson2 = Convert.ToDecimal(Console.ReadLine()); // SECOND HOURS A WEEK SAVED

            Console.WriteLine("Thank you. Now press enter to calculate their annual incomes.");
            Console.ReadLine(); // PAUSED TO EXPLAIN NEXT STEP IN DISPLAY
            decimal annualPerson1 = hourPerson1 * weekPerson1 * 4 * 12; // ANNUAL INCOME CALC
            Console.WriteLine("The annual income of person #1 is: " + annualPerson1); // DISPLAY ANNUAL INCOME CALC
            decimal annualPerson2 = hourPerson2 * weekPerson2 * 4 * 12; // ANNUAL INCOME 2 CALC
            Console.WriteLine("The annual income of person #2 is: " + annualPerson2); // DISPLAY ANNUAL 2

            Console.WriteLine("Now press enter to see if it's true that person #1 makes more than person #2:");
            Console.ReadLine(); // PAUSE TO EXPLAIN WHAT'S NEXT TO BE DISPLAYED
            Console.WriteLine(annualPerson1 > annualPerson2); // COMPARISON OF THE ANNUAL INCOMES TO SEE IF #1 IS GREATER
            Console.ReadLine(); // KEEPS CONSOLE OPEN



        }
    }
}
