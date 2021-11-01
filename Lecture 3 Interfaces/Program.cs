using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
            new Car(){Make="Poga", Model = "Champia", Price = 60000},
            new Car(){Make="Skoda", Model = "Fabia", Price = 50000},
            new Car(){Make="Mazda", Model = "CX-3", Price = 40000},
            new Car(){Make="Jaguar", Model = "E Type", Price = 12000000000},
            new Car(){Make="Poga", Model = "AmongUs", Price = 9000000},
            new Car(){Make="Poga", Model = "AmongUs", Price = 4}
            };
            cars.Sort(new CarComparerer());
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Price}");
            }

            List<ITaxable> tax = new List<ITaxable>()
            {
                new House("Aalborg", true, 250.4, 150000M),
                new Bus(42, 69, 250000M)
            };
            foreach (var item in tax)
            {
                Console.WriteLine(item.TaxValue());
            }
        }
    }
}
