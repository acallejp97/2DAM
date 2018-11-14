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
    
    &nbsp;<asp:Button ID="Button1" runat="server" Text="Taula" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Table ID="Tablamulti" runat="server" BorderColor="Fuchsia" BorderStyle="Solid" Height="247px" Width="186px">
        </asp:Table>
    
    </div>
    </form>
</body>
</html>
