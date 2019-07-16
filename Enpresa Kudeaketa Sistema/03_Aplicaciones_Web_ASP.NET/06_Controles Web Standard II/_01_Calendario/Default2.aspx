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
    
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
            <asp:ListItem>na de na</asp:ListItem>
            <asp:ListItem>uno</asp:ListItem>
            <asp:ListItem>una semana</asp:ListItem>
            <asp:ListItem>una semana / mes</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="ACEPTAR" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Calendar1.SelectionMode"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Calendar1.SelectedDates"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblResultado" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
