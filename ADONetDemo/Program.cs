using ADONetDemo.Library;
using ADONetDemo.Library.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace ADONetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlRepository repository = new SqlRepository())

            {
                //    foreach (var item in repository.GetAll())
                //    {
                //        Console.WriteLine(item);
                //    }

                if (repository.AddNew("Avok2adoes", "Gröne Avoks2ado", 129)>0)
                {
                    Console.WriteLine("Frukt tillagd");
                } else
                {
                    Console.WriteLine("Ingen frukt tillagd");
                }

                List<Fruit> fruits = repository.GetAll();

                var q = fruits.FirstOrDefault(x => x.FruitType == "Avokado");
                Console.WriteLine(q);
            }
        }
    }
}
