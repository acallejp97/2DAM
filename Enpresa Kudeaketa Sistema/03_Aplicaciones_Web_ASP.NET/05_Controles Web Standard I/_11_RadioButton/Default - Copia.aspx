<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default - Copia.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="aaa" />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="aaa" />
        <br />
        <asp:RadioButton ID="RadioButton3" runat="server" AutoPostBack="True" GroupName="aaa" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <asp:RadioButton ID="RadioButton4" runat="server" AutoPostBack="True" GroupName="bbb" />
        <br />
        <asp:RadioButton ID="RadioButton5" runat="server" AutoPostBack="True" GroupName="bbb" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
