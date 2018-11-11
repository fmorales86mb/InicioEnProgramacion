<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="EmpleadosxPais.aspx.cs" Inherits="WebCurso.EmpleadosxPais" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <center>
            <h1>&nbsp;</h1>
            <h1>Empleados por Pais</h1>
            <asp:DropDownList ID="ddlPaises" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPaises_SelectedIndexChanged" Width="260px"></asp:DropDownList>
            <br />
            <br />
            <asp:GridView ID="gvEmpleados" runat="server" Width="450px"></asp:GridView>
        </center>
    </div>
</asp:Content>
