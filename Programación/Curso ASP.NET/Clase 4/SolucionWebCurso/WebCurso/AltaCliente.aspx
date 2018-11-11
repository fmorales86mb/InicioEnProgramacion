<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="AltaCliente.aspx.cs" Inherits="WebCurso.AltaCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

      <style type="text/css">
        .auto-style5 {
            width: 461px;
        }
        .auto-style6 {
            width: 185px;
        }
    </style>    

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div>

        <h1> &nbsp;</h1>
        <h1> &nbsp;</h1>
        <h2> ALTA DE CLIENTE </h2>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label1" runat="server" Text="Id de Cliente :"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtID" runat="server" Width="235px" MaxLength="5"></asp:TextBox>
                </td>
               
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label2" runat="server" Text="Nombre : :"></asp:Label>
                </td>
                <td class="auto-style5">
                    
                    <asp:TextBox ID="txtNombre" runat="server" Width="231px"></asp:TextBox>
                    
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label3" runat="server" Text="Contacto :"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtContacto" runat="server" Width="235px"></asp:TextBox>
                </td>
                <td>
                    
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label4" runat="server" Text="Pais :"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtPais" runat="server" Width="235px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label5" runat="server" Text="Ciudad :"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtCiudad" runat="server" Width="232px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
                </td>
                <td class="auto-style5">
                    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>
