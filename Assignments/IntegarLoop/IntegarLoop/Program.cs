using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegarLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 5, 10, 15, 20, 25 }; // CREATE LIST OF INTEGARS
            try // HELP CATCH USER ERRORS
            {

            foreach (int number in numbers) // ITERATE THROUGH NUMBER LIST
            {
                Console.WriteLine(number); // PRINT EACH NUMBER IN CONSOLE
            }

            Console.WriteLine("Pick a number to divide each number in this list by."); // REQUEST USER INPUT
            int numberDivideBy = Convert.ToInt32(Console.ReadLine()); // SAVE USER INPUT NUMBER

            foreach (int number in numbers) // ITERATE THROUGH NUMBER LIST 
            {
                int answer = number / numberDivideBy; // DIVID EACH NUMBER BY USER INPUT NUMBER
                Console.WriteLine(number + " divided by " + numberDivideBy + " equals " + answer); // PRINT EQUATION OF EACH NUMBER IN CONSOLE
            }

            }
            catch (FormatException ex) // CODE BLOCK IS FOR STRING INSTEAD OF INT ERROR
            {
                Console.WriteLine("Please write a whole number.");
                
            }
            catch (DivideByZeroException ex) // CODE BLOCK IS FOR DIVIDING BY 0 ERROR
            {
                Console.WriteLine("Please don't divide by zero.");
                
            }
            catch (Exception ex) // CODE BLOCK FOR ANY OTHER ERRORS
            {
                Console.WriteLine(ex);
               
            }
            finally // CODE BLOCK SIGNALS THE END OF THE PROGRAM
            {
                Console.WriteLine("Program End!");
            }

            Console.WriteLine("The program has emerged from the try/catch block!"); // ALERTING THE USER THAT THE PROGRAM MADE IT THROUGH THE TRY/CATCH BLOCK

            Console.ReadLine(); // KEEPS CONSOLE OPEN
        }
    }
}
