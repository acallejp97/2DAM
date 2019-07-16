<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 308px">
        <asp:Label ID="Label1" runat="server" Text="Izena:  "></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="Zure izena sartu behar duzu." ValidationGroup="grupo1"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Abizenak:   "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
            ErrorMessage="Zure abizena sartu behar duzu." ValidationGroup="grupo1"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Datuak bidali" ValidationGroup="grupo1" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" ForeColor="Blue" Text="ValidationGroup (bai requireden bai botoian)"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Telefonoa:  "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3"
            ErrorMessage="Sartu zure telefonoa, mesedez." ValidationGroup="grupo2"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Datuak bidali" ValidationGroup="grupo2" />
    </div>
    </form>
</body>
</html>
