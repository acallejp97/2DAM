﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Komikiak.aspx.vb" Inherits="Helados" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1">
        </asp:Menu>
        <br />
        <br />
    
        <br />
        <asp:Label ID="Label1" runat="server" 
            Text="Momentuz komiki bat baino ez daukagu"></asp:Label>
    
    </div>
    </form>
</body>
</html>
