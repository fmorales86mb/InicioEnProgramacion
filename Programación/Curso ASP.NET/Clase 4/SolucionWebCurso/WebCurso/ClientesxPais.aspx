<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="ClientesxPais.aspx.cs" Inherits="WebCurso.ClientesxPais" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
         <center>
              <h1>&nbsp;</h1>
              <h1>Clientes por Pais</h1>
              &nbsp;
             <asp:DropDownList ID="ddlPaises" runat="server" Height="16px" Width="260px" AutoPostBack="True" OnSelectedIndexChanged="ddlPaises_SelectedIndexChanged" ></asp:DropDownList>
              <br />
              <br />
            <asp:GridView ID="gvClientes" runat="server" AllowPaging="True" Width="676px" CellPadding="4" ForeColor="#333333" GridLines="None" Height="299px" >
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
              </asp:GridView>
              <br />
         </center>
    </div>
</asp:Content>
