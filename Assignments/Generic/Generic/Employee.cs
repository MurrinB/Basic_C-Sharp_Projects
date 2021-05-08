using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Employee<T> // CREATE A CLASS THAT TAKES A GENERIC TYPE PARAMETER
    {
        public List<T> Things { get; set; } 

    }
}
