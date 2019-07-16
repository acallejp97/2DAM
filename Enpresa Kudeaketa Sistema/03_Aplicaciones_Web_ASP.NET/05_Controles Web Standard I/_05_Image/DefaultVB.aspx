<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DefaultVB.aspx.vb" Inherits="DefaultVB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Hydrangeas.jpg" Width="140px" />
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Font-Size="X-Large">
            <asp:ListItem Value="Hydrangeas.jpg">Flor</asp:ListItem>
            <asp:ListItem Value="Koala.jpg">Koala</asp:ListItem>
            <asp:ListItem Value="Tulips.jpg">Tulipanes</asp:ListItem>
            <asp:ListItem Value="Jellyfish.jpg">Medusas</asp:ListItem>
            <asp:ListItem Value="Penguins.jpg">Pinguinos</asp:ListItem>
            <asp:ListItem Value="Lighthouse.jpg">Faro</asp:ListItem>
            <asp:ListItem>aaa</asp:ListItem>
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
