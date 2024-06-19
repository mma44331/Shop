using BLL;
using Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DAL
{
    public class CatagoryDAL
    {
        public static void Save(Catagory Tmp)
        {
            int RetVal = 0;

        
            string Sql = "";
            if (Tmp.Cid == -1)
            {
                Sql = $"insert into t_Catagory(Cname,Cdesc,Cpic,CDid)";
                Sql += $"values(N'{Tmp.Cname}',N'{Tmp.Cdesc}',N'{Tmp.Cpic}',N'{Tmp.CDid}')";
            }
            else
            {
                Sql = "Update t_Catagory set ";
                Sql += $" Cname=N'{Tmp.Cname}',";
                Sql += $" Cdesc=N'{Tmp.Cdesc}',";
                Sql += $" Cpic=N'{Tmp.Cpic}', ";
                Sql += $" CDid=N'{Tmp.CDid}', ";
                Sql += $" Where Cid={Tmp.Cid}";

            }



            DbContext Db = new DbContext();
            Db.ExecuteNonQuery(Sql);


            if (Tmp.Cid == -1)
            {
                Sql += $"select max(Cid) from T_Catagory where Cname=N'{Tmp.Cname}'";
                Tmp.Cid = (int)Db.ExecuteScalar(Sql);
            }
            Db.Close();

        }

        public static List<Catagory> GetAll()
        {

            List<Catagory> lstCatagory = new List<Catagory>();

         
            string Sql = "select * from t_Catagory";
            DbContext Db = new DbContext();
            DataTable Dt = Db.Execute(Sql);


            for (int i=0;i<Dt.Rows.Count;i++)
            {
                lstCatagory.Add(new Catagory()
                {
                    Cid = (int)Dt.Rows[i]["Cid"],
                    Cname = Dt.Rows[i]["Cname"] + "",
                    Cdesc = Dt.Rows[i]["Cdesc"] + "",
                    Cpic = Dt.Rows[i]["Cpic"] + "",
                    CDid = (int)Dt.Rows[i]["CDid"]
                });

            }
           
            Db.Close();
            return lstCatagory;

        }

        public static Catagory GetByiD(int Id)
        {

            Catagory tmp = null;
            string Sql = $"select * from t_Catagory where Cid={Id}";
            DbContext Db = new DbContext();
            DataTable Dt = Db.Execute(Sql);


            if (Dt.Rows.Count>0)
            {
                tmp = new Catagory()
                {
                    Cid = (int)Dt.Rows[0]["Cid"],
                    Cname = Dt.Rows[0]["Cname"] + "",
                    Cdesc = Dt.Rows[0]["Cdesc"] + "",
                    Cpic = Dt.Rows[0]["Cpic"] + "",
                    CDid = (int)Dt.Rows[0]["CDid"]
                };

            }
            Db.Close();
            return tmp;


        }

        public static int DeleteByiD(int Id)
        {
            int RetVal = 0;

          
            string Sql = $"delete from t_Catagory where Cid={Id}";
            DbContext Db = new DbContext();
            RetVal = Db.ExecuteNonQuery(Sql);

            Db.Close();

            return RetVal;
        }



    }
}