using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Cycling
{
    public partial class PowerGraph : Form
    {
        public PowerGraph()
        {
            InitializeComponent();
        }
        public void PowerGraphs(ZedGraphControl zgc)
        {
            GraphPane myPane = zgc.GraphPane;

            // Set the Titles
            myPane.Title.Text = "Power Graph";
            myPane.XAxis.Title.Text = "Label";
            myPane.YAxis.Title.Text = "Y Axis";

            // Make up some random data points
            string[] labels = { "Power" };
            double[] y = { 100, 115, 75, 22 };
            // Generate a red bar with "Curve 1" in the legend
            BarItem myBar = myPane.AddBar("Curve 1", null, y,
                                                        Color.Red);
            myBar.Bar.Fill = new Fill(Color.Red, Color.White,
                                                        Color.Red);

            // Fix up the curve attributes a little
            /*myCurve.Symbol.Size = 8.0F;
            myCurve.Symbol.Fill = new Fill(Color.White);
            myCurve.Line.Width = 2.0F;*/

            // Draw the X tics between the labels instead of 
            // at the labels
            myPane.XAxis.MajorTic.IsBetweenLabels = true;

            // Set the XAxis labels
            myPane.XAxis.Scale.TextLabels = labels;
            // Set the XAxis to Text type
            myPane.XAxis.Type = AxisType.Text;

            // Fill the Axis and Pane backgrounds
            myPane.Chart.Fill = new Fill(Color.White,
                  Color.FromArgb(255, 255, 166), 90F);
            myPane.Fill = new Fill(Color.FromArgb(250, 250, 255));


            // Tell ZedGraph to refigure the
            // axes since the data have changed
            zgc.AxisChange();
        }
        private void powerGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerGraphs(zedGraphControl1);
            // Size the control to fill the form with a margin
            SetSize();
           
        }
        private void SetSize()
        {
            zedGraphControl1.Location = new Point(10, 10);
            // Leave a small margin around the outside of the control
            zedGraphControl1.Size = new Size(ClientRectangle.Width - 5,
                                    ClientRectangle.Height - 5);
        }
    }

}
