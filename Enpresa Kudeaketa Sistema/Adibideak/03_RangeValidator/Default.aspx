<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Balioa:      "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="96px"></asp:TextBox>
        <br />
        <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ControlToValidate="TextBox1" EnableClientScript="False" 
            ErrorMessage="Balioa 0 eta 100 artean izan behar da" ForeColor="Red" 
            MaximumValue="100" MinimumValue="0" Type="Integer"></asp:RangeValidator>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Datuak bidali" />
        <br />
    
    </div>
    </form>
</body>
</html>
