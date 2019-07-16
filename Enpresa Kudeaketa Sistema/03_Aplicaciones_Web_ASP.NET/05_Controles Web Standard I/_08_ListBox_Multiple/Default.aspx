<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="ListBox1" runat="server" Font-Size="X-Large" Height="153px" SelectionMode="Multiple" Width="138px">
            <asp:ListItem>aa</asp:ListItem>
            <asp:ListItem>bb</asp:ListItem>
            <asp:ListItem>cc</asp:ListItem>
            <asp:ListItem>dd</asp:ListItem>
            <asp:ListItem>ee</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Overline="False" ForeColor="#000099" Text="SELECTION MODE = MULTIPLE"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="ACEPTAR" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
