<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 32%;
            border: 6px solid #000099;
            background-color: #00CC00;
        }
        .auto-style2 {
            width: 134px;
        }
        .auto-style3 {
            width: 135px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">1 OPERADOR</td>
                <td class="auto-style3">COMPARADOR</td>
                <td>2 OPERADOR</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>=</asp:ListItem>
                        <asp:ListItem>&lt;&gt;</asp:ListItem>
                        <asp:ListItem>&gt;</asp:ListItem>
                        <asp:ListItem>&gt;=</asp:ListItem>
                        <asp:ListItem>&lt;</asp:ListItem>
                        <asp:ListItem>&lt;=</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox1" EnableClientScript="False" ErrorMessage="ERROR..."></asp:CompareValidator>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
