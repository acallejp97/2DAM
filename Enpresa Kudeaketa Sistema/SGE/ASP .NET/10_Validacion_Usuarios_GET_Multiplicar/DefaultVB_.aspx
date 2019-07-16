<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DefaultVB_.aspx.vb" Inherits="DefaultVB_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 36%;
            border: 8px solid #00FF00;
            background-color: #FFFF00;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 155px;
        }
        .auto-style4 {
            width: 236px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="X-Large" Text="USUARIO"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtusuario" runat="server" BackColor="Aqua" Width="220px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="X-Large" Text="PASSWORD"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtPassword" runat="server" BackColor="Aqua" TextMode="Password" Width="219px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="text-align: center; font-family: Cambria">
                    <asp:Button ID="btnAceptar" runat="server" Text="ACEPTAR" Width="179px" />
                </td>
                <td class="auto-style2" style="text-align: left; font-family: Cambria">
                    <asp:TextBox ID="txtNumero" runat="server" BackColor="Aqua" TextMode="Number" Width="219px"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
