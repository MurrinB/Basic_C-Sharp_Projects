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

            List<string> groceryList = new List<string>() { "eggs", "milk", "bread", "butter", "coffee" }; // CREATE LIST OF STRING
            bool itemSearch = false; // ESTABLISH BOOLEAN VARIABLE AS FALSE FOR LOOP TO REPEAT

            Console.WriteLine("Enter an item to search for in the grocery list: "); // REQUEST USER INPUT
            string grocerySearch = Console.ReadLine(); // USER INPUT TO SEARCH LIST

            while (!itemSearch) // STARTS A LOOP TO LOOP THROUGH WHOLE PROCESS
            {


                for (int i = 0; i < groceryList.Count; i++) // LOOP TO ITERATE THROUGH LIST
                {
                    if (grocerySearch == groceryList[i]) // COMPARISON OF LIST ITEMS
                    {
                        Console.WriteLine(groceryList[i] + " is at index " + i); // DISPLAYS MATCHING LIST ITEM AND IT'S INDEX
                        itemSearch = true; // ENDS LOOP 
                    }


                }
                if (!itemSearch) // LOOP FOR INPUT THAT DOES NOT MATCH THE LIST
                {
                    Console.WriteLine("Sorry, but " + grocerySearch + " is not in the list."); // INFORMS USER
                    Console.WriteLine("Enter an item to search for in the grocery list: "); // REQUEST USER ANOTHER INPUT
                    grocerySearch = Console.ReadLine(); // GETS NEW INPUT TO START AT WHILE LOOP AGAIN
                }
            }





            List<string> animals = new List<string>() { "cow", "horse", "cat", "dog", "cat", "monkey" };
            Console.WriteLine("What animal would you like to see on the farm?"); // REQUEST USER INPUT
            string requestedAnimal = Console.ReadLine(); //SAVE USER INPUT
            bool foundAnimal = false; // ESTABLISH VARIABLE AS FALSE TO HELP WITH A WHILE LOOP

            while (!foundAnimal) // START LOOP THROUGH WHOLE PROCESS OF THIS STRING DATA 
            { 
                for (int animal = 0; animal < animals.Count; animal++) // ITERATE THROUGH THE LIST
                {
                    if (requestedAnimal == animals[animal]) // COMPARE EACH ITEM FOR A MATCH IN THE LIST
                    {
                        Console.WriteLine(requestedAnimal + " is on the farm at index " + animal); // DISPLAY ITEM OR MULTIPLE ITEMS AND THEIR INDICES
                        foundAnimal = true; // END LOOP
                    }
                    

                }
                if (!foundAnimal) // IF USER INPUT DOESN'T MATCH AN ITEM IN THE STRING LIST
                {
                    Console.WriteLine(requestedAnimal + " is not on this farm!"); // DISPLAY ERROR
                    Console.WriteLine("What animal would you like to see on the farm?"); // REQUEST USER TO TRY AGAIN
                    requestedAnimal = Console.ReadLine(); // SAVE NEW INPUT

                }
            }
            
            List<string> colors = new List<string>() { "blue", "black", "brown", "red", "black", "green" }; // CREATE LIST WITH TWO IDENTICAL STRINGS
            Console.WriteLine("Press enter for a list of colors. If a color is in the list twice, the word duplicate will display.");
            Console.ReadLine();

            foreach (string color in colors) // ITERATES THROUGH LIST
            {
                Console.WriteLine(color); // PRINTS OUT ALL COLORS IN LIST
                if (color == "black") // COMPARES BLACK TO LIST ITEMS AND PRINTS DUPLICATE IF IT'S ALREADY PRESENT
                {
                    Console.WriteLine("duplicate"); 
                }
    
            }

                             




            Console.ReadLine(); // LEAVES CONSOLE OPEN


            
        }
    }
}
