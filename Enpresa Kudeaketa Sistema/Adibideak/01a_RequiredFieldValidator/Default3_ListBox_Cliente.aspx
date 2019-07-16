<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default3_ListBox_Cliente.aspx.vb" Inherits="Default3_ListBox_Servidor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="ListBox1" runat="server" Height="88px" Width="78px">
            <asp:ListItem>aaa</asp:ListItem>
            <asp:ListItem>bbb</asp:ListItem>
            <asp:ListItem>ccc</asp:ListItem>
            <asp:ListItem>ddd</asp:ListItem>
        </asp:ListBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="ListBox1" ErrorMessage="Selecciona un Item"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
