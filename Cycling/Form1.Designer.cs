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
            this.button1 = new System.Windows.Forms.Button();
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Files ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(791, 365);
            this.dataGridView1.TabIndex = 1;
            // 
            // OsiMon
            // 
            this.OsiMon.AutoSize = true;
            this.OsiMon.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsiMon.ForeColor = System.Drawing.Color.DarkBlue;
            this.OsiMon.Location = new System.Drawing.Point(215, 9);
            this.OsiMon.Name = "OsiMon";
            this.OsiMon.Size = new System.Drawing.Size(75, 22);
            this.OsiMon.TabIndex = 2;
            this.OsiMon.Text = "Monitor";
            // 
            // OsiVer
            // 
            this.OsiVer.AutoSize = true;
            this.OsiVer.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsiVer.ForeColor = System.Drawing.Color.Blue;
            this.OsiVer.Location = new System.Drawing.Point(530, 50);
            this.OsiVer.Name = "OsiVer";
            this.OsiVer.Size = new System.Drawing.Size(70, 22);
            this.OsiVer.TabIndex = 3;
            this.OsiVer.Text = "Version";
            // 
            // OsiVo2
            // 
            this.OsiVo2.AutoSize = true;
            this.OsiVo2.BackColor = System.Drawing.SystemColors.Menu;
            this.OsiVo2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsiVo2.ForeColor = System.Drawing.Color.DarkBlue;
            this.OsiVo2.Location = new System.Drawing.Point(874, 87);
            this.OsiVo2.Name = "OsiVo2";
            this.OsiVo2.Size = new System.Drawing.Size(76, 22);
            this.OsiVo2.TabIndex = 4;
            this.OsiVo2.Text = "VO2max";
            // 
            // OsiSmo
            // 
            this.OsiSmo.AutoSize = true;
            this.OsiSmo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsiSmo.ForeColor = System.Drawing.Color.DarkBlue;
            this.OsiSmo.Location = new System.Drawing.Point(874, 17);
            this.OsiSmo.Name = "OsiSmo";
            this.OsiSmo.Size = new System.Drawing.Size(63, 22);
            this.OsiSmo.TabIndex = 5;
            this.OsiSmo.Text = "SMode";
            // 
            // OsiInt
            // 
            this.OsiInt.AutoSize = true;
            this.OsiInt.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsiInt.ForeColor = System.Drawing.Color.Blue;
            this.OsiInt.Location = new System.Drawing.Point(628, 87);
            this.OsiInt.Name = "OsiInt";
            this.OsiInt.Size = new System.Drawing.Size(74, 22);
            this.OsiInt.TabIndex = 6;
            this.OsiInt.Text = "Interval";
            // 
            // OsiWei
            // 
            this.OsiWei.AutoSize = true;
            this.OsiWei.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsiWei.ForeColor = System.Drawing.Color.Blue;
            this.OsiWei.Location = new System.Drawing.Point(628, 12);
            this.OsiWei.Name = "OsiWei";
            this.OsiWei.Size = new System.Drawing.Size(67, 22);
            this.OsiWei.TabIndex = 7;
            this.OsiWei.Text = "Weight";
            // 
            // OsiSta
            // 
            this.OsiSta.AutoSize = true;
            this.OsiSta.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsiSta.ForeColor = System.Drawing.Color.Blue;
            this.OsiSta.Location = new System.Drawing.Point(421, 87);
            this.OsiSta.Name = "OsiSta";
            this.OsiSta.Size = new System.Drawing.Size(93, 22);
            this.OsiSta.TabIndex = 8;
            this.OsiSta.Text = "Start Time";
            // 
            // OsiLen
            // 
            this.OsiLen.AutoSize = true;
            this.OsiLen.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsiLen.ForeColor = System.Drawing.Color.Blue;
            this.OsiLen.Location = new System.Drawing.Point(421, 9);
            this.OsiLen.Name = "OsiLen";
            this.OsiLen.Size = new System.Drawing.Size(65, 22);
            this.OsiLen.TabIndex = 9;
            this.OsiLen.Text = "Length";
            // 
            // OsiDat
            // 
            this.OsiDat.AutoSize = true;
            this.OsiDat.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsiDat.ForeColor = System.Drawing.Color.DarkBlue;
            this.OsiDat.Location = new System.Drawing.Point(215, 87);
            this.OsiDat.Name = "OsiDat";
            this.OsiDat.Size = new System.Drawing.Size(48, 22);
            this.OsiDat.TabIndex = 10;
            this.OsiDat.Text = "Date";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Grouped Graph";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 27);
            this.button3.TabIndex = 12;
            this.button3.Text = "Single Graph";
            this.button3.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 504);
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Cycling Computer Trainning Software";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
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
    }
}

