using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Done--TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Done--Create 2 Interfaces called IVehicle & ICompany

            //Done--Create 3 classes called Car , Truck , & SUV

            //Done--In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //Done--In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //Done--In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;

            var porsche = new Car() { Make = "Porsche", Model = "911 GT3 RS", Year = "2023", Warranty = "4 Years or 50,000 Miles", NumberOfPassengers = 2, HorsePower = 518, EPAFuelEconomy = "16.9 mpg", Engine = "4.0-liter naturally aspirated boxer 6", AccellerateTo60MPH = 3.0, HasTurbo = true };
            var mercedes = new SUV() { Make = "Mercedes Benz", Model = "AMG G 63 4Matic SUV", Year = "2022", Warranty = "6 Years or 75,000 Miles", NumberOfPassengers = 5, HorsePower = 577, EPAFuelEconomy = "13 to 16 mpg", Engine = "4.0L AMG V8 biturbo", FourWheelDrive = true, GroundClearance = 9.5 };
            var rivian = new Truck() {Make = "Rivian", Model = "R1T", Year = "2022", Warranty = "8 Years or 175,000 Miles", NumberOfPassengers = 5, HorsePower = 835, EPAFuelEconomy ="70 MPGe", Engine = "Electric", FuelType = "Electricity", TowingCapacity = 11000  };
            //Creatively display and organize their values
           var car = new List<Car>{porsche};
            var truck = new List<Truck> { rivian };
            var suv = new List<SUV> { mercedes };
            
            

            foreach (var item in car)
            {
                Console.WriteLine($"The {item.Year} {item.Make} {item.Model} comes with the manufacturer warranty for the {item.Model} that is {item.Warranty}. \nIt comes packed with {item.HorsePower} horsepower and estimated fuel economy of {item.EPAFuelEconomy} and can seat comfortably {item.NumberOfPassengers} passengers.");
                Console.WriteLine();
                Console.WriteLine($"In addition, the {item.Make} {item.Model} can accellerate from 0-60 mph in {item.AccellerateTo60MPH} seconds!! True or False: the {item.Model} has turbo? {item.HasTurbo}!!");
                Console.WriteLine("----------------------------------------------");
            }
            foreach(var item in truck)
            {
                Console.WriteLine($"The {item.Year} {item.Make} {item.Model} comes with the manufacturer warranty for the {item.Model} that is {item.Warranty}. \nIt comes packed with {item.HorsePower} horsepower and estimated fuel economy of {item.EPAFuelEconomy} and can seat comfortably {item.NumberOfPassengers} passengers.");
                Console.WriteLine();
                Console.WriteLine($"In addition, the {item.Make} {item.Model} has a towing capacity of {item.TowingCapacity} which is impressive for an {item.FuelType} vehicle!!");
                Console.WriteLine("----------------------------------------------");

            }
            foreach(var item in suv)
            {
                Console.WriteLine($"The {item.Year} {item.Make} {item.Model} comes with the manufacturer warranty for the {item.Model} that is {item.Warranty}. \nIt comes packed with {item.HorsePower} horsepower and estimated fuel economy of {item.EPAFuelEconomy} and can seat comfortably {item.NumberOfPassengers} passengers.");
                Console.WriteLine();
                Console.WriteLine($"In addition, the {item.Make} {item.Model} has a ground clearance of {item.GroundClearance} inches in case you want to go off road!! True or False: the {item.Model} is one of the best 4X4 SUVs? {item.FourWheelDrive}!!");
                Console.WriteLine("----------------------------------------------");
            }


        }
    }
}
