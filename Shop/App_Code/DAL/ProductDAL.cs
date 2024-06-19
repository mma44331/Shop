using BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Data;
using System.Data;

namespace DAL
{
    public class ProductDAL
    {
        
        public static void Save(Product Tmp)
        {
            int RetVal = 0;

            
            string Sql="";
            if (Tmp.Pid == -1)
            {
                Sql= $"insert into t_product(Pname,Price,PDesc,Picname)";
                Sql+= $"values(N'{Tmp.Pname}',{Tmp.Price},N'{Tmp.PDesc}',N'{Tmp.PicName}')";


            }
            else
            {
                Sql = "Update t_Product set ";
                Sql += $" Pname=N'{Tmp.Pname}',";
                Sql += $" Price={Tmp.Price},";
                Sql += $" PDesc=N'{Tmp.PDesc}',";
                Sql += $" PicName=N'{Tmp.PicName}'";
                Sql += $" Where Pid={Tmp.Pid}";

            }

            DbContext Db = new DbContext();
            Db.ExecuteNonQuery(Sql);

            if (Tmp.Pid == -1)
            {
                Sql = $"select max(Pid) from T_Product where Pname=N'{Tmp.Pname}'";
              
                Tmp.Pid=(int)Db.ExecuteScalar(Sql);
            }
            Db.Close();

        }
        public static List<Product> GetAll()
        {

            List<Product> lstProd = new List<Product>();

            string Sql = "select * from t_product";
            DbContext Db = new DbContext();
            DataTable Dt=Db.Execute(Sql);

            //נעבור על טבלת הנתונים שורה שורה נעביר אותם אותם לתוך רשימה של מוצרים

            for(int i = 0; i < Dt.Rows.Count; i++)
            {
                lstProd.Add(new Product()
                {
                    Pid = (int)Dt.Rows[i]["Pid"],
                    Pname = Dt.Rows[i]["Pname"] + "",
                    Price = float.Parse(Dt.Rows[i]["Price"] + ""),
                    PDesc = Dt.Rows[i]["PDesc"] + "",
                    PicName = Dt.Rows[i]["PicName"] + "",
                });
            }
           
            Db.Close();
            return lstProd;

        }

        public static Product GetByiD(int Id)
        {
            

            Product tmp = null;
           
            string Sql = $"select * from t_product where Pid={Id}";
           
            DbContext Db = new DbContext();
            DataTable Dt=Db.Execute(Sql);

            if (Dt.Rows.Count>0)
            {
               tmp=new Product()
                {
                    Pid = (int)Dt.Rows[0]["Pid"],
                    Pname = Dt.Rows[0]["Pname"] + "",
                    Price = float.Parse(Dt.Rows[0]["Price"] + ""),
                    PDesc = Dt.Rows[0]["PDesc"] + "",
                    PicName = Dt.Rows[0]["PicName"] + "",
                };

            }
          
            Db.Close();
            return tmp;


        }

        public static int DeleteByiD(int Id)
        {
            int RetVal = 0;       
            string Sql = $"delete from t_product where Pid={Id}";
            DbContext Db = new DbContext();
            RetVal=Db.ExecuteNonQuery(Sql);
            Db.Close();
            return RetVal;
        }

    }
}