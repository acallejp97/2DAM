<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Numeros:
        <asp:DropDownList ID="Lista" runat="server">
        </asp:DropDownList>
        &nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="PROPIEDAD DATASOURCE ..."></asp:Label>
        <br />
        <br />
        Destinos:
        <asp:ListBox ID="listados" runat="server">
        </asp:ListBox>
        <br />
        <br />
        <asp:Label ID="hora" runat="server"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="caja" runat="server" >
        </asp:TextBox>
    
        <br />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
    
        <br />
        <br />
        <br />
    
        <br />
        <asp:Button ID="Button1" runat="server" Text="Me.Page.DATABIND" />
        <br />
    
    </div>
    </form>
</body>
</html>
