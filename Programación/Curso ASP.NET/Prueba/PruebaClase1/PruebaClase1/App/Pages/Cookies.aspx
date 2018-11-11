<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cookies.aspx.cs" Inherits="PruebaClase1.App.Cookies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <samp style="background-color:azure">MANEJO DE COOKIES</samp>
    <br />
    <br />

    <div  style="text-align:center">

        &nbsp;<p>
    Ingrese el valor a guardar en Cookie: <asp:TextBox ID="tbCookie" runat="server"></asp:TextBox>
    <br />
    Valor de Cookie recuperado: <asp:Label ID="lblCookieRecuperado" runat="server" Text="..."></asp:Label>
        </p>
           
        &nbsp;<p>

    <asp:Button ID="btnGuardarCookie" runat="server" Text="Guardar Cookie" OnClick="btnGuardarCookie_Click" />
    <asp:Button ID="btnRecuperarCookie" runat="server" Text="Recuperar Cookie" OnClick="btnRecuperarCookie_Click" />
        </p> 

        &nbsp;<p>
    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
        </p>
        
    </div>

</asp:Content>
