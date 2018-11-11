<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="EmpleadosPorPais.aspx.cs" Inherits="PruebaClase1.App.Pages.EmpleadosPorPais" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <center>
            <h1>&nbsp</h1>
            <h1>Empleados por País</h1>
            <br />
            &nbsp;<asp:DropDownList ID="ddlPaises" runat="server" Height="16px" Width="260px" AutoPostBack="true" OnSelectedIndexChanged="ddlPaises_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <asp:GridView ID="gvEmpleados" runat="server" AllowPaging="true" Width="400px"></asp:GridView>
            <br />
        </center>
    </div>
</asp:Content>
