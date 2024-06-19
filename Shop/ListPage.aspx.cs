using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop
{
    public partial class ListsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var ListCity = (List<City>)Application["LCity"];
            var ListProduct = (List<LProduct>)Application["LProduct"];




            if (!IsPostBack)
            {
                for (int i = 0; i < ListCity.Count; i++)
                {
                    DDLCity.Items.Add(new ListItem(ListCity[i].CityName, ListCity[i].CityId + ""));
                }
                for (int i = 0; i < ListProduct.Count; i++)
                {
                    DDLProduct.Items.Add(new ListItem(ListProduct[i].PName, ListProduct[i].Pid + ""));
                }
                for (int i = 1; i < 91; i++)
                {
                    DDLNum.Items.Add(new ListItem(i + " "));
                }
            }



        }
    }
}