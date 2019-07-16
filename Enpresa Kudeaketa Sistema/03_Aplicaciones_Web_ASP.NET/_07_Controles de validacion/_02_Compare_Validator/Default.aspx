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
    
        <asp:Label ID="Label1" runat="server" Text="Escribe tu edad:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" EnableClientScript="False" ErrorMessage="Escribe algo..."></asp:RequiredFieldValidator>
        <br />
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TextBox1" EnableClientScript="False" ErrorMessage="MAYOR QUE 0" Operator="GreaterThan" Type="Integer" ValueToCompare="0"></asp:CompareValidator>
        <br />
        <br />
        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="TextBox1" EnableClientScript="False" ErrorMessage="Escribe un NUMERO" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" EnableClientScript="False" HeaderText="TUS ERRORES SON" />
    
    </div>
    </form>
</body>
</html>
