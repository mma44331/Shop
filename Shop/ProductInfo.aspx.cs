using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Shop
{
    public partial class ProductInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var lstProd = (List<Product>)Application["Product"];

            if (!IsPostBack)
            {
                string Pid = Request["pid"] + "";
                if (Pid != "")
                {
                    for (int i = 0; i < lstProd.Count; i++)
                    {
                        if (lstProd[i].Pid.ToString() == Pid)
                        {
                            LtlPid.Text = "הקוד מוצר הוא:"+" "+ lstProd[i].Pid+"";
                            LtlPname.Text ="שם שמוצר הוא:"+""+ lstProd[i].Pname;
                            LtlPrice.Text = "המחיר -" + " " + lstProd[i].Price+"שח" ;
                            LtlPDesc.Text ="תיאור המוצר הוא:"+ lstProd[i].PDesc;
                            LtlPicName.Text ="שם התמונה:"+ lstProd[i].PicName + "";
                        }
                    }
                }
            }
        }
    }
}