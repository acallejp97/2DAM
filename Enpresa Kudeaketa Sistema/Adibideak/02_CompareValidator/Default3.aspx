<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default3.aspx.vb" Inherits="Default3" %>

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
        Password:&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" EnableClientScript="False" ErrorMessage="*"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="TextBox2" ControlToValidate="TextBox1" 
            EnableClientScript="False" ErrorMessage="ERROREA"></asp:CompareValidator>
        <br />
        <br />
        Re-Password:&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" EnableClientScript="False" ErrorMessage="*"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Botoia" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#000099" 
            Text="En VB2013-Ez dabil ShowMessageBox=&quot;True&quot;"></asp:Label>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
            HeaderText="ERRORE MEZUAK:" ShowMessageBox="True" />
        <br />
    
    </div>
    </form>
</body>
</html>
