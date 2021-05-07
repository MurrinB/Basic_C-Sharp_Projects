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
            employee.id = 15;
            employee.SayName(); // CALL SUPERCLASS METHOD

            Employee employee2 = new Employee(); 
            employee2.id = 20;

            Console.WriteLine(employee == employee2); // COMPARISON OF IDS FROM OVERLOADED == OPERATOR

            Console.ReadLine(); // KEEPS CONSOLE OPEN

            IQuittable employee3 = new Employee(); // CREATE OBJECT TYPE IQUITTABLE WITH POLYMORPHISM
            employee3.Quit(); // CALL IQUITTABLE METHOD QUIT

            Console.ReadLine();


            

            

            

        }
    }
}
