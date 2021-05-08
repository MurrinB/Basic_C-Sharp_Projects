using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.ReadLine();

        }
    }
}
