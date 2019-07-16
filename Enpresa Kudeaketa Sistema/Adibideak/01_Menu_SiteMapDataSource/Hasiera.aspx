<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Hasiera.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
            <asp:ListItem Value="0">Bertikala</asp:ListItem>
            <asp:ListItem Value="1">Horizontala</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1" 
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
    </div>
    <asp:Label ID="Label1" runat="server" Text="Hasiera orrian gaude"></asp:Label>
    </form>
</body>
</html>
