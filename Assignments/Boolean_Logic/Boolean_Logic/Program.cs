using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval \nPlease answer these 3 questions:"); // INTRODUCTION
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine()); // SAVED AGE INPUT
            Console.WriteLine("Have you ever had a DUI? Please answer Yes or No.");
            string dui = Console.ReadLine(); // SAVED DUI INPUT
            Console.WriteLine("How many speeding tickets have you had?");
            int tickets = Convert.ToInt32(Console.ReadLine()); // SAVED TICKET # INPUT

            Console.WriteLine("Press enter to see if you qualify for insurance!");
            Console.ReadLine(); // USED TO PAUSE AND EXPLAIN NEXT STEP FOR USER
            bool qualify = age > 15 && dui == "No" && tickets <= 3; // BOOLEAN LOGIC ON EACH VARIABLE TO CHECK QUALIFICATION
            if (qualify == true) // IF STATEMENT TO PRINT OUT WHETHER USER IS QUALIFIED OR NOT
            {
                Console.WriteLine("You qualify!");
            }
            else
            {
                Console.WriteLine("You do NOT qualify!");
            }
            Console.ReadLine(); // KEEP CONSOLE OPEN
        }
    }
}
