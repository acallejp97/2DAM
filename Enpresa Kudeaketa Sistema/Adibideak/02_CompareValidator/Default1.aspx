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
    
        <asp:Label ID="Label1" runat="server" Text="Idatzi zure adina:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TextBox1" EnableClientScript="False" 
            ErrorMessage="Idatzi zerbait hemen..."></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToValidate="TextBox1" EnableClientScript="False" 
            ErrorMessage="0 baino handiagoa" Operator="GreaterThan" Type="Integer" 
            ValueToCompare="0"></asp:CompareValidator>
        <br />
        <asp:CompareValidator ID="CompareValidator2" runat="server" 
            ControlToValidate="TextBox1" EnableClientScript="False" 
            ErrorMessage="Zenbakia izan behar da" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
        <br />
        <br />
        <asp:Button ID="Botoia" runat="server" Text="Button" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
