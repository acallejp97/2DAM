<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label3" runat="server" Text="RADIOBUTTONLIST-Ordenar los resultados"></asp:Label><br />
        <asp:Label ID="Label4" runat="server" Text="Unir arrays con radiobuttonlist"></asp:Label><br />
        <br />
        <br />
        <asp:RadioButtonList ID="rb" runat="server" AutoPostBack="True">
        </asp:RadioButtonList>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:RadioButtonList ID="rb2" runat="server" AutoPostBack="True">
        </asp:RadioButtonList>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
