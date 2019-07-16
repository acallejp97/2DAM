<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default1.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="hora" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="PROPIEDADES: DATASOURCE y DATABIND" Font-Bold="True"></asp:Label>
        <br />
        <br />
        Destinos:
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True">
        </asp:ListBox>
        &nbsp; LISTBOX1<br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <br />
        
        <br />
    
        &nbsp;&nbsp;&nbsp;<br />
        <asp:ListBox ID="ListBox2" runat="server" AutoPostBack="True"></asp:ListBox>
    
        &nbsp;LISTBOX2<br />
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        Numeros:
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        &nbsp;&nbsp;
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
