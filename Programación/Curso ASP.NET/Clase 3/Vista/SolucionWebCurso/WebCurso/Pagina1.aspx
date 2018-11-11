<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="WebCurso.Pagina1" %>

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
    
        <asp:HyperLink ID="hl2" NavigateUrl="~/Pagina2.aspx" runat="server">
            
          <h1> Click aqui para ir a pagina2 </h1>
            
        </asp:HyperLink>

         <a href="Pagina2.aspx">haga Click aqui para ir a pagina2 con href</a>
    
    </div>
    </form>
</body>
</html>

