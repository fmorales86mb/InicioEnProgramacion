<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="ProductosxCategoria.aspx.cs" Inherits="WebCurso.ProductosxCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <link href="Styles/EstilosGrid.css" rel="stylesheet" />

    <div>
        <center>
              <h1>&nbsp;</h1>
              <h1>&nbsp;</h1>
              <h1>Productos x categoria</h1>
              <p>&nbsp;</p>
              &nbsp;<asp:DropDownList ID="ddcategorias" runat="server" Height="16px" Width="260px" AutoPostBack="True" OnSelectedIndexChanged="ddcategorias_SelectedIndexChanged" ></asp:DropDownList>
              <br />
              <br />
            <asp:GridView ID="gvProductoxCategoria" runat="server" 
            AllowPaging="True" 
            Width="470px" 
            CssClass="DataWebControlStyle">
           <AlternatingRowStyle CssClass="AlternatingRowStyle" />
           <RowStyle CssClass="RowStyle" />
           <HeaderStyle CssClass="HeaderStyle" />
           <FooterStyle CssClass="FooterStyle" />
           <PagerStyle CssClass="PagerStyle" />
            </asp:GridView>
      </center>
    </div>
</asp:Content>
