<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Página 1.aspx.cs" Inherits="PruebaClase1.WebForm1" %>

<%@ Register Src="~/App/MasterPage/Encabezado.ascx" TagPrefix="uc1" TagName="Encabezado" %>


<uc1:Encabezado runat="server" ID="Encabezado" />

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%--Clase 1: Controles del servidor / Elementos dinámicos y elementos estáticos.--%>
        <h1>Clase 1</h1>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Hola Mundo" SkinID="Moderno"></asp:Label>
        <br />
        <span>Hora en el servidor</span>
        <asp:Label ID="lblHora" runat="server" Text=""></asp:Label>
        <br />
        <br />
    </div>
    <div>
         <%--Clase 2: Métodos de navegación.--%>
        <h1>Clase 2</h1>
        <br />
        Método href.
        <br />
        <samp>href a un web form interno.</samp>
        <a href ="Página 2.aspx"> Pag2 </a>
        <br />
        <samp>href a una página externa.</samp>
        <a href="https://www.google.com.ar"> Google</a>
        <br />

        Método Redirect
        <br />
        <asp:Button ID="btn1Pag2" runat="server" Text="Página 2" OnClick="btnPag2_Click" />
        <br />

        Método HiperLink
        <br />
        <asp:HyperLink
            ID="hl2"
            NavigateUrl="~/Página 2.aspx"
            runat="server">
            <samp>Página 2</samp>
        </asp:HyperLink>
        <br />
        
        Método Server.Transfer
        <br />
        <asp:TextBox ID="tbPag1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btn2Pag2" runat="server" Text="Página 2" OnClick="btn2Pag2_Click" />
        <br />

        Método Server.Execute
        <br />
        <asp:Button ID="btnPag3" runat="server" Text="Página 3" OnClick="btnPag3_Click" />
        <br />
        <asp:Label ID="lblDato" runat="server" Text="Acá va a aparecer la pág. 3..." SkinID="Clasico"></asp:Label>
        <br />

        Método Window.Open
        <br />
        <asp:Button ID="btn3Pag2" runat="server" Text="Página 2" OnClick="btn3Pag2_Click" />

    </div>
    </form>
</body>
</html>
