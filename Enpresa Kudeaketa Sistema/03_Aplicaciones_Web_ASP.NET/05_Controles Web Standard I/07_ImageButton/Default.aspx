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
     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> 
    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/arrow.png" style="height: 16px" />
&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server">Sumar</asp:LinkButton>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
