<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ErrorVB.aspx.vb" Inherits="ErrorVB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="ERROR"></asp:Label>
    
    </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/DefaultVB.aspx">VOLVER...</asp:HyperLink>
    </form>
</body>
</html>
