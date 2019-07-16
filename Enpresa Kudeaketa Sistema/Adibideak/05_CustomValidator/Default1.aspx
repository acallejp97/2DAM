<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default1.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Zenbakia al da?" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox1" EnableClientScript="False" ErrorMessage="Errorea: sartu duzun datua ez dago ondo, zenbakia izan behar da."></asp:CustomValidator>
    </div>
    </form>
</body>
</html>
