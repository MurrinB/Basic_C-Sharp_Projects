using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a random number."); // REQUEST USER INPUT
            int number = Convert.ToInt32(Console.ReadLine()); // SAVE INTEGER INPUT

            int math = Math.AddFive(number); // CALL ADDFIVE FUNCTION WITH USER INPUT VARIABLE

            int mathTwo = Math.SubtractFive(number); // CALL SUBTRACTFIVE FUNCTION WITH USER INPUT VARIABLE

            int mathThree = Math.MultiplyFive(number); // CALL MULTIPLYFIVE FUNCTION WITH USER INPUT VARIABLE

            Console.WriteLine("Your number plus 5 equals " + math +
                "\nYour number subtracted by 5 equals " + mathTwo +
                "\nYour number multiplied by 5 equals " + mathThree); // DISPLAY ALL ANSWERS FROM METHOD CALLS

            Console.ReadLine(); // LEAVES CONSOLE OPEN
        }
    }
}
