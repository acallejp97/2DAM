<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DefaultVB.aspx.vb" Inherits="DefaultVB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #FF0000;
            background-color: #C0C0C0;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 1237px;
        }
        .auto-style4 {
            width: 348px;
        }
    </style>
</head>
<body style="width: 352px">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">Nombre del usuario</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Password</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2" style="text-align: center">
                    <asp:Button ID="btnAceptar" runat="server" Text="ACEPTAR" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
