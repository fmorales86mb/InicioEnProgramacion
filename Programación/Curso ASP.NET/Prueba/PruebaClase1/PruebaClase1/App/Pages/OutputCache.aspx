<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="OutputCache.aspx.cs" Inherits="PruebaClase1.App.OutputCache" %>

<%--Acá agrego la directiva @OutputCache y la configuro.--%>
<%@ OutputCache Duration="10" VaryByParam="none" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br />
        <br />
        Con la directiva @OutputCache puedo hacer que la página se recargue del caché durante determinado plazo.
        Esto agiliza el tiempo de respuesta.
        <br />
        <br />
        <asp:Label ID="lblFecha" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" />
    </div>
</asp:Content>
