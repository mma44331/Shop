using System;
using BLL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data;
using System.Data;

namespace DAL
{
    public class CityDAL
    {
        public static void Save(City Tmp)
        {
            string Sql = "";
            if (Tmp.CityId == -1)
            {
                Sql = $"insert into t_City(CityId,CityName)";
                Sql += $"values(N'{Tmp.CityId}',{Tmp.CityName})";


            }
            else
            {
                Sql = "Update t_City set ";
                Sql += $" CityId=N'{Tmp.CityId}',";
                Sql += $" CityName={Tmp.CityName}'";
            }

            DbContext Db = new DbContext();
            Db.ExecuteNonQuery(Sql);

            if (Tmp.CityId == -1)
            {
                Sql = $"select max(CityId) from T_City where CityName=N'{Tmp.CityName}'";

                Tmp.CityId = (int)Db.ExecuteScalar(Sql);
            }
            Db.Close();

        }
        public static List<City> GetAll()
        {

            List<City> lstCity = new List<City>();

            string Sql = "select * from t_City";
            DbContext Db = new DbContext();
            DataTable Dt = Db.Execute(Sql);

            //נעבור על טבלת הנתונים שורה שורה נעביר אותם אותם לתוך רשימה של מוצרים

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                lstCity.Add(new City()
                {

                    CityId = (int)Dt.Rows[0]["CityId"],
                    CityName = Dt.Rows[0]["CityName"] + "",
                });
            }

            Db.Close();
            return lstCity;
        }

        public static City GetByiD(int Id)
        {


            City tmp = null;

            string Sql = $"select * from t_City where CityId={Id}";

            DbContext Db = new DbContext();
            DataTable Dt = Db.Execute(Sql);

            if (Dt.Rows.Count > 0)
            {
                tmp = new City()
                {
                    CityId = (int)Dt.Rows[0]["CityId"],
                    CityName = Dt.Rows[0]["CityName"] + "",
                };

            }

            Db.Close();
            return tmp;


        }

        public static int DeleteByiD(int Id)
        {
            int RetVal = 0;
            string Sql = $"delete from t_City where CityId={Id}";
            DbContext Db = new DbContext();
            RetVal = Db.ExecuteNonQuery(Sql);
            Db.Close();
            return RetVal;
        }

    }
}