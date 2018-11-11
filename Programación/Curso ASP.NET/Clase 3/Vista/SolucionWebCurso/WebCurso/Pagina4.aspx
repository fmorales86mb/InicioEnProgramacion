<%@ Page Language="C#" Theme="Estilo2" AutoEventWireup="true" CodeBehind="Pagina4.aspx.cs" Inherits="WebCurso.Pagina4" %>
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
         <asp:Label ID="lblPag4Msj" runat="server" Text="Label"></asp:Label>

        <br />
        <br />

    <asp:Label ID="lblInfo4" runat="server" Text="Informacion de pagina 4" SkinID="Moderno"></asp:Label>

         <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnPag5" runat="server" Height="65px" Text="Abrir Pagina5 en forma de ventana emergente" Width="294px" OnClick="Button1_Click" />
        </p>
    </div>
    </form>
</body>
</html>
