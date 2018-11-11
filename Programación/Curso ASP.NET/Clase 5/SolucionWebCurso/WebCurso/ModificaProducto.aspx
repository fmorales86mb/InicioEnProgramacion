<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="ModificaProducto.aspx.cs" Inherits="WebCurso.ModificaProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
         <center>
              <h1>&nbsp;</h1>
              <h1>Modificacion de Productos</h1>
        <asp:GridView ID="gvProductos" runat="server" AllowPaging="True" Width="784px"  AutoGenerateColumns="False"
             BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" AutoGenerateSelectButton="true" OnPageIndexChanging="gvProductos_PageIndexChanging" OnSelectedIndexChanged="gvProductos_SelectedIndexChanged" >
            <Columns>
          
                <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
          
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Categoria" DataField="Categoria" />            
            <asp:BoundField HeaderText="Precio" DataField="Precio" />
            <asp:BoundField HeaderText="Stock" DataField="Stock" />
             </Columns>
                 <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                 <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                 <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                 <RowStyle BackColor="White" ForeColor="#330099" />
                 <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                 <SortedAscendingCellStyle BackColor="#FEFCEB" />
                 <SortedAscendingHeaderStyle BackColor="#AF0101" />
                 <SortedDescendingCellStyle BackColor="#F6F0C0" />
                 <SortedDescendingHeaderStyle BackColor="#7E0000" />
              </asp:GridView>

              <br />
              <asp:Label ID="Label1" runat="server" Text="Articulo Seleccionado :"></asp:Label>

              <asp:Label ID="lblID" runat="server" Text=""></asp:Label>

         </center>
    </div>
</asp:Content>
