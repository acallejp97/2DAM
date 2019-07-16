<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Calendar ID="Calendar1" runat="server" SelectionMode="None"></asp:Calendar>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Width="228px">
            <asp:ListItem>Ninguno</asp:ListItem>
            <asp:ListItem>Dia</asp:ListItem>
            <asp:ListItem>Semana y dia</asp:ListItem>
            <asp:ListItem>Mes, semana y dia</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="ACEPTAR" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="None"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Day"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="DayWeek"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Text="DayWeekMonth"></asp:Label>
        <br />
        Calendario.selectionMode = CalendarSelectionMode.None<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
