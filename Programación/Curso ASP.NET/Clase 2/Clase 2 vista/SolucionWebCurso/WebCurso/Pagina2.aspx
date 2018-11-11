<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina2.aspx.cs" Inherits="WebCurso.Pagina2" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

       
        <asp:Label ID="lblTexto" runat="server" ></asp:Label>
    <div>
    
   
         <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Ingrese su Nombre :"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <br />
      
            <asp:Button ID="btnPagina3" runat="server" OnClick="Button1_Click" Text="Ir a Pagina 3" />
        </div>
    </form>
</body>
</html>
