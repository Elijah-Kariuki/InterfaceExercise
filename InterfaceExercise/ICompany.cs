using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface ICompany
    {
        public string Warranty { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
    }
}
