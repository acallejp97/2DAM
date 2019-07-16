<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="Button1">
    <div>
    
        Formulario 2<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True" 
            ForeColor="#3366FF"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/Default.aspx" 
            Text="Itzuli" />
        &nbsp;&nbsp;
        <br />
    
    </div>
    </form>
</body>
</html>
