using System;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using ZedGraph;
using System.Drawing;

namespace Cycling
{
    public partial class Form1 : Form
    {
        
        string T = "CData";
        string hrData = "[HRData]";
        string Params = "[Params]";
        string[] data;
        string heading = "";
        List<HrData> Hrdata = new List<HrData>();
        HrData osidata;
        DataSet osi = new DataSet();
        public Form1()
        {
            InitializeComponent();
            osi.Reset();
            osi.Tables.Add(T);
            osi.Tables[0].Columns.Add("Heart Rate");
            osi.Tables[0].Columns.Add("Speed");
            osi.Tables[0].Columns.Add("Cadence");
            osi.Tables[0].Columns.Add("Altitude");
            osi.Tables[0].Columns.Add("Power");
            osi.Tables[0].Columns.Add("PowerBalance");


            this.dataGridView1.DataSource = osi.Tables[T].DefaultView;

        }

       

        public void readDisplayParams(string[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {

                if (data[i] == Params)
                {
                    heading = Params;
                    i++;
                }

                if (heading == Params)
                {
                    string[] paramsValue = data[i].Split('=');
                    if (paramsValue[0] == "Version")
                    {
                        OsiVer.Text = (paramsValue[1]);
                    }
                    if (paramsValue[0] == "Monitor")
                    {
                        OsiMon.Text = (paramsValue[1]);
                    }
                    if (paramsValue[0] == "SMode")
                    {
                        OsiSmo.Text = (paramsValue[1]);
                    }
                    if (paramsValue[0] == "Date")
                    {
                        OsiDat.Text = (paramsValue[1]);
                    }
                    if (paramsValue[0] == "StartTime")
                    {
                        OsiSta.Text = (paramsValue[1]);
                    }
                    if (paramsValue[0] == "Length")
                    {
                        OsiLen.Text = (paramsValue[1]);
                    }
                    if (paramsValue[0] == "Weight")
                    {
                        OsiWei.Text = (paramsValue[1]);
                    }
                    if (paramsValue[0] == "VO2max")
                    {
                        OsiVo2.Text = (paramsValue[1]);
                    }
                    if (paramsValue[0] == "Interval")
                    {
                        OsiInt.Text = (paramsValue[1]);
                    }

                }
            }
        }
        public void readData(string[] data)
        {

            for (int i = 0; i < data.Length; i++)
            {

                if (data[i] == hrData)
                {
                    heading = hrData;
                    i++;
                }

                if (heading == hrData)
                {

                    string[] rowItems = data[i].Split(null);
                    osidata = new HrData();
                    osidata.setEntry(int.Parse(rowItems[0]), int.Parse(rowItems[1]),
                        int.Parse(rowItems[2]), int.Parse(rowItems[3]),
                        int.Parse(rowItems[4]), int.Parse(rowItems[5]));
                    Hrdata.Add(osidata);
                }
            }
        }
        private void openFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())

            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string filename = open.FileName;
                    data = File.ReadAllLines(filename);
                    if (data.Length > 0)
                    {
                        readData(data);
                        osi.Tables[T].Rows.Clear();
                        displayData();
                        readDisplayParams(data);
                        displaySummary();
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }

                }
            }
        }      
        public void displayData()
        {
            for (int i = 0; i < Hrdata.Count; i++)
            {
                osidata = Hrdata[i];
                osi.Tables[T].Rows.Add(osidata.getHeartRate(), osidata.getSpeed(),
                        osidata.getCadence(), osidata.getAscent(), osidata.getPower(),
                        osidata.getPowerBal());
            }


        }
        public class HrData
    {
        int heartRate = 0;
        int speed =0;
        int cadence =0;
        int alt =0;
        int power =0;
        int powerBal =0;

        public void setEntry(int heartRate, int speed, int cadence, int altitude, int power, int powerBal)
        {
            this.heartRate = heartRate;
            this.speed = speed;
            this.cadence = cadence;
            this.alt = altitude;
            this.power = power;
            this.powerBal = powerBal;
        }

        public string getEntry()
        {
            string getData = getHeartRate() + ", " + getSpeed() + ", " + cadence + ", " + alt + ", " + power + ", " + powerBal + " ||";
            return getData;
        }


        public int getHeartRate()
        {
            return heartRate;
        }
        public int getSpeed()
        {
            return speed;
        }
        public int getCadence()
        {
            return cadence;
        }
        public int getAscent()
        {
            return alt;
        }
        public int getPower()
        {
            return power;
        }
        public int getPowerBal()
        {
            return powerBal;
        }
        }
      public void displaySummary()
        {
            Maxspeed.Text = dataGridView1.Rows.Cast<DataGridViewRow>()
           .AsEnumerable().Max(x => Convert.ToInt32(x.Cells[1].Value)).ToString();

            Avgspeed.Text = dataGridView1.Rows.Cast<DataGridViewRow>()
           .AsEnumerable().Average(x => Convert.ToInt32(x.Cells[1].Value)).ToString();

            MaxHR.Text = dataGridView1.Rows.Cast<DataGridViewRow>()
            .AsEnumerable().Max(x => Convert.ToInt32(x.Cells[0].Value)).ToString();

            AvgHR.Text = dataGridView1.Rows.Cast<DataGridViewRow>()
            .AsEnumerable().Average(x => Convert.ToInt32(x.Cells[0].Value)).ToString();

            MinHR.Text = dataGridView1.Rows.Cast<DataGridViewRow>()
           .AsEnumerable().Min(x => Convert.ToInt32(x.Cells[0].Value)).ToString();

            Maxpower.Text = dataGridView1.Rows.Cast<DataGridViewRow>()
           .AsEnumerable().Max(x => Convert.ToInt32(x.Cells[4].Value)).ToString();

            Avgpower.Text = dataGridView1.Rows.Cast<DataGridViewRow>()
            .AsEnumerable().Average(x => Convert.ToInt32(x.Cells[4].Value)).ToString();

            Maxalt.Text = dataGridView1.Rows.Cast<DataGridViewRow>()
            .AsEnumerable().Max(x => Convert.ToInt32(x.Cells[3].Value)).ToString();

            Avgalt.Text = dataGridView1.Rows.Cast<DataGridViewRow>()
           .AsEnumerable().Average(x => Convert.ToInt32(x.Cells[3].Value)).ToString();

            string omo = dataGridView1.Rows.Cast<DataGridViewRow>()
            .AsEnumerable().Sum(x => Convert.ToInt32(x.Cells[1].Value)).ToString();

            TotDC.Text = omo;
           

        }
        private void groupedGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Setup the graph
            CreateGraph(zedGraphControl1);
            // Size the control to fill the form with a margin
            SetSize();
            displaySummary();
        }
        // Build the Chart
        // SetSize() is separate from Resize() so we can 
        // call it independently from the Form1_Load() method
        // This leaves a 10 px margin around the outside of the control
        // Customize this to fit your needs
        private void SetSize()
    {
        zedGraphControl1.Location = new Point(10, 10);
        // Leave a small margin around the outside of the control
        zedGraphControl1.Size = new Size(ClientRectangle.Width - 5,
                                ClientRectangle.Height - 5);
    }

    // Respond to form 'Load' event

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
            double[] y = { 100, 115, 75, 22};
            double[] y2 = { 200, 150, 100, 50};
            double[] y3 = { 300, 250, 200, 150};
            double[] y4 = { 400, 350, 300, 250};

            // Generate a red bar with "Curve 1" in the legend
            BarItem myBar = djeasy.AddBar("Curve 1", null, y,
                                                        Color.Red);
            myBar.Bar.Fill = new Fill(Color.Red, Color.White,
                                                        Color.Red);

            // Generate a blue bar with "Curve 2" in the legend
            myBar = djeasy.AddBar("Curve 2", null, y2, Color.Blue);
            myBar.Bar.Fill = new Fill(Color.Blue, Color.White,
                                                        Color.Blue);

            // Generate a green bar with "Curve 3" in the legend
            myBar = djeasy.AddBar("Curve 3", null, y3, Color.Green);
            myBar.Bar.Fill = new Fill(Color.Green, Color.White,
                                                        Color.Green);

            // Generate a black line with "Curve 4" in the legend
            LineItem myCurve = djeasy.AddCurve("Curve 4",
                  null, y4, Color.Black, SymbolType.Circle);
            myCurve.Line.Fill = new Fill(Color.White,
                                  Color.LightSkyBlue, -45F);

            // Fix up the curve attributes a little
            myCurve.Symbol.Size = 8.0F;
            myCurve.Symbol.Fill = new Fill(Color.White);
            myCurve.Line.Width = 2.0F;

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

        //Switches of different Graph
        public void PowerGraph(ZedGraphControl zgc)
        {
            GraphPane djeasy = zgc.GraphPane;

            // Set the Titles
            djeasy.Title.Text = "Power Graph";
            djeasy.XAxis.Title.Text = "Label";
            djeasy.YAxis.Title.Text = "Y Axis";

            // Make up some random data points
            string[] labels = { "Power" };
            double[] y = { 100, 115, 75, 22 };
            // Generate a red bar with "Curve 1" in the legend
            BarItem myBar = djeasy.AddBar("Curve 1", null, y,
                                                        Color.Red);
            myBar.Bar.Fill = new Fill(Color.Red, Color.White,
                                                        Color.Red);

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
        private void powerGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerGraph(zedGraphControl1);
            // Size the control to fill the form with a margin
            SetSize();
            PowerGraph power = new PowerGraph();
            power.Show();
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
            double[] y2 = { 90, 100, 95, 35 };
            // Generate a red bar with "Curve 1" in the legend
            // Generate a blue bar with "Curve 2" in the legend
            BarItem myBar = djeasy.AddBar("Curve 2", null, y2, Color.Blue);
            myBar.Bar.Fill = new Fill(Color.Blue, Color.White,
                                                        Color.Blue);
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
        private void heartRateGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateHeartGraph(zedGraphControl1);
            // Size the control to fill the form with a margin
            SetSize();
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
            double[] y3 = { 80, 110, 65, 15 };
            // Generate a red bar with "Curve 1" in the legend
            // Generate a blue bar with "Curve 2" in the legend
            BarItem myBar = djeasy.AddBar("Curve 3", null, y3, Color.Green);
            myBar.Bar.Fill = new Fill(Color.Green, Color.White,
                                                        Color.Green);
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
        private void speedGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateSpeedGraph(zedGraphControl1);
            // Size the control to fill the form with a margin
            SetSize();
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
            double[] y5 = { 100, 130, 95, 45 };
            // Generate a red bar with "Curve 1" in the legend
            // Generate a blue bar with "Curve 2" in the legend
            BarItem myBar = djeasy.AddBar("Curve 4", null, y5, Color.Black);
            myBar.Bar.Fill = new Fill(Color.Black, Color.White,
                                                        Color.Black);
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
        private void altitudeGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAltitudeGraph(zedGraphControl1);
            // Size the control to fill the form with a margin
            SetSize();
        }
        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        
    }

}
