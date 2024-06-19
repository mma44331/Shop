using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop.BackAdmin
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var lstProd = (List<Product>)Application["Product"];

                RptProduct.DataSource = lstProd;
                RptProduct.DataBind();
            }

            //List<Product> lstProd = new List<Product>();
            //Product tmp;
            //tmp = new Product()
            //{
            //    Pid = 0,
            //    Pname = "bread",
            //    Price = 4,
            //    PDesc = "Best Bread",
            //    PicName = "bread.jpg",
            //};
            //lstProd.Add(tmp);
            //tmp = new Product()
            //{
            //    Pid = 1,
            //    Pname = "solt",
            //    Price = 12,
            //    PDesc = "Best solt",
            //    PicName = "solt.jpg",
            //};
            //lstProd.Add(tmp);
            //tmp = new Product()
            //{
            //    Pid = 2,
            //    Pname = "kuky",
            //    Price = 3,
            //    PDesc = "Best kuky",
            //    PicName = "kuky.jpg",
            //};
            //lstProd.Add(tmp);
            //tmp = new Product()
            //{
            //    Pid = 3,
            //    Pname = "milk",
            //    Price = 11,
            //    PDesc = "Best milk",
            //    PicName = "milk.jpg",
            //};
            //lstProd.Add(tmp);
            //tmp = new Product()
            //{
            //    Pid = 4,
            //    Pname = "agge",
            //    Price = 6,
            //    PDesc = "Best agge",
            //    PicName = "agge.jpg",
            //};
            //lstProd.Add(tmp);


        }
    }
}