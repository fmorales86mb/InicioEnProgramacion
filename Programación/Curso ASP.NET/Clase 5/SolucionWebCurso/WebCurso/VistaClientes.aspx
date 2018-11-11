<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="VistaClientes.aspx.cs" Inherits="WebCurso.VistaClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>&nbsp;</h1>
    <h1>Listado de Clientes</h1>
    <asp:GridView ID="gvClientes" AllowPaging="True" PageSize="5" AutoGenerateColumns="true" OnPageIndexChanging="gvClientes_PageIndexChanging" runat="server" >
        <PagerStyle BorderColor="#FFCC00" />
    </asp:GridView>

</asp:Content>
