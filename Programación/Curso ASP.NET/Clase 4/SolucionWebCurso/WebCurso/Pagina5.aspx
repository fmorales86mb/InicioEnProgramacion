<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina5.aspx.cs" Inherits="WebCurso.Pagina5" %>
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
    
        <asp:Label ID="lblPag5Maj" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
