<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="WebCurso.Pagina1" %>
<%@ Register Src="~/Encabezado.ascx" TagName="Encabezado" TagPrefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  <form id="form1" runat="server">  
      <p>
          <uc1:Encabezado ID="Encabezado1" runat="server" />
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

