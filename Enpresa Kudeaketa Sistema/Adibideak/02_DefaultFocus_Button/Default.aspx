<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" 
    defaultfocus="TextBox3" 
    defaultbutton="Button2">

    <div>
    
        <asp:Label ID="Label4" runat="server" Font-Size="XX-Large" ForeColor="#0066FF" 
            
            Text="Fokua jarri lehenengo eta bigarren textboxetan botoiak erabiliz."></asp:Label>
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="Etiketa 1"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Etiketa 2"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Etiketa 3"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Kokatu lehenengoan" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Kokatu bigarrenean" />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
