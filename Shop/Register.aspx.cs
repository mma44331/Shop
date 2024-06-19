using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Shop
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var LstCity = (List<City>)Application["City"];
            if (!IsPostBack)
            {

            }
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            string Msg = "";
            if (TxtFulName.Text.Length <3)
                Msg += "עליך להזין שם מלא<br/>";
            
            if (Textpassword.Text.Length < 6|| Textpassword.Text.Contains(" "))
                Msg += "סיסמה לא תקינה חייב לפחות 6 תווים וללא רווחים<br/>";
            if (ChTerm.Checked == false)
                Msg += "עליך לאשר את התנאים<br/>";
            if (RDMale.Checked == false && RDFemale.Checked == false)
                Msg += "אנא בחר מין<br/>";

            if (Msg != "")
                LtlMsg.Text = Msg;
            else
                LtlMsg.Text = "!נרשמת בהצלחה";
        }
    }
}