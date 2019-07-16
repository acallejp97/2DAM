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
        <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxNombre" EnableClientScript="False" ErrorMessage="Error nombre" ValidationGroup="aaa"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Apellidos:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBoxApellidos" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxApellidos" EnableClientScript="False" ErrorMessage="Error apellidos" ValidationGroup="aaa"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="enviar datos" ValidationGroup="aaa" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="ValidationGroup (en los required y en el boton)"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Telefono:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBoxTelefono" runat="server"></asp:TextBox>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxTelefono" EnableClientScript="False" ErrorMessage="Error Telefono" ValidationGroup="bbb"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Enviar datos" ValidationGroup="bbb" />
        <br />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ValidationGroup="aaa" />
    
    </div>
    </form>
</body>
</html>
