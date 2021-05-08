using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfTheWeek
{
    class Program
    {
        public enum Day // CREATE ENUM OF DAYS OF THE WEEK
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What day of the week is it?"); // PROMPT USER INPUT
            string answer = Console.ReadLine(); // SAVE USER INPUT AS VARIABLE ANSWER


            try // TRY TO CATCH ERRORS IF USER DOESN'T TYPE A PROPER DAY OF THE WEEK
            {
                Day answerDay = (Day)Enum.Parse(typeof(Day), answer); // CONVERT USER INPUT TO ENUM
                Console.WriteLine("Today is " + answerDay); // DISPLAY ENUM VALUE IN CONSOLE
            }
            catch (System.Exception) // GIVE ERROR MESSAGE IF USER TYPES ANYTHING ELSE
            {
                Console.WriteLine("Please enter a day of the week.");
            }



            Console.ReadLine(); // KEEPS CONSOLE OPEN
    
                
        }
    }
}
