
<%@ Page Language="VB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"><html  >

  <head id="Head1" runat="server">
    <title>Menu Declarative Example</title>
    <style type="text/css">
        .level1
        {
            color: White;
            background-color: Black;
            font-variant: small-caps;
            font-size: large;
            font-weight: bold;
        }

        .level2
        {
            color: Blue;
            background-color: Gray;        
            font-family: Gill Sans MT;
            font-size: medium;
    
        }

        .level3
        {
            color: black;
            background-color: Silver;
            font-family: Gill Sans MT;
            font-size: small;
        }
        
         .level4
        {
            color: White;         
            background-color: Gray;
            font-size: small;
        } 

        .level4:hover
        {
            color: red;
            font-weight: bold;
        }

    </style>
</head>

  <body>
    <form id="form1" runat="server">

    <asp:menu id="Menu1" CssClass="menu1"
      staticdisplaylevels="3"
      staticsubmenuindent="0" 
      orientation="Vertical"
      target="_blank"
      Font-names="Arial, Gill Sans"
      Width="100px"
      runat="server">

      <LevelMenuItemStyles>
        <asp:MenuItemStyle CssClass="level1"/>
        <asp:MenuItemStyle CssClass="level2"/>
        <asp:MenuItemStyle CssClass="level3" />
        <asp:MenuItemStyle CssClass="level4" />
      </LevelMenuItemStyles>

      <StaticHoverStyle CssClass="hoverstyle"/>
   
      <items>
        <asp:menuitem text="Home" tooltip="Home">
        <asp:menuitem text="Section 1" tooltip="Section 1">
          <asp:menuitem text="Item 1" tooltip="Item 1"/>
          <asp:menuitem text="Item 2" tooltip="Item 2"/>
          <asp:menuitem text="Item 3" tooltip="Item 3"/>
        </asp:menuitem>
        <asp:menuitem text="Section 2" tooltip="Section 2">
          <asp:menuitem text="Item 1" tooltip="Item 1"/>
          <asp:menuitem text="Item 2" tooltip="Item 2">
            <asp:menuitem Text="Subitem 1"/>
            <asp:menuitem Text="Subitem 2" />
          </asp:menuitem>
          <asp:menuitem text="Item 3" tooltip="Item 3"/>
        </asp:menuitem>
      </asp:menuitem>
      </items>
    </asp:menu>

    <br />
    
    </form>
  </body>
</html>