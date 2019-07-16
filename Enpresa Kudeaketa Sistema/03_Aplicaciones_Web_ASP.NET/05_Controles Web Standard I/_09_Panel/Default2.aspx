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
    
        <asp:Panel ID="Panel1" runat="server">
            <asp:TextBox ID="TextBox1" runat="server" BackColor="Red"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" BackColor="#33CC33"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="ACEPTAR" />
            &nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
        </asp:Panel>
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" Text="Panel Visible" />
        <br />

    </div>
    </form>
</body>
</html>
