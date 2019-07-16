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
    
        <asp:ListBox ID="ListBox1" runat="server" Font-Size="X-Large" SelectionMode="Multiple" Width="174px">
            <asp:ListItem>Arrate</asp:ListItem>
            <asp:ListItem>Anton</asp:ListItem>
            <asp:ListItem>Alatz</asp:ListItem>
            <asp:ListItem>Alejandro</asp:ListItem>
            <asp:ListItem>Dari</asp:ListItem>
            <asp:ListItem>Iker</asp:ListItem>
        </asp:ListBox>
        .<br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Font-Size="Large" Text="Zeintzuk daude aukeratuta?" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
