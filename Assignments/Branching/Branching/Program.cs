using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. \nWhat is the weight of the package?");
            decimal weight = Convert.ToDecimal(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to ship via Package Express. Have a good day!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("What is the packages width?");
                decimal width = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What is the packages height?");
                decimal height = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What is the packages length?");
                decimal length = Convert.ToDecimal(Console.ReadLine());
                if (width > 50 || height > 50 || length > 50)
                {
                    Console.WriteLine("Package too big to ship via Package Express. Have a good day!");
                    Console.ReadLine();
                }
                else
                {
                    decimal quote = ((height * width * length) * weight) / 100;
                    Console.WriteLine("Your shipping will cost: " + quote.ToString("C2") + "\nThank you for shipping with Package Express!");
                    
                }
                Console.ReadLine();
            }
        }
    }
}
