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
    
        <asp:Label ID="Label1" runat="server" Text="Nombre: "></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox1" EnableClientScript="False" ErrorMessage="error"></asp:CustomValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Aceptar" />
        <br />
        <br />
&nbsp;<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="LA VALIDACION SE HACE EN EL SERVIDOR"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" ForeColor="Blue" Text="No admitir el nombre pepe"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" ForeColor="Blue" Text="Con CUSTOMVALIDATOR"></asp:Label>
    
    </div>
    </form>
</body>
</html>
