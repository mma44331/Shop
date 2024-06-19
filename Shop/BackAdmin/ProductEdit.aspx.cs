using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop.BackAdmin
{
    public partial class ProductEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSav_Click(object sender, EventArgs e)
        {
            string Msg = "";
            if (FileImg.HasFile)
            {
                FileImg.SaveAs(Server.MapPath("/Upload/Users/")+FileImg.FileName);
                Msg+= "המוצר התווסף בהצלחה";
            }
            else
            {
                Msg+= "חסר תמונת מוצר";
            }
            if (Msg!="")
                LtlMsg.Text = Msg;

            Product tmp = new Product()
            {
                Pname = TextPname.Text,
                Price = float.Parse(TextPrice.Text),
                PicName = FileImg.TemplateSourceDirectory,
                PDesc = TextDS.Text,
            };
            tmp.Save();
            Application["product"] = Product.GetAll();
            Response.Redirect("ProductList.aspx");
        }
    }
}