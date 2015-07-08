<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Compliance.aspx.cs" Inherits="ePro.Reports.Compliance" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="1304px">
            <LocalReport ReportPath="Reports\ComplaintItems.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="SqlDataSource1" Name="CompliantItems" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ePro.DB.eProContextConnectionString %>" SelectCommand=" select [ProductName], pc.ProductListingID, ItemName,checked 
 from [ProductCompliances] as pc join [ComplianceItems] as pis
 on pc.ComplianceItemsID	=pis.ComplianceItemsID
 Join ProductListings pl on pl.ProductListingID = pc.ProductListingID
"></asp:SqlDataSource>
        <br />
       
    </div>
    </form>
</body>
</html>
