using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntegerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMethod compute = new MathMethod(); // INITIATE CLASS (SADLY I'M NOT SURE HOW TO USE THIS BELOW. I TRIED COMPUTE.MATHOPERATION(NUMONE, NUMTWO) WITH NO LUCK

            Console.WriteLine("Pick a number."); // REQUEST USER INPUT FOR PARAMETER A
            int numOne = Convert.ToInt32(Console.ReadLine()); // NOW ARGUMENT A 
            int i; // CREATE INTEGER VARIABLE
            Console.WriteLine("Pick a second number or press enter to leave blank."); // REQUEST USER INOUT FOR PARAMETER B OR NONE
            bool numTwo = int.TryParse(Console.ReadLine(), out i); // USE BOOL TO CHECK FOR BLANK, ADD I VARIABLE TO CONVERT TO INTEGER FROM BOOL

            if (numTwo) // USED BOOL VARIABLE TO CHECK FOR BLANK OR INTEGER
            {
                int answer = MathMethod.MathOperation(numOne, i); // PASS BOTH ARGUMENTS IF BOTH PRESENT
                Console.WriteLine("Your total: " + answer); // ANSWER WITH BOTH ARGUMENTS

            }
            else 
            {
                int answer = MathMethod.MathOperation(numOne); // IF ONLY ONE ARGUMENT PRESENT PASS THE ONE
                Console.WriteLine("Your total without a second number: " + answer); // ANSWER FROM ONE ARGUMENT
            }




            Console.ReadLine(); // KEEP CONSOLE OPEN

        }
    }
}
