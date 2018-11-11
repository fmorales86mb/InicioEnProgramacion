<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="AltaProducto.aspx.cs" Inherits="WebCurso.AltaProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            height: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <h1> &nbsp;</h1>
        <h1> &nbsp;</h1>
        <h2> ALTA DE PRODUCTO </h2>
        <p> &nbsp;</p>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lblCodigo" runat="server" Text="Codigo :"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtCodigo" runat="server" Width="235px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCodigo" ErrorMessage="Debe ingresar el codigo" Font-Bold="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>            
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="Nombre :"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtNombre" runat="server" Width="235px" Text='<%#Bind("ProductName") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator 
                            ID="rfvNombre" 
                            runat="server" 
                            ControlToValidate="txtNombre" 
                            ErrorMessage="El nombre es obligatorio!" 
                            Font-Bold="True" ForeColor="#FF3300">
                    </asp:RequiredFieldValidator>

                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Categoria :"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlCategorias" runat="server" Height="16px" Width="235px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label3" runat="server" Text="Precio Unitario :"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtPrecio" runat="server" Width="235px"></asp:TextBox>
                    <asp:CompareValidator 
                        ID="cvNombre" 
                       runat="server" 
                          ControlToValidate="txtPrecio" 
                         ErrorMessage="Debe ser un numero !" 
                      Font-Bold="True" ForeColor="#FF3300" Operator="DataTypeCheck" 
                     Type="Currency"></asp:CompareValidator>

                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label4" runat="server" Text="Stock :"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtStock" runat="server" Width="235px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblMensaje" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>
