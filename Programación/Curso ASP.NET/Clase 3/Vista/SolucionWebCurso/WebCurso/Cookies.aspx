<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Cookies.aspx.cs" Inherits="WebCurso.Cookies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <br />
        <br />
        <br />
       </br>
       <asp:Label ID="Label1" runat="server" Text="MANEJO DE COOKIES"></asp:Label>
    </div>
 
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        <asp:Label ID="Label2" runat="server" Text="Ingrese valor a guardar en cookie:"></asp:Label>
        <asp:TextBox ID="txtCookie" runat="server"></asp:TextBox>

    </p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        <asp:Label ID="Label3" runat="server" Text="Valor de Cookie recuperado :"></asp:Label>

        <asp:Label ID="lblValorCookie" runat="server" Text=""></asp:Label>

    </p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar COOKIE" Width="129px" OnClick="btnGuardar_Click" />

        <asp:Button ID="btnRecuperar" runat="server" Text="Recuperar Cookie" Width="131px" OnClick="btnRecuperar_Click" />

    </p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        <asp:Label ID="lblmensaje" runat="server" Text=""></asp:Label>

    </p>
</asp:Content>
