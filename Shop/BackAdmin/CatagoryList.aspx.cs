using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop.BackAdmin
{
    public partial class CatagoryList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var ListCatagory = (List<Catagory>)Application["LCatagory"];
                RptCatagory.DataSource = ListCatagory;
                RptCatagory.DataBind();
            }

        }
    }
}