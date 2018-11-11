<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Origen.aspx.cs" Inherits="WebCurso.Origen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div>
        <br />
        <br />
        <br />
       </br>
       
        Dato a pasar :
        <asp:TextBox ID="txtDato" runat="server"></asp:TextBox> 

     </div>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btnEnviar" runat="server" Text="Enviar pagina Destino" Width="136px" OnClick="btnEnviar_Click" />
    </p>
</asp:Content>
