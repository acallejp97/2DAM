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
    
        <asp:Image ID="Image1" runat="server" Height="140px" ImageUrl="~/Koala.jpg" Width="150px" />
        <br />
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" BackColor="#66FFFF" Font-Size="XX-Large">
            <asp:ListItem Value="Koala.jpg">Koala</asp:ListItem>
            <asp:ListItem Value="Lighthouse.jpg">Itsasargia</asp:ListItem>
            <asp:ListItem Value="Tulips.jpg">Idi-bihotzak</asp:ListItem>
            <asp:ListItem Value="Jellyfish.jpg">Marmokak</asp:ListItem>
            <asp:ListItem Value="Penguins.jpg">Pinguinoak</asp:ListItem>
            <asp:ListItem>Irakaslea</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
