using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "John", "Mark", "Sarah", "Jane" }; // CREATE ARRAY OF STRINGS
            Console.WriteLine("What is a common last name?"); // INTRODUCTION TO USER
            string lastname = Console.ReadLine(); // GET USER INPUT 

            for (int name = 0; name < names.Length; name++) // FOR LOOP TO ITERATE THROUGH ARRAY AND ADD USER INPUT TO EACH STRING INDEX
            {
                names[name] = names[name] + lastname; 
            }

            foreach (string name in names) // USE FOREACH LOOP TO DISPLAY EACH STRING WITH USER ADDITION IN CONSOLE
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();


            
        }
    }
}
