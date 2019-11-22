using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DelegatesDemo
{
    class Program
    {
        delegate bool Del();
       

        static void Main(string[] args)
        {
            List<Company> companies = new List<Company>
            {
                new Company { Name = "McDonalds", EmployeeCount = 37 },
                new Company { Name = "Bibblan", EmployeeCount = 12 },
                new Company { Name = "IKEA", EmployeeCount = 3 },
                new Company { Name = "Nordea", EmployeeCount = 18 },
                new Company { Name = "Nike", EmployeeCount = 17 },
                new Company { Name = "SBAB", EmployeeCount = 1 }
            };

          
            var newList = companies.FindAll(x => x.EmployeeCount > 10);

            foreach (var item in newList)
            {
                Console.WriteLine($"{item.Name} Employees: {item.EmployeeCount}");
            }
            Console.WriteLine();

            

            //companies.FindAll(c => c.EmployeeCount > 10).ForEach(c => Console.WriteLine(c.Name));
            //companies.Where()
            //foreach (var item in newerList)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //var hej = companies.TrueForAll(EmployeeCounter);
           
        }

        static bool EmployeeCounter(Company c)
        {
             return c.EmployeeCount < 10;
        }
          
        static bool MyTextFilter(string filePath)
        {
            return Path.GetExtension(filePath) == ".txt";
        }
    }
}
// string dirPath = @"C:\Users\Alexander\Desktop";
// FileFinder.FindTextFiles(dirPath, x => x.EndsWith(".txt"));
// Console.WriteLine();

//// FileFinder.FindTextFiles(dirPath, MyTextFilter);
// Console.WriteLine();

// FileFinder.FindTextFiles(dirPath, x => Path.GetExtension(x) == ".txt");