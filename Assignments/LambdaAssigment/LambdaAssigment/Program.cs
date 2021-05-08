using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> ListOfEmployees = new List<Employee>() // CREATE LIST OF EMPLOYEES WITH 10 INSTANCES OF EMPLOYEE
            {
                new Employee() { FirstName = "Joe", LastName = "Johnson", ID = 1 },
                new Employee() { FirstName = "Max", LastName = "Burton", ID = 2 },
                new Employee() { FirstName = "Mel", LastName = "Mason", ID = 3 },
                new Employee() { FirstName = "Joe", LastName = "Jackson", ID = 4 },
                new Employee() { FirstName = "Sarah", LastName = "Morris", ID = 5 },
                new Employee() { FirstName = "Lisa", LastName = "Jones", ID = 6 },
                new Employee() { FirstName = "Angela", LastName = "Madison", ID = 7 },
                new Employee() { FirstName = "James", LastName = "Johnson", ID = 8 },
                new Employee() { FirstName = "Jennifer", LastName = "Jaxson", ID = 9 },
                new Employee() { FirstName = "Britney", LastName = "Marrin", ID = 10 },
            };

            List<Employee> ListJoes = new List<Employee>(); // CREATE EMPTY LIST TO FILL IN FOREACH LOOP
            foreach (Employee employee in ListOfEmployees) // CREATE FOREACH LOOP TO FILL EMPTY LIST WITH ALL EMPLOYEES NAMED "JOE" IN LISTOFEMPLOYEES
                {
                    if (employee.FirstName == "Joe")
                    {
                        ListJoes.Add(employee);
                        Console.WriteLine(employee.FirstName); // DISPLAY EMPLOYEE ADDED TO LIST FOR VERIFICATION
                   
                    }
                }

            List<Employee> NameJoes = ListOfEmployees.Where(i => i.FirstName == "Joe").ToList(); // USE LAMBDA STATEMENT TO CREATE LIST OF EMPLOYEES NAMED JOE FROM LISTOFEMPLOYEES
            foreach (Employee joe in NameJoes) // USED FOREACH LOOP TO DISPLAY LIST TO VERIFY LAMBDA STAEMENT WORKED
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName);
            }

            List<Employee> EmployeeIDList = ListOfEmployees.Where(x => x.ID > 5).ToList(); // USE LAMBDA STATEMENT TO CREATE LIST OF ALL EMPLOYEES WITH ID > 5 FROM LISTOFEMPLOYEES
            foreach (Employee id in EmployeeIDList) // AGAIN USED FOR LOOP TO DISPLAY IN CONSOLE FOR VERFICATION
            {
                Console.WriteLine(id.FirstName + " " + id.ID);
            }
            


            Console.ReadLine();
        }

            
    }
   
}
