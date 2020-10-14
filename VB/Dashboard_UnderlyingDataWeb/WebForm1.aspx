<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="WebForm1.aspx.vb" 
         Inherits="Dashboard_UnderlyingDataWeb.WebForm1" %>

<%@ Register Assembly="DevExpress.Dashboard.v14.2.Web, Version=14.2.17.0, 
                       Culture=neutral, 
                       PublicKeyToken=b88d1754d700e49a"
             Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
                      "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="myPopup"></div>
    <div>
    <script type="text/javascript" src="<%=Page.ResolveClientUrl("~/Scripts/UnderlyingData.js")%>">
    </script>
        <dx:ASPxDashboardViewer ID="ASPxDashboardViewer1" runat="server" 
            DashboardSource="<%#GetType(Dashboard_UnderlyingDataWeb.SalesDashboard)%>">            
            <ClientSideEvents 
                   ItemClick="function(s, e) { getUnderlyingData(e); }"
                   Init="function(s, e) { initPopup(); }" />
        </dx:ASPxDashboardViewer>
    </div>
    </form>
</body>
</html>