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

            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server">
                    <asp:Label ID="Label1" runat="server" Text="aaa"></asp:Label>
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <asp:Label ID="Label2" runat="server" Text="bbb"></asp:Label>
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <asp:Label ID="Label3" runat="server" Text="ccc"></asp:Label>
                </asp:View>
            </asp:MultiView>

        </div>
        <p>
        <p>
        <asp:DropDownList ID="DropDownList1" runat="server" 
            AutoPostBack="True" Height="28px" Width="136px">
            <asp:ListItem>VISTA 1</asp:ListItem>
            <asp:ListItem>VISTA 2</asp:ListItem>
            <asp:ListItem>VISTA 3</asp:ListItem>
        </asp:DropDownList>
        <p>
            &nbsp;<p>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
