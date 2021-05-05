using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int Division = MathMethods.MathOperation(10); // CALLS DIVIDETWO METHOD AND PASSES IN 10
            Console.WriteLine("The answer to 10 divided by 2 is " + Division); // DISPLAYS IN CONSOLE ANSWER FROM METHOD

            decimal Multiplication = MathMethods.MathOperation(1.25m); // CALLS METHOD WITH SAME NAME BUT REQUIRES A DECIMAL 
            Console.WriteLine("The answer to 1.25 times 2 as an integer is " + Multiplication); // DISPLAYS IN CONSOLE ANSWER FROM METHOD

            int Addition = MathMethods.MathOperation("15"); // CALLS METHOD WITH SAME NAME BUT REQUIRES STRING VARIABLE
            Console.WriteLine("The answer to the given string of 15 plus 10 is " + Addition); // DISPLAYS IN CONSOLE INTEGER ANSWER FROM MATH EQUATION 

            Console.ReadLine(); // KEEPS CONSOLE OPEN
        }
    }
}
