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
            List<string> Days = new List<string>(); // CREATE EMPTY STRING TO ASSIGN ENUM VALUE TO 
            Console.WriteLine("What day of the week is it?"); // PROMPT USER INPUT
           

            try // TRY TO CATCH ERRORS IF USER DOESN'T TYPE A PROPER DAY OF THE WEEK
            {
                string answer = Console.ReadLine(); // SAVE USER INPUT AS VARIABLE ANSWER
                foreach (string day in Enum.GetNames(typeof(Day))) // PARSE THROUGH ENUM DAY
                {
                    if (day == answer) // COMPARE USER ANSWER TO ENUM
                    {
                        Days.Add(day); // ADD ENUM VALUE TO EMPTY LIST IF IT MATCHES
                        for (int i = 0; i < Days.Count; i++) // PARSE THROUGH DAYS LIST
                        {
                            Console.WriteLine(Days[i]); // DISPLAY DAYS LIST IN CONSOLE 
                        }
                    }
                }
            
            }
            catch (System.Exception) // GIVE ERROR MESSAGE IF USER TYPES ANYTHING ELSE
            {
                Console.WriteLine("Please enter a day of the week.");
            }



            Console.ReadLine(); // KEEPS CONSOLE OPEN
    
                
        }
    }
}
