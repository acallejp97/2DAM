<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DefaultVB_.aspx.vb" Inherits="DefaultVB_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 106%;
            height: 116px;
            border: 3px solid #3399FF;
            background-color: #CCFFFF;
        }
        .auto-style2 {
            height: 23px;
            width: 504px;
        }
        .auto-style3 {
        }
        .auto-style4 {
            height: 23px;
            width: 285px;
        }
        .auto-style5 {
            width: 504px;
        }
    </style>
</head>
<body style="width: 444px; height: 120px">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="#6600CC" Text="Usuario:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtusuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label2" runat="server" Font-Size="Large" ForeColor="#9933FF" Text="Password:"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2" style="text-align: center">
                    <asp:Button ID="btnaceptar" runat="server" Font-Size="Medium" Text="Aceptar" />
                    <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2" style="text-align: center">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
