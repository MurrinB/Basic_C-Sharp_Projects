using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. \nWhat is the weight of the package?"); // INTRODUCTION
            decimal weight = Convert.ToDecimal(Console.ReadLine()); // GET USER INPUT FOR WEIGHT
            if (weight > 50) // CREATE IF STATEMENT TO STOP PROGRAM IF PACKAGE IS BIGGER THAN 50
            {
                Console.WriteLine("Package too heavy to ship via Package Express. Have a good day!"); // ENDS PROGRAM AND NOTIFY USER
                Console.ReadLine(); // KEEPS CONSOLE OPEN
            }
            else
            {
                Console.WriteLine("What is the packages width?");
                decimal width = Convert.ToDecimal(Console.ReadLine()); // GETS USER INPUT FOR WIDTH
                Console.WriteLine("What is the packages height?");
                decimal height = Convert.ToDecimal(Console.ReadLine()); // GET USER INPUT FOR HEIGHT
                Console.WriteLine("What is the packages length?");
                decimal length = Convert.ToDecimal(Console.ReadLine()); // GET USER INPUT FOR LENGTH
                if ((width + height + length) > 50) // CREATE IF STATEMENT TO END PROGRAM IF PACKAGE DIMENSIONS ARE TOO LARGE
                {
                    Console.WriteLine("Package too big to ship via Package Express. Have a good day!"); // NOTIFY USER PACKAGE IS TO LARGE AND PROGRAM END
                    Console.ReadLine(); // KEEPS CONSOLE OPEN
                }
                else
                {
                    decimal quote = ((height * width * length) * weight) / 100; // CALCULATION OF SHIPPING QUOTE
                    Console.WriteLine("Your shipping will cost: " + quote.ToString("C2") + "\nThank you for shipping with Package Express!"); // DISPLAY TOTAL IN DOLLAR AMOUNT 
                    
                }
                Console.ReadLine(); // KEEPS CONSOLE OPEN
            }
        }
    }
}
