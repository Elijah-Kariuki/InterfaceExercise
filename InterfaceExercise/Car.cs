﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
   public class Car : IVehicle, ICompany
    {
        public string Model { get; set; }
        public string Year { get; set; }
        public string Warranty { get; set; }
        public string Make { get; set; }
        public int NumberOfPassengers { get; set; }
        public int HorsePower { get; set; }
        public string EPAFuelEconomy { get; set; }
        public string Engine { get; set; }
        public double AccellerateTo60MPH { get; set; }
        public bool HasTurbo { get; set; }
    }
}
