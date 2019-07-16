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
    
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Anton</asp:ListItem>
            <asp:ListItem>Arrate</asp:ListItem>
            <asp:ListItem>Asier</asp:ListItem>
            <asp:ListItem>Gorka</asp:ListItem>
            <asp:ListItem>Unai</asp:ListItem>
            <asp:ListItem>Mario</asp:ListItem>
            <asp:ListItem>Alatz</asp:ListItem>
            <asp:ListItem>Dari</asp:ListItem>
            <asp:ListItem>Julen</asp:ListItem>
            <asp:ListItem>Alejandro</asp:ListItem>
            <asp:ListItem>Iker</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Nortzuk aukeratu ditugu?" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" Text="Horizontala" />
        <br />
    
    </div>
    </form>
</body>
</html>
