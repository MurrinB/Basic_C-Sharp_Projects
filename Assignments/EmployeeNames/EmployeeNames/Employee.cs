using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNames
{
    public class Employee : Person // CREATE EMPLOYEE CLASS WITH INHERITANCE TO PERSON
    {
        public int id { get; set; } // CREATE INT PROPERTY

        public override void SayName() // MADE ADJUSTMENTS TO INHERITED METHOD WITH OVERRIDE
        {
            Console.WriteLine("Here is the employee's name."); // ADDITION TO METHOD
            base.SayName();
        }
    }
}
