namespace Cycling
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OsiMon = new System.Windows.Forms.Label();
            this.OsiVer = new System.Windows.Forms.Label();
            this.OsiVo2 = new System.Windows.Forms.Label();
            this.OsiSmo = new System.Windows.Forms.Label();
            this.OsiInt = new System.Windows.Forms.Label();
            this.OsiWei = new System.Windows.Forms.Label();
            this.OsiSta = new System.Windows.Forms.Label();
            this.OsiLen = new System.Windows.Forms.Label();
            this.OsiDat = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Avgpower = new System.Windows.Forms.TextBox();
            this.TotDC = new System.Windows.Forms.TextBox();
            this.Maxalt = new System.Windows.Forms.TextBox();
            this.Avgalt = new System.Windows.Forms.TextBox();
            this.Maxspeed = new System.Windows.Forms.TextBox();
            this.Avgspeed = new System.Windows.Forms.TextBox();
            this.MaxHR = new System.Windows.Forms.TextBox();
            this.AvgHR = new System.Windows.Forms.TextBox();
            this.MinHR = new System.Windows.Forms.TextBox();
            this.Maxpower = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heartRateGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altitudeGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupedGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(219, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 365);
            this.dataGridView1.TabIndex = 1;
            // 
            // OsiMon
            // 
            this.OsiMon.AutoSize = true;
            this.OsiMon.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsiMon.ForeColor = System.Drawing.Color.DarkBlue;
            this.OsiMon.Location = new System.Drawing.Point(230, 9);
            this.OsiMon.Name = "OsiMon";
            this.OsiMon.Size = new System.Drawing.Size(61, 18);
            this.OsiMon.TabIndex = 2;
            this.OsiMon.Text = "Monitor";
            // 
            // OsiVer
            // 
            this.OsiVer.AutoSize = true;
            this.OsiVer.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsiVer.ForeColor = System.Drawing.Color.Blue;
            this.OsiVer.Location = new System.Drawing.Point(530, 50);
            this.OsiVer.Name = "OsiVer";
            this.OsiVer.Size = new System.Drawing.Size(58, 18);
            this.OsiVer.TabIndex = 3;
            this.OsiVer.Text = "Version";
            // 
            // OsiVo2
            // 
            this.OsiVo2.AutoSize = true;
            this.OsiVo2.BackColor = System.Drawing.SystemColors.Menu;
            this.OsiVo2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsiVo2.ForeColor = System.Drawing.Color.DarkBlue;
            this.OsiVo2.Location = new System.Drawing.Point(874, 87);
            this.OsiVo2.Name = "OsiVo2";
            this.OsiVo2.Size = new System.Drawing.Size(64, 18);
            this.OsiVo2.TabIndex = 4;
            this.OsiVo2.Text = "VO2max";
            // 
            // OsiSmo
            // 
            this.OsiSmo.AutoSize = true;
            this.OsiSmo.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsiSmo.ForeColor = System.Drawing.Color.DarkBlue;
            this.OsiSmo.Location = new System.Drawing.Point(873, 12);
            this.OsiSmo.Name = "OsiSmo";
            this.OsiSmo.Size = new System.Drawing.Size(53, 18);
            this.OsiSmo.TabIndex = 5;
            this.OsiSmo.Text = "SMode";
            // 
            // OsiInt
            // 
            this.OsiInt.AutoSize = true;
            this.OsiInt.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsiInt.ForeColor = System.Drawing.Color.Blue;
            this.OsiInt.Location = new System.Drawing.Point(628, 87);
            this.OsiInt.Name = "OsiInt";
            this.OsiInt.Size = new System.Drawing.Size(63, 18);
            this.OsiInt.TabIndex = 6;
            this.OsiInt.Text = "Interval";
            // 
            // OsiWei
            // 
            this.OsiWei.AutoSize = true;
            this.OsiWei.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsiWei.ForeColor = System.Drawing.Color.Blue;
            this.OsiWei.Location = new System.Drawing.Point(628, 12);
            this.OsiWei.Name = "OsiWei";
            this.OsiWei.Size = new System.Drawing.Size(56, 18);
            this.OsiWei.TabIndex = 7;
            this.OsiWei.Text = "Weight";
            // 
            // OsiSta
            // 
            this.OsiSta.AutoSize = true;
            this.OsiSta.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsiSta.ForeColor = System.Drawing.Color.Blue;
            this.OsiSta.Location = new System.Drawing.Point(421, 87);
            this.OsiSta.Name = "OsiSta";
            this.OsiSta.Size = new System.Drawing.Size(78, 18);
            this.OsiSta.TabIndex = 8;
            this.OsiSta.Text = "Start Time";
            // 
            // OsiLen
            // 
            this.OsiLen.AutoSize = true;
            this.OsiLen.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsiLen.ForeColor = System.Drawing.Color.Blue;
            this.OsiLen.Location = new System.Drawing.Point(421, 9);
            this.OsiLen.Name = "OsiLen";
            this.OsiLen.Size = new System.Drawing.Size(54, 18);
            this.OsiLen.TabIndex = 9;
            this.OsiLen.Text = "Length";
            // 
            // OsiDat
            // 
            this.OsiDat.AutoSize = true;
            this.OsiDat.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsiDat.ForeColor = System.Drawing.Color.DarkBlue;
            this.OsiDat.Location = new System.Drawing.Point(215, 87);
            this.OsiDat.Name = "OsiDat";
            this.OsiDat.Size = new System.Drawing.Size(40, 18);
            this.OsiDat.TabIndex = 10;
            this.OsiDat.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(8, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Total Dist. Covered";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(8, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Max. Altitude";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(8, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Avg. Altitude";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(8, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "Max. Speed";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(8, 333);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Avg. Speed";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(8, 297);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 17);
            this.label15.TabIndex = 18;
            this.label15.Text = "Max. Heart Rate ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(8, 264);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 17);
            this.label16.TabIndex = 19;
            this.label16.Text = "Avg. Heart Rate";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(8, 230);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 17);
            this.label17.TabIndex = 20;
            this.label17.Text = "Min. Heart Rate ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(8, 196);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 17);
            this.label18.TabIndex = 21;
            this.label18.Text = "Max. Power";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(8, 161);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 17);
            this.label19.TabIndex = 22;
            this.label19.Text = "Avg. Power";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(8, 123);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 22);
            this.label20.TabIndex = 23;
            this.label20.Text = "Display ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(91, 128);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 17);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Miles";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(151, 127);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Metres";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Avgpower
            // 
            this.Avgpower.Location = new System.Drawing.Point(114, 160);
            this.Avgpower.Name = "Avgpower";
            this.Avgpower.Size = new System.Drawing.Size(100, 20);
            this.Avgpower.TabIndex = 26;
            // 
            // TotDC
            // 
            this.TotDC.Location = new System.Drawing.Point(148, 466);
            this.TotDC.Name = "TotDC";
            this.TotDC.Size = new System.Drawing.Size(66, 20);
            this.TotDC.TabIndex = 27;
            // 
            // Maxalt
            // 
            this.Maxalt.Location = new System.Drawing.Point(114, 433);
            this.Maxalt.Name = "Maxalt";
            this.Maxalt.Size = new System.Drawing.Size(100, 20);
            this.Maxalt.TabIndex = 28;
            // 
            // Avgalt
            // 
            this.Avgalt.Location = new System.Drawing.Point(114, 395);
            this.Avgalt.Name = "Avgalt";
            this.Avgalt.Size = new System.Drawing.Size(100, 20);
            this.Avgalt.TabIndex = 29;
            // 
            // Maxspeed
            // 
            this.Maxspeed.Location = new System.Drawing.Point(114, 365);
            this.Maxspeed.Name = "Maxspeed";
            this.Maxspeed.Size = new System.Drawing.Size(100, 20);
            this.Maxspeed.TabIndex = 30;
            // 
            // Avgspeed
            // 
            this.Avgspeed.Location = new System.Drawing.Point(114, 332);
            this.Avgspeed.Name = "Avgspeed";
            this.Avgspeed.Size = new System.Drawing.Size(100, 20);
            this.Avgspeed.TabIndex = 31;
            // 
            // MaxHR
            // 
            this.MaxHR.Location = new System.Drawing.Point(131, 294);
            this.MaxHR.Name = "MaxHR";
            this.MaxHR.Size = new System.Drawing.Size(83, 20);
            this.MaxHR.TabIndex = 32;
            // 
            // AvgHR
            // 
            this.AvgHR.Location = new System.Drawing.Point(131, 256);
            this.AvgHR.Name = "AvgHR";
            this.AvgHR.Size = new System.Drawing.Size(83, 20);
            this.AvgHR.TabIndex = 33;
            // 
            // MinHR
            // 
            this.MinHR.Location = new System.Drawing.Point(131, 227);
            this.MinHR.Name = "MinHR";
            this.MinHR.Size = new System.Drawing.Size(83, 20);
            this.MinHR.TabIndex = 34;
            // 
            // Maxpower
            // 
            this.Maxpower.Location = new System.Drawing.Point(113, 193);
            this.Maxpower.Name = "Maxpower";
            this.Maxpower.Size = new System.Drawing.Size(100, 20);
            this.Maxpower.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Monitor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(361, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Length :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(169, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(337, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = "Start Time :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(466, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "Version :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(566, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Weight :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(559, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 43;
            this.label7.Text = "Interval :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(815, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 44;
            this.label8.Text = "SMode :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Menu;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(804, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 45;
            this.label9.Text = "VO2max :";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(932, 123);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(431, 363);
            this.zedGraphControl1.TabIndex = 46;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.graphsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFilesToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // openFilesToolStripMenuItem
            // 
            this.openFilesToolStripMenuItem.Name = "openFilesToolStripMenuItem";
            this.openFilesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openFilesToolStripMenuItem.Text = "Open Files";
            this.openFilesToolStripMenuItem.Click += new System.EventHandler(this.openFilesToolStripMenuItem_Click);
            // 
            // graphsToolStripMenuItem
            // 
            this.graphsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powerGraphToolStripMenuItem,
            this.heartRateGraphToolStripMenuItem,
            this.speedGraphToolStripMenuItem,
            this.altitudeGraphToolStripMenuItem,
            this.groupedGraphToolStripMenuItem});
            this.graphsToolStripMenuItem.Name = "graphsToolStripMenuItem";
            this.graphsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.graphsToolStripMenuItem.Text = "Switch Graph";
            // 
            // powerGraphToolStripMenuItem
            // 
            this.powerGraphToolStripMenuItem.Name = "powerGraphToolStripMenuItem";
            this.powerGraphToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.powerGraphToolStripMenuItem.Text = "Power Graph";
            this.powerGraphToolStripMenuItem.Click += new System.EventHandler(this.powerGraphToolStripMenuItem_Click);
            // 
            // heartRateGraphToolStripMenuItem
            // 
            this.heartRateGraphToolStripMenuItem.Name = "heartRateGraphToolStripMenuItem";
            this.heartRateGraphToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.heartRateGraphToolStripMenuItem.Text = "Heart Rate Graph";
            this.heartRateGraphToolStripMenuItem.Click += new System.EventHandler(this.heartRateGraphToolStripMenuItem_Click);
            // 
            // speedGraphToolStripMenuItem
            // 
            this.speedGraphToolStripMenuItem.Name = "speedGraphToolStripMenuItem";
            this.speedGraphToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.speedGraphToolStripMenuItem.Text = "Speed Graph";
            this.speedGraphToolStripMenuItem.Click += new System.EventHandler(this.speedGraphToolStripMenuItem_Click);
            // 
            // altitudeGraphToolStripMenuItem
            // 
            this.altitudeGraphToolStripMenuItem.Name = "altitudeGraphToolStripMenuItem";
            this.altitudeGraphToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.altitudeGraphToolStripMenuItem.Text = "Altitude Graph";
            this.altitudeGraphToolStripMenuItem.Click += new System.EventHandler(this.altitudeGraphToolStripMenuItem_Click);
            // 
            // groupedGraphToolStripMenuItem
            // 
            this.groupedGraphToolStripMenuItem.Name = "groupedGraphToolStripMenuItem";
            this.groupedGraphToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.groupedGraphToolStripMenuItem.Text = "Grouped Graph";
            this.groupedGraphToolStripMenuItem.Click += new System.EventHandler(this.groupedGraphToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 507);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Maxpower);
            this.Controls.Add(this.MinHR);
            this.Controls.Add(this.AvgHR);
            this.Controls.Add(this.MaxHR);
            this.Controls.Add(this.Avgspeed);
            this.Controls.Add(this.Maxspeed);
            this.Controls.Add(this.Avgalt);
            this.Controls.Add(this.Maxalt);
            this.Controls.Add(this.TotDC);
            this.Controls.Add(this.Avgpower);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.OsiDat);
            this.Controls.Add(this.OsiLen);
            this.Controls.Add(this.OsiSta);
            this.Controls.Add(this.OsiWei);
            this.Controls.Add(this.OsiInt);
            this.Controls.Add(this.OsiSmo);
            this.Controls.Add(this.OsiVo2);
            this.Controls.Add(this.OsiVer);
            this.Controls.Add(this.OsiMon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cycling Computer Trainning Software";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label OsiMon;
        private System.Windows.Forms.Label OsiVer;
        private System.Windows.Forms.Label OsiVo2;
        private System.Windows.Forms.Label OsiSmo;
        private System.Windows.Forms.Label OsiInt;
        private System.Windows.Forms.Label OsiWei;
        private System.Windows.Forms.Label OsiSta;
        private System.Windows.Forms.Label OsiLen;
        private System.Windows.Forms.Label OsiDat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox Avgpower;
        private System.Windows.Forms.TextBox TotDC;
        private System.Windows.Forms.TextBox Maxalt;
        private System.Windows.Forms.TextBox Avgalt;
        private System.Windows.Forms.TextBox Maxspeed;
        private System.Windows.Forms.TextBox Avgspeed;
        private System.Windows.Forms.TextBox MaxHR;
        private System.Windows.Forms.TextBox AvgHR;
        private System.Windows.Forms.TextBox MinHR;
        private System.Windows.Forms.TextBox Maxpower;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heartRateGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speedGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altitudeGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupedGraphToolStripMenuItem;
    }
}

