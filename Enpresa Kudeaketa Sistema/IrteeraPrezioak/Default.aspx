<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 105px;
        }
    </style>
</head>
<body style="height: 153px">
    <form id="form1" runat="server">
    <div style="height: 25px">
    
        <asp:DropDownList ID="Helmuga" runat="server" style="margin-bottom: 0px">
            <asp:ListItem>Isla de Pascua</asp:ListItem>
            <asp:ListItem>Morea</asp:ListItem>
            <asp:ListItem>Paapeete</asp:ListItem>
            <asp:ListItem>Bora-Bora</asp:ListItem>
            <asp:ListItem>Bermudas</asp:ListItem>
            <asp:ListItem>Elorrieta</asp:ListItem>
        </asp:DropDownList>
    
    </div>
        <p>
            <asp:Button ID="Prezioa" runat="server" Text="Pezioa erakutsi" />
        </p>
        <asp:Label ID="lblPrezio" runat="server"></asp:Label>
    </form>
</body>
</html>
