using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to multiply by 50?");
            int multi50 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(multi50 * 50); // Create an input for users that multiplies input by 50 and prints to console

            Console.WriteLine("What number do you want to add 25 to?");
            int add25 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(add25 + 25); // Create an input for users to + 25 to and print in console

            Console.WriteLine("What number do you want to divide by 12.5?");
            int div = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(div / 12.5); // takes user input and divides by 12.5 and displays answer in console

            Console.WriteLine("Enter a number to check if it is greater than 50.");
            int greaterCheck = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(greaterCheck > 50); // takes user input and uses boolean logic to get true/false answer displayed

            Console.WriteLine("Check to see if your number has a remainder when divided by 7?");
            int remainder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(remainder % 7); // takes user input and / by 7 to check what the remainder is and displays remainder
            Console.ReadLine();
        }
    }
}
