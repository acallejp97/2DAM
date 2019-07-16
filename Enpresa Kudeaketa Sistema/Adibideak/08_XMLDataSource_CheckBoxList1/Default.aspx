<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Denda.xml">
        </asp:XmlDataSource>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        </asp:CheckBoxList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="1_For" Height="25px" 
            Width="130px" />
        &nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="2_For_Each" Height="25px" 
            style="margin-right: 2px; margin-top: 0px" Width="130px" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#0033CC" 
            Text="XML fitxetegi bat lotzen dugu CheckBoxList batekin"></asp:Label>
    
    </div>
    </form>
</body>
</html>
