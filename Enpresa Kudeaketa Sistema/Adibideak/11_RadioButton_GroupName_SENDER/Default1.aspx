<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default1.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:RadioButton ID="opc1" runat="server" AutoPostBack="True" GroupName="Talde1" 
            Text="Lehenengo aukera" />
        <br />
        <asp:RadioButton ID="opc2" runat="server" AutoPostBack="True" GroupName="Talde1" 
            Text="Bigarren aukera" />
        <br />
        <asp:RadioButton ID="opc3" runat="server" AutoPostBack="True" GroupName="Talde1" 
            Text="Hirugarren aukera" />
        <br />
          <asp:Label ID="seleccion" runat="server"></asp:Label>
        <br />
        <br />
        <hr />
        <asp:RadioButton ID="opc4" runat="server" AutoPostBack="True" 
            GroupName="Talde2" Text="Laugarren aukera" />
        <br />
        <asp:RadioButton ID="opc5" runat="server" AutoPostBack="True" 
            GroupName="Talde2" Text="Bostgarren aukera" />   
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
