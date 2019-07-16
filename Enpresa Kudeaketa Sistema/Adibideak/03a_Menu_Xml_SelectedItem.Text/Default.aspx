<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .menu1
        {
        border-style: solid !important;
        border-width: 2px;
        background-color: #E4EAEB;
        width: 100px;
        }
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
     <!--  COMENTARIOS  -->  
        <asp:Menu ID="Menu" runat="server" BackColor="#B5C7DE" 
            DataSourceID="XmlDataSource1" DynamicHorizontalOffset="2" Font-Names="Verdana" 
            Font-Size="0.8em" ForeColor="#284E98" StaticSubMenuIndent="10px">
            <DataBindings>
                <asp:MenuItemBinding DataMember="Fruteria" TextField="#Value" />
                <asp:MenuItemBinding DataMember="Elemento" TextField="Categoria" />
                <asp:MenuItemBinding DataMember="Opcion" TextField="Seleccion" />
            </DataBindings>

           <LevelMenuItemStyles>
                  <asp:menuitemstyle BackColor="LightSteelBlue"
                    forecolor="White"/>
                  <asp:menuitemstyle BackColor="LightGreen"
                    forecolor="Blue" Width="120" />
                  <asp:menuitemstyle BackColor="PaleTurquoise"
                    forecolor="Red"/>     
           </LevelMenuItemStyles>   
                   
        </asp:Menu>



        <br />
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Fruteria.xml">
        </asp:XmlDataSource>
    
        <br />
        <br />
    
        <br />
        <asp:Label ID="seleccion" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
