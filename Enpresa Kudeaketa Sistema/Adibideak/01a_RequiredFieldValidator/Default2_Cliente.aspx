<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2_Cliente.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <br />
        Pais:&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" 
    ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Font-Size="X-Large" Text="Aceptar" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Validacion en el cliente"></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
