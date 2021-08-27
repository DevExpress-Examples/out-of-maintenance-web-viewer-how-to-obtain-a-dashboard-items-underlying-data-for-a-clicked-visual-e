<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580523/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T115445)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [UnderlyingData.js](./CS/Dashboard_UnderlyingDataWeb/Scripts/UnderlyingData.js) (VB: [UnderlyingData.js](./VB/Dashboard_UnderlyingDataWeb/Scripts/UnderlyingData.js))
* [WebForm1.aspx](./CS/Dashboard_UnderlyingDataWeb/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/Dashboard_UnderlyingDataWeb/WebForm1.aspx))
<!-- default file list end -->
# Web Viewer - How to obtain a dashboard item's underlying data for a clicked visual element
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t115445)**
<!-- run online end -->


<p><strong>Note:</strong> <em>Starting with v17.1, we recommend using the <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16976.aspx">ASPxDashboard control</a> or a corresponding <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16977.aspx">ASP.NET MVC extension</a> to display dashboards within web applications.</em><br><br>The following example demonstrates how to get underlying data corresponding to a particular visual element using the <a href="http://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWebScriptsASPxClientDashboardViewertopic">ASPxClientDashboardViewer</a>'s API.</p>
<p>In this example, the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboardViewer_ItemClicktopic">ASPxClientDashboardViewer.ItemClick</a> event is handled to obtain underlying data and invoke the dxPopup widget with the child dxDataGrid. In the event handler, the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboardViewer_RequestUnderlyingDatatopic">RequestUnderlyingData</a> method is called to obtain records from the dashboard's data source. The dxDataGrid is used to display these records.</p>

<br/>


