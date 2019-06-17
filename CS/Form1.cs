using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace ChartInteractivePoints {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        static int lastY = -1;
        static bool isPressed = false;
        static SeriesPoint selectedPoint = null;

        private void chartControl1_ObjectHotTracked(object sender, HotTrackEventArgs e) {
            if(e.HitInfo.SeriesPoint != null)
                selectedPoint = e.HitInfo.SeriesPoint;

            if(selectedPoint != null && isPressed) {
                DiagramCoordinates point = 
                    ((XYDiagram)(sender as ChartControl).Diagram).PointToDiagram(e.HitInfo.HitPoint);

                if(lastY != -1) {
                    VisualRange range = ((XYDiagram)(sender as ChartControl).Diagram).AxisY.VisualRange;
                    double delta = ((double)range.MaxValue - (double)range.MinValue) / 8;

                    if(selectedPoint.Values[0] >= (double)range.MaxValue - delta)
                        range.MaxValue = selectedPoint.Values[0] + delta;

                    selectedPoint.Values[0] = point.NumericalValue;

                    if(point.QualitativeArgument != "")
                        selectedPoint.Argument = point.QualitativeArgument;
                }

                ((ChartControl)sender).RefreshData();
                lastY = e.HitInfo.HitPoint.Y;
                return;
            }

            lastY = -1;
        }

        private void chartControl1_MouseDown(object sender, MouseEventArgs e) {
            isPressed = true;
        }

        private void chartControl1_MouseUp(object sender, MouseEventArgs e) {
            isPressed = false;
        }
    }
}