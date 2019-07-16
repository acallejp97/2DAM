<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Helados.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Estoy en HELADOS"></asp:Label>
        <br />
        <br />
        <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1">
        </asp:Menu>
    
    </div>
    </form>
</body>
</html>
