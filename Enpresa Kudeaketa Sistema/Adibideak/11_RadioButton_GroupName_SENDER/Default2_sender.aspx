<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2_sender.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:RadioButton ID="opc1" runat="server" AutoPostBack="True" GroupName="Talde1" 
            Text="Bat" />
        <br />
        <asp:RadioButton ID="opc2" runat="server" AutoPostBack="True" GroupName="Talde1" 
            Text="Bi" />
        <br />
        <asp:RadioButton ID="opc3" runat="server" AutoPostBack="True" GroupName="Talde1" 
            Text="Hiru" />
        <br />
          <asp:Label ID="seleccion" runat="server"></asp:Label>
        <br />
        <br />
        <hr />
        <asp:RadioButton ID="opc4" runat="server" AutoPostBack="True" 
            GroupName="Talde2" Text="Lau" />
        <br />
        <asp:RadioButton ID="opc5" runat="server" AutoPostBack="True" 
            GroupName="Talde2" Text="Bost" />   
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
