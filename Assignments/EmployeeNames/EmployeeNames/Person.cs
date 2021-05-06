using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNames
{
    public class Person // CREATE CLASS PERSON
    {
        public string FirstName { get; set; } // CREATE STRING PROPERTIES
        public string LastName { get; set; }


        public void SayName() { // CREATE METHOD TO WRITE OUT NAME IN CONSOLE

        Console.WriteLine("Name: " + FirstName + " " + LastName);
            
        }
    }
}
