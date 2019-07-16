<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" EnableClientScript="False" ErrorMessage="Error"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TextBox2" EnableClientScript="False" ErrorMessage="Error"></asp:CompareValidator>
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Button" />
            <br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" EnableClientScript="False" ErrorMessage="Error" ValidationExpression="\d{2}(-(\d{2}))"></asp:RegularExpressionValidator>
&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
