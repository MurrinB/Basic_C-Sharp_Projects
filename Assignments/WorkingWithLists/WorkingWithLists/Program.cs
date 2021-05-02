using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "John", "Mark", "Sarah", "Jane" }; // CREATE ARRAY OF STRINGS
            Console.WriteLine("What is a common last name?"); // INTRODUCTION TO USER
            string lastname = Console.ReadLine(); // GET USER INPUT 

            for (int name = 0; name < names.Length; name++) // FOR LOOP TO ITERATE THROUGH ARRAY AND ADD USER INPUT TO EACH STRING INDEX
            {
                names[name] = names[name] + lastname; 
            }

            foreach (string name in names) // USE FOREACH LOOP TO DISPLAY EACH STRING WITH USER ADDITION IN CONSOLE
            {
                Console.WriteLine(name);
            }

            bool infinite = false; // CREATE BOOL VARIABLE TO CAUSE INFINITE LOOP
            while (!infinite) // USE WHILE LOOP TO CREATE NEVER ENDING LOOP
            {
                Console.WriteLine("I will repeat forever!");
                infinite = true; // CHANGE BOOL VARIABLE TO END THE INFINITE LOOP
            }

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // CREATE AN ARRAY OF INTEGARS
            for (int i = 0; i < numbers.Length; i++) // LOOP THROUGH ARRAY 
            {
                if (numbers[i] < 6) // MAKE COMPARISON THAT PROGRAM WILL USE WHILE ITERATING THROUGH ARRAY
                {
                    Console.WriteLine(numbers[i]); // PRINT ALL NUMBERS LESS THAN 6
                }
            }
            for (int i = 0; i < numbers.Length; i++) // LOOP THROUGH ARRAY
            {
                if (numbers[i] <= 5) // MAKE COMPARISON THAT PROGRAM WILL USE WHILE ITERATING THROUGH ARRAY
                {
                    Console.WriteLine(numbers[i]); // PRINT OUT 1 TO 5 
                }
            }



                Console.ReadLine(); // LEAVES CONSOLE OPEN


            
        }
    }
}
