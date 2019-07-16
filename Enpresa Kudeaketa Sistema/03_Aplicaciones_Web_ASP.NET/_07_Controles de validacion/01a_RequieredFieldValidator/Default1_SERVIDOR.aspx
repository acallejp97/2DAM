<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default1_SERVIDOR.aspx.vb" Inherits="Default1_SERVIDOR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="PAIS:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" EnableClientScript="False" ErrorMessage="&lt;img src=&quot;jack.png&quot;&gt; Escribe algo..."></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnAceptar" runat="server" Text="ACEPTAR" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Validacion en el SERVIDOR"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="EnableClientScript = False"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
