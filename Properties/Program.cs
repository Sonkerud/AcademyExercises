using System;
using System.Collections.Generic;

namespace Properties
{
    class Program
    {
        static List<Car> carList = new List<Car>();
        static void Main(string[] args)
        {
            //Car newCar = new Car();
            //newCar.Color = "blue";
            //newCar.LicenseNumber = "hjjk133";
            //Console.WriteLine(newCar.LicenseNumber);

            bool addCars = true;
            while (addCars)
            {
                AddCar();
                Console.WriteLine("Add new car? (Y)es (N)o");
                string ans = Console.ReadLine();
                if (ans == "N" || ans == "n")
                {
                    addCars = false;
                }
            }
            foreach (var car in carList)
            {
                Console.WriteLine($"License number: {car.GetLicenseNumber()} Color: {car.GetColor(true)}");
            }
        }
        public static void AddCar() 
        {
            Console.WriteLine("Add a new Car\n");
            Car car = new Car();
            Console.WriteLine("License number:");
            //car.SetLicenseNumber(Console.ReadLine());
            car.LicenseNumber = Console.ReadLine();
            Console.WriteLine("Color:");
            //car.SetColor(Console.ReadLine());
            car.Color = (Console.ReadLine());
            carList.Add(car);
        }
    }
}
