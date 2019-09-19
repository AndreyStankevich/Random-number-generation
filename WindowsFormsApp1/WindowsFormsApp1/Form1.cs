using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Chart chart;
        Series series;
        List<double> numbers = new List<double>();
        List<double> tmpNumbers = new List<double>();
        double average, dispersion, period;

        const double COUNT = 100000;

        public Form1()
        {
            InitializeComponent();

            chart = new Chart();
            chart.Parent = this;
            chart.Width = 1000;
            chart.Height = 400;
            chart.ChartAreas.Add(new ChartArea("Lemer"));
        }

        public double Lemer(double a, double m, double R)
        {
            double step_1 = a * R;
            double step_2 = step_1 % m;
            numbers.Add(step_2 / m);
            return step_2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(editA.Text);
            double m = Convert.ToDouble(editM.Text);
            double R = Convert.ToDouble(editR.Text);

            numbers.Clear();

            for (int i = 0; i < COUNT; i++)
            {
                R = Lemer(a, m, R);
            }

            WriteToFile();
            CalculateAverage();
            CalculateDispersion();
            CalculateDeviation();
            CalculatePeriod();
            CalculateAperiodic();
            CheckIncorrectSigns();
            DrawHistogram();
        }

        public void DrawHistogram()
        {
            series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.ChartArea = "Lemer";
            series.Color = System.Drawing.Color.Red;

            numbers.Sort();
            double interval = Math.Round(Math.Abs((numbers[Convert.ToInt32(COUNT - 1)] - numbers[0])) / 20, 2);
            double k = Math.Round(numbers[0]) + interval;
            int counter = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= k)
                {
                    counter++;
                }
                else
                {
                    series.Points.AddXY(k, counter / COUNT);
                    counter = 0;
                    k += interval;
                }
            }
            series.Points.AddXY(k, counter / COUNT);

            WriteToFile();
            chart.ResetAutoValues();
            chart.Series.Clear();
            chart.Series.Add(series);
        }

        public void WriteToFile()
        {
            File.WriteAllText(@"test.txt", string.Empty);
            StreamWriter file = new StreamWriter(@"test.txt");
            for (int i = 0; i < COUNT; i++)
            {
                file.WriteLine(string.Format("{0:0.00000}", numbers[i]));
            }
            file.Close();
        }

        public void CalculatePeriod()
        {
            lblPeriod.Text = "Период - более " + Convert.ToString(COUNT);
            period = 0;
            for (int i = numbers.Count - 2; i > -1; i--)
            {
                if (numbers[numbers.Count - 1] == numbers[i])
                {
                    lblPeriod.Text = "Период - " + (numbers.Count - 1 - i);
                    period = numbers.Count - 1 - i;
                    break;
                }
            }
        }

        public void CalculateAperiodic()
        {
            if (period != 0)
            {
                lblAperiodic.Text = "Апериодичность - " + Convert.ToString(COUNT % period);
            }
            else
            {
                lblAperiodic.Text = "Апериодичность - 0";
            }
        }

        public void CalculateAverage()
        {
            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;
            }
            average = sum / COUNT;
            lblAverage.Text = "Мат. ожидание - " + Convert.ToString(string.Format("{0:0.000}", sum / COUNT));
        }

        public void CalculateDispersion()
        {
            double sum = 0;
            foreach (double number in numbers)
            {
                sum += Math.Pow(number - average, 2);
            }
            dispersion = sum / COUNT;
            lblDispersion.Text = "Дисперсия - " + Convert.ToString(string.Format("{0:0.000}", sum / COUNT));
        }

        private void rbLab2_CheckedChanged(object sender, EventArgs e)
        {
            panelLab1.Enabled = false;
            panelLab2.Enabled = true;
        }

        private void rbLab1_CheckedChanged(object sender, EventArgs e)
        {
            panelLab1.Enabled = true;
            panelLab2.Enabled = false;
        }

        public void ChangeEnabled(bool a, bool b, bool lambda, bool eta)
        {
            editAlpha.Enabled = a;
            editBeta.Enabled = b;
            editλ.Enabled = lambda;
            editη.Enabled = eta;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(editA.Text);
            double m = Convert.ToDouble(editM.Text);
            double R = Convert.ToDouble(editR.Text);

            numbers.Clear();
            tmpNumbers.Clear();

            for (int i = 0; i < COUNT; i++)
            {
                R = Lemer(a, m, R);
            }

            switch (cbDistribution.Text)
            {
                case "Равномерное":
                    ChangeEnabled(true, true, false, false);
                    double low = Convert.ToDouble(editAlpha.Text);
                    double max = Convert.ToDouble(editBeta.Text);
                    UniformDistribution(low, max);
                    break;
                case "Гауссовское":
                    double mean = Convert.ToDouble(editAlpha.Text);
                    double scale = Convert.ToDouble(editBeta.Text);
                    GaussianDistribution(mean, scale);
                    break;
                case "Экспоненциальное":
                    double λ = Convert.ToDouble(editλ.Text);
                    ExponentialDistribution(λ);
                    break;
                case "Гамма":
                    double lambda = Convert.ToDouble(editλ.Text);
                    double η = Convert.ToDouble(editη.Text);
                    GammaDistribution(lambda, η);
                    break;
                case "Треугольное":
                    double a1 = Convert.ToDouble(editAlpha.Text);
                    double b1 = Convert.ToDouble(editBeta.Text);
                    TriangleDistribution(a1, b1);
                    break;
                case "Симпсона":
                    double a2 = Convert.ToDouble(editAlpha.Text);
                    double b2 = Convert.ToDouble(editBeta.Text);
                    UniformDistribution(a2 / 2, b2 / 2);
                    SimpsonDistribution();
                    break;
            }
            WriteToFile();
            CalculateAverage();
            CalculateDispersion();
            CalculateDeviation();
            DrawHistogram();
        }

        public void UniformDistribution(double low, double max)
        {
            for (int i = 0; i < COUNT; i++)
            {
                numbers[i] = low + (max - low) * numbers[i];
            }
        }

        public void GaussianDistribution(double mean, double scale)
        {
            for (int i = 0; i < COUNT; i++)
            {
                tmpNumbers.Add(numbers[i]);
            }

            int counter = 0;            for (int i = 0; i < COUNT; i++)
            {
                double sum = 0;
                for (int j = 1; j <= 6; j++)
                {
                    sum = sum + (tmpNumbers[Convert.ToInt32(counter % COUNT)]);
                    counter++;
                }
                numbers[i] = Math.Abs(mean + scale * Math.Sqrt(2) * (sum - 3));
            }
        }

        public void ExponentialDistribution(double λ)
        {
            for (int i = 0; i < COUNT; i++)
            {
                numbers[i] = -1 / λ * Math.Log(numbers[i]);
            }
        }

        public void GammaDistribution(double λ, double η)
        {
            for (int i = 0; i < COUNT; i++)
            {
                tmpNumbers.Add(numbers[i]);
            }

            int counter = 0;
            for (int i = 0; i < COUNT; i++)
            {
                double multiply = 1;
                for (int j = 1; j <= η; j++)
                {
                    multiply = multiply * tmpNumbers[Convert.ToInt32(counter % COUNT)];
                    counter++;
                }
                numbers[i] = -1 / λ * Math.Log(multiply);
            }
        }

        public void TriangleDistribution(double a, double b)
        {
            for (int i = 0; i < COUNT; i++)
            {
                tmpNumbers.Add(numbers[i]);
            }

            for (int i = 0; i < COUNT; i++)
            {
                numbers[i] = a + (b - a) * Math.Min(tmpNumbers[Convert.ToInt32((i * 2) % COUNT)], tmpNumbers[Convert.ToInt32((i * 2 + 1) % COUNT)]);
            }
        }

        public void SimpsonDistribution()
        {
            for (int i = 0; i < COUNT; i++)
            {
                tmpNumbers.Add(numbers[i]);
            }

            for (int i = 0; i < COUNT; i++)
            {
                numbers[i] = tmpNumbers[Convert.ToInt32((i * 2) % COUNT)] + tmpNumbers[Convert.ToInt32((i * 2 + 1) % COUNT)];
            }
        }

        private void cbDistribution_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbDistribution.Text)
            {
                case "Нормальное":
                    ChangeEnabled(true, true, false, false);
                    break;
                case "Гауссовское":
                    ChangeEnabled(true, true, false, false);
                    break;
                case "Экспоненциальное":
                    ChangeEnabled(false, false, true, false);
                    break;
                case "Гамма":
                    ChangeEnabled(false, false, true, true);
                    break;
                case "Треугольное":
                    ChangeEnabled(true, true, false, false);
                    break;
                case "Симпсона":
                    ChangeEnabled(true, true, false, false);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void CalculateDeviation()
        {
            lblDeviation.Text = "Отклонение - " + Convert.ToString(string.Format("{0:0.000}", Math.Sqrt(dispersion)));
        }

        public void CheckIncorrectSigns()
        {
            double counter = 0;
            for (int i = 0; i < COUNT; i += 2)
            {
                if (Math.Pow(numbers[i], 2) + Math.Pow(numbers[i + 1], 2) < 1)
                {
                    counter++;
                }
            }
            lblK.Text = "Косвенные - " + Convert.ToString(2 * counter / COUNT);
        }
    }
}
