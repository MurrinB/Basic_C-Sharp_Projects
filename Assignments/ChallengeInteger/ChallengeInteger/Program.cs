using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegersClass instantiateClass = new IntegersClass(); // INSTANTIATE CLASS
            instantiateClass.IntegersMethod(4, 5); // CALL METHOD AND PASS IN TWO INTEGERS
            instantiateClass.IntegersMethod(x: 4, y: 5); // CALL METHODS SPECIFYING PARAMETERS BY NAME
            Console.ReadLine(); // KEEPS CONSOLE OPEN
        }
    }
}
