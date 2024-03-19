// Used for generating sine waveforms
using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;


// Used for FFT


// Used for Complex numbers
using System.Numerics;

// Used for Charts
using System.Windows.Forms.DataVisualization.Charting;



namespace FastFourierTransform_FFT__Example {
    public partial class MainForm : Form {


        static int numSamples = 1000;
        static int sampleRate = 2000;
        static int magSecond;
        static int magThird;
        static double PHSecond;
        static double PHThird;

        Complex[] samples = new Complex[numSamples];


        public MainForm() {
            InitializeComponent();
        }

        // Use a 2kHz sampling rate, and make the signal 1000 samples in length
        // THis means that the signal will last for 0.5 seconds (1,000/2,000)
        // and show 100 cycles
        // Note : the FFT "bidirectional bandwidth" is the same as the sampling frequency, or 2kHz.
        // Since there are 1,000 samples, each sample represents 2kHz/1kHz, or 2Hz
        // The max freuqency you can detect is 1/2 the sampling rate, or 1Khz
        // and that appears in the middle of the chart of 1,000 samples
        // Therefore the top 500 samples are unnecessary




        private void btnLoad_Click(object sender, EventArgs e) {
            PlotWaveform(0, 0, 0, 0);
        }

        private void btnFFT_Click(object sender, EventArgs e) {
            PlotFFT();
        }
        public void PlotWaveform(int secondHarm, int thirdHarm, double secondPH, double thirdPH) {

            chart1.Series["Waveform"].Points.Clear();
            chart1.Series["Second Harmonic"].Points.Clear();
            chart1.Series["Third Harmonic"].Points.Clear();

            //Generate fundamental, 2nd & 3rd harmonic waveforms using MathNet libraries
            double[] fundamental = Generate.Sinusoidal(numSamples, sampleRate, 60, 10.0);
            double[] second = Generate.Sinusoidal(numSamples, sampleRate, 120, secondHarm, 0.0, secondPH);
            double[] third = Generate.Sinusoidal(numSamples, sampleRate, 180, thirdHarm, 0.0, thirdPH);


            //Add waveforms together to get composite waveform
            for (int i = 0; i < numSamples; i++) {
                samples[i] = new Complex(fundamental[i] + second[i] + third[i], 0);
            }


            // Plot composite waveform
            // Each sample represents a time of 1/sampling rate
            for (int i = 0; i < samples.Length / 5; i++) {
                double time = ((i + 1.0) / numSamples) / 2;

                chart1.Series["Waveform"].LegendText = "Waveform";
                chart1.Series["Waveform"].ChartType = SeriesChartType.Line;

                chart1.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 14.0f);
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Seconds";

                if (checkBox1.Checked) {
                    chart1.Series["Second Harmonic"].Points.AddXY(time, second[i]);
                }

                if (checkBox2.Checked) {
                    chart1.Series["Third Harmonic"].Points.AddXY(time, third[i]);
                }

                chart1.Series["Waveform"].Points.AddXY(time, samples[i].Real);

            }
        }

        public void PlotFFT() {
            chart2.Series["Frequency"].Points.Clear();

            // "Forward" Fourier converts time => frequency
            Fourier.Forward(samples, FourierOptions.NoScaling);

            // Plot the frequency spectrum. Since it's "bidirectional bandwidth",
            // you only need the bottom 1/2 of the samples
            for (int i = 1; i < samples.Length / 10; i++) {
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Hz";
                chart2.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 14.0f);
                chart2.ChartAreas["ChartArea1"].AxisX.MinorTickMark.Enabled = true;

                // Get the magnitude of each FFT sample:
                // = abs[sqrt(r^2 + i ^2)]
                double mag = (2.0 / numSamples) * (Math.Abs(Math.Sqrt(Math.Pow(samples[i].Real, 2) + Math.Pow(samples[i].Imaginary, 2))));


                // Determine how many Hz represented by each sample
                double hzPerSample = sampleRate / numSamples;

                chart2.Series["Frequency"].Points.AddXY(hzPerSample * i, mag);

            }
        }
        //Event Handlers
        private void trkThird_Scroll(object sender, EventArgs e) {
            //Plot resultant waveform, then plot FFT
            trkPHThird.Enabled = true;
            magThird = trkThird.Value;
            lblMagThird.Text = magThird.ToString("F0");
            PlotWaveform(magSecond, magThird, PHSecond, PHThird);
            PlotFFT();
        }

        private void trkSecond_Scroll(object sender, EventArgs e) {
            //Plot resultant waveform, then plot FFT
            trkPHSecond.Enabled = true;
            magSecond = trkSecond.Value;
            lblMagSecond.Text = magSecond.ToString("F0");
            PlotWaveform(magSecond, magThird, PHSecond, PHThird);
            PlotFFT();
        }
        private void trkPHSecond_Scroll(object sender, EventArgs e) {
            //Value goes from 0 to 10, corresponding to 0 to 360 degrees, or 2*PI radians
            // First convert value to radians, where 10 = 360 degrees or 2PI radians
            PHSecond = 2.0 * Math.PI * (trkPHSecond.Value / (double)trkPHSecond.Maximum);
            double angle = PHSecond * 360 / (2 * Math.PI);

            lblPHSecond.Text = angle.ToString("F1");
            PlotWaveform(magSecond, magThird, PHSecond, PHThird);
            PlotFFT();
        }
        private void trkPHThird_Scroll(object sender, EventArgs e) {
            //Value goes from 0 to 10, corresponding to 0 to 360 degrees, or 2*PI radians
            // First convert value to radians, where 10 = 360 degrees or 2PI radians
            PHThird = 2.0 * Math.PI * (trkPHThird.Value / (double)trkPHThird.Maximum);
            double angle = PHThird * 360 / (2 * Math.PI);

            lblPHThird.Text = angle.ToString("F1");
            PlotWaveform(magSecond, magThird, PHSecond, PHThird);
            PlotFFT();
        }

    }

}
