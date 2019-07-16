<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="Stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server" defaultfocus="TextBox3" defaultbutton="Button1">
    <div>
    
        <asp:Label ID="Label4" runat="server" 
            Text="SetFocusOnError = True" Font-Size="X-Large" 
            ForeColor="#0066FF"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" 
            Text="Hiruretan errorea badago lehenengo textboxean kokatzen da." 
            Font-Size="X-Large" ForeColor="#0066FF"></asp:Label>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
    
        <asp:Label ID="Label1" runat="server" Text="Izena"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        &nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TextBox1" ErrorMessage="Izena hutsik dago" 
            SetFocusOnError="True" CssClass="p"></asp:RequiredFieldValidator>
        &nbsp;
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Abizena"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        &nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="TextBox2" ErrorMessage="Abizena hutsik dago" 
            SetFocusOnError="True" CssClass="p"></asp:RequiredFieldValidator>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Adina"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        &nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="TextBox3" ErrorMessage="Adina hutsik dago" 
            SetFocusOnError="True" CssClass="p"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Balidatu" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
