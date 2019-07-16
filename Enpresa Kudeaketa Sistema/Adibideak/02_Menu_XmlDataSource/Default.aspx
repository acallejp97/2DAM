<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" 
            DataSourceID="XmlDataSource1" DynamicHorizontalOffset="2" Font-Names="Verdana" 
            Font-Size="0.8em" ForeColor="#284E98" StaticSubMenuIndent="10px">
            <DataBindings>
                <asp:MenuItemBinding DataMember="Fruteria" TextField="#Value" />
                <asp:MenuItemBinding DataMember="Elemento" TextField="Categoria" />
                <asp:MenuItemBinding DataMember="Opcion" TextField="Seleccion" />
            </DataBindings>
            <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
            <DynamicMenuItemStyle BackColor="#66FFFF" HorizontalPadding="5px" 
                VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#B5C7DE" />
            <DynamicSelectedStyle BackColor="#507CD1" />
            <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
            <StaticMenuItemStyle BackColor="#FFCC00" HorizontalPadding="5px" 
                VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#507CD1" />
        </asp:Menu>
        <br />
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Tienda.xml">
        </asp:XmlDataSource>
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Ikusi oharrak kodean"></asp:Label>
    
    </div>
    </form>
</body>
</html>
