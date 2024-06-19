<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Shop.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl" lang="he">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
     <title>הרשמה לאתר</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.rtl.min.css" integrity="sha384-nU14brUcp6StFntEOOEBvcJm4huWjB0OcIeQ3fltAfSmuZFrkAif0T+UtNGlKKQv" crossorigin="anonymous"/>
    <link rel="stylesheet" href="css/style.css" />
</head>
<body>
    <nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Navbar</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="#">Home</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Link</a>
        </li>
        <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            Dropdown
          </a>
          <ul class="dropdown-menu">
            <li><a class="dropdown-item" href="#">Action</a></li>
            <li><a class="dropdown-item" href="#">Another action</a></li>
            <li><hr class="dropdown-divider"></li>
            <li><a class="dropdown-item" href="#">Something else here</a></li>
          </ul>
        </li>
        <li class="nav-item">
          <a class="nav-link disabled" aria-disabled="true">Disabled</a>
        </li>
      </ul>
      <form class="d-flex" role="search">
        <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search">
        <button class="btn btn-outline-success" type="submit">Search</button>
      </form>
    </div>
  </div>
</nav><br />
  

    <form id="form1" runat="server">
          <div class="container text-center">
  
              <div class="row">
    <div class="col-md-2 col-sm-3">
      שם מלא
    </div>
    <div class="col-md-2 col-sm-3">
        <asp:TextBox ID="TxtFulName" runat="server" Class="form-control" placeholder="נא הזן שם מלא"/>
        <asp:RequiredFieldValidator Id="RqFulName" runat="server" ErrorMessage="נא הזן שם מלא" ControlToValidate="TxtFulName" ForeColor="Red"/>
    </div>
    <div class="col-md-2 col-sm-2">
        כתובת
    </div>
         <div class="col-md-2 col-sm-3">
       <asp:TextBox ID="TextBox1" runat="server" Class="form-control" placeholder="נא הזן כתובת"/>
    </div> 
  </div>
              <br />
  <div class="row">
  <div class="col-md-2 col-sm-3">
   עיר
  </div>
  <div class="col-md-2 col-sm-3">

       <asp:DropDownList ID="DropDownList1" runat="server" Class="container-fluid">
           <asp:ListItem Text="בחר עיר" Value="-1" />
     <asp:ListItem Text="אשדוד" Value="2" />
     <asp:ListItem Text="תל אביב" Value="5" />
     <asp:ListItem Text="חיפה" Value="7" />
 </asp:DropDownList>
  </div>
  <div class="col-md-2 col-sm-2">
     טלפון
  </div>
       <div class="col-md-2 col-sm-3">
     <asp:TextBox ID="Textphoone" runat="server" Class="form-control" placeholder="נא הזן טלפון"/>
     <asp:RegularExpressionValidator  ID="RgPhoone" runat="server" ErrorMessage="טלפון לא תקין" ControlToValidate="Textphoone" ValidationExpression="05[0-8][-]?[1-9][0-9]{6}" />
  </div> 
</div>
              <br />
  <div class="row">
   <div class="col-md-2 col-sm-3">
   אימייל
  </div>
  <div class="col-md-2 col-sm-3">
      <asp:TextBox ID="Textemail" runat="server" Class="form-control" placeholder="נא הזן כתובת אימייל"/>
  </div>
  <div class="col-md-2 col-sm-2">
      סיסמה
  </div>
       <div class="col-md-2 col-sm-3">
     <asp:TextBox ID="Textpassword" TextMode="Password" runat="server" Class="form-control" placeholder="נא הזן סיסמה"/>
  </div>
      </div>
              <br />
  <div class="row">
  <div class="col-md-2 col-sm-3">
    גיל
  </div>
  <div class="col-md-2 col-sm-3">
      <asp:TextBox ID="TextAge" runat="server" Class="form-control" placeholder="נא הזן את גילך"/>
      <asp:RangeValidator Id="RgAge" runat="server" ErrorMessage="ההרשמה מגיל 18 ומעלה" ControlToValidate="TextAge" MaximumValue="120" MinimumValue="18" Type="Double" ForeColor="Red"/>
  </div>
  <div class="col-md-2 col-sm-2">
     תעודת זהות
  </div>
       <div class="col-md-2 col-sm-3">
     <asp:TextBox ID="TextId" runat="server" Class="form-control" placeholder="נא הזן תעודת זהות"/>
  </div>
 </div>
              <br />
  <div class="row">
                 <div class="col-md-2 col-sm-3">
                     הערות כלליות
                 </div>
                 <div class="col-md-2 col-sm-3">
                     <asp:TextBox ID="TexRemarks" runat="server" Class="form-control" placeholder="נא הזן הערות כלליות" TextMode="MultiLine" Rows="3" Columns="5" />              
                  </div>
 </div>
              <br />
  <div class="row">
   <div class="col -md-3 col-sm-3">
    <asp:RadioButton id="RDMale" runat="server"  GroupName="gender" Text="זכר" />
    <asp:RadioButton id="RDFemale" runat="server" GroupName="gender" Text="נקבה"/>

 </div>
 </div>
              <br />
  <div class="row">
    <div class="container">
     <asp:CheckBox id="ChTerm" runat="server" Text=" אני מסכים לתנאי השימוש באתר" />
  </div>

  </div>
              <br />
  <div class="row">
   <div class="container">
      <asp:button ID="BtnRegister" runat="server" Class="btn btn-outline-success text-" text="הרשמה"  OnClick="BtnRegister_Click"/>
   </div>
 </div>
              <br />
  <div class="row">
<div class="active">
    <asp:Literal Id="LtlMsg" Runat="server"/>
</div>
</div>
              </div>
  </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</body>
</html>
