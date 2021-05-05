using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerMethod
{
    public class MathMethods // CREATE A CLASS
    {
        public static int MathOperation(int x) // CREATE METHOD WITHIN CLASS THAT PASSES AN INTEGER THROUGH
        {
            return x / 2; // RETURNS AN INTEGER WHEN CALLED IN PROGRAM
        }

        public static int MathOperation(decimal x) // CREATE METHOD THAT IS THE SAME NAME BUT HAS A DIFFERENT REQUIREMENT
        {
            int answer = Convert.ToInt32(x * 2); // ALSO HAS A DIFFERENT MATH FUNCTION AND RETURNS AN INTEGER, NOT A DECIMAL
            return answer;
        }

        public static int MathOperation(string x) // CREATE METHOD THAT IS THE SAME NAME BUT DIFFERENT REQUIREMENT
        {
            int answer = Convert.ToInt32(x) + 10; // CONVERTS STRING VARIABLE TO INT AND MULTIPLIES BY TEN
            return answer; // RETURN ANSWER AS AN INTEGER 
        }
    }
}
