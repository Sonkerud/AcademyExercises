using System;
using System.Collections.Generic;
using System.Linq;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Company> companyList = new List<Company>
            {
                //new Company{CompanyName = "IKEA",EmployeeCount= 100},
                new Company{CompanyName = "ICA", EmployeeCount = 10},
                new Company{CompanyName = "Tretorn", EmployeeCount = 10},
                new Company{CompanyName = "Nordea", EmployeeCount = 1200},
              
            };

            List<Employee> employees = new List<Employee>
            {
                new Employee{Name = "Aaron", CompanyName = "IKEA"},
                new Employee{Name = "Benny", CompanyName = "IKEA"},
                new Employee{Name = "Sanna", CompanyName = "ICA"},
                new Employee{Name = "Petter", CompanyName = "ICA"},
                new Employee{Name = "Tom", CompanyName = "ICA"},
                new Employee{Name = "Gunnar", CompanyName = "Volvo"},
                new Employee{Name = "Johanna", CompanyName = "SAAB"},
            };
            List<Employee> employeesAtGivenCompanies = new List<Employee>();

           

            var mergadLista = MergeThem.ObjectMerger(employees, companyList, employeesAtGivenCompanies);


            //foreach (var employee in mergadLista)
            //{
            //    Console.WriteLine($"{employee.Name} jobbar på {employee.CompanyName}");
            //}

            Cigarr("heeeje", Scream);
            Cigarr("hFDADKDFJKSDFJK", Whisper);



        }
        static void Cigarr(string str, Action<string> action)
        {
            action(str);
        }

        static void Scream(string str)
        {
            Console.WriteLine(str.ToUpper());
        }

        static void Whisper(string str)
        {
            Console.WriteLine(str.ToLower());
        }
    }
}
