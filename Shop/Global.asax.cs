using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Configuration;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Shop
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

            List<Product> lstProd = new List<Product>();
            List<City> ListCity = new List<City>();
            List<City> LstCity = new List<City>();
            List<LProduct> ListProduct = new List<LProduct>();
            List<Catagory> ListCatagory = new List<Catagory>();

            ListCity.Add(new City()
            {
                CityId = 10,
                CityName = "אשדוד"
            });
            ListCity.Add(new City()
            {
                CityId = 20,
                CityName = "תל אביב"
            });
            ListCity.Add(new City()
            {
                CityId = 30,
                CityName = "חיפה"
            });
            ListCity.Add(new City()
            {
                CityId = 40,
                CityName = "אשקלון"
            });

            string ConnStr;
            string Sql = "select * from t_product";
            ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Conn = new SqlConnection(ConnStr);
            Conn.ConnectionString = ConnStr;
            Conn.Open();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = Sql;
            SqlDataReader Dr;
            Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                lstProd.Add(new Product()
                {
                    Pid = (int)Dr["Pid"],
                    Pname = Dr["Pname"] + "",
                    Price = float.Parse(Dr["Price"] + ""),
                    PDesc = Dr["PDesc"] + "",
                    PicName = Dr["PicName"] + "",
                });

            }
            Dr.Close();

            Sql = "select * from T_LProduct";
            Cmd.CommandText = Sql;
            Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                ListProduct.Add(new LProduct()
                {
                    Pid = (int)Dr["PId"],
                    PName = Dr["PName"] + "",
                });

            }
            Dr.Close();

            Sql = "select * from T_Catagory";
            Cmd.CommandText = Sql;
            Dr=Cmd.ExecuteReader();
            while (Dr.Read())
            {
                ListCatagory.Add(new Catagory()
                {
                    Cid = (int)Dr["Cid"],
                    Cname = Dr["Cname"]+ "",
                    Cdesc = Dr["Cdesc"]+ "",
                    Cpic = Dr["Cpic"]+ "",
                    CDid = (int)Dr["CDid"]
                });
            }
            Dr.Close();
            Conn.Close();





            Application["Product"] = Product.GetAll();
            Application["City"] = LstCity;
            Application["LProduct"] = ListProduct;
            Application["LCity"] = ListCity;
            Application["LCatagory"] = ListCatagory;




            //LstCity.Add(new City()
            //{
            //    CityId = 1,
            //    CityName = "Ashdod"
            //});

            //LstCity.Add(new City()
            //{
            //    CityId = 2,
            //    CityName = "Bny Brak"
            //});

            //LstCity.Add(new City()
            //{
            //    CityId = 3,
            //    CityName = "Hifa"
            //});

            //LstCity.Add(new City()
            //{
            //    CityId = 4,
            //    CityName = "Yerusliem"
            //});

            //LstCity.Add(new City()
            //{
            //    CityId = 5,
            //    CityName = "TZfat"
            //});
            //Application["City"] = LstCity;

        }
    
        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}