using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class City
    {
        public int CityId {  get; set; }
        public string CityName { get; set; }

        public void Save()
        {
            CityDAL.Save(this);
        }
        public static List<City> GetAll()
        {
            return CityDAL.GetAll();
        }
        public static City GetByiD(int Id)
        {
            return CityDAL.GetByiD(Id);
        }
        public static int DeleteByiD(int Id)
        {
            return CityDAL.DeleteByiD(Id);
        }


    }
}