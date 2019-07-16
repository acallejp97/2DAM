<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TreeView ID="TreeView1" runat="server" ShowCheckBoxes="All">
            <Nodes>
                <asp:TreeNode Text="Books" Value="Books">
                    <asp:TreeNode Text="Book 1" Value="Book 1">
                        <asp:TreeNode Text="Nuevo 1" Value="Nuevo 1"></asp:TreeNode>
                        <asp:TreeNode Text="Nuevo 2" Value="Nuevo 2"></asp:TreeNode>
                        <asp:TreeNode Text="Nuevo 3" Value="Nuevo 3"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="Book 2" Value="Book 2"></asp:TreeNode>
                    <asp:TreeNode Text="Book 3" Value="Book 3"></asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode Text="Papers" Value="Papers">
                    <asp:TreeNode Text="Papers 1" Value="Papers 1"></asp:TreeNode>
                    <asp:TreeNode Text="Papers 2" Value="Papers 2"></asp:TreeNode>
                    <asp:TreeNode Text="Papers 3" Value="Papers 3"></asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
        </asp:TreeView>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Cheked nodoak EZABATU" />
    
    </div>
    </form>
</body>
</html>
