using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Person 
    {
        public Person(string name) : this (name, "F") { } // CHAIN CONSTRUCT PERSON WITH ONE PARAMETER AND GIVE AUTO GEN VARIABLE FOR PARAMETER TWO

        public Person(string name, string gender) // CREATE PERSON CONSTRUCT WITH TWO PARAMETERS
        {
            Name = name;
            Gender = gender;
        }
        public string Name; // ASSIGN VARIABLES
        public string Gender;
    }
}
