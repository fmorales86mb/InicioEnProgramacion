<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Sumar.aspx.cs" Inherits="WebCurso.Sumar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style4
    {
        width: 155px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
<p>
        &nbsp;</p>
<p>
        <strong>SUMANDO CON SERVICIOS WEB
    </strong>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <table style="width:100%;">
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="NUMERO 1 :
                        "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNro1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label2" runat="server" Text="NUMERO 2 :
                        "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNro2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="btnSumar" runat="server" Text="Sumar" OnClick="btnSumar_Click" />
                </td>
                <td>
                    <asp:Label ID="lblSuma" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
