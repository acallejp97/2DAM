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
    
        <asp:TextBox ID="TextBox1" runat="server" Font-Size="X-Large"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Font-Size="X-Large" Text="Pasar con SESSION" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Font-Size="X-Large" PostBackUrl="~/Default3.aspx" Text="PASAR CON PREVIUSPAGE" Width="333px" />
    
    </div>
    </form>
</body>
</html>
