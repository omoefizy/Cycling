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
        
        string O = "CData";
        string hrData = "[HRData]";
        string Params = "[Params]";
        string[] data;
        string heading = "";
        List<HrData> Hrdata = new List<HrData>();
        HrData osiData;
        DataSet osi = new DataSet();
        public Form1()
        {
            InitializeComponent();
            osi.Reset();
            osi.Tables.Add(O);
            osi.Tables[0].Columns.Add("Heart Rate");
            osi.Tables[0].Columns.Add("Speed");
            osi.Tables[0].Columns.Add("Cadence");
            osi.Tables[0].Columns.Add("Altitude");
            osi.Tables[0].Columns.Add("Power");
            osi.Tables[0].Columns.Add("PowerBalance");


            this.dataGridView1.DataSource = osi.Tables[O].DefaultView;

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
                    osiData = new HrData();
                    osiData.setEntry(int.Parse(rowItems[0]), int.Parse(rowItems[1]),
                        int.Parse(rowItems[2]), int.Parse(rowItems[3]),
                        int.Parse(rowItems[4]), int.Parse(rowItems[5]));
                    Hrdata.Add(osiData);
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
                        osi.Tables[O].Rows.Clear();
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
                osiData = Hrdata[i];
                osi.Tables[O].Rows.Add(osiData.getHeartRate(), osiData.getSpeed(),
                        osiData.getCadence(), osiData.getAscent(), osiData.getPower(),
                        osiData.getPowerBal());
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
            GroupGraph group = new GroupGraph();
            group.Show();
        }
        // Build the Chart
        // SetSize() is separate from Resize() so we can 
        // call it independently from the Form1_Load() method
        // This leaves a 10 px margin around the outside of the control
        // Customize this to fit your needs
   
        //Switches of different Graph
        private void powerGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerGraph power = new PowerGraph();
            power.Show();
        }
       
        private void heartRateGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HeartGraph heart = new HeartGraph();
            heart.Show();
        }

       
        private void speedGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeedGraph speed = new SpeedGraph();
            speed.Show();
        }
      
        private void altitudeGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltitudeGraph Alt = new AltitudeGraph();
            Alt.Show();
        }
             
    }

}
