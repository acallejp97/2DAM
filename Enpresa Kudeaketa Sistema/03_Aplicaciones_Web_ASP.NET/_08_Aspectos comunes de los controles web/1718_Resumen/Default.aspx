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
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox1" EnableClientScript="False" ErrorMessage="Te has equivocado" Font-Size="X-Large" SetFocusOnError="True"></asp:CustomValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:BulletedList ID="BulletedList1" runat="server">
        </asp:BulletedList>
    
    </div>
    </form>
</body>
</html>
