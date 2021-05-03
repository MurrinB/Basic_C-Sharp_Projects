using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Math // CREATED CLASS CALLED MATH AND MADE IT PUBLIC TO USE
    {

        public static int AddFive(int x) // CREATED ADDFIVE METHOD WITH ONE INT PARAMETER AND MADE IT PUBLIC
        {
            return x + 5; // ADD FIVE TO INT GIVEN ARGUMENT 
        }

        public static int SubtractFive(int x) // CREATED SUBTRACTFIVE METHOD WITH ONE INT PARAMETER AND MADE IT PUBLIC
        {
            int answer = x - 5; // SUBTRACT FIVE FROM GIVEN ARGUMENT, MADE THE ANSWER A VARIABLE TO RETURN TO SEE IT DONE BOTH WAYS
            return answer;
        }

        public static int MultiplyFive(int x) // CREATED MULTIPLYFIVE METHOD WITH ONE INT PARAMETER AND MADE IT PUBLIC
        {
            int answer = x * 5; // MULTIPLY BY FIVE TO GIVEN ARGUMENT
            return answer;
        }
        }

    }
  

