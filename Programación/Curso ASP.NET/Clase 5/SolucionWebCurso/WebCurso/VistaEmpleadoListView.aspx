<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VistaEmpleadoListView.aspx.cs" Inherits="WebCurso.VistaEmpleadoListView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
            <AlternatingItemTemplate>
                <tr style="">
                    <td>
                        <asp:Label ID="CodigoClienteLabel" runat="server" Text='<%# Eval("CodigoCliente") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ApellidoLabel" runat="server" Text='<%# Eval("Apellido") %>' />
                    </td>
                    <td>
                        <asp:Label ID="NombreLabel" runat="server" Text='<%# Eval("Nombre") %>' />
                    </td>
                    <td>
                        <asp:Label ID="TituloLabel" runat="server" Text='<%# Eval("Titulo") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                    </td>
                </tr>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
                    </td>
                    <td>
                        <asp:TextBox ID="CodigoClienteTextBox" runat="server" Text='<%# Bind("CodigoCliente") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="ApellidoTextBox" runat="server" Text='<%# Bind("Apellido") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="NombreTextBox" runat="server" Text='<%# Bind("Nombre") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="TituloTextBox" runat="server" Text='<%# Bind("Titulo") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="">
                    <tr>
                        <td>No se han devuelto datos.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
                    </td>
                    <td>
                        <asp:TextBox ID="CodigoClienteTextBox" runat="server" Text='<%# Bind("CodigoCliente") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="ApellidoTextBox" runat="server" Text='<%# Bind("Apellido") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="NombreTextBox" runat="server" Text='<%# Bind("Nombre") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="TituloTextBox" runat="server" Text='<%# Bind("Titulo") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="">
                    <td>
                        <asp:Label ID="CodigoClienteLabel" runat="server" Text='<%# Eval("CodigoCliente") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ApellidoLabel" runat="server" Text='<%# Eval("Apellido") %>' />
                    </td>
                    <td>
                        <asp:Label ID="NombreLabel" runat="server" Text='<%# Eval("Nombre") %>' />
                    </td>
                    <td>
                        <asp:Label ID="TituloLabel" runat="server" Text='<%# Eval("Titulo") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                                <tr runat="server" style="">
                                    <th runat="server">CodigoCliente</th>
                                    <th runat="server">Apellido</th>
                                    <th runat="server">Nombre</th>
                                    <th runat="server">Titulo</th>
                                    <th runat="server">City</th>
                                    <th runat="server">Country</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style=""></td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="">
                    <td>
                        <asp:Label ID="CodigoClienteLabel" runat="server" Text='<%# Eval("CodigoCliente") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ApellidoLabel" runat="server" Text='<%# Eval("Apellido") %>' />
                    </td>
                    <td>
                        <asp:Label ID="NombreLabel" runat="server" Text='<%# Eval("Nombre") %>' />
                    </td>
                    <td>
                        <asp:Label ID="TituloLabel" runat="server" Text='<%# Eval("Titulo") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>
    
    </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DemoConnectionString %>" SelectCommand="SELECT [Id] as CodigoCliente, [Lastname] as Apellido, [FirstName] as Nombre, [Title] as Titulo, [City], [Country] FROM [Employees]"></asp:SqlDataSource>
    </form>
</body>
</html>
