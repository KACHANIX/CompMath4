using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CompMath3
{
    public partial class Form1 : Form
    {
        public delegate double CurFun (double x);
        public CurFun CurrentFunction;
        public string CF = "y' = Sqrt(x)";
        
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //MaximizeBox = false;
            Chart.Visible = false;


            CurrentFunction  = Math.Sqrt;
            //Func.Items.Add("y' = Sin(x)");
            Func.Items.Add("y' = Sqrt(x)");
            Func.Items.Add("y' = x^2");
            //Func.Items.Add("y' = Tg(x)");
            Func.Items.Add("y' = x^4");
            Func.ReadOnly = true;

            Func.SelectedIndex = 0;

            FirstX.DecimalPlaces = 1;
            FirstX.Increment = 0.1M;
            
            FirstY.DecimalPlaces = 1;
            FirstY.Increment = 0.1M;


            LastX.DecimalPlaces = 1;
            LastX.Increment = 0.1M;

            Precision.Value = 0.1M;
            Precision.Minimum = 0.1M;
            Precision.Increment = 0.1M;
            Precision.DecimalPlaces = 1;

            
            FirstY.KeyPress += new KeyPressEventHandler(Key_down);
            FirstX.KeyPress += new KeyPressEventHandler(Key_down);
            Precision.KeyPress += new KeyPressEventHandler(Key_down);
            LastX.KeyPress += new KeyPressEventHandler(Key_down);

        }

        private void Key_down(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Enter)
            {
                BuildCharts();
            }
        }

        private void BuildCharts()
        {
            if ((double)FirstX.Value >= (double)LastX.Value || CurrentFunction((double)FirstX.Value) != (double)FirstY.Value)
            {
                MessageBox.Show("Your input is wrong, please re-check it");
                return;
            }
            Chart.Visible = true;
            ChartArea ca = new ChartArea("Two charts") ;
            try
            {
                Chart.Series.Clear();
                Chart.ChartAreas.Clear();
            }
            catch { }
            Chart.ChartAreas.Add(ca);

            Series fun = new Series(CF)
            {
                ChartType = SeriesChartType.Line,
                ChartArea = "Two charts"
            };
            for (double x = (double)FirstX.Value; x <= (double)LastX.Value;
                    x += ((double)LastX.Value - (double)FirstX.Value)/100)
            {
                fun.Points.AddXY(x, CurrentFunction(x));
            }
            Chart.Series.Add(fun);
            Series Euler = new Series("Euler")
            {
                ChartType = SeriesChartType.FastLine,
                ChartArea = "Two charts",
                Color = Color.Red

            };
            Series Nodes = new Series("Nodes")
            {
                ChartArea = "Two charts",
                ChartType = SeriesChartType.Point,
                Color = Color.Purple
            };

            int Steps = 10;
            double precision = (double) Precision.Value;
            List<double> X = new List<double>();
            List<double> Y = new List<double>();

            List<double> XD = new List<double>();
            List<double> YD = new List<double>();
            double error;
            do
            {
                X.Clear(); Y.Clear(); XD.Clear(); YD.Clear();
                X.Add((double)FirstX.Value); Y.Add((double)FirstY.Value);
                XD.Add((double)FirstX.Value); YD.Add((double)FirstY.Value);
                double Step = ((double)LastX.Value - (double)FirstX.Value) / Steps;
                error = 0;
                double Sum1 = 0;
                double Sum2 = 0;
                for (int i = 1; i <= Steps; i++)
                {
                    X.Add((double)FirstX.Value + i * Step);
                    Y.Add(Y[i - 1] + Step * CurrentFunction(X[i]));
                    Sum1 += Step * (Y[i] + Y[i-1]) / 2 ;
                }
                for (int i = 1; i <= Steps * 2; i++)
                {
                    XD.Add((double)FirstX.Value + i * Step / 2);
                    YD.Add(YD[i - 1] + Step / 2 * CurrentFunction(XD[i]));
                    Sum2 += Step  * (YD[i] + YD[i - 1]) / 4;
                }
                error = Math.Abs(Sum1 - Sum2) / 3;
                if (error > precision)
                {
                    Steps *= 2;
                }
            } while (error > precision);
            
            for (int i = 0; i < X.Count; i++)
            {
                Euler.Points.AddXY(X[i], Y[i]);
                Nodes.Points.AddXY(X[i], Y[i]);
            }
            
            Chart.Series.Add(Euler);
            Chart.Series.Add(Nodes);
        }
        private void Func_SelectedItemChanged(object sender, EventArgs e)
        {
            //if (Func.SelectedItem.ToString() == "y' = Sin(x)")
            //{
            //    CurrentFunction = Math.Sin;
            //    CF = "Sin(x)";
            //}
            if (Func.SelectedItem.ToString() == "y' = Sqrt(x)")
            {
                CurrentFunction = Math.Sqrt;
                CF = "Sqrt(x)";
            }
            if (Func.SelectedItem.ToString() == "y' = x^2")
            {
                CurrentFunction = x => x*x;
                CF = "x^2";
            }
            if (Func.SelectedItem.ToString() == "y' = x^4")
            {
                CurrentFunction = x => x * x * x * x;
                CF = "x^4";
            }
            
            //MessageBox.Show(CurrentFunction(5).ToString());
        }
        private void Interpolate_Click(object sender, EventArgs e)
        {
            BuildCharts();
            
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
