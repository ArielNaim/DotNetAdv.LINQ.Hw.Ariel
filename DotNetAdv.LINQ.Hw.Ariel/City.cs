using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdv.LINQ.Hw.Ariel
{
    class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfPopulation { get; set; }

        public City(int id, string name, int nuberOfPopulation)
        {
            Id = id;
            Name = name;
            NumberOfPopulation = nuberOfPopulation;
        }
    }
}
