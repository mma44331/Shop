using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Shop
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string Msg = "";
            if (TxtFulName.Text.Length < 3)
                Msg += "עליך ללהזין שם מלא<br/>";
            if (Textpassword.Text.Length < 6 || Textpassword.Text.Contains(" "))
                Msg += "סיסמה לא תקינה, עליך להזין סיסמה חוקית לפחות 6 תווים וללא רווחים";
            if (Msg != "")
                LtlMsg.Text = Msg;

            Client Tmp = new Client()
            {
                Email = Textemail.Text,
                Pass = Textpassword.Text
            };
            if (Tmp.ChkLogin())
            {
                Session["ClientLogin"] = Tmp;//משמר את האבייקט הנוכחי עם הפרטים המלאים באיחסון כדי להשתמש עם זה תמיד ולחסוך לשלוף כל פעם מהDATABA
                Response.Redirect("/BackAdmin");// מפנה אותך לדף הרצוי
            }
            else
            {
                Msg += "המערכת לא זיהת את פרטי המשתמש";
                LtlMsg.Text = Msg;
            }

               

        }
    }
}