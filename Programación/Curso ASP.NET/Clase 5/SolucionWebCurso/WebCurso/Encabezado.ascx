<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Encabezado.ascx.cs" Inherits="WebCurso.Encabezado" %>
<style type="text/css">
    .auto-style1 {
        width: 143px;
        text-align: center;
        background-color:aquamarine
    }
    .auto-style2 {
        width: 460px;
    }
</style>

<table style="width:100%;" border="1">
    <tr>
        <td class="auto-style1">
            <asp:Image ID="Image1" runat="server" Height="61px" Width="105px" ImageUrl="~/Images/dero.jpg" />
        </td>
        <td style="text-align: center" class="auto-style2">
            <asp:Label ID="Label1" runat="server" Text="CURSO ASPNET  EDUCACIONIT"></asp:Label>
        </td>
        <td style="text-align: center">
            <asp:Label ID="lblEmpresa" runat="server" Text=""></asp:Label>
        </td>
        <td style="text-align: center">
            <asp:Label ID="lblFecha" runat="server" Text=""></asp:Label>   
            <br />    
            Conectados:<asp:Label ID="lblConectados" runat="server" Text=""></asp:Label>
        </td>
    </tr>
</table>