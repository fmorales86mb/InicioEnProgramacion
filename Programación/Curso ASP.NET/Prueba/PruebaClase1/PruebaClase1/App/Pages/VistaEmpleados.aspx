<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="VistaEmpleados.aspx.cs" Inherits="PruebaClase1.App.Pages.VistaEmpleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <div>
        <center>
            
            <h1>&nbsp;</h1>
                 <h1>Vista de Empleados</h1>
            <asp:GridView ID="gvEmpleados" runat="server" Width="546px" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" Height="164px" PageSize="4" OnPageIndexChanging="gvEmpleados_PageIndexChanging">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#FFFF99" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
                 </asp:GridView>
        </center>
    </div>

</asp:Content>
