<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validators.aspx.cs" Inherits="WebCurso.Validators" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script type="text/javascript">
<!--
    function CheckPrime(sender, args) {
        var iPrime = parseInt(args.Value);
        var iSqrt = parseInt(Math.sqrt(iPrime));

        for (var iLoop = 2; iLoop <= iSqrt; iLoop++)
            if (iPrime % iLoop == 0) {
                args.IsValid = false;
                return;
            }

        args.IsValid = true;        
    }
    // -->
    </script>
    <style type="text/css">
        .auto-style1 {
            height: 61px;
        }
    </style>
</head>

<body>
    <h1>Validacion de Datos</h1>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>

                    Ingrese Nombre:

                </td>
                 <td>

                     <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>

                </td>
                 <td>

                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" ErrorMessage="Debe ingresar Nombre"></asp:RequiredFieldValidator>

                </td>
            </tr>
             <tr>
                <td>

                    Ingrese Password:</td>
                 <td>

                     <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>

                </td>
                 <td>

                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="La password es obligatoria"></asp:RequiredFieldValidator>

                </td>
            </tr>
             <tr>
                <td>

                    Rengrese Password:</td>
                 <td>

                     <asp:TextBox ID="txtReplyPassword" runat="server"></asp:TextBox>

                </td>
                 <td>

                     <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtReplyPassword" ErrorMessage="Las passwords no coinciden"></asp:CompareValidator>

                </td>
            </tr>
             <tr>
                <td>

                    Ingrese Email:</td>
                 <td>

                     <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

                </td>
                 <td>

                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="El email es obligatorio" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>

                     <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="No es email valido" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>

                </td>
                 
            </tr>
             <tr>
                <td>

                    Ingrese Nota (1-10):</td>
                 <td>

                     <asp:TextBox ID="txtRange" runat="server"></asp:TextBox>

                </td>
                 <td>

                     <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtRange" ErrorMessage="El valor a ingresar es entre 1 y 10" MaximumValue="10" MinimumValue="1" Type="Integer"></asp:RangeValidator>

                </td>
            </tr>
             <tr>
                    <td>Ingrese número primo:</td>
                    <td>
                        <asp:TextBox ID="TextBoxNumeroPrimo" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:CustomValidator ID="CustomValidator1" runat="server"
                            ClientValidationFunction="CheckPrime" ControlToValidate="TextBoxNumeroPrimo"
                            ErrorMessage="No es un número primo"></asp:CustomValidator>
                    </td>
                </tr>
            <tr>
                <td class="auto-style1">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
            </tr>
            <tr>
                <br />
                <td colspan="3">
                    <asp:Button ID="Button1" runat="server" Text="Enviar" ToolTip="hacer click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
