<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebCurso.Login" %>

<!DOCTYPE html>

<html lang="en">
<head>
<meta charset="UTF-8">
<title>LOGIN</title>

<link href="Styles/bootstrap.min.css" rel="stylesheet" />
<script src="Scripts/jquery-2.1.4.min.js"></script>
    
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
<div class="bs-example">
    <form id="Form1" runat="server"  class="central" height=200px width=200px>
        <h1> INICIO DE SESION </h1>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" class="form-control" placeholder="Email" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" class="form-control" placeholder="Password" runat="server"></asp:TextBox>
        </div>
        
        <br />
        <asp:Button ID="btnEnviar" class="btn btn-primary" runat="server" Text="ENVIAR" />
       
        <asp:CheckBox ID="chkMantener" runat="server" Text="Mantener Identidad en proxima sesion" />
       
    </form>
</div>
</body>
</html>                           
