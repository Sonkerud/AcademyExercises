using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ24
{
    public static class ListCreator
    {
        public static string FilePath { get; set; }

        //public ListCreator(string filePath)
        //{
        //    FilePath = filePath;
        //}

        public static List<Person> CreateListFromFile( string path)
        {
            return  File.ReadAllLines(path).Distinct().Select(x => x.Split(';')).Select(x => new Person
            {
                Name = x[0],
                //NameDay = DateTime.Parse(x[1])
                NameDay = Convert.ToDateTime(x[1])
            }).ToList();
        }




    }
}
