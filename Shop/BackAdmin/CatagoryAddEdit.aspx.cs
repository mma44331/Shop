using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop.BackAdmin
{
    public partial class CategoryaddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //נשלוף את קוד המוצר שנשלח, במידה ונשלח
            //ןנטען את הנתונים
            if (!IsPostBack)
            {
                string Cid = Request["Cid"] + "";
                if (string.IsNullOrEmpty(Cid))
                {
                    Cid = "-1";
                }
                else
                {
                    //נחפש מוצר מתוך מאגר המוצרים עם קוד מוצר שקיבלנו
                    FillData(Cid);
                }
            }
        }
        public void FillData(string Cid)
        {
            //נשלוף את פרטי המטצר לעריכה מתוך בסיס הנתונים
            Catagory tmp = Catagory.GetByiD(int.Parse(Cid));
            if (tmp == null)
            {
                Cid = "-1";
            }
            else
            {
                //מלא את כל תיבות הטקסט בפרטי המוצר
                HidCid.Value = Cid;
                TxtCname.Text = tmp.Cname;
                TxtCdesc.Text = tmp.Cdesc;
                TxtCpic.Text = tmp.Cpic;
                TxtCDid.Text = tmp.CDid + "";
            }
        }



        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Catagory  tmp=new Catagory()                           
            {
                Cid = int.Parse(HidCid.Value),
                Cname = TxtCname.Text,
                Cdesc = TxtCdesc.Text,
                Cpic = TxtCpic.Text,
                CDid=int.Parse(TxtCDid.Text)
            };
            tmp.Save();
            Application["LCatagory"] = Catagory.GetAll();
            Response.Redirect("CatagoryList.aspx");
        }
    }
}