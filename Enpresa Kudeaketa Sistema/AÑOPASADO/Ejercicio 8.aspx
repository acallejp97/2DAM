﻿<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Ejercicio 8.aspx.vb" Inherits="Ejercicio_8" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Pais: "></asp:Label>
<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
    DataSourceID="AccessDataSource1" DataTextField="Country" 
    DataValueField="Country">
</asp:DropDownList>
<br />
<rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
    Font-Size="8pt" InteractiveDeviceInfos="(Colección)" 
    WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
    <LocalReport ReportPath="Report1.rdlc">
        <DataSources>
            <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
        </DataSources>
    </LocalReport>
</rsweb:ReportViewer>
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
    SelectMethod="GetData" 
    TypeName="Northwind_CompactaDataSetTableAdapters.CustomersTableAdapter">
</asp:ObjectDataSource>
<asp:AccessDataSource ID="AccessDataSource1" runat="server" 
    DataFile="~/App_Data/Northwind_Compacta.mdb" 
    SelectCommand="SELECT DISTINCT [Country] FROM [Customers] ORDER BY [Country]">
</asp:AccessDataSource>
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<br />
<br />
</asp:Content>

