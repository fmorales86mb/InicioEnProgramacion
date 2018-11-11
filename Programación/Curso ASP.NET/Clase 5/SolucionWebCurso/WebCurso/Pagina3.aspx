<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina3.aspx.cs" Inherits="WebCurso.Pagina3" %>
<%@ Register src="Encabezado.ascx" tagname="Encabezado" tagprefix="uc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <uc1:Encabezado ID="Encabezado1" runat="server" />
            <br />
        </p>
    <div>
    
    </div>
        <asp:Label ID="lblMsjPag3" runat="server" Text=""></asp:Label>
        <p>
            <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
        </p>
        <br />
        <br />
        <br />
        <asp:Label ID="lbldato" runat="server" Text="EnviandoInformacion"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnIrPag4ST" runat="server" Height="64px" Text="Ejecutar Pagina4" Width="215px" OnClick="Button1_Click" />
        <br />
    </form>
</body>
</html>
