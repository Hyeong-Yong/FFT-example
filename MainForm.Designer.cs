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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkSecond).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkThird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkPHSecond).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkPHThird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(113, 15);
            chart1.Margin = new Padding(2, 1, 2, 1);
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
            chart1.Size = new Size(589, 150);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(113, 181);
            chart2.Margin = new Padding(2, 1, 2, 1);
            chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Frequency";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Angle";
            chart2.Series.Add(series4);
            chart2.Series.Add(series5);
            chart2.Size = new Size(589, 170);
            chart2.TabIndex = 1;
            chart2.Text = "chart2";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(721, 15);
            btnLoad.Margin = new Padding(2, 1, 2, 1);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 22);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load Signal";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnFFT
            // 
            btnFFT.Location = new Point(382, 354);
            btnFFT.Margin = new Padding(2, 1, 2, 1);
            btnFFT.Name = "btnFFT";
            btnFFT.Size = new Size(75, 22);
            btnFFT.TabIndex = 3;
            btnFFT.Text = "FFT";
            btnFFT.UseVisualStyleBackColor = true;
            btnFFT.Click += btnFFT_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(740, 48);
            checkBox1.Margin = new Padding(2, 1, 2, 1);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 4;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(788, 48);
            checkBox2.Margin = new Padding(2, 1, 2, 1);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 5;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // lblMagSecond
            // 
            lblMagSecond.AutoSize = true;
            lblMagSecond.Location = new Point(728, 92);
            lblMagSecond.Margin = new Padding(2, 0, 2, 0);
            lblMagSecond.Name = "lblMagSecond";
            lblMagSecond.Size = new Size(39, 15);
            lblMagSecond.TabIndex = 6;
            lblMagSecond.Text = "label1";
            // 
            // lblMagThird
            // 
            lblMagThird.AutoSize = true;
            lblMagThird.Location = new Point(781, 91);
            lblMagThird.Margin = new Padding(2, 0, 2, 0);
            lblMagThird.Name = "lblMagThird";
            lblMagThird.Size = new Size(39, 15);
            lblMagThird.TabIndex = 7;
            lblMagThird.Text = "label2";
            // 
            // lblPHSecond
            // 
            lblPHSecond.AutoSize = true;
            lblPHSecond.Location = new Point(726, 253);
            lblPHSecond.Margin = new Padding(2, 0, 2, 0);
            lblPHSecond.Name = "lblPHSecond";
            lblPHSecond.Size = new Size(39, 15);
            lblPHSecond.TabIndex = 8;
            lblPHSecond.Text = "label3";
            // 
            // lblPHThird
            // 
            lblPHThird.AutoSize = true;
            lblPHThird.Location = new Point(778, 253);
            lblPHThird.Margin = new Padding(2, 0, 2, 0);
            lblPHThird.Name = "lblPHThird";
            lblPHThird.Size = new Size(39, 15);
            lblPHThird.TabIndex = 9;
            lblPHThird.Text = "label4";
            // 
            // trkSecond
            // 
            trkSecond.Location = new Point(734, 108);
            trkSecond.Margin = new Padding(2, 1, 2, 1);
            trkSecond.Name = "trkSecond";
            trkSecond.Orientation = Orientation.Vertical;
            trkSecond.Size = new Size(45, 98);
            trkSecond.TabIndex = 10;
            trkSecond.Scroll += trkSecond_Scroll;
            // 
            // trkThird
            // 
            trkThird.Location = new Point(788, 107);
            trkThird.Margin = new Padding(2, 1, 2, 1);
            trkThird.Name = "trkThird";
            trkThird.Orientation = Orientation.Vertical;
            trkThird.Size = new Size(45, 98);
            trkThird.TabIndex = 11;
            trkThird.Scroll += trkThird_Scroll;
            // 
            // trkPHSecond
            // 
            trkPHSecond.Location = new Point(733, 273);
            trkPHSecond.Margin = new Padding(2, 1, 2, 1);
            trkPHSecond.Name = "trkPHSecond";
            trkPHSecond.Orientation = Orientation.Vertical;
            trkPHSecond.Size = new Size(45, 98);
            trkPHSecond.TabIndex = 12;
            trkPHSecond.Scroll += trkPHSecond_Scroll;
            // 
            // trkPHThird
            // 
            trkPHThird.Location = new Point(788, 273);
            trkPHThird.Margin = new Padding(2, 1, 2, 1);
            trkPHThird.Name = "trkPHThird";
            trkPHThird.Orientation = Orientation.Vertical;
            trkPHThird.Size = new Size(45, 98);
            trkPHThird.TabIndex = 13;
            trkPHThird.Scroll += trkPHThird_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(745, 70);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 14;
            label5.Text = "Magnitude";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(726, 231);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 15;
            label6.Text = "Phase (degrees)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(724, 207);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 16;
            label7.Text = "120Hz";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(721, 372);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 17;
            label8.Text = "120Hz";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(780, 207);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 18;
            label9.Text = "180Hz";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(780, 372);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 19;
            label10.Text = "180Hz";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart3.Legends.Add(legend3);
            chart3.Location = new Point(113, 401);
            chart3.Margin = new Padding(2, 1, 2, 1);
            chart3.Name = "chart3";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Waveform";
            chart3.Series.Add(series6);
            chart3.Size = new Size(589, 170);
            chart3.TabIndex = 20;
            chart3.Text = "chart3";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 625);
            Controls.Add(chart3);
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
            Margin = new Padding(2, 1, 2, 1);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkSecond).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkThird).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkPHSecond).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkPHThird).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
    }
}
