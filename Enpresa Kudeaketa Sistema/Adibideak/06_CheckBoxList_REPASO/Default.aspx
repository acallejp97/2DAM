<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label3" runat="server" Text="Es un CheckBoxList"></asp:Label>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" 
            RepeatDirection="Horizontal">
            <asp:ListItem>Diplomado</asp:ListItem>
            <asp:ListItem>Graduado</asp:ListItem>
            <asp:ListItem>PostGraduado</asp:ListItem>
            <asp:ListItem>Doctorado</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Es un ListBox"></asp:Label>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True"></asp:ListBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Label"></asp:Label>
    
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
