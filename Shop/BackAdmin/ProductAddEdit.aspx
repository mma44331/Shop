<%@ Page Title="עריכת מוצר" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" ValidateRequest="false" AutoEventWireup="true" CodeBehind="ProductAddEdit.aspx.cs" Inherits="Shop.BackAdmin.ProductAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
               <h1 class="page-header">הוספה / עריכת מוצר</h1>
            <div class="container">
                  <asp:HiddenField Id="HidPid" runat="server" value="-1"></asp:HiddenField>
               <div class="row">
                   <div class="col-md-2">שם מוצר</div>
                   <div class="col-md-4"><asp:TextBox Id="TxtPname" runat="server" class="form-control" /></div>
               </div>
                <div class="row">
                    <div class="col-md-2">מחיר מוצר</div>
                    <div class="col-md-4"><asp:TextBox Id="TxtPrice" runat="server" class="form-control" /></div>
                </div>
                <div class="row">
                    <div class="col-md-2">תמונה</div>
                    <div class="col-md-4"><asp:TextBox Id="TxtPicName" runat="server" class="form-control" /></div>
               </div>
               <div class="row">
                    <div class="col-md-2">תמונה</div>
                    <div class="col-md-4"><asp:fileupload Id="PicUpload" runat="server" class="form-control" /></div>
               </div>
                 <div class="row">
                   <div class="col-md-2">תיאור מוצר</div>
                   <div class="col-md-4"><asp:TextBox Id="TxtProdDesc" TextMode="MultiLine" Rows="6" Columns="40" MaxLength="500" runat="server" class="form-control" /></div>
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
    <script src="https://cdn.ckeditor.com/ckeditor5/41.4.2/classic/ckeditor.js"></script>
<script>
    ClassicEditor
        .create(document.querySelector( '#MainContent_TxtProdDesc' ) )
        .catch( error => {
            console.error( error );
        } );
</script>

</asp:Content>
