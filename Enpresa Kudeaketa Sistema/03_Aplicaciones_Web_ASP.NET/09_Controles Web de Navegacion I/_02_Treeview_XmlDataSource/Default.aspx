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
    
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="BD, Editar enlaces de datos"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="XmlDataSource1" ImageSet="Arrows">
            <DataBindings>
                <asp:TreeNodeBinding DataMember="Fruteria" TextField="#Name" />
                <asp:TreeNodeBinding DataMember="Elemento" TextField="Categoria" />
                <asp:TreeNodeBinding DataMember="Opcion" TextField="Seleccion" />
            </DataBindings>
            <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
            <NodeStyle BackColor="Blue" Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
            <ParentNodeStyle BackColor="#FFFF66" Font-Bold="False" />
            <RootNodeStyle BackColor="#00CC00" />
            <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
        </asp:TreeView>
        <br />
        <br />
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Tienda.xml"></asp:XmlDataSource>
    
        <br />
    
    </div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
