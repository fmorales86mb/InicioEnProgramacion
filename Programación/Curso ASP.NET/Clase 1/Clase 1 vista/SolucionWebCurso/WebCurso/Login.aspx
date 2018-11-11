<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebCurso.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="UTF-8">
<title>LOGIN</title>
    <style type="text/css">
    .bs-example{
    	margin: 20px;
    }
    .central{ 
        position:absolute;
        top:50%;     left: 50%;     margin-top: -100px;     margin-left: -100px; }

</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1> INICIO DE SESION </h1>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" class="form-control" placeholder="Email" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" placeholder="Password" runat="server"></asp:TextBox>
        </div>
        
        <br />
        <asp:Button ID="btnEnviar" runat="server" Text="ENVIAR" />
       
        <asp:CheckBox ID="chkMantener"  runat="server" Text="Mantener Identidad en proxima sesion" />
       
    </div>
    </form>
</body>
</html>
