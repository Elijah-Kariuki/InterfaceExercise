using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int HorsePower { get; set; }
        public int NumberOfPassengers { get; set; }
        public string EPAFuelEconomy { get; set; }
        public string Engine { get; set; }
    }
}
