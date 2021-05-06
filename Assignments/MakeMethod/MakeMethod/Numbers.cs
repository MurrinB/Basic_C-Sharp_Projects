using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMethod
{
    public class Numbers // CREATE CLASS
    {
        public void OutputsInteger(int x) // CREATE METHOD THAT OUTPUTS AN INTEGER
        {
            int answer = x / 2; // DIVIDES PARAMETER BY TWO
            Console.WriteLine(answer); // DISPLAYS ANSWER IN CONSOLE
        }

        public void OutputParameters(out int a, out int b) // CREATE METHOD WITH OUTPUT PARAMETERS
        {
            a = 10; // DEFINE PARAMETERS
            b = 15;
        }

        public void OutputParameters(out int a, out int b, out int c) // OVERLOAD METHOD
        {
            a = 10; // DEFINE PARAMETERS
            b = 15;
            c = 20;
        }

    }
}
