<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Izena:  "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:CustomValidator ID="CustomValidator1" runat="server" 
            ControlToValidate="TextBox1" EnableClientScript="False" 
            ErrorMessage="Izen hori ez dago onartuta"></asp:CustomValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Onartu" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" 
            Text="BALIZIOA ZERBITZARIAN EGIN BEHAR DA"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="X-Large" 
            ForeColor="#0033CC" Text="&quot;pepe&quot; EZ DAGO ONARTUTA"></asp:Label>
    
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="X-Large" 
            ForeColor="#0033CC" Text="Erabili CUSTOMVALIDATOR"></asp:Label>
    
    </div>
    </form>
</body>
</html>
