﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IItemized : IVehicle, ICompany
    {
        public string Warranty { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public int HorsePower { get; set; }
        public int NumberOfPassengers { get; set; }
        public string EPAFuelEconomy { get; set; }
        public string Engine { get; set; }
    }
}
