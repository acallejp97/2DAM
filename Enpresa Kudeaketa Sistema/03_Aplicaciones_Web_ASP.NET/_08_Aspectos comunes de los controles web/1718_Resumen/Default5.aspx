<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default5.aspx.vb" Inherits="Default5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/Default5b.aspx" Text="Button" />
    
    </div>
    </form>
</body>
</html>
