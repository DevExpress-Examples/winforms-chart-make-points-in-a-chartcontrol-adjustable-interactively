Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace ChartInteractivePoints
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Shared lastY As Integer = -1
		Private Shared isPressed As Boolean = False
		Private Shared selectedPoint As SeriesPoint = Nothing

		Private Sub chartControl1_ObjectHotTracked(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles chartControl1.ObjectHotTracked
			If e.HitInfo.SeriesPoint IsNot Nothing Then
				selectedPoint = e.HitInfo.SeriesPoint
			End If

			If selectedPoint IsNot Nothing AndAlso isPressed Then
				Dim point As DiagramCoordinates = CType((TryCast(sender, ChartControl)).Diagram, XYDiagram).PointToDiagram(e.HitInfo.HitPoint)

				If lastY <> -1 Then
					Dim range As AxisRange = CType((TryCast(sender, ChartControl)).Diagram, XYDiagram).AxisY.Range
					Dim delta As Double = (CDbl(range.MaxValue) - CDbl(range.MinValue)) / 8

					If selectedPoint.Values(0) >= CDbl(range.MaxValue) - delta Then
						range.MaxValue = selectedPoint.Values(0) + delta
					End If

					selectedPoint.Values(0) = point.NumericalValue

					If point.QualitativeArgument <> "" Then
						selectedPoint.Argument = point.QualitativeArgument
					End If
				End If

				DirectCast(sender, ChartControl).RefreshData()
				lastY = e.HitInfo.HitPoint.Y
				Return
			End If

			lastY = -1
		End Sub

		Private Sub chartControl1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chartControl1.MouseDown
			isPressed = True
		End Sub

		Private Sub chartControl1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chartControl1.MouseUp
			isPressed = False
		End Sub
	End Class
End Namespace