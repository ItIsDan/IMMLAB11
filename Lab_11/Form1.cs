using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11
{
    public partial class Form1 : Form
    {
        double N = 0;
        double mean = 0;
        double variance = 0;

        List<double> values = new List<double>();
      

        public Form1()
        {
            InitializeComponent();
        }

        private void startBut_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double x;
            values = new List<double>();

            N = (double)SizeNmd.Value;
            mean = (double)MeanNmd.Value;
            variance = (double)VarNmd.Value;

            for(int i = 0; i < N; i++)
            {
                double x1 = rand.NextDouble();
                double x2 = rand.NextDouble(); // СтдНСВ = Бокс-Мюллер * ско + среднее (слайд 18 и 16)
                x = (Math.Sqrt(-2 * Math.Log(x1))) * (Math.Cos(2 * Math.PI * x2)) * (Math.Sqrt(variance)) + mean;
                
                values.Add(x);
            }

            var intervalAmount = (int)Math.Ceiling(Math.Sqrt(values.Count)); // Количество интервалов.  
            var interval = (values.Max() - values.Min()) / intervalAmount; // Шаг интервала
            double[] points = new double[intervalAmount + 1];
           
            points[0] = values.Min();   

            for(int i = 1; i < intervalAmount + 1; i++)
                points[i] = points[i - 1] + interval; // Сетка интервалов

            double[] freq = new double[intervalAmount];

            for (int i = 0; i < intervalAmount; i++)
                for (int j = 0; j < values.Count; j++)
                    if ((points[i] < values[j]) && (values[j] <= points[i + 1])) 
                        freq[i] += 1;   // Подсчитываем, сколько раз значения из выборки попали в какой-то интервал.
            
            freq[0] += 2;

            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.Minimum = values.Min();
            chart1.ChartAreas[0].AxisX.Maximum = points[intervalAmount];
            chart1.ChartAreas[0].AxisX.Interval = interval;

            for (int i = 0; i < freq.Length; i++)
                chart1.Series[0].Points.AddXY((points[i + 1] + points[i]) / 2, freq[i] / N);   // Делим частоты на объём выборки

            double empMean = 0.0;
            for (int i = 0; i < freq.Length; i++)
                empMean += (freq[i] / N) * (points[i + 1] + points[i]) / 2; // Эмпирическое среднее 
            
            double empVariance = 0.0;
            for (int i = 0; i < freq.Length; i++) // Эмперическая дисперсия
                empVariance += (freq[i] / N) * Math.Pow((points[i + 1] + points[i]) / 2 - empMean, 2);
            
            double meanError = Math.Abs((empMean - mean) / mean) * 100; // Относительная погрешность среднего
            double varianceError = Math.Abs((empVariance - variance) / variance) * 100;   // Относительная погрешность дисперсии

            double chi = 0;
            if (N == 10000)
                chi = 180.342;
            if (N == 1000)
                chi = 55.758;
            if (N == 100)
                chi = 18.307;
            if (N == 10)
                chi = 9.488;

            double[] probs = new double[intervalAmount];
            
            for (int i = 0; i < probs.Length; i++)
            {
                double probsC; //   Норм Распр  e^-((x-a)^2/2o)/(o*sqrt(2*pi)
                probsC = (Math.Exp((-Math.Pow(((points[i + 1] + points[i]) / 2 - mean), 2))  / (2 * variance))) 
                            / (Math.Sqrt(2 * Math.PI * variance));
                probs[i] = (points[i + 1] - points[i]) * probsC;
            } //                        x * ksi

            double chiSquare = 0.0;
            
            for (int i = 0; i < freq.Length; i++)
                if (probs[i] > 0)
                    chiSquare += ((freq[i] * freq[i]) / (N * probs[i]));
            chiSquare -= N; // Критерий Хи-квадрата.

            if (Math.Log10(N) != 1 && Math.Log10(N) != 2 && Math.Log10(N) != 3 && Math.Log10(N) != 4)
                ChiLabel.Text = "Невозможно посчитать, выберите размер выборки равный 10/100/1000/10000";
            else
            {
                AverLabel.Text = Math.Round(empMean, 3).ToString() + " (error = " + Math.Round(meanError, 3).ToString() + "% )";
                VarLabel.Text = Math.Round(empVariance, 3).ToString() + " (error = " + Math.Round(varianceError, 3).ToString() + "% )";
                ChiLabel.Text = Math.Round(chiSquare, 3).ToString() + " < " + chi.ToString() + " is " + (chiSquare < chi).ToString();
            }
        }
    }
}
