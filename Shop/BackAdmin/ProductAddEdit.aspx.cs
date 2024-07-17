using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Shop.BackAdmin
{
    public partial class ProductAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //נשלוף את קוד המוצר שנשלח, במידה ונשלח
            //ןנטען את הנתונים
            if (!IsPostBack)
            {
                string Pid = Request["Pid"] + "";
                if (string.IsNullOrEmpty(Pid) )
                {
                    Pid = "-1";
                }
                else
                {
                    //נחפש מוצר מתוך מאגר המוצרים עם קוד מוצר שקיבלנו
                    FillData(Pid);
                }
            }
        }
        public void FillData(string Pid)
        {
            //נשלוף את פרטי המטצר לעריכה מתוך בסיס הנתונים
            Product tmp=Product.GetByiD(int.Parse(Pid));
            if (tmp == null)
            {
                Pid = "-1";
            }
            else
            {
                //מלא את כל תיבות הטקסט בפרטי המוצר
                HidPid.Value = Pid;
                TxtPname.Text=tmp.Pname;
                TxtPrice.Text =tmp.Price+"";
                TxtPicName.Text = tmp.PicName;

            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            string Picname;
            if (PicUpload.HasFile)
            {
              Picname= GlobFunc.GetRandStr(8);
                //string Ext=Path.GetExtension(PicUpload.FileName);
                string ext =PicUpload.FileName.Substring(PicUpload.FileName.LastIndexOf('.'));
                string NewName=Picname+ext;
                PicUpload.SaveAs(Server.MapPath("/Upload/Users/")+NewName);
                Picname = NewName;
            }
            else
            {
                Picname = TxtPicName.Text;
            }
            Product tmp = new Product()
            {
                Pid = int.Parse(HidPid.Value),
                Pname = TxtPname.Text,
                Price = float.Parse(TxtPrice.Text),
                PicName = Picname,
                PDesc= TxtProdDesc.Text,
            };
            tmp.Save();
            Application["product"] = Product.GetAll();
            Response.Redirect("ProductList.aspx");
        }
    }
}