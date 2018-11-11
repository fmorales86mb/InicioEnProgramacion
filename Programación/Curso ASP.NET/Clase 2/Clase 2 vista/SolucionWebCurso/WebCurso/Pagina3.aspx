<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina3.aspx.cs" Inherits="WebCurso.Pagina3" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
    <div>
    
    </div>
        <asp:Label ID="lblMsjPag3" runat="server" Text=""></asp:Label>
        <p>
            <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
        </p>
        <br />
        <br />
        <br />
        <asp:Label ID="lblDato" runat="server" Text="Enviando Informacion"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnIrAPagina4" runat="server" Text="Ejecutar pagina 4" OnClick="btnIrAPagina4_Click" />
    </form>
</body>
</html>
