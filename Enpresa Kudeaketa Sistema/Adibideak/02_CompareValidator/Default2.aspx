<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 5px solid #0000FF;
            background-color: #CCFF99;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>Lehenengo katea</td>
                <td>KONPARAKETA</td>
                <td>Bigarren katea</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:ListBox ID="ListBox1" runat="server">
                        <asp:ListItem>=</asp:ListItem>
                        <asp:ListItem>&lt;&gt;</asp:ListItem>
                        <asp:ListItem>&gt;</asp:ListItem>
                        <asp:ListItem>&gt;=</asp:ListItem>
                        <asp:ListItem>&lt;</asp:ListItem>
                        <asp:ListItem>&lt;=</asp:ListItem>
                    </asp:ListBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
        <asp:Button ID="Botoia" runat="server" Text="Botoia" />
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox1" EnableClientScript="False" ErrorMessage="CompareValidator"></asp:CompareValidator>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
