using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers instantiateClass = new Numbers(); // INSTANTIATE CLASS

            Console.WriteLine("Enter a number: "); // REQUEST USER INPUT
            int userInput = Convert.ToInt32(Console.ReadLine()); // SAVE USER INPUT AT INT
            instantiateClass.OutputsInteger(userInput); // CALL METHOD FROM CLASS WITH USER INPUT NUMBER

            int c, d; // CREATE INTEGER VARIABLES
            instantiateClass.OutputParameters(out c, out d); // CALL METHOD WITH OUTPUT PARAMETERS
            Console.WriteLine("Output parameters: {0} ", (c,d)); // DISPLAY OUTPUT PARAMETERS
            
            
            Console.ReadLine(); // KEEPS CONSOLE OPEN
        }
    }
}
