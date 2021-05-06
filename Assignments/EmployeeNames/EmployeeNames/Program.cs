using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // INSTANTIATE EMPLOYEE CLASS
            employee.FirstName = "Sample"; // CALL CLASS AND ADD NAME
            employee.LastName = "Student";
            employee.SayName(); // CALL SUPERCLASS METHOD

            Console.ReadLine(); // KEEPS CONSOLE OPEN

        }
    }
}
