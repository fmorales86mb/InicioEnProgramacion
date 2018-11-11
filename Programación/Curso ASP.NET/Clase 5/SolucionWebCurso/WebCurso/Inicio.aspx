<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebCurso.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles/StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="estilo2" style="text-align: center; font-weight: 700; font-size: xx-large">
        Hola Mundo ASP NET
    </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblNombre" runat="server" Text="Ingrese su Nombre:" style="font-size: xx-large"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" Width="278px" style="font-size: x-large"></asp:TextBox>
        </p>
        <asp:Label ID="lblIdioma" runat="server" Text="Ingrese su idioma: " style="font-size: x-large"></asp:Label>
        <asp:DropDownList ID="ddlIdioma" runat="server"  Height="33px" style="font-size: x-large" Width="238px" AutoPostBack="True" OnSelectedIndexChanged="ddlIdioma_SelectedIndexChanged">
        </asp:DropDownList>
         <br />
         <br />
        <p>
            <asp:Button ID="btnAceptar" runat="server" Height="35px" Text="Aceptar" Width="98px" OnClick="btnAceptar_Click" />
            <asp:Label ID="lblSaludo" runat="server" style="font-weight: 700; font-size: x-large" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
