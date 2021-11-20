using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DotNetAdv.LINQ.Hw.Ariel
{
    enum CityTipe { City, Settelmant }
    class Program
    {
        Func<string> GetCityParameter;
        // GetCityParameter getCityNameContain(string str);
       

        static void Main(string[] args)
        {
            #region City - Targil 8 - 10 
            List<City> cities = new List<City>();
            cities.Add(new City(01, "Tel Aviv", 450000));
            cities.Add(new City(02, "Nahariy", 45000));
            cities.Add(new City(03, "KiryatShmona", 23000));
            cities.Add(new City(04, "Carmiel", 60000));
            cities.Add(new City(05, "Ramot Naftaly", 550));
            cities.Add(new City(06, "Rishon Letzion", 300000));
            cities.Add(new City(07, "Rehovot", 150000));
            #region Targil 8 + 9 
            var qeuryOver25 = cities.Where(c => c.NumberOfPopulation > 25000);
            foreach (var item in qeuryOver25)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("===");
            var qeury25 = (from city in cities
                           where city.NumberOfPopulation < 25000
                           select city).ToList();
            foreach (var item in qeury25)
            {
                Console.WriteLine(item.Name + " " + item.NumberOfPopulation);
            }
            #endregion
            Console.WriteLine("=== === ===");
            #region Targil 10
            var qeury1 = cities.Select(c => new{ c.Name, IsCity = c.NumberOfPopulation > 25000 });
            var qeury2 = cities.Select(c => new{ c.Name, IsCity = c.NumberOfPopulation > 25000?CityTipe.City: CityTipe.Settelmant});
            var listOfAnonymus = qeury1.ToList();

            var listOfCs = GetListOfCities();
            foreach (dynamic item in listOfCs)
            {
                Console.WriteLine(item.Name);
            }
             public static IEnumerable GetListOfCities()
            {
                var query = cities.Select(c => new
                {
                    c.Name,
                    CityTipe = c.NumberOfPopulation > 25000 ?
                    CityTipe.City : CityTipe.Settelmant

                });
            }


            var qeuryIsCity = from c in cities
                              where c.NumberOfPopulation > 25000
                              select new { Name = c.Name, IsCity = true };
            foreach (var item in qeuryIsCity)
            {
                Console.WriteLine(item.Name + " " + item.IsCity);
            }
            Console.WriteLine("====");
            var qIscity = cities.Where(c => c.NumberOfPopulation < 25000).Select(c => new { c.Name, IsCity = false }).ToList();
            foreach (var item in qIscity)
            {
                Console.WriteLine(item.Name);
            }

            #endregion

            
            #region Citys Targil 4 - 7
            List<string> list = new List<string>() { "Tel Aviv", "Qiryat Shmona", "Eilat", "Dimona", "Kfar Bloom", "Haifa", "hulate", "Tel Dor", "Qiryq Mozkin", "kfar saba" };

            #endregion 

            #region Int numbers Targil 1 - 3 
            List<int> listInt = new List<int>() { 15, -32, 17, 8, 350, -45, -2 };
            #region Targil 1 negativ numbers
            var qeuryNegativNum = from number in listInt
                                  where number < 0
                                  select number;
            var qeuryNnMethod = listInt.Where(number => number < 0).ToList();
            foreach (var item in qeuryNegativNum)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=====");
            for (int i = 0; i < qeuryNnMethod.Count; i++)
            {
                Console.WriteLine(qeuryNnMethod[i]);
            }
            #endregion
            Console.WriteLine("=====Targil=====");
            #region Targil 2 
            var qeuryOddNumber = (from number in listInt
                                  where number % 2 != 0
                                  select number).OrderByDescending(number => number).ToList();
            var qeuryOddNMethod = listInt.Where(number => number % 2 != 0).ToList().OrderByDescending(n => n).ToList();
            foreach (var item in qeuryOddNumber)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=====");
            for (int i = 0; i < qeuryOddNMethod.Count; i++)
            {
                Console.WriteLine(qeuryOddNMethod[i]);
            }

            #endregion
            Console.WriteLine("=====Targil=====");
            #region Targil 3 bigger then 5 miltiplay by 3
            var queryBigAndMultiplay = from number in listInt
                                       where (number > 5) && (number % 3 != 0)
                                       select number * 3;
            var qeury3Met = listInt.Where(n => (n > 5 && n % 3 != 0)).Select(n => n * 3).ToList();
            foreach (var item in queryBigAndMultiplay)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=====");
            for (int i = 0; i < qeury3Met.Count; i++)
            {
                Console.WriteLine(qeury3Met[i]);
            }
            #endregion

            #endregion
            
            Console.ReadLine();
            #endregion
        }
    }

}
