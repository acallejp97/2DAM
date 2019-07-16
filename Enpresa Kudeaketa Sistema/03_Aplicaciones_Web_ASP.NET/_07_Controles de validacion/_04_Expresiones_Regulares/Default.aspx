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
    
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Valor:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Font-Size="X-Large"></asp:TextBox>
        <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" EnableClientScript="False" ErrorMessage="Formato 3-3" ValidationExpression="\d{1}-\d{1}"></asp:RegularExpressionValidator>
        <br />
        <asp:Button ID="Button1" runat="server" Font-Size="X-Large" Text="Button" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Size="X-Large" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
