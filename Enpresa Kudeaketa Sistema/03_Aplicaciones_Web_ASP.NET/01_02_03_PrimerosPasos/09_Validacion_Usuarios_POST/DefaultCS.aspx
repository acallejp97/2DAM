<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultCS.aspx.cs" Inherits="DefaultCS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 24%;
        }
        .auto-style2 {
            width: 231px;
        }
        .auto-style3 {
            width: 265px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Nombre Usuario"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextUsu" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextPass" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center; background-color: #FF6666;">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
