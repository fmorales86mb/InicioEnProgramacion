<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnProducto.aspx.cs" Inherits="WebCurso.UnProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 123px;
        }
        .auto-style2 {
            width: 82px;
        }
    </style>
</head>
<body>
     <p>
        <br />
        MODIFICACION DE PRODUCTO</p>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 53%;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Nombre :"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtNombre" runat="server" Width="284px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Precio :"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Stock :"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" Text="Confirmar" OnClick="Button1_Click" />
                </td>
                <td class="auto-style2">
                    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
