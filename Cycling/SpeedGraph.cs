using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Cycling
{
    public partial class SpeedGraph : Form
    {
        public SpeedGraph()
        {
            InitializeComponent();
        }
        private void SetSize()
        {
            zedGraphControl1.Location = new Point(10, 10);
            // Leave a small margin around the outside of the control
            zedGraphControl1.Size = new Size(ClientRectangle.Width - 5,
                                    ClientRectangle.Height - 5);
        }
        public void CreateSpeedGraph(ZedGraphControl zgc)
        {
            GraphPane djeasy = zgc.GraphPane;

            // Set the Titles
            djeasy.Title.Text = "Speed Graph";
            djeasy.XAxis.Title.Text = "Label";
            djeasy.YAxis.Title.Text = "Y Axis";

            // Make up some random data points
            string[] labels = { "Speed" };
            double[] y = { 100, 115, 75, 22 };
            double[] y2 = { 200, 150, 100, 50 };
            double[] y3 = { 300, 250, 200, 150 };
            double[] y4 = { 400, 350, 300, 250 };
            // Generate a red bar with "Curve 1" in the legend
            // Generate a blue bar with "Curve 2" in the legend
            BarItem myBar = djeasy.AddBar("Avg", null, y3, Color.Pink);
            myBar.Bar.Fill = new Fill(Color.Pink, Color.White,
                                                        Color.Pink);

            // Generate a blue bar with "Curve 2" in the legend
            myBar = djeasy.AddBar("Max", null, y2, Color.RosyBrown);
            myBar.Bar.Fill = new Fill(Color.RosyBrown, Color.White,
                                                        Color.RosyBrown);

            // Generate a green bar with "Curve 3" in the legend
            myBar = djeasy.AddBar("", null, y3, Color.RoyalBlue);
            myBar.Bar.Fill = new Fill(Color.RoyalBlue, Color.White,
                                                        Color.RoyalBlue);
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
        private void SpeedGraph_Load(object sender, EventArgs e)
        {
            CreateSpeedGraph(zedGraphControl1);
            SetSize();
        }
    }
}
