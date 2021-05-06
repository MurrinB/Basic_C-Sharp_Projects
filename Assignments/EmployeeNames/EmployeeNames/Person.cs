using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNames
{
    public abstract class Person // CREATE ABSTRACT CLASS PERSON, CANNOT BE INSTANTIATED 
    {
        public string FirstName { get; set; } // CREATE STRING PROPERTIES
        public string LastName { get; set; }


        public virtual void SayName() { // CREATE METHOD TO WRITE OUT NAME IN CONSOLE,  USED VIRTUAL TO BE ABLE TO OVERRIDE IN INHERITED CLASSES

        Console.WriteLine("Name: " + FirstName + " " + LastName);
            
        }
    }
}
