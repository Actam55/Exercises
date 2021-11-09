using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lecture_8_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //RandomNNumbers nums = new RandomNNumbers(2, 10, 100, 20);
            //
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //SortedList<string> list = new();
            //list.Add("69");
            //list.Add("Raymond");
            //list.Add("420");
            //list.Add("88");
            //list.Add("Tobias");

            //IEnumerator<string> reversedInstructions = list.GetElementsReversed();
            //
            //while (reversedInstructions.MoveNext())
            //{
            //    Console.WriteLine(reversedInstructions.Current);
            //}

            //IEnumerator<string> filteredInstructions = list.GetElements(f => f.Contains("o"));
            //
            //while (filteredInstructions.MoveNext())
            //{
            //    Console.WriteLine(filteredInstructions.Current);
            //}

            //List<int> numbers = new List<int>();
            //Random r = new Random();
            //int randomNum = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    randomNum = r.Next(0, 100); //random number between 0 and 100
            //    numbers.Add(randomNum);
            //}

            //
            //List<int> filteredList = new List<int>();
            //IEnumerable<int> filteredList = numbers
            //    .Where(p => p >= 20 && p <= 40)
            //    .Select(p => p * 2)
            //    .OrderByDescending(p => p);
            //int filteredList = numbers.Where(p => p >= 20 && p <= 40).Max();

            //foreach (var item in filteredList)
            //{
            //    Console.WriteLine(item);
            //}


            //IEnumerable<int> foo = Enumerable.Range(1, 10).Select(x => r.Next(1, 100));
            //foreach (int item in foo)
            //{
            //    Console.WriteLine(item);
            //}

            List<Person> people = new List<Person>()
            {
                new Person() { Name = "Ib", Weight = 89.6, Age = 27 },
                new Person() { Name = "Kaj", Weight = 65.7, Age = 17 },
                new Person() { Name = "Ole", Weight = 77, Age = 7 },
                new Person() { Name = "Andre", Weight = 72, Age = 40 },
                new Person() { Name = "Børge", Weight = 88.8, Age = 13 }
            };

            //IEnumerable<Person> sortedByWeight = people.OrderBy(p => p.Weight);
            //IEnumerable<Person> sortedByNameReverse = people.OrderBy(p => p.Name).Reverse();
            //IEnumerable<string> aNames = people.Where(p => p.Name.Contains("a") || p.Name.Contains("A"))
            //    .Where(p => p.Age > 10)
            //    .Select(p => p.Name);
            //var longestName = people.Where(p => p.Age > 12 && p.Age < 20).OrderByDescending(p => p.Name.Length).First().Weight;

            //foreach (var person in longestName)
            //{
            //    Console.WriteLine(person);
            //}
            //Console.WriteLine(longestName);

            List<MotorVehicle> vehicles = TestVehicles();

            decimal avgPwice = vehicles.Average(p => p.Price);
            double avgSeatsInBus = vehicles.OfType<Bus>().Average(p => p.NumSeats);
            int hasSunRoof = vehicles.OfType<Car>().Count(p => p.HasSunRoof == true);
            IEnumerable<IGrouping<string, MotorVehicle>> sameMake = vehicles.GroupBy(p => p.Make);
            IEnumerable<MotorVehicle> filteredList = vehicles.Where(p => p.Fuel == Fuel.Octane95 || p.Fuel == Fuel.Octane92)
                .Where(p => p.Price > 50000 && p.Price < 150000)
                .OrderBy(p => p.Make)
                .ThenBy(p => p.Model)
                .ThenBy(p => p.Price);
            var veteranVehicels = vehicles.Where(p => 25 < DateTime.Now.Year - p.Year)
                .Select(p => new { Model_Make = $"{p.Model}_{p.Make}", YearsOld = DateTime.Now.Year - p.Year });

            foreach (var item in veteranVehicels)
            {
                Console.WriteLine($"Model_make: {item.Model_Make, -20} Age: {item.YearsOld, -20}");
            }

            //Console.WriteLine(avgPwice);
            //Console.WriteLine(avgSeatsInBus);
            //Console.WriteLine(hasSunRoof);
            //foreach (var item in sameMake)
            //{
            //    foreach (var foo in item)
            //    {
            //        Console.WriteLine(foo.Model);
            //    }
            //}
            //foreach (var item in filteredList)
            //{
            //    Console.WriteLine(item);
            //}
        }
        public static List<MotorVehicle> TestVehicles()
        {
            List<MotorVehicle> vehicles = new List<MotorVehicle>()
            {
                new Car() { Make = "Opel", Model = "Zafira", Year = 2002,
                    Fuel = Fuel.Octane95, Price = 112000 },
                new Car() { Make = "Ford", Model = "Fiesta", Year = 1994,
                    Fuel = Fuel.Octane92, HasSunRoof = true, Price = 72000 },
                new Car() { Make = "Mazda", Model = "6", Year = 2007,
                    Fuel = Fuel.Octane95, Price = 200000 },
                new Car() { Make = "Opel", Model = "Astra", Year = 1995,
                    Fuel = Fuel.Octane92, HasSunRoof = true, Price = 45000 },
                new Car() { Make = "Opel", Model = "Astra", Year = 1997,
                    Fuel = Fuel.Diesel, Price = 52000 },
                new Car() { Make = "Opel", Model = "Zafira", Year = 2001,
                    Fuel = Fuel.Diesel, Price = 137000 },
                new Car() { Make = "Ford", Model = "Focus", Year = 2007,
                    Fuel = Fuel.Octane92, HasSunRoof = true, Price = 199999 },
                new Car() { Make = "Opel", Model = "Astra", Year = 1996,
                    Fuel = Fuel.Diesel, Price = 29000 },
                new Bus() { Make = "Scania", Model = "Buzz", Year = 1999,
                    Price = 275000, NumSeats = 52},
                new Bus() { Make = "Scania", Model = "Fuzz", Year = 2000,
                    Price = 225000, NumSeats = 12}
            };
            return vehicles;
        }
    }
}
