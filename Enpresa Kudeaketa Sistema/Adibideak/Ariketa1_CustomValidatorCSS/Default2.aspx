<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

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
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToValidate="TextBox1" EnableClientScript="False" 
            ErrorMessage="CompareValidator" Operator="NotEqual" ValueToCompare="pepe"></asp:CompareValidator>
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
            Text="BALIDAZIOA ZERBITZARIAN EGINGO DUGU"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="X-Large" 
            ForeColor="#0033CC" Text="&quot;pepe&quot; ez dago onartuta"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="X-Large" 
            ForeColor="#0033CC" Text="Erabili behar da COMPAREVALIDATOR"></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
