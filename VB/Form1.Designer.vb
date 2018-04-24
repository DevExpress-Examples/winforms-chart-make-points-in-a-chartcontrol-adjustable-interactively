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
            Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("a", New Object() { (CObj(1R))})
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("b", New Object() { (CObj(2R))})
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("c", New Object() { (CObj(2R))})
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("d", New Object() { (CObj(1R))})
            Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
            Dim pointSeriesLabel2 As New DevExpress.XtraCharts.PointSeriesLabel()
            Dim lineSeriesView2 As New DevExpress.XtraCharts.LineSeriesView()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisualRange.Auto = False
            xyDiagram1.AxisY.VisualRange.AutoSideMargins = True
            xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "2.3"
            xyDiagram1.AxisY.VisualRange.MinValueSerializable = "0"
            xyDiagram1.AxisY.WholeRange.Auto = False
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = True
            xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "2.3"
            xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0"
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.RuntimeHitTesting = True
            pointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            pointSeriesLabel1.TextPattern = "{V:N2}"
            series1.Label = pointSeriesLabel1
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4})
            lineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
            series1.View = lineSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            pointSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            Me.chartControl1.SeriesTemplate.Label = pointSeriesLabel2
            Me.chartControl1.SeriesTemplate.View = lineSeriesView2
            Me.chartControl1.Size = New System.Drawing.Size(466, 344)
            Me.chartControl1.TabIndex = 0
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
            CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace

