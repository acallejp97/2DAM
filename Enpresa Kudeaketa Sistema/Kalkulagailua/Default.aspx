<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 233px">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="Kalkulagailua" Font-Bold="True" Font-Size="XX-Large" ForeColor="#FF9900"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton1" runat="server" Height="29px" ImageUrl="~/220px-Division_Sign.svg.png" Width="30px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server">Gehitu</asp:LinkButton>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Emaitza:    "></asp:Label>
        <asp:Label ID="Result" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
