<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Página 3.aspx.cs" Inherits="PruebaClase1.Página_3" %>

<%@ Register Src="~/App/MasterPage/Encabezado.ascx" TagPrefix="uc1" TagName="Encabezado" %>


<uc1:Encabezado runat="server" ID="Encabezado" />



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
    Usted está en la página 3.
        <br />
        <asp:Label ID="lblPag3Minutos" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
