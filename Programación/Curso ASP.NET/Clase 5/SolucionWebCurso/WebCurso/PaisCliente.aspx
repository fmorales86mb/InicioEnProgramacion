<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="PaisCliente.aspx.cs" Inherits="WebCurso.PaisCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p><br /></p>
    <p></p>   
     <h1> &nbsp;</h1>
     <h1 style="text-align: center"> OBTENER PAIS DE UN CLIENTE</h1>    
    <p>&nbsp;</p>
   
        <div style="text-align: center">
            <asp:Label ID="Label1" runat="server" Text="Id de Cliente :"></asp:Label>
            <asp:TextBox ID="txtID" runat="server" Width="91px"></asp:TextBox>
            &nbsp;<asp:Button ID="btnBuscar" runat="server" Text="Buscar" Height="26px" Width="59px" OnClick="btnBuscar_Click"/>        

            <p>
                &nbsp;</p>
            <p>
                <asp:Label ID="lblPais" runat="server" Text=""></asp:Label>
            </p>
        </div>
</asp:Content>
