<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="XmlDataSource2" 
            ImageSet="Arrows">
            <DataBindings>
                <asp:TreeNodeBinding DataMember="Frutadenda" TextField="#Name" />
                <asp:TreeNodeBinding DataMember="Elemento" TextField="Categoria" />
                <asp:TreeNodeBinding DataMember="Opcion" TextField="Seleccion" />
            </DataBindings>
            <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
            <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" 
                HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
            <ParentNodeStyle Font-Bold="False" />
            <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" 
                HorizontalPadding="0px" VerticalPadding="0px" />
        </asp:TreeView>
        <asp:XmlDataSource ID="XmlDataSource2" runat="server" DataFile="~/Fruteria.xml">
        </asp:XmlDataSource>
        <asp:Label ID="Label1" runat="server" Text="Comentario" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Etiketa" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
