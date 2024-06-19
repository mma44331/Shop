<%@ Page Title="עריכת קטגוריה" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="CatagoryAddEdit.aspx.cs" Inherits="Shop.BackAdmin.CategoryaddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
       <h1 class="page-header">הוספת / עריכת קטגוריה</h1>
<div class="container">
      <asp:HiddenField Id="HidCid" runat="server" value="-1"></asp:HiddenField>
   <div class="row">
       <div class="col-md-2">שם קטגוריה</div>
       <div class="col-md-4"><asp:TextBox Id="TxtCname" runat="server" class="form-control" /></div>
   </div>
    <div class="row">
        <div class="col-md-2">תיאור מוצר</div>
        <div class="col-md-4"><asp:TextBox Id="TxtCdesc" runat="server" class="form-control" /></div>
    </div>
    <div class="row">
        <div class="col-md-2">תמונה</div>
        <div class="col-md-4"><asp:TextBox Id="TxtCpic" runat="server" class="form-control" /></div>
    </div>
    <div class="row">
        <div class="col-md-2">קוד קטגוריה אב</div>
        <div class="col-md-4"><asp:TextBox Id="TxtCDid" runat="server" class="form-control" /></div>
    </div>
    <div class="row">
        <div class="col-md-2">
           <asp:Button Id="BtnSave"  runat="server" Class="btn btn-outline-success text-" text="שמור" OnClick="BtnSave_Click"/>
    </div>
   </div>
 </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooterCnt" runat="server">
</asp:Content>
