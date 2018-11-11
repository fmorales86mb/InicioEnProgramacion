<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="Origen.aspx.cs" Inherits="PruebaClase1.App.Pages.Origen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    Método "QueryString"
    <br />
    <br />

    <p style="text-align:center">
    Información a enviar: <asp:TextBox ID="tbInformacion" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
    </p>

</asp:Content>
