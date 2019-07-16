<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" EnableClientScript="False" ErrorMessage="Error" SetFocusOnError="True"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" EnableClientScript="False" ErrorMessage="Error" SetFocusOnError="True"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" EnableClientScript="False" ErrorMessage="Error" SetFocusOnError="True"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" ForeColor="#0033CC" Text="Tienen la propiedad SetFocusOnError = True"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Si hay error en los 3 se coloca en el primer textbox"></asp:Label>
    </form>
</body>
</html>
