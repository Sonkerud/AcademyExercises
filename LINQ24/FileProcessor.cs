using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LINQ24
{
    public class FileProcessor
    {
        public string FilePath { get; set; }

        public FileProcessor(string filepath)
        {
            FilePath = filepath;
        }

        public List<Person> PersonListCreator()
        {
            return File.ReadAllLines(FilePath).Distinct().Select(x => x.Split(";")).Select(x => new Person
            {
                Name = x[0].ToString(),
                NameDay = Convert.ToDateTime(x[1])
            }).ToList();
        }
    }
}
