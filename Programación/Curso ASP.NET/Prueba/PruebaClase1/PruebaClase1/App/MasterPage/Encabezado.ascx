<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Encabezado.ascx.cs" Inherits="PruebaClase1.WebUserControl1" %>

<%--tabla html de 1x3--%>
<table style="width: 100%;" border="1">
    <tr>
        <td style="text-align:center">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/App/Imágenes/20160105_201750.jpg" Width="60px" Height="60px" />
        </td>
        <td style="text-align:center">
            <asp:Label ID="lblTitulo" runat="server" Text=""></asp:Label>
        </td>
        <td style="text-align:center">
            <asp:Label ID="lblFechaHora" runat="server" Text=""></asp:Label>
            <br />
            Usuarios Conectados: <asp:Label ID="lblNroConectados" runat="server" Text=""></asp:Label>
        </td>
    </tr>
</table>
