using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report"); // introduction
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine(); // Name is string variable console reads and saves variable here
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine(); // Course is string variable console reads and saves variable here
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine()); // pagenumber is int variable and needs to convert for the console to read and save as int
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            bool needHelp = Convert.ToBoolean(Console.ReadLine()); // Help is boolean variable and needs to convert for the console to read and save as boolean
            Console.WriteLine("Are there any positive experiences you would like yo share? Please give specifics.");
            string positiveExp = Console.ReadLine(); // Experience is string variable console reads and saves variable here
            Console.WriteLine("Is there any other feedback you would like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine(); // Feedback is string variable console reads and saves variable here
            Console.WriteLine("How many hours did you study today?");
            decimal studyHours = Convert.ToDecimal(Console.ReadLine()); // Hours is decimal variable and needs to convert for the console to read and save as decimal
            Console.WriteLine("Thank you for your answers. An intructor will respond to this shortly. Have a great day!"); // End program 
            Console.ReadLine(); // Keeps console open 
        }
    }
}
