<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="XmlDataSource1">
            <DataBindings>
                <asp:TreeNodeBinding DataMember="Fruteria" TextField="#Name" />
                <asp:TreeNodeBinding DataMember="Elemento" TextField="Categoria" />
                <asp:TreeNodeBinding DataMember="Opcion" TextField="Seleccion" />
            </DataBindings>
        </asp:TreeView>
        <br />
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Tienda.xml"></asp:XmlDataSource>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Borrar nodo seleccionado (que no chequeado)" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Visualizar los chequeados" />
        <br />
        <br />
        <asp:Button ID="ButtonExpandir" runat="server" Text="Expandir" />
&nbsp;&nbsp;
        <asp:Button ID="ButtonContraer" runat="server" Text="Contraer" />
&nbsp;&nbsp;
        <asp:Button ID="ButtonRestablecer" runat="server" Text="Restablecer" />
        <br />
        <asp:BulletedList ID="BulletedList1" runat="server">
        </asp:BulletedList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nodo:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server">Fruteria/Legumbres</asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="aaa" Text="Expandir" AutoPostBack="True" />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="aaa" Text="Contraer" AutoPostBack="True" />
    
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server">mi nodo</asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Añadir nodo al que esta en textbox1" />
    
        <br />
        <br />
        <asp:TextBox ID="TextBox3" runat="server" Width="236px">Fruteria/Hortalizas/Zanahorias</asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Checked" />
    
    </div>
    </form>
</body>
</html>
