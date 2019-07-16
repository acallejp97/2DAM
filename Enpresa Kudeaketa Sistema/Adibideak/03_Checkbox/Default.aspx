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
    
        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" Text="Elorrieta" />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
    
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Zelan dago checkbox?" ForeColor="Blue" />
        <br />
        <asp:Label ID="Label1" runat="server" ForeColor="Blue"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
