<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default1.aspx.vb" Inherits="Default1" %>

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
        <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="TextBox1" 
            ErrorMessage="Bi digito jarri behar formatu honetan 2-3, 0 eta 9 artean" 
            ValidationExpression="[0-9]-[0-9]" EnableClientScript="False"></asp:RegularExpressionValidator>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Bestela" Font-Size="XX-Large" 
            ForeColor="#0033CC"></asp:Label>
        <br />
        <br />
        <br />
    
        <asp:Label ID="Label2" runat="server" Text="Balioa:      "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
            ControlToValidate="TextBox2" ErrorMessage="RegularExpressionValidator" 
            ValidationExpression="\d{1}-\d{1}" EnableClientScript="False"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Datuak bidali" 
            style="height: 26px" />
    
    </div>
    </form>
</body>
</html>
