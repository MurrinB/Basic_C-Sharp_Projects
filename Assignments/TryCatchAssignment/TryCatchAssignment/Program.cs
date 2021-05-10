using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your age?");
            bool validAnswer = false;
            while (!validAnswer)
            {
            try
                {
                    int age = Convert.ToInt32(Console.ReadLine());
                    DateTime birthyear = DateTime.Now.AddYears(-age);
                    Console.WriteLine("The year you were born was " + birthyear.Year);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please write a number.");
                    validAnswer = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occurred.");
                    Console.ReadLine();
                    return;
                }
            }
            
            
            
            Console.ReadLine();

        }
    }
}
