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
    
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Fruteria.xml"></asp:XmlDataSource>
        <br />
        <asp:Label ID="Label1" runat="server" Text="BD, Editar enlaces de datos"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="He utilizado la propiedad LEVELMENUITEMSTYLES"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Menu ID="Menu1" runat="server" DataSourceID="XmlDataSource1">
            <DataBindings>
                <asp:MenuItemBinding DataMember="Fruteria" />
                <asp:MenuItemBinding DataMember="Elemento" TextField="Categoria" />
                <asp:MenuItemBinding DataMember="Opcion" TextField="Seleccion" />
            </DataBindings>
            <LevelMenuItemStyles>
                <asp:MenuItemStyle BackColor="#CC33FF" Font-Underline="False" />
                <asp:MenuItemStyle BackColor="#009933" Font-Underline="False" Width="100px" />
                <asp:MenuItemStyle BackColor="#FFFF66" Font-Underline="False" Width="120px" />
            </LevelMenuItemStyles>
        </asp:Menu>
    
    </div>
    </form>
</body>
</html>
