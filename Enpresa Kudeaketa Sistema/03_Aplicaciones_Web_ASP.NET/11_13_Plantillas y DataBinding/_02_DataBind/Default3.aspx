<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default3.aspx.vb" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Es un CheckBoxList"></asp:Label>
        <br />
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" Width="250px">
            <asp:ListItem>Diplomado</asp:ListItem>
            <asp:ListItem>Graduado</asp:ListItem>
            <asp:ListItem>PostGrado</asp:ListItem>
            <asp:ListItem>Doctorado</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Es un Listbox"></asp:Label>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True"></asp:ListBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
