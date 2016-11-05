using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;


namespace Cycling
{
    public partial class HeartGraph : Form
    {
        public HeartGraph()
        {
            InitializeComponent();
        }
        private void SetSize()
        {
            zedGraphControl1.Location = new Point(10, 10);
            // Leave a small margin around the outside of the control
            zedGraphControl1.Size = new Size(ClientRectangle.Width -25,
                                    ClientRectangle.Height -25);
        }
        public void CreateHeartGraph(ZedGraphControl zgc)
        {
            GraphPane djeasy = zgc.GraphPane;

            // Set the Titles
            djeasy.Title.Text = "Heart Rate Graph";
            djeasy.XAxis.Title.Text = "Label";
            djeasy.YAxis.Title.Text = "Y Axis";

            // Make up some random data points
            string[] labels = { "Heart Rate" };
            double[] y = { 100, 115, 75, 22 };
            double[] y2 = { 200, 150, 100, 50 };
            double[] y3 = { 300, 250, 200, 150 };
            double[] y4 = { 400, 350, 300, 250 };
            // Generate a red bar with "Curve 1" in the legend
            // Generate a blue bar with "Curve 2" in the legend
            BarItem myBar = djeasy.AddBar("Min", null, y2, Color.DeepSkyBlue);
            myBar.Bar.Fill = new Fill(Color.DeepSkyBlue, Color.White,
                                                        Color.DeepSkyBlue);

            // Generate a blue bar with "Curve 2" in the legend
            myBar = djeasy.AddBar("Avg", null, y2, Color.Maroon);
            myBar.Bar.Fill = new Fill(Color.Maroon, Color.White,
                                                        Color.Maroon);

            // Generate a green bar with "Curve 3" in the legend
            myBar = djeasy.AddBar("Max", null, y3, Color.Purple);
            myBar.Bar.Fill = new Fill(Color.Purple, Color.White,
                                                        Color.Purple);
            // Fix up the curve attributes a little
            /*myCurve.Symbol.Size = 8.0F;
            myCurve.Symbol.Fill = new Fill(Color.White);
            myCurve.Line.Width = 2.0F;*/

            // Draw the X tics between the labels instead of 
            // at the labels
            djeasy.XAxis.MajorTic.IsBetweenLabels = true;

            // Set the XAxis labels
            djeasy.XAxis.Scale.TextLabels = labels;
            // Set the XAxis to Text type
            djeasy.XAxis.Type = AxisType.Text;

            // Fill the Axis and Pane backgrounds
            djeasy.Chart.Fill = new Fill(Color.White,
                  Color.FromArgb(255, 255, 166), 90F);
            djeasy.Fill = new Fill(Color.FromArgb(250, 250, 255));


            // Tell ZedGraph to refigure the
            // axes since the data have changed
            zgc.AxisChange();
        }
        private void HeartGraph_Load(object sender, EventArgs e)
        {
            CreateHeartGraph(zedGraphControl1);
            // Size the control to fill the form with a margin
            SetSize();
        }
    }
}
