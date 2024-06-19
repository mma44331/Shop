using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public string PDesc { get; set; }
        public float Price { get; set; }
        public string PicName { get; set; }

        public void Save()
        {
            ProductDAL.Save(this);
        }
        public static List<Product> GetAll()
        {
            return ProductDAL.GetAll();
        }
        public static Product GetByiD(int Id)
        {
            return ProductDAL.GetByiD(Id);
        }
        public static int DeleteByiD(int Id)
        {
            return ProductDAL.DeleteByiD(Id);
        }



    }
}