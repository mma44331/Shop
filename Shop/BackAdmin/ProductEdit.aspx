<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductEdit.aspx.cs" Inherits="Shop.BackAdmin.ProductEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl">
<head runat="server">
    <title>הוספת מוצרים</title>
        <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.rtl.min.css" integrity="sha384-nU14brUcp6StFntEOOEBvcJm4huWjB0OcIeQ3fltAfSmuZFrkAif0T+UtNGlKKQv" crossorigin="anonymous"/>
    <link rel="stylesheet" href=css/style.css" />

</head>
<body>
    <form id="form1" runat="server">
     <div class="container text-center">
       <div class="row p-2">
             <div class="col-md-2">
             שם מוצר
             </div>
             <div class="col-md-4">
             <asp:TextBox ID="TextPname" runat="server"  class="form-control"/>
             <asp:RequiredFieldValidator ID="TxtPname" runat="server" ErrorMessage="הקלד שם מוצר" ControlToValidate="TextPname" ForeColor="Red" />
             </div>
        </div>

        <div class="row p-2">
             <div class="col-md-2">
             מחיר מוצר
             </div>
             <div class="col-md-4">
             <asp:TextBox ID="TextPrice" runat="server"  class="form-control"/>
             <asp:RequiredFieldValidator ID="TxtPrice" runat="server" ErrorMessage="הקלד מחיר מוצר" ControlToValidate="TextPrice" ForeColor="Red" />
            </div>
        </div>

        <div class="row p-2">
             <div class="col-md-2">
             תיאור מוצר
             </div>
             <div class="col-md-4">
             <asp:TextBox ID="TextDS" runat="server"  class="form-control" />
             <asp:RequiredFieldValidator ID="TxtDS" runat="server" ErrorMessage="הקלד תיאור מוצר" ControlToValidate="TextDS" ForeColor="Red" />
            </div>
        </div >

       <div class="row p-2">
             <div class="col-md-2">
           סוג קטוגוריה
           </div>
           <div class="col-md-3">
           <asp:DropDownList ID="DDL" runat="server"  class="form-control">
         <asp:ListItem Text="" Value="-1" />
         <asp:ListItem Text="כלי בית" Value="01"/>
         <asp:ListItem Text="מזון" Value="02" />
         <asp:ListItem Text="קפואים" Value="03" />
         <asp:ListItem Text="שימורים" Value="04" />
         <asp:ListItem Text="חד פעמי" Value="05" />
     </asp:DropDownList>
           <asp:RequiredFieldValidator ID="VDDL" runat="server" ErrorMessage=" בחר קטוגוריה" ControlToValidate="DDL" ForeColor="Red" />
          </div>
        </div> 

        <div class="row p-2"> 
             <div class="col-md-2">
             תמונת מוצר
             </div>
             <div class="col-md-4">
             <asp:FileUpload ID="FileImg" runat="server"  class="form-control" />
             <asp:RequiredFieldValidator ID="RFVFileImg" runat="server" ErrorMessage=" הכנס תמונת מוצר" ControlToValidate="FileImg" ForeColor="Red" />
             </div>
        </div>
         <br />

       <div class="row p-2">
          <div class="col-md-2">
               <asp:Button ID="BtnSave" runat="server" Text="שמור נתונים" OnClick="BtnSav_Click"/>
          </div>
          </div>

       <div class="row p-2">
               <div class="col-md-4">
                               <asp:Literal ID="LtlMsg" runat="server" />
           </div>
        </div>
     </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</body>
</html>
