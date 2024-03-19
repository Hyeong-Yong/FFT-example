namespace FastFourierTransform_FFT__Example {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnLoad = new Button();
            btnFFT = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            lblMagSecond = new Label();
            lblMagThird = new Label();
            lblPHSecond = new Label();
            lblPHThird = new Label();
            trkSecond = new TrackBar();
            trkThird = new TrackBar();
            trkPHSecond = new TrackBar();
            trkPHThird = new TrackBar();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkSecond).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkThird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkPHSecond).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkPHThird).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(226, 31);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Waveform";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Second Harmonic";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Third Harmonic";
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Size = new Size(1178, 321);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(226, 387);
            chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Frequency";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Angle";
            chart2.Series.Add(series4);
            chart2.Series.Add(series5);
            chart2.Size = new Size(1178, 362);
            chart2.TabIndex = 1;
            chart2.Text = "chart2";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(1442, 31);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(150, 46);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load Signal";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnFFT
            // 
            btnFFT.Location = new Point(764, 755);
            btnFFT.Name = "btnFFT";
            btnFFT.Size = new Size(150, 46);
            btnFFT.TabIndex = 3;
            btnFFT.Text = "FFT";
            btnFFT.UseVisualStyleBackColor = true;
            btnFFT.Click += btnFFT_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(1480, 103);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(28, 27);
            checkBox1.TabIndex = 4;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(1575, 103);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(28, 27);
            checkBox2.TabIndex = 5;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // lblMagSecond
            // 
            lblMagSecond.AutoSize = true;
            lblMagSecond.Location = new Point(1456, 196);
            lblMagSecond.Name = "lblMagSecond";
            lblMagSecond.Size = new Size(78, 32);
            lblMagSecond.TabIndex = 6;
            lblMagSecond.Text = "label1";
            // 
            // lblMagThird
            // 
            lblMagThird.AutoSize = true;
            lblMagThird.Location = new Point(1562, 194);
            lblMagThird.Name = "lblMagThird";
            lblMagThird.Size = new Size(78, 32);
            lblMagThird.TabIndex = 7;
            lblMagThird.Text = "label2";
            // 
            // lblPHSecond
            // 
            lblPHSecond.AutoSize = true;
            lblPHSecond.Location = new Point(1451, 540);
            lblPHSecond.Name = "lblPHSecond";
            lblPHSecond.Size = new Size(78, 32);
            lblPHSecond.TabIndex = 8;
            lblPHSecond.Text = "label3";
            // 
            // lblPHThird
            // 
            lblPHThird.AutoSize = true;
            lblPHThird.Location = new Point(1556, 540);
            lblPHThird.Name = "lblPHThird";
            lblPHThird.Size = new Size(78, 32);
            lblPHThird.TabIndex = 9;
            lblPHThird.Text = "label4";
            // 
            // trkSecond
            // 
            trkSecond.Location = new Point(1468, 231);
            trkSecond.Name = "trkSecond";
            trkSecond.Orientation = Orientation.Vertical;
            trkSecond.Size = new Size(90, 208);
            trkSecond.TabIndex = 10;
            trkSecond.Scroll += trkSecond_Scroll;
            // 
            // trkThird
            // 
            trkThird.Location = new Point(1575, 229);
            trkThird.Name = "trkThird";
            trkThird.Orientation = Orientation.Vertical;
            trkThird.Size = new Size(90, 208);
            trkThird.TabIndex = 11;
            trkThird.Scroll += trkThird_Scroll;
            // 
            // trkPHSecond
            // 
            trkPHSecond.Location = new Point(1466, 583);
            trkPHSecond.Name = "trkPHSecond";
            trkPHSecond.Orientation = Orientation.Vertical;
            trkPHSecond.Size = new Size(90, 208);
            trkPHSecond.TabIndex = 12;
            trkPHSecond.Scroll += trkPHSecond_Scroll;
            // 
            // trkPHThird
            // 
            trkPHThird.Location = new Point(1575, 583);
            trkPHThird.Name = "trkPHThird";
            trkPHThird.Orientation = Orientation.Vertical;
            trkPHThird.Size = new Size(90, 208);
            trkPHThird.TabIndex = 13;
            trkPHThird.Scroll += trkPHThird_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1490, 150);
            label5.Name = "label5";
            label5.Size = new Size(131, 32);
            label5.TabIndex = 14;
            label5.Text = "Magnitude";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1451, 492);
            label6.Name = "label6";
            label6.Size = new Size(184, 32);
            label6.TabIndex = 15;
            label6.Text = "Phase (degrees)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1448, 442);
            label7.Name = "label7";
            label7.Size = new Size(81, 32);
            label7.TabIndex = 16;
            label7.Text = "120Hz";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1442, 794);
            label8.Name = "label8";
            label8.Size = new Size(81, 32);
            label8.TabIndex = 17;
            label8.Text = "120Hz";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1561, 442);
            label9.Name = "label9";
            label9.Size = new Size(81, 32);
            label9.TabIndex = 18;
            label9.Text = "180Hz";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1561, 794);
            label10.Name = "label10";
            label10.Size = new Size(81, 32);
            label10.TabIndex = 19;
            label10.Text = "180Hz";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1945, 839);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(trkPHThird);
            Controls.Add(trkPHSecond);
            Controls.Add(trkThird);
            Controls.Add(trkSecond);
            Controls.Add(lblPHThird);
            Controls.Add(lblPHSecond);
            Controls.Add(lblMagThird);
            Controls.Add(lblMagSecond);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(btnFFT);
            Controls.Add(btnLoad);
            Controls.Add(chart2);
            Controls.Add(chart1);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkSecond).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkThird).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkPHSecond).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkPHThird).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Button btnLoad;
        private Button btnFFT;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label lblMagSecond;
        private Label lblMagThird;
        private Label lblPHSecond;
        private Label lblPHThird;
        private TrackBar trkSecond;
        private TrackBar trkThird;
        private TrackBar trkPHSecond;
        private TrackBar trkPHThird;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
