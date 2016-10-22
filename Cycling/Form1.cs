using System;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Collections.Generic;

namespace Cycling
{
    public partial class Form1 : Form
    {
        DataSet table = new DataSet();
        string T = "CData";
        string hrData = "[HRData]";
        string Params = "[Params]";
        string[] data;
        string heading = "";
        List<HrData> Hrdata = new List<HrData>();
        HrData newdata;

        public Form1()
        {
            InitializeComponent();
            table.Reset();
            table.Tables.Add(T);
            table.Tables[0].Columns.Add("Heart Rate");
            table.Tables[0].Columns.Add("Speed");
            table.Tables[0].Columns.Add("Cadence");
            table.Tables[0].Columns.Add("Altitude");
            table.Tables[0].Columns.Add("Power");
            table.Tables[0].Columns.Add("PowerBalance");


            this.dataGridView1.DataSource = table.Tables[T].DefaultView;
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
                    newdata = new HrData();
                    newdata.setEntry(int.Parse(rowItems[0]), int.Parse(rowItems[1]),
                        int.Parse(rowItems[2]), int.Parse(rowItems[3]),
                        int.Parse(rowItems[4]), int.Parse(rowItems[5]));
                    Hrdata.Add(newdata);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
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
                        table.Tables[T].Rows.Clear();
                        displayData();
                        readDisplayParams(data);
                        //displaySummary();
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
                newdata = Hrdata[i];
                table.Tables[T].Rows.Add(newdata.getHeartRate(), newdata.getSpeed(),
                        newdata.getCadence(), newdata.getAscent(), newdata.getPower(),
                        newdata.getPowerBal());
            }


        }
        public class HrData
        {
            int heartRate = 0;
            int speed = 0;
            int cadence = 0;
            int alt = 0;
            int power = 0;
            int powerBal = 0;

            public void setEntry(int heartRate, int speed, int cadence, int altitude, int power, int powerBal)
            {
                this.heartRate = heartRate;
                this.speed = speed;
                this.cadence = cadence;
                this.alt = altitude;
                this.power = power;
                this.powerBal = powerBal;
            }

            internal object getCadence()
            {
                throw new NotImplementedException();
            }

            internal DataRow getHeartRate()
            {
                throw new NotImplementedException();
            }

            internal object getSpeed()
            {
                throw new NotImplementedException();
            }

            internal object getAscent()
            {
                throw new NotImplementedException();
            }

            internal object getPower()
            {
                throw new NotImplementedException();
            }

            internal object getPowerBal()
            {
                throw new NotImplementedException();
            }
        }
    }
}
