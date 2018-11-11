<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="ClientesPorPais.aspx.cs" Inherits="PruebaClase1.App.Pages.ClientesPorPais" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <center>
            <h1>&nbsp;</h1>
            <h1>Clientes Por País</h1>
            <br />
            &nbsp;<asp:DropDownList ID="ddlPaises" runat="server" Height="20px" Width="250px" AutoPostBack="true" OnSelectedIndexChanged="ddlPaises_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <br />
            <asp:GridView ID="gvClientes" runat="server" AllowPaging="true" Width="400px"></asp:GridView>
            <br />
        </center>
    </div>
</asp:Content>
