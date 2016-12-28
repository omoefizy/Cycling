using System;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace Cycling
{
    public partial class Form1 : Form
    {
        
        string O = "CData";
        public string hrData = "[HRData]";
        string Params = "[Params]";
        string[] data;
        string heading = "";
       public List<HrData> Hrdata = new List<HrData>();
       public HrData osiData;
        DataSet osi = new DataSet();
        int interval;
        int duration;
        double Avp;
        // Private variables
        private double durations = 0;
        public DateTime startDateTime;
        private int[] smode = new int[8];
        private int frequency = 0, startYear = 0, startMonth = 0, startDay = 0;
        public int[] heartRate, speed, cadence, altitude, power, pedallingIndex, lrbalanceLeftLeg;
        private string startTimeText, durationText;
        public DateTime startDate, durationDateTime;

        public static Form1 djeasy = new Form1();

       

        //int Avgpower = p;
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
                        interval = Convert.ToInt32(paramsValue[1]);
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
                        osiData.getCadence(), osiData.getAltitude(), osiData.getPower(),
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
   
        public int getAltitude()
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
            
            Avp = dataGridView1.Rows.Cast<DataGridViewRow>()
            .AsEnumerable().Average(x => Convert.ToInt32(x.Cells[4].Value));
            Avgpower.Text = Avp.ToString();
            Maxalt.Text = dataGridView1.Rows.Cast<DataGridViewRow>()
            .AsEnumerable().Max(x => Convert.ToInt32(x.Cells[3].Value)).ToString();

            Avgalt.Text = dataGridView1.Rows.Cast<DataGridViewRow>()
           .AsEnumerable().Average(x => Convert.ToInt32(x.Cells[3].Value)).ToString();

            string omo = dataGridView1.Rows.Cast<DataGridViewRow>()
            .AsEnumerable().Sum(x => Convert.ToInt32(x.Cells[1].Value)).ToString();

            TotDC.Text = omo;

            List<double> listnp = new List<double>();
            List<double> calaverage = new List<double>();
            for (int i = 0; i < Hrdata.Count; i++)
            {
                osiData = Hrdata[i];
                listnp.Add(osiData.getPower());
                if (i % 30 / interval == 0 && i > 0)
                {
                    double total = 0;
                    for (int Dj = 0; Dj < listnp.Count; Dj++)
                    {
                        listnp[Dj] = Math.Pow(listnp[Dj], 4);
                        total += listnp[Dj];
                        listnp.Clear();
                    }
                    calaverage.Add(total);
                }
            }

            double maxp = 0;
            for (int i = 0; i < calaverage.Count; i++)
            {
                maxp += calaverage[i];
            }
            maxp /= calaverage.Count;
            duration = Hrdata.Count * interval;
            double nPower = Math.Round(Math.Pow(maxp, 1 / 4.0), 2);
            omobo.Text = nPower.ToString();
            double iF = Avp / nPower;
            ebi.Text = iF.ToString();
            double TSS = (duration * nPower * iF) / (Avp * 3600) * 100;
            eazi.Text = TSS.ToString();

        }
        private void Selectobject(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 1)
            {
                Maxspeed.Text = dataGridView1.SelectedRows.Cast<DataGridViewRow>()
          .AsEnumerable().Max(x => Convert.ToInt32(x.Cells[1].Value)).ToString();

                Avgspeed.Text = dataGridView1.SelectedRows.Cast<DataGridViewRow>()
               .AsEnumerable().Average(x => Convert.ToInt32(x.Cells[1].Value)).ToString();

                MaxHR.Text = dataGridView1.SelectedRows.Cast<DataGridViewRow>()
                .AsEnumerable().Max(x => Convert.ToInt32(x.Cells[0].Value)).ToString();

                AvgHR.Text = dataGridView1.SelectedRows.Cast<DataGridViewRow>()
                .AsEnumerable().Average(x => Convert.ToInt32(x.Cells[0].Value)).ToString();

                MinHR.Text = dataGridView1.SelectedRows.Cast<DataGridViewRow>()
               .AsEnumerable().Min(x => Convert.ToInt32(x.Cells[0].Value)).ToString();

                Maxpower.Text = dataGridView1.SelectedRows.Cast<DataGridViewRow>()
               .AsEnumerable().Max(x => Convert.ToInt32(x.Cells[4].Value)).ToString();

                Avgpower.Text = dataGridView1.SelectedRows.Cast<DataGridViewRow>()
                .AsEnumerable().Average(x => Convert.ToInt32(x.Cells[4].Value)).ToString();

                Maxalt.Text = dataGridView1.SelectedRows.Cast<DataGridViewRow>()
                .AsEnumerable().Max(x => Convert.ToInt32(x.Cells[3].Value)).ToString();

                Avgalt.Text = dataGridView1.SelectedRows.Cast<DataGridViewRow>()
               .AsEnumerable().Average(x => Convert.ToInt32(x.Cells[3].Value)).ToString();

                string omo = dataGridView1.SelectedRows.Cast<DataGridViewRow>()
                .AsEnumerable().Sum(x => Convert.ToInt32(x.Cells[1].Value)).ToString();

                TotDC.Text = omo;
            }
        }
            

        private void groupedGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupGraph group = new GroupGraph();
            group.Show();
        }
        
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

        private void graphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchGraph form = new SwitchGraph(Hrdata);
            form.Show();
        }

        private static double radioButton1_CheckedChanged(double meters)
        {
            return (meters / 1609.344);
           
    }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
 
        }
        public static double ConvertMilesToMeters(double distance)
        {
            return Math.Round((double)(distance) * 1609.34, 2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void calendarEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calendar cal = new Calendar();
            cal.Show();
        }

    }

}
