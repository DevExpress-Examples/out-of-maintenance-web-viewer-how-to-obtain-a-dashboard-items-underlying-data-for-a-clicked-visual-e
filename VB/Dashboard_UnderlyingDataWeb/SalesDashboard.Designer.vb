Imports Microsoft.VisualBasic
Imports System
Namespace Dashboard_UnderlyingDataWeb
	Partial Public Class SalesDashboard
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim card1 As New DevExpress.DashboardCommon.Card()
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.dataSource1 = New DevExpress.DashboardCommon.DataSource()
			Me.nwindDataSet1 = New Dashboard_UnderlyingDataWeb.nwindDataSet()
			Me.cardDashboardItem1 = New DevExpress.DashboardCommon.CardDashboardItem()
			Me.pivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
			CType(Me.dataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cardDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' dataSource1
			' 
			Me.dataSource1.ComponentName = "dataSource1"
			Me.dataSource1.Data = Me.nwindDataSet1
			Me.dataSource1.DataMember = "SalesPerson"
			Me.dataSource1.DataProcessingMode = DevExpress.DashboardCommon.DataProcessingMode.Client
			Me.dataSource1.Name = "Data Source 1"
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' cardDashboardItem1
			' 
			measure1.DataMember = "Extended Price"
			card1.AddDataItem("ActualValue", measure1)
			Me.cardDashboardItem1.Cards.AddRange(New DevExpress.DashboardCommon.Card() { card1})
			Me.cardDashboardItem1.ComponentName = "cardDashboardItem1"
			dimension1.DataMember = "Sales Person"
			Me.cardDashboardItem1.DataItemRepository.Clear()
			Me.cardDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
			Me.cardDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
			Me.cardDashboardItem1.DataSource = Me.dataSource1
			Me.cardDashboardItem1.IgnoreMasterFilters = False
			Me.cardDashboardItem1.Name = "Cards 1"
			Me.cardDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
			Me.cardDashboardItem1.ShowCaption = True
			' 
			' pivotDashboardItem1
			' 
			dimension2.DataMember = "OrderDate"
			Me.pivotDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2})
			Me.pivotDashboardItem1.ComponentName = "pivotDashboardItem1"
			measure2.DataMember = "Extended Price"
			dimension3.DataMember = "CategoryName"
			dimension4.DataMember = "ProductName"
			Me.pivotDashboardItem1.DataItemRepository.Clear()
			Me.pivotDashboardItem1.DataItemRepository.Add(measure2, "DataItem0")
			Me.pivotDashboardItem1.DataItemRepository.Add(dimension3, "DataItem1")
			Me.pivotDashboardItem1.DataItemRepository.Add(dimension4, "DataItem2")
			Me.pivotDashboardItem1.DataItemRepository.Add(dimension2, "DataItem3")
			Me.pivotDashboardItem1.DataSource = Me.dataSource1
			Me.pivotDashboardItem1.IgnoreMasterFilters = False
			Me.pivotDashboardItem1.Name = "Pivot 1"
			Me.pivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3, dimension4})
			Me.pivotDashboardItem1.ShowCaption = True
			Me.pivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure2})
			' 
			' SalesDashboard
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.DataSource() { Me.dataSource1})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.cardDashboardItem1, Me.pivotDashboardItem1})
			dashboardLayoutItem1.DashboardItem = Me.cardDashboardItem1
			dashboardLayoutItem1.Weight = 31.104921077065924R
			dashboardLayoutItem2.DashboardItem = Me.pivotDashboardItem1
			dashboardLayoutItem2.Weight = 68.895078922934076R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Dashboard"
'			Me.DashboardLoading += New System.EventHandler(Me.SalesDashboard_DashboardLoading);
			CType(Me.dataSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cardDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private dataSource1 As DevExpress.DashboardCommon.DataSource
		Private nwindDataSet1 As nwindDataSet
		Private cardDashboardItem1 As DevExpress.DashboardCommon.CardDashboardItem
		Private pivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem

	End Class
End Namespace
