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
    
        Zenbakia:&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox1" EnableClientScript="False" ErrorMessage="Zenbakia bikoitia izan behar da." ValidateEmptyText="True"></asp:CustomValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Balidatu" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="ValidateEmptyText=True"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
