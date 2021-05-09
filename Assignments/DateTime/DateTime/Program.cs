using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //DISPLAY CURRENT DATE AND TIME 
            Console.WriteLine("Pick a number between 1 and 24."); // REQUEST USER INPUT
            double numPick = Convert.ToDouble(Console.ReadLine()); // SAVE USER INPUT AS DOUBLE VARIABLE
            DateTime newTime = DateTime.Now.AddHours(numPick); // ADD USER INPUT TO CURRENT DATETIME 
            Console.WriteLine("The exact time {0} hours from now is " + newTime, numPick); // DISPLAY DATE TIME WITH ADDITION


            Console.ReadLine(); // LEAVE CONSOLE OPEN
        }
    }
}
