<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Izozkiak.aspx.vb" Inherits="Helados" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" 
            ImageSet="Arrows">
            <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
            <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" 
                HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
            <ParentNodeStyle Font-Bold="False" />
            <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" 
                HorizontalPadding="0px" VerticalPadding="0px" />
        </asp:TreeView>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Izozkiak aukeratu dituzu."></asp:Label>
    
    </div>
    </form>
</body>
</html>
