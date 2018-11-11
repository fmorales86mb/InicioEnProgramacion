<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="PruebaClase1.App.Pages.Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />

    <center>

        <h1>Todos los Clientes</h1>
        <br />
        <asp:GridView ID="gvCliente" runat="server" AllowPaging="true" Width="470px" OnPageIndexChanging="gvCliente_PageIndexChanging"></asp:GridView>
    </center>
    

</asp:Content>
