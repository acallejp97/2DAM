<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                <asp:ListItem>Selecciona usuario</asp:ListItem>
                <asp:ListItem>Administrador</asp:ListItem>
                <asp:ListItem>Usuario</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Estan en ADMINISTRADOR"></asp:Label>
            </asp:Panel>
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server">
                <asp:Label ID="Label2" runat="server" Text="Estan en USUARIO"></asp:Label>
            </asp:Panel>

        </div>

    </form>
</body>
</html>
