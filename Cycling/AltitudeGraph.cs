using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;


namespace Cycling
{
    public partial class AltitudeGraph : Form
    {
        public AltitudeGraph()
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
        public void CreateAltitudeGraph(ZedGraphControl zgc)
        {
            GraphPane djeasy = zgc.GraphPane;

            // Set the Titles
            djeasy.Title.Text = "Altitude Graph";
            djeasy.XAxis.Title.Text = "Label";
            djeasy.YAxis.Title.Text = "Y Axis";

            // Make up some random data points
            string[] labels = { "Altitude" };
            double[] y = { 100, 115, 75, 22 };
            double[] y2 = { 200, 150, 100, 50 };
            double[] y3 = { 300, 250, 200, 150 };
            double[] y4 = { 400, 350, 300, 250 };

            // Generate a red bar with "Curve 1" in the legend
            // Generate a blue bar with "Curve 2" in the legend
            BarItem myBar = djeasy.AddBar("Curve 4", null, y4, Color.Black);
            myBar.Bar.Fill = new Fill(Color.Black, Color.White,
                                                        Color.Black);

            // Generate a blue bar with "Curve 2" in the legend
            myBar = djeasy.AddBar("Curve 2", null, y2, Color.PaleGreen);
            myBar.Bar.Fill = new Fill(Color.PaleGreen, Color.White,
                                                        Color.PaleGreen);

            // Generate a green bar with "Curve 3" in the legend
            myBar = djeasy.AddBar("Curve 3", null, y3, Color.Gray);
            myBar.Bar.Fill = new Fill(Color.Gray, Color.White,
                                                        Color.Gray);
            /*LineItem myCurve = djeasy.AddCurve("Curve 4",
                 null, y5, Color.Black, SymbolType.Circle);
            myCurve.Line.Fill = new Fill(Color.White,
                                  Color.LightSkyBlue, -45F);
            // Fix up the curve attributes a little
            myCurve.Symbol.Size = 8.0F;
            myCurve.Symbol.Fill = new Fill(Color.White);
            myCurve.Line.Width = 2.0F; */

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
        private void AltitudeGraph_Load(object sender, EventArgs e)
        {
            CreateAltitudeGraph(zedGraphControl1);
            // Size the control to fill the form with a margin
            SetSize();
        }
    }
}
