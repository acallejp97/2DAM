﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default_VB.aspx.vb" Inherits="Default_VB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="2550">Isla de Pascua</asp:ListItem>
            <asp:ListItem Value="2300">Morea</asp:ListItem>
            <asp:ListItem Value="3200">Papeete</asp:ListItem>
            <asp:ListItem Value="2100">Bora-Bora</asp:ListItem>
            <asp:ListItem Value="1000">Bermudas</asp:ListItem>
            <asp:ListItem Value="1,05">Elorrieta</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Prezioa jakin nahi?" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
