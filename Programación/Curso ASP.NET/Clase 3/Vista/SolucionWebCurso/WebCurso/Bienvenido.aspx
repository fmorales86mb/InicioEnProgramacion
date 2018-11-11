<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bienvenido.aspx.cs" Inherits="WebCurso.Bienvenido" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .estilo1 {
            font-family: Verdana;
            font-size: xx-large;
            background-color: #66FFCC;
            border-style: dotted;
        }
    </style>
    <link href="Styles/StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="estilo2">
    <div>
     Usuario Conectado: 
        <asp:Label ID="lblUsuario" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
