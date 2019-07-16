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
    
        <asp:MultiView ID="MultiView1" runat="server">
             <asp:View ID="View1" runat="server">
                 <asp:Label ID="Label1" runat="server" Text="AAA"></asp:Label>
             </asp:View>
            <asp:View ID="View2" runat="server">
                     <asp:Label ID="Label2" runat="server" Text="BBB"></asp:Label>
                 </asp:View>
            <asp:View ID="View3" runat="server">
                <asp:Label ID="Label3" runat="server" Text="CCC"></asp:Label>
            </asp:View>
        </asp:MultiView>
        <br /><br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
