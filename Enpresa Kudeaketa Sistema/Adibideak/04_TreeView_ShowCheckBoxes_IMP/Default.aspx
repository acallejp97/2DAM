<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="XmlDataSource1" 
            ShowCheckBoxes="Leaf">
            <DataBindings>
                <asp:TreeNodeBinding DataMember="Fruteria" TextField="#Name" />
                <asp:TreeNodeBinding DataMember="Elemento" TextField="Categoria" />
                <asp:TreeNodeBinding DataMember="Opcion" TextField="Seleccion" />
            </DataBindings>
        </asp:TreeView>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Fruteria.xml">
        </asp:XmlDataSource>
        <asp:Label ID="Label4" runat="server" Text="Aukeratuarik daudenak:"></asp:Label>
        <br />
        <asp:Label ID="Lbl_Aukeraturik" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Orain aukeratu dudana:"></asp:Label>
        <br />
        <asp:Label ID="Lbl_Nodoak" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btn_Aukeratuak" runat="server" 
            Text="Ikusi Aukeratuak" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_Ezabatu" runat="server" 
            Text="Aukeratutako Nodoak ezabatu" />
        <br />
        <br />
        <asp:Button ID="btnHedatuDena" runat="server" style="height: 26px" 
            Text="Hedatu dena" />&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnUzkurtuDena" runat="server" Text="Uzkurtu dena" />&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBerrezarri" runat="server" Text="Berrezarri" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nodoa: "></asp:Label>
        &nbsp;
        <asp:TextBox ID="Txt_Nodoa" runat="server">Frutadenda/Barazkiak</asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="Rb_Hedatu" runat="server" AutoPostBack="True" 
            GroupName="aaa" Text="Hedatu" />
        &nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="Rb_Uzkurtu" runat="server" AutoPostBack="True" 
            GroupName="aaa" Text="Uzkurtu" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:TextBox ID="txtGehitu" runat="server">Nirenodoa</asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnGehitu" runat="server" 
            Text="Textbox-ean dagoenari Nodoa gehitu" />
        &nbsp;&nbsp;<br />
        <br />
        <br />
        <asp:TextBox ID="txtChecked" runat="server" Width="254px">Frutadenda/Barazkiak/Azenarioak</asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnChecked" runat="server" Text="Checked" />
        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
