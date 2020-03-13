Namespace TreemapColorizerValueProvider
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim treeMapGradientColorizer1 As New DevExpress.XtraTreeMap.TreeMapGradientColorizer()
			Dim treeMapFlatDataAdapter1 As New DevExpress.XtraTreeMap.TreeMapFlatDataAdapter()
			Me.treeMapControl1 = New DevExpress.XtraTreeMap.TreeMapControl()
			CType(Me.treeMapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeMapControl1
			' 
			treeMapGradientColorizer1.EndColor = System.Drawing.Color.Red
			treeMapGradientColorizer1.StartColor = System.Drawing.Color.Lime
			Me.treeMapControl1.Colorizer = treeMapGradientColorizer1
			treeMapFlatDataAdapter1.LabelDataMember = "Country"
			treeMapFlatDataAdapter1.ValueDataMember = "Population"
			Me.treeMapControl1.DataAdapter = treeMapFlatDataAdapter1
			Me.treeMapControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeMapControl1.Location = New System.Drawing.Point(0, 0)
			Me.treeMapControl1.Name = "treeMapControl1"
			Me.treeMapControl1.Size = New System.Drawing.Size(800, 450)
			Me.treeMapControl1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(800, 450)
			Me.Controls.Add(Me.treeMapControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.treeMapControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private treeMapControl1 As DevExpress.XtraTreeMap.TreeMapControl
	End Class
End Namespace

