
using System;
using System.Collections.Generic;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Honda";
            myCar.Model = "Civic";
            myCar.Year = 2012;

            var mazda = new Car()
            {
                Make = "Mazda",
                Model = "CX-5",
                Year = 2016
            };

            var chevy = new Car("Chevy", "Impala", 2001);

            var carList = new List<Car>() { myCar, mazda, chevy };


            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        }
    }
}
