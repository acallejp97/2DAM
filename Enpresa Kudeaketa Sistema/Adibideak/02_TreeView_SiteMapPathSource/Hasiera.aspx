<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Hasiera.aspx.vb" Inherits="Inicio" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1">
        </asp:TreeView>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Hasieran zaude."></asp:Label>
    
    </div>
    </form>
</body>
</html>
