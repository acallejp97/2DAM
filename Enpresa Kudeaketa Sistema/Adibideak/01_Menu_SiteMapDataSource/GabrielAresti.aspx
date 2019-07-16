<%@ Page Language="VB" AutoEventWireup="false" CodeFile="GabrielAresti.aspx.vb" Inherits="Helados" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <asp:Menu ID="Menu2" runat="server" DataSourceID="SiteMapDataSource1" 
            BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" 
            Font-Size="0.8em" ForeColor="#284E98" StaticSubMenuIndent="10px">
            <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
            <DynamicMenuItemStyle BackColor="#FF9966" HorizontalPadding="5px" 
                VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#B5C7DE" />
            <DynamicSelectedStyle BackColor="#507CD1" />
            <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#507CD1" />
        </asp:Menu>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/GabrielAresti2.JPG" />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/GabrielAresti.jpg" 
            style="margin-right: 0px; margin-top: 0px" />
        <br />
    
        <br />
    
    </div>
    </form>
</body>
</html>
