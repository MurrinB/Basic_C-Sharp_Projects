using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's count to 10! Press enter!"); // INTRODUCTION
            Console.ReadLine(); // PAUSE PROGRAM
            int i = 0; // ESTABLISH VARIABLE I AS VALUE 0
            while (i < 11) // CREATE WHILE LOOP TO COUNT TO TEN
            {
                Console.WriteLine(i); // DISPLAY EACH NUMBER AS IT COUNTS UP BY 1
                i++; // ADD 1 TO VALUE 'i' EACH LOOP
            }
            Console.WriteLine("Guess my favorite Pixar character!"); // INTRODUCTION
            string character = Console.ReadLine(); // INPUT FOR USER TO ENTER A STRING VARIABLE
            bool guess = false; // ESTABLISH A CONDITION FOR THE LOOP TO CONTINUE

            do // HELPS ENTER THE WHILE LOOP EVEN WHEN THE CORRECT ANSWER IS INPUTED RIGHT AWAY
            {
                switch (character) // ESTABLISH THE CHARACTER VARIABLE AS THE CONDITION TO LOOK AT 
                {
                    case "Flinn": // COMPARE WITH CONDITION
                        Console.WriteLine("Flinn is great, but not my favorite! Try again!"); // RESPONSE TO USER
                        Console.WriteLine("Guess my favorite Pixar character!"); // GIVES USER OPTION TO INPUT AGAIN
                        character = Console.ReadLine();
                        break;
                    case "Mike Wazowsky":
                        Console.WriteLine("Fun to say, but still not my favorite! Try again!"); // RESPONSE TO USER
                        Console.WriteLine("Guess my favorite Pixar character!"); // GIVES USER OPTION TO INPUT AGAIN
                        character = Console.ReadLine();
                        break;
                    case "Arlo":
                        Console.WriteLine("You got it! I love that dinosaur!"); // RESPONSE TO USER 
                        guess = true; // CORRECT ANSWER SO PROGRAM CAN END
                        break;
                    default:
                        Console.WriteLine("No, try again!"); // RESPONSE TO ANY USER INPUT OUTSIDE OF GIVEN OPTIONS
                        Console.WriteLine("Guess my favorite Pixar character!"); // GIVES USER OPTION TO INPUT AGAIN
                        character = Console.ReadLine();
                        break;
                }
            }
            while (!guess); // THE WHILE LOOP TO ENTER WITH GUESS EQUALING FALSE UNTIL HITTING THE TRUE RESPONSE
            Console.ReadLine(); // KEEPS CONSOLE OPEN
        }
    }
}
