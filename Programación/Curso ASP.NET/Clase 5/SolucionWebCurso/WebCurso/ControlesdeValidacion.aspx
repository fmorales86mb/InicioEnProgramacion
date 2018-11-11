<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlesdeValidacion.aspx.cs" Inherits="WebCurso.ControlesdeValidacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Formulario de Validacion</title>

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
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="El nombre es requerido" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
                </td>                
            </tr>
             <tr>
                <td>

                    Ingrese Password:</td>
                 <td>
                     <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td> 
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="La password es requerida" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                </td>              
            </tr>
             <tr>
                <td>
                    Reingrese Password:</td>
                 <td>
                     <asp:TextBox ID="txtReplyPassword" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Las password deben ser iguales" ControlToCompare="txtPassword" ControlToValidate="txtReplyPassword"></asp:CompareValidator>
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
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="El email no tiene el formato requerido" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>                 
            </tr>
             <tr>
                <td>
                    Ingrese Nota (1-10):</td>
                 <td>
                     <asp:TextBox ID="txtRange" runat="server"></asp:TextBox>
                </td>
               <td>
                   <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="El valor ingresado esta fuera de rango" ControlToValidate="txtRange" MaximumValue="10" MinimumValue="1" Type="Integer"></asp:RangeValidator>
               </td>
            </tr>
             <tr>
                    <td>Ingrese número primo:</td>
                    <td>
                        <asp:TextBox ID="TextBoxNumeroPrimo" runat="server"></asp:TextBox>
                    </td>
                   <td>
                       <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="El valor ingresado no es un numero primo" ClientValidationFunction="CheckPrime" ControlToValidate="TextBoxNumeroPrimo"></asp:CustomValidator>
                   </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
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
