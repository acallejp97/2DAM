<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default4.aspx.vb" Inherits="Default4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/loading.png" />
        <br />
        <br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    
    </div>
    </form>
</body>
</html>
