<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="PAG1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:BulletedList ID="Lista" runat="server">
            <asp:ListItem>Elemento 1</asp:ListItem>
            <asp:ListItem>Elemento 2</asp:ListItem>
            <asp:ListItem>Elemento 3</asp:ListItem>
        </asp:BulletedList>
        <asp:Label ID="Label1" runat="server" Text="Lista.DISPLAYMODE"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
            <asp:ListItem>text</asp:ListItem>
            <asp:ListItem>linkbutton</asp:ListItem>
            <asp:ListItem>hyperlink</asp:ListItem>
        </asp:DropDownList>
        <br />
    
    </div>
    </form>
</body>
</html>
