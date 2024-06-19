<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Shop.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body dir="rtl">
    
    <form id="form1" runat="server">
        <div>
            <button type="button" id="btn1" name="btn1" ><h3>כפתור רגיל קלאסי</h3></button>
            <input type="button" id="btn3" name="btn3" value="עוד כפתור" />
            <asp:Button ID="btn2" runat="server" Text="צד של שרת" />
           שם פרטי: <asp:TextBox ID="texFirstName" runat="server" placeholder="Yor name"></asp:TextBox>
        </div>
    </form>
    <div id="meir" runat="server"></div>
</body>
</html>
