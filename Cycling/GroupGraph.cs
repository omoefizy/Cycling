﻿using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Cycling
{
    public partial class GroupGraph : Form
    {
        public GroupGraph()
        {
            InitializeComponent();
        }
        private void SetSize()
        {
            zedGraphControl1.Location = new Point(10, 10);
            // Leave a small margin around the outside of the control
            zedGraphControl1.Size = new Size(ClientRectangle.Width - 25,
                                    ClientRectangle.Height -25);
        }

        // Respond to form 'Load' event
        // Build the Chart
        // SetSize() is separate from Resize() so we can 
        // call it independently from the Form1_Load() method
        // This leaves a 10 px margin around the outside of the control
        // Customize this to fit your needs

     
        private void CreateGraph(ZedGraphControl zgc)
        {
            // get a reference to the GraphPane
            GraphPane djeasy = zgc.GraphPane;

            // Set the Titles
            djeasy.Title.Text = "Summary For Grouped Graph";
            djeasy.XAxis.Title.Text = "Label";
            djeasy.YAxis.Title.Text = "Y Axis";

            // Make up some random data points
            string[] labels = { "Power", "Heart Rate", "Speed",
                      "Altitude"};
            double[] y = { 100, 115, 75, 22 };
            double[] y2 = { 200, 150, 100, 50 };
            double[] y3 = { 300, 250, 200, 150 };
            double[] y4 = { 400, 350, 300, 250 };

            // Generate a red bar with "Curve 1" in the legend
            BarItem myBar = djeasy.AddBar("Min", null, y,
                                                        Color.Red);
            myBar.Bar.Fill = new Fill(Color.Red, Color.White,
                                                        Color.Red);

            // Generate a blue bar with "Curve 2" in the legend
            myBar = djeasy.AddBar("Avg", null, y2, Color.Blue);
            myBar.Bar.Fill = new Fill(Color.Blue, Color.White,
                                                        Color.Blue);

            // Generate a green bar with "Curve 3" in the legend
            myBar = djeasy.AddBar("Max", null, y3, Color.Green);
            myBar.Bar.Fill = new Fill(Color.Green, Color.White,
                                                        Color.Green);

          

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

        private void GroupGraph_Load(object sender, EventArgs e)
        {
            // Setup the graph
            CreateGraph(zedGraphControl1);
            // Size the control to fill the form with a margin
            SetSize();
        }
    }
}
