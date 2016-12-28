using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;
using System.Collections.Generic;
using static Cycling.Form1;

namespace Cycling
{
    public partial class SwitchGraph : Form
    {
        HrData graph = new HrData();
        List<HrData> Hrdata = new List<HrData>();
        public int Interval;
        GraphPane SwitchG;

        LineItem curve1;
        LineItem curve2;
        LineItem curve3;
        LineItem curve4;
        LineItem curve5;

        PointPairList list1 = new PointPairList();
        PointPairList list2 = new PointPairList();
        PointPairList list3 = new PointPairList();
        PointPairList list4 = new PointPairList();
        PointPairList list5 = new PointPairList();
        public SwitchGraph(List<HrData> data)
        {
            InitializeComponent();
            Hrdata = data;
            CreateGraph(zedGraphControl1);
          
        }
        public void CreateGraph(ZedGraphControl zedGraphControl1)
        {
            SwitchG = zedGraphControl1.GraphPane;

            SwitchG.Title.Text = "Cycle Data";
            SwitchG.XAxis.Title.Text = "Time (Secs)";
            SwitchG.YAxis.Title.Text = "Values";

            SwitchG.YAxis.Scale.Min = 10.0;
            SwitchG.YAxis.Scale.Max = 400.0;

            int length = Hrdata.Count;
            //int interval = int.Parse(graph.getInterval());
            int dat = length / 10, num = 0;
            SwitchG.XAxis.Scale.Min = 0;
            SwitchG.XAxis.Scale.Max = length + 30;

            // SET THE VALUES                    
            for (int i = 0; i < length; i += dat)
            {
                HrData fr = Hrdata[i];
                num++;
                int dj = num * dat;

                list1.Add(dj, fr.getHeartRate());
                list2.Add(dj, fr.getSpeed() / 10);
                list3.Add(dj, fr.getCadence());
                list4.Add(dj, fr.getAltitude());
                list5.Add(dj, fr.getPower());

            }

            curve1 = SwitchG.AddCurve(null, list1, Color.Black, SymbolType.None);
            curve2 = SwitchG.AddCurve(null, list2, Color.Navy, SymbolType.None);
            curve3 = SwitchG.AddCurve(null, list3, Color.DarkBlue, SymbolType.None);
            curve4 = SwitchG.AddCurve(null, list4, Color.DarkGreen, SymbolType.None);
            curve5 = SwitchG.AddCurve(null, list5, Color.DarkOrange, SymbolType.None);


            // draw 
            zedGraphControl1.AxisChange();

            // Change the color of the title
            SwitchG.Title.FontSpec.FontColor = Color.Green;

            // Add gridlines to the plot, and make them gray
            SwitchG.XAxis.MajorGrid.IsVisible = true;
            SwitchG.YAxis.MajorGrid.IsVisible = true;
            SwitchG.XAxis.MajorGrid.Color = Color.LightGray;
            SwitchG.YAxis.MajorGrid.Color = Color.LightGray;

            // Move the legend location
            SwitchG.Legend.Position = ZedGraph.LegendPos.Bottom;

            // Make both curves thicker
            curve1.Line.Width = 2.0F;
            curve2.Line.Width = 2.0F;
            curve3.Line.Width = 2.0F;
            curve4.Line.Width = 2.0F;
            curve5.Line.Width = 2.0F;


            // Add a background gradient fill to the axis frame
            SwitchG.Chart.Fill = new Fill(Color.White,
                Color.FromArgb(255, 255, 210), -45F);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            if (obj == null)
            {
                obj.Parent = this;
            }
            obj.Show();
            this.Close();
        }


        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (SwitchG.CurveList.Contains(curve1))
            {
                SwitchG.CurveList.Remove(curve1);
            }
            else
            {
                curve1 = SwitchG.AddCurve(null, list1, Color.Black, SymbolType.None);
            }

            SwitchG.AxisChange();
            zedGraphControl1.Refresh();
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (SwitchG.CurveList.Contains(curve5))
            {
                SwitchG.CurveList.Remove(curve5);
            }
            else
            {
                curve5 = SwitchG.AddCurve(null, list5, Color.DarkOrange, SymbolType.None);
            }

            SwitchG.AxisChange();
            zedGraphControl1.Refresh();
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {

            if (SwitchG.CurveList.Contains(curve4))
            {
                SwitchG.CurveList.Remove(curve4);
            }
            else
            {
                curve4 = SwitchG.AddCurve(null, list4, Color.DarkGreen, SymbolType.None);
            }

            SwitchG.AxisChange();
            zedGraphControl1.Refresh();
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (SwitchG.CurveList.Contains(curve3))
            {
                SwitchG.CurveList.Remove(curve3);
            }
            else
            {
                curve3 = SwitchG.AddCurve(null, list3, Color.DarkBlue, SymbolType.None);
            }

            SwitchG.AxisChange();
            zedGraphControl1.Refresh();
        }

        private void checkBox2_CheckedChanged_2(object sender, EventArgs e)
        {
            if (SwitchG.CurveList.Contains(curve2))
            {
                SwitchG.CurveList.Remove(curve2);
            }
            else
            {
                curve2 = SwitchG.AddCurve(null, list2, Color.DarkRed, SymbolType.None);
            }

            SwitchG.AxisChange();
            zedGraphControl1.Refresh();
        }
    }
    
    }

