<%@ Page Title="רשימת מוצרים" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Shop.BackAdmin.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <!-- DataTables CSS -->
  <link href="css/plugins/dataTables.bootstrap.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>מאגר מוצרים</h1>
                        <div class="panel panel-default">
                        <div class="panel-heading">
                            ניהול מוצרים במערך
                        </div>
                        <!-- /.panel-heading -->
                        <div class="panel-body">
                            <div class="table-responsive">
                                <table class="table table-striped table-bordered table-hover" id="TblProduct">
                                    <thead>
                                        <tr>
                                            <th>קוד מוצר</th>
                                            <th>שם מוצר</th>
                                            <th>מחיר מוצר</th>
                                            <th>תמונה</th>
                                        </tr>
                                    </thead>
                                    <asp:Repeater id="RptProduct" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                            <td><a href="ProductAddEdit.aspx?pid=<%#Eval("Pid") %>"><%#Eval("Pid") %></a></td>
                                            <td><%#Eval("Pname") %></td>
                                            <td><%#Eval("Price") %></td>
                                            <td><img src="/Upload/Users/<%#Eval("PicName") %>" width="30" /></td>
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
            $('#TblProduct').dataTable();
        });
    </script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooterCnt" runat="server">
</asp:Content>
