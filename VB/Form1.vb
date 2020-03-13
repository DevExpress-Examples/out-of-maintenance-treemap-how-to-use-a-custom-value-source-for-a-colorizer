Imports DevExpress.TreeMap
Imports DevExpress.XtraTreeMap
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace TreemapColorizerValueProvider
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			CType(treeMapControl1.DataAdapter, TreeMapFlatDataAdapter).DataSource = CreateDataSet()
			CType(treeMapControl1.Colorizer, TreeMapColorizerBase).ValueProvider = New ColorizerValueProvider()
		End Sub
		Public Function CreateDataSet() As DataTable
			Dim filePath As String = "..\..\Data\HPI.xml"
			If Not String.IsNullOrWhiteSpace(filePath) Then
				Dim dataSet As New DataSet()
				dataSet.ReadXml(filePath)
				If dataSet.Tables.Count > 0 Then
					Return dataSet.Tables(0)
				End If
			End If
			Return Nothing
		End Function
	End Class

	Public Class ColorizerValueProvider
		Implements IColorizerValueProvider

		Private Function IColorizerValueProvider_GetValue(ByVal item As IHierarchicalItem, ByVal itemIndex As Integer) As Double Implements IColorizerValueProvider.GetValue
			Dim row As DataRowView = TryCast(item.Tag, DataRowView)
			If row IsNot Nothing Then
				Return DirectCast(row("HPI"), Double)
			End If
			Return 0
		End Function
	End Class
End Namespace
