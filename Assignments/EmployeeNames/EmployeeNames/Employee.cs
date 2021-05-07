using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNames
{
    public class Employee : Person, IQuittable // CREATE EMPLOYEE CLASS WITH INHERITANCE TO PERSON AND INTERFACE IQUITTABLE
    {
        public int id { get; set; } // CREATE INT PROPERTY

        public override void SayName() // MADE ADJUSTMENTS TO INHERITED METHOD WITH OVERRIDE
        {
            Console.WriteLine("Here is the employee's name."); // ADDITION TO METHOD
            base.SayName();
        }

        public void Quit() // IMPLEMENT IQUITTABLE INTERFACE
        {
            Console.WriteLine("I quit!"); 
        }

        public static bool operator ==(Employee idOne, Employee idTwo) // OVERLOAD == OPERATOR 
        {
            bool compare = idOne == idTwo; // COMPARE TWO EMPLOYEE IDS TO CHECK IF THEY ARE EQUAL
            return true;

   
        }

        public static bool operator !=(Employee idOne, Employee idTwo) // OVERLOAD != AS A PAIR WITH == 
        {
            bool compare = idOne != idTwo; // COMPARE THE OPPOSITE IF THE IDS DO NOT MATCH
            return false;

        }
    }
}
