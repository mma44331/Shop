using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Catagory
    {
        public int Cid {  get; set; }  
        public string Cname { get; set; }
        public string Cdesc { get; set; }
        public string Cpic {  get; set; }
        public int CDid {  get; set; }

        public void Save()
        {
            CatagoryDAL.Save(this);
        }
        public static List<Catagory> GetAll()
        {
            return CatagoryDAL.GetAll();
        }
        public static Catagory GetByiD(int Id)
        {
            return CatagoryDAL.GetByiD(Id);
        }
        public static int DeleteByiD(int Id)
        {
            return CatagoryDAL.DeleteByiD(Id);
        }
    }
}