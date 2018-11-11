<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="PruebaClase1.App.Pages.Producto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div>
        <center>
            <h1>Productos</h1>
            <br />
            <asp:GridView ID="gvProductos" runat="server" AllowPaging="true" Width="470px"></asp:GridView>
        </center>
        
    </div>
    
</asp:Content>
