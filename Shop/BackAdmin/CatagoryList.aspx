<%@ Page Title="" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="CatagoryList.aspx.cs" Inherits="Shop.BackAdmin.CatagoryList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <!-- DataTables CSS -->
<link href="css/plugins/dataTables.bootstrap.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <h1>מאגר קטגוריות</h1>
                     <div class="panel panel-default">
                     <div class="panel-heading">
                         ניהול קטגוריות במערך
                     </div>
                     <!-- /.panel-heading -->
                     <div class="panel-body">
                         <div class="table-responsive">
                             <table class="table table-striped table-bordered table-hover" id="TblProduct">
                                 <thead>
                                     <tr>
                                         <th>קוד קטגוריה</th>
                                         <th>שם קטגוריה</th>
                                         <th>תיאור קטגוריה</th>
                                         <th>תמונה</th>
                                         <th>קוד אב קטגוריה</th>
                                     </tr>
                                 </thead>
                                 <asp:Repeater id="RptCatagory" runat="server">
                                     <ItemTemplate>
                                         <tr>
                                         <td><a href="CatagoryAddEdit.aspx?Cid=<%#Eval("Cid") %>"><%#Eval("Cid") %></a></td>
                                         <td><%#Eval("Cname") %></td>
                                         <td><%#Eval("Cdesc") %></td>
                                         <td><%#Eval("Cpic") %></td>
                                         <td><%#Eval("CDid") %></td>
                                         </tr>
                                     </ItemTemplate>
                                 </asp:Repeater>
                             </table>
                         </div>
                         <!-- /.table-responsive -->
                     </div>
                     <!-- /.panel-body -->
                 </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
     <!-- DataTables JavaScript -->
 <script src="js/jquery/jquery.dataTables.min.js"></script>
 <script src="js/bootstrap/dataTables.bootstrap.min.js"></script>

 <!-- Page-Level Demo Scripts - Tables - Use for reference -->
 <script>
     $(document).ready(function() {
         $('#TblCatagory').dataTable();
     });
 </script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooterCnt" runat="server">
</asp:Content>
