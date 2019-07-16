<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Aseo.aspx.vb" Inherits="Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1">
        </asp:TreeView>
        <br />
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Aseo"></asp:Label>
    
    </div>
    </form>
</body>
</html>
