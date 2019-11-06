using System;
using System.Collections.Generic;

namespace PropertiesViktor
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(car.GetLicenceNumber());
            car.SetLicenceNumber("abc999");
            Console.WriteLine(car.GetLicenceNumber());
            car.SetColor("blue");
            Console.WriteLine(car.GetColor());

            Console.WriteLine("\n------------TIME TO ADD SOME CARS---------------");
            List<Car> Cars = new List<Car>();
            bool addMoreCars = true;
            while (addMoreCars)
            {
                Console.WriteLine("Lägga till en bil? y / n");
                var ans = Console.ReadLine();
                switch (ans)
                {
                    case "y":
                        Console.WriteLine("Licence number?");
                        string licenceNumber = Console.ReadLine();
                        Console.WriteLine("Color?");
                        string color = Console.ReadLine();
                        Car newCar = new Car();
                        newCar.SetLicenceNumber(licenceNumber);
                        newCar.SetColor(color);
                        Cars.Add(newCar);
                        break;
                    case "n":
                        addMoreCars = false;
                        break;
                    default:
                        break;
                }
            }
            foreach (var c in Cars)
            {
                Console.WriteLine($"{c.GetLicenceNumber()} : {c.GetColor()}");
            }
        }
    }
}
