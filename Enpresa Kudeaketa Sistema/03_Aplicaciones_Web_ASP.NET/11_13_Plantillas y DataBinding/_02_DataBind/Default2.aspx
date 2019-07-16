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
    
        <asp:Label ID="Label1" runat="server" Text="RADIOBUTTONLIST"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Unir arrays con radiobuttonlist"></asp:Label>
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True">
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList3" runat="server" AutoPostBack="True">
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
