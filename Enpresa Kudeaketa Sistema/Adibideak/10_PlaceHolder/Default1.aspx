<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default1.aspx.vb" Inherits="Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:PlaceHolder ID="PlaceHolder1" runat="server">

        </asp:PlaceHolder>
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" 
            AutoPostBack="True" Text="Visible" />
    
    </div>
    </form>
</body>
</html>
