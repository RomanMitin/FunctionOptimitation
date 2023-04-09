using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace FunctionOptimitation
{
    internal struct Func_t
    {
        public double a, b, w1, w2;

        public double calc(double x)
        {
            double result = a * Math.Sin(w1* x);
            result += b * Math.Cos(w2 * x);

            return result;
        }

        public Series GetSeries(double left, double right)
        {
            const double density = 100;
            Series result = new Series("Function");
            result.ChartType = SeriesChartType.Spline;

            double step = (right - left) / density;
            for(;left <=right;left+=step)
            {
                result.Points.AddXY(left, calc(left));
            }

            return result;
        }
    }
}
