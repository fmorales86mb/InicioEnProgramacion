﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HolaMundo.aspx.cs" Inherits="HolaMundo.HolaMundo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        1. Hola Mundo
        <br />
        <asp:Label ID="lblHola" runat="server" Text="2. Aquí no dice Hola Mundo"></asp:Label>
        <br />
        <% Response.Write("3. Hola Mundo"); %>
    </div>
    </form>
</body>
</html>
