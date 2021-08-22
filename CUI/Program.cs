using Business.concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CityTest();
        }

        private static void CityTest()
        {
            City city = new City();

            city.CityName = "Adana";

            CityManager cityManager = new CityManager(new EfCityDal());

            //cityManager.Add(city);
            var result = cityManager.GetAll();

            foreach (var item in result.Data)
            {
                Console.WriteLine(item.CityName);
            }
        }
    }
}
