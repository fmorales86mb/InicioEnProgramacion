<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="OutputCache.aspx.cs" Inherits="WebCurso.OutputCache" %>
<%@ OutputCache Duration="10" VaryByParam="none" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br />
        <br />
        <br />
       </br>
            <asp:Label ID="lblfecha" runat="server" Text="" />
       </br>
            
            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
   </div>

</asp:Content>
