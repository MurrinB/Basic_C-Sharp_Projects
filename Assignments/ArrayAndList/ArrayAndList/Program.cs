using System;
using System.Collections.Generic;


namespace ArrayAndList
{
    class Program
    {
        static void Main()
        {
            string[] superheros = { "Iron Man", "Capitan America", "Thor", "Capitan Marvel", "Hulk" }; // CREATE STRING ARRAY

            bool superheroLoop = false; // ESTABLISH A FALSE TO START A LOOP
            while (!superheroLoop) // WHILE BOOL STATEMENT FALSE, LOOP WILL CONTINUE
            {
                Console.WriteLine("Pick an index between 0-4 for a Marvel superhero!"); // PROMPT FOR USER INPUT
                try // ESTABLISH A LOOP FOR INCORRECT INPUT
                {
                    int index = int.Parse(Console.ReadLine()); // GET INDEX FROM USER INPUT
                    Console.WriteLine(superheros[index].ToString()); // RETRIEVES STRING AT THE INPUTED INDEX
                    superheroLoop = true; // ENDS LOOP
                }
                catch // IF INCORRECT INPUT, MESSAGE DISPLAYS
                {
                    Console.WriteLine("Please select a valid index number.");
                }
            }

            int[] picknumber = { 44, 10, 8, 23, 50 }; // CREATE AN ARRAY OF NUMBERS

            bool numberLoop = false; // ESTABLISH AS FALSE TO START THE LOOP
            while (!numberLoop) // WHILE BOOL IS FALSE, LOOP WILL CONTINUE
            {
                Console.WriteLine("Pick an index between 0-4 for a random number!"); // PROMPT USER INPUT
                try // ESTABLISH LOOP FOR INCORRECT INPUT
                {
                    int index = int.Parse(Console.ReadLine()); // GET INDEX FROM USER INPUT
                    Console.WriteLine(picknumber[index].ToString()); // RETRIEVES INTEGAR FROM ARRAY AND DISPLAYS
                    numberLoop = true; // ENDS LOOP
                }
                catch // IF INCORRECT INPUT, DISPLAYS MESSAGE
                {
                    Console.WriteLine("Please select a valid index number.");
                }
            }

            var dcheros = new List<string>() // CREATE LIST OF STRING DATA
            {
                "Batman", "Aquaman", "The Flash", "Wonder Woman", "Green Lantern"
            };

            bool dcLoop = false; // ESTABLISH AS FALSE TO START THE LOOP
            while (!dcLoop) // WHILE BOOL FALSE, LOOP WILL CONTINUE
            {
                Console.WriteLine("Pick an index between 0-4 for a DC superhero!"); // PROMPT USER INPUT
                try // ESTABLISH LOOP FOR INCORRECT INPUT
                {
                    int index = int.Parse(Console.ReadLine()); // GET INDEX FROM USER INPUT
                    Console.WriteLine(dcheros[index].ToString()); // RETRIEVES STRING OF THAT INDEX AND DISPLAYS
                    dcLoop = true; // ENDS LOOP
                }
                catch // IF INCORRECT INPUT DISPLAYS MESSAGE
                {
                    Console.WriteLine("Please select a valid index number.");
                }
            }


            Console.ReadLine(); // KEEPS CONSOLE OPEN
        }
    }
}
