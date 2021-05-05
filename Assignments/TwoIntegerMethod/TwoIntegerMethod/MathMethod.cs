using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntegerMethod
{
    public class MathMethod
    {
        public static int MathOperation(int a) // CREATE METHOD WITH ONE PARAMETER
        {
            return a + 10; // SEND BACK VARIABLE + 10
        }   

        public static int MathOperation(int a, int b) // CREATE SAME METHOD WITH TWO PARAMETERS
        {
            return a + b + 10; // SEND BACK SUM OF BOTH VARIABLES AND 10
        }
    }
}
