<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Control.aspx.cs" Inherits="HTML_Control.Control" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1><asp:Label ID="lblTitulo" runat="server" Text="Este es el título de esta página"></asp:Label></h1>
        <br />
        <asp:Label ID="lblFecha" runat="server" Text="Aquí debe mostrarse la fecha actual del servidor"></asp:Label>
        <br />
        <input id="Button1" type="button" value="hola hola" />
    </div>
    </form>
</body>
</html>
