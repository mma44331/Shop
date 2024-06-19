using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btn2.Text = "שניתי את השם";
            //for(int i = 0; i < 10; i++)
            //{
            //    Response.Write($"<h1> {(i+1)*3}</h1>");
            //}

        }
    }
}