<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DefaultVB.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 26%;
        }
        .auto-style2 {
            height: 23px;
            width: 646px;
        }
        .auto-style3 {
            height: 23px;
            width: 1014px;
        }
        .auto-style4 {
        }
        .auto-style5 {
            width: 646px;
        }
        .auto-style6 {
            width: 1014px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table border="1" class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="NOMBRE DE USUARIO"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label2" runat="server" Text="PASSWORD"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color: #6699FF; position: static; text-align: center">
                <td class="auto-style4" colspan="2">
                    <asp:Button ID="botonAceptar" runat="server" Text="Aceptar" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
