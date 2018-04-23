Imports Microsoft.VisualBasic
Imports System
Namespace ChartInteractivePoints
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
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("a", New Object() { (CObj(1))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("b", New Object() { (CObj(2))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("c", New Object() { (CObj(2))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("d", New Object() { (CObj(1))})
			Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
			Dim pointOptions1 As New DevExpress.XtraCharts.PointOptions()
			Dim lineSeriesView2 As New DevExpress.XtraCharts.LineSeriesView()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Range.MinValueSerializable = "0"
			xyDiagram1.AxisY.Range.MaxValueSerializable = "2.3"
			xyDiagram1.AxisY.Range.Auto = False
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			series1.Name = "Series 1"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4})
			series1.View = lineSeriesView1
			pointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
			series1.PointOptions = pointOptions1
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chartControl1.SeriesTemplate.View = lineSeriesView2
			Me.chartControl1.Size = New System.Drawing.Size(466, 344)
			Me.chartControl1.TabIndex = 0
'			Me.chartControl1.MouseUp += New System.Windows.Forms.MouseEventHandler(Me.chartControl1_MouseUp);
'			Me.chartControl1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.chartControl1_MouseDown);
'			Me.chartControl1.ObjectHotTracked += New DevExpress.XtraCharts.HotTrackEventHandler(Me.chartControl1_ObjectHotTracked);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(466, 344)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

