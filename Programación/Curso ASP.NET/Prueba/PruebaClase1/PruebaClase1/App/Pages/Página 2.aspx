<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Página 2.aspx.cs" Inherits="PruebaClase1.Página_2" %>

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
        <samp>Ésta es la página 2!</samp>
        <br />
        <asp:Label ID="lblCopiaHora" runat="server" Text=""></asp:Label>
    </div>
    <div>
        tipos de listas html:
         lista sin ordenar
        <ul>
            <li>uno</li>
            <li>dos</li>
            <li>tres</li>
        </ul>
        lista ordenada
        <ol>
            <li>uno</li>
            <li>dos</li>
            <li>tres</li>
        </ol>
        lista anidada
        <ul>
            <li>uno</li>
                <ul>
                    <li>uno bis</li>
                </ul>
        </ul>
    </div>
    </form>
</body>
</html>
