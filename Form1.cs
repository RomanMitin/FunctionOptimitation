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

namespace FunctionOptimitation
{
    public partial class Form1 : Form
    {
        Func_t func;

        double a, b;

        ulong max_step;

        double eps;

        double metod_param;

        int cur_metod;

        public Form1()
        {
            InitializeComponent();
            
            func.a = double.Parse(AtextBox.Text);
            func.b = double.Parse(BtextBox.Text);
            func.w1 = double.Parse(W1textBox.Text);
            func.w2 = double.Parse(W2textBox.Text);
            
            a = double.Parse(aTextBox2.Text);
            b = double.Parse(bTextBox2.Text);

            max_step = ulong.Parse(MaxStepTextBox.Text);
            eps = double.Parse(EpsTextBox.Text);
            metod_param = double.Parse(ParamTextBox.Text);
        }

        void GetDouble(out double d, string txt)
        {
            if(!double.TryParse(txt, out d))
            {
                MessageBox.Show("Wrong number format, try again!");
            }
        }

        private void AtextBox_Validated(object sender, EventArgs e)
        {
            double tmp;
            GetDouble(out tmp, AtextBox.Text);
            func.a = tmp;
        }

        private void W1textBox_Validated(object sender, EventArgs e)
        {
            double tmp;
            GetDouble(out tmp, W1textBox.Text);
            func.w1 = tmp;
        }

        private void BtextBox_Validated(object sender, EventArgs e)
        {
            double tmp;
            GetDouble(out tmp, BtextBox.Text);
            func.b = tmp;
        }

        private void aTextBox2_Validated(object sender, EventArgs e)
        {
            double tmp;
            GetDouble(out tmp, aTextBox2.Text);
            a = tmp;
        }

        private void bTextBox2_Validated(object sender, EventArgs e)
        {
            double tmp;
            GetDouble(out tmp, bTextBox2.Text);
            b = tmp;
        }

        private void W2textBox_Validated(object sender, EventArgs e)
        {
            double tmp;
            GetDouble(out tmp, W2textBox.Text);
            func.w2 = tmp;
        }

        private void MaxStepTextBox_Validated(object sender, EventArgs e)
        {
            if(!ulong.TryParse(MaxStepTextBox.Text, out max_step))
            {
                MessageBox.Show("Wrong number format");
            }
        }

        private void EpsTextBox_Validated(object sender, EventArgs e)
        {
            double tmp;
            GetDouble(out tmp, EpsTextBox.Text);
            eps = tmp;
        }

        private void ParamTextBox_Validated(object sender, EventArgs e)
        {
            double tmp;
            GetDouble(out tmp, ParamTextBox.Text);
            metod_param = tmp;
        }


        private void ParamTextBox2_Validated(object sender, EventArgs e)
        {
            double tmp;
            GetDouble(out tmp, ParamTextBox2.Text);
            metod_param = tmp;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cur_metod = tabControl1.SelectedIndex;
            if(cur_metod == 1)
            {
                ParamTextBox.Text = metod_param.ToString();
            }
            else if (cur_metod == 2)
            {
                ParamTextBox2.Text = metod_param.ToString();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Stop_t stop = new Stop_t(max_step, eps);

            Point_t[] res = null;
            switch (cur_metod)
            {
                case 0:
                    res = SimpleIteration.Calc(func, a, b, ref stop);
                    break;
                case 1:
                    Piyavski.m = metod_param;
                    res = Piyavski.Calc(func, a, b, ref stop);
                    break;
                case 2:
                    Strongin.r = metod_param;
                    res = Strongin.Calc(func, a, b, ref stop);
                    break;
                default:
                    throw new Exception("Wrong metod");
            }
            

            FuncChart.Series.Clear();
            FuncChart.ResetAutoValues();
            FuncChart.Series.Add(func.GetSeries(a, b));

            Series Test_point = new Series("Test point");
            Test_point.ChartType = SeriesChartType.Point;
            Test_point.Color = Color.Green;
            double Test_point_Level = 0.0;

            Point_t min_val = new Point_t(0, double.MaxValue);
            for (int i = 0; i < res.Length; i++) 
            {
                Test_point.Points.AddXY(res[i].x, Test_point_Level);
                if(min_val.y > res[i].y)
                {
                    min_val = res[i];
                }
            }

            FuncChart.Series.Add(Test_point);

            Series Global_minimum = new Series("Global minimum");
            Global_minimum.ChartType = SeriesChartType.Point;
            Global_minimum.Color = Color.Red;
            Global_minimum.BorderWidth = 5;
            MinCoordTextBox.Text = min_val.x.ToString();
            MinValTextBox.Text = min_val.y.ToString();
            IterNumTextBox.Text = stop.cur_step.ToString();
            Global_minimum.Points.AddXY(min_val.x, min_val.y);
            FuncChart.Series.Add(Global_minimum);
        }
    }
}
