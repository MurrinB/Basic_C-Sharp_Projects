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
            //Console.WriteLine("Please pick a number to add by ten.");
            //int numOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please pick a second number to add to the equation. Feel free to leave blank.");
            //int numTwo = Convert.ToInt32(Console.ReadLine());
            //int answer = MathMethod.MathOperation(numOne, numTwo);
            //Console.WriteLine("The answer to this equation is " + answer);

            int answer = MathMethod.MathOperation(10); // CALL METHOD WITH ONE ARGUMENT
            int answerTwo = MathMethod.MathOperation(10, 12); // CALL METHOD WITH TWO ARGUMENTS 
            Console.WriteLine("Answer with one variable: " + answer + "\nAnswer with two variables: " + answerTwo); // DISPLAY BOTH ANSWERS FROM THE TWO CALLS
            

            Console.ReadLine(); // KEEP CONSOLE OPEN

        }
    }
}
