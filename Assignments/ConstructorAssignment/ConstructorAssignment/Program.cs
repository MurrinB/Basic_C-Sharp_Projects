using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string fName = "Bob"; // CREATE CONSTANT VARIABLE 
            const string lName = "Smith"; // SECOND CONSTANT VARIABLE
            var email = "bob.smith@msn.com"; // CREATE VARIABLE USING VAR 
            Console.WriteLine(fName + " " + lName + "\nThis email was created using var: " + email); // DISPLAY CANSTANT VARIABLE AND VAR VARIABLE ALL STRING VARIABLES

            Person person = new Person("Britnee"); // INSTANTIATE CLASS PERSON WITH ONE VARIABLE NAME
            Console.WriteLine(person.Name + " " + person.Gender); // DISPLAY PERSON INSTANCE WITH GENDER VARIABLE ADDED BECAUSE OF CONSTRUCT CHAINING 

            Console.ReadLine();

        }
    }
}
