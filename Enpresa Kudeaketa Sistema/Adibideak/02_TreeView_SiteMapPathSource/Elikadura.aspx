<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Elikadura.aspx.vb" Inherits="Alimentacion" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" 
            ImageSet="XPFileExplorer" NodeIndent="15">
            <HoverNodeStyle Font-Underline="True" ForeColor="#6666AA" />
            <NodeStyle Font-Names="Tahoma" Font-Size="8pt" ForeColor="Black" 
                HorizontalPadding="2px" NodeSpacing="0px" VerticalPadding="2px" />
            <ParentNodeStyle Font-Bold="False" />
            <SelectedNodeStyle BackColor="#B5B5B5" Font-Underline="False" 
                HorizontalPadding="0px" VerticalPadding="0px" />
        </asp:TreeView>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Elikadura aukeratu duzu."></asp:Label>
    
    </div>
    </form>
</body>
</html>
