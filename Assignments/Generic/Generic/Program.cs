using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> person = new  Employee<string>(); // INSTANTIATE EMPLOYEE OBJECT WITH STRINGS
            person.Things = new List<string>() { "uniform", "name tag", "walkie-talkie"}; // ASSIGN LIST OF STRING TO PROPTERY THINGS

            Employee<int> personTwo = new Employee<int>(); // INSTANTIATE EMPLOYEE OBJECT WITH INTEGERS
            personTwo.Things = new List<int>() { 1, 2, 3 };

            for (int i = 0; i < person.Things.Count; i++) // CREATE LOOP THAT PRINTS OUT ALL THINGS TO CONSOLE FROM PERSON
            {
                Console.WriteLine(person.Things[i]);
            }

            for (int i = 0; i < personTwo.Things.Count; i++) // CREATE LOOP THAT PRINTS OUT ALL THINGS TO CONSOLE FROM PERSONTWO
            {
                Console.WriteLine(personTwo.Things[i]);
            }

            Number number = new Number(); // INSTANTIATE NUMBER STRUCT
            number.Amount = 2.34m; // ASSIGN VALUE TO AMOUNT PROPERTY 
            Console.WriteLine("The amount assigned is " + number.Amount); // DISPLAY ASSIGNED VALUE IN CONSOLE

            Console.WriteLine("Pick a number."); // PROPMT USER TO PICK RANDOM NUMBER
            int numberPick = Convert.ToInt32(Console.ReadLine()); // SAVE USER INPUT
            using (StreamWriter file = new StreamWriter(@"C:\Users\Britnee Murrin\OneDrive\Desktop\FolderA\NumLog.txt", true)) // GET FILE LOCATION AND INTIATE APPEND COMMAND
            {
                file.WriteLine(numberPick); // APPEND FILE WITH USER INPUT
            }
            string text = File.ReadAllText(@"C:\Users\Britnee Murrin\OneDrive\Desktop\FolderA\NumLog.txt"); // GET THE FILE LOCATION AND READ THE TEXT WITHIN THE FILE
            Console.WriteLine(text); // PRINT OUT THAT TEXT IN THE CONSOLE


                Console.ReadLine(); // KEEP CONSOLE OPEN

        }
    }
}
