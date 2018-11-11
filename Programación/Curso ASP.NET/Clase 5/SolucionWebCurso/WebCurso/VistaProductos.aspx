<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="VistaProductos.aspx.cs" Inherits="WebCurso.VistaProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <div>
         <center>
              <h1>&nbsp;</h1>
              <h1>&nbsp;</h1>
              <h1>Vista de Productos</h1>
        <asp:GridView ID="gvProductos" runat="server" AllowPaging="True" Width="470px" ></asp:GridView>
         </center>
    </div>
</asp:Content>
