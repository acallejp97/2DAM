<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Bebidas.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <table border="1"> 
        <tr> 
        <td><asp:Literal ID="Literal1" runat="server" Text="Erro-Nodoa erakutsi"></asp:Literal> <br /> 
        <asp:RadioButton ID="RbErroaBai" runat="server" Text="Bai" 
        AutoPostBack="true" GroupName="Erroa" 
        OnCheckedChanged="rbErroa_CheckedChanged"/> 
        <asp:RadioButton ID="RbErroaEz" runat="server" Text="Ez" 
        AutoPostBack="true" GroupName="Erroa" 
        OnCheckedChanged="rbErroa_CheckedChanged"/> 
        </td> 
        <td><asp:Literal ID="Literal2" runat="server" 
                Text="Oraingo nodotik aurrera erakutsi"></asp:Literal> <br /> 
        <asp:RadioButton ID="RbNodoaBai" runat="server" Text="Bai" 
        AutoPostBack="true" GroupName="Nodoa" 
        OnCheckedChanged="rbNodoa_CheckedChanged"/> 
        <asp:RadioButton ID="rbNodoaEz" runat="server" Text="Ez" 
        AutoPostBack="true" GroupName="Nodoa" 
        OnCheckedChanged="rbNodoa_CheckedChanged"/> 
    </td> 
    </tr> 
    </table> 


    <br />
    <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1">
    </asp:Menu>
    <hr />
    
    <br />
    <asp:TreeView ID="TreeView1" runat="server" 
    DataSourceID="SiteMapDataSource1">
    </asp:TreeView>

    <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />

    </form>
</body>
</html>
