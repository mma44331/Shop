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
    public class ClientDAL
    {
      
        public static bool ChkLogin(Client Tmp) 
        {
            bool Status=false;
            string Sql = $"select * from t_Client where Email='{Tmp.Email}' And Pass='{Tmp.Pass}'";

            DbContext Db = new DbContext();
            DataTable Dt = Db.Execute(Sql);

            if (Dt.Rows.Count>0)
            {
                Tmp.ClientId = (int)Dt.Rows[0]["ClientId"] ;
                Tmp.FullName = Dt.Rows[0]["FullName"] + "";
                Status = true;
            }
           
            Db.Close();
            return Status;
        }

        public static void Save(Client Tmp)
        {
            string Sql = "";
            if (Tmp.ClientId == -1)
            {
                Sql = $"insert into t_Client(Email,Pass,FullName)";
                Sql += $"values(N'{Tmp.Email}',{Tmp.Pass},N'{Tmp.FullName}')";


            }
            else
            {
                Sql = "Update t_Client set ";
                Sql += $" Email=N'{Tmp.Email}',";
                Sql += $" Pass={Tmp.Pass}',";
                Sql += $" FullName=N'{Tmp.FullName}'";
            }

            DbContext Db = new DbContext();
            Db.ExecuteNonQuery(Sql);

            if (Tmp.ClientId == -1)
            {
                Sql = $"select max(ClientId) from T_Client where Email=N'{Tmp.Email}'";

                Tmp.ClientId = (int)Db.ExecuteScalar(Sql);
            }
            Db.Close();

        }
        public static List<Client> GetAll()
        {

            List<Client> lstClient = new List<Client>();

            string Sql = "select * from t_Client";
            DbContext Db = new DbContext();
            DataTable Dt = Db.Execute(Sql);

            //נעבור על טבלת הנתונים שורה שורה נעביר אותם אותם לתוך רשימה של מוצרים

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                lstClient.Add(new Client()
                {

                    ClientId = (int)Dt.Rows[0]["ClientId"],
                    Email = Dt.Rows[0]["Email"] + "",
                    Pass = Dt.Rows[0]["Pass"] + "",
                    FullName = Dt.Rows[0]["FullName"] + "",
                });
            }

            Db.Close();
            return lstClient;
        }

        public static Client GetByiD(int Id)
        {


            Client tmp = null;

            string Sql = $"select * from t_Client where ClientId={Id}";

            DbContext Db = new DbContext();
            DataTable Dt = Db.Execute(Sql);

            if (Dt.Rows.Count > 0)
            {
                tmp = new Client()
                {
                    ClientId = (int)Dt.Rows[0]["ClientId"],
                    Email = Dt.Rows[0]["Email"] + "",
                    Pass = Dt.Rows[0]["Pass"]+"",
                    FullName = Dt.Rows[0]["FullName"] + "",
                };

            }

            Db.Close();
            return tmp;


        }

        public static int DeleteByiD(int Id)
        {
            int RetVal = 0;
            string Sql = $"delete from t_Client where ClientId={Id}";
            DbContext Db = new DbContext();
            RetVal = Db.ExecuteNonQuery(Sql);
            Db.Close();
            return RetVal;
        }

    }
}