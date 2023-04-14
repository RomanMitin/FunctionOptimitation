using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOptimitation
{
    internal class Strongin
    {
        static public double r;
        static private double m;

        private static double get_r(Point_t point_t1, Point_t point_t2)
        {
            double result = m * (point_t2.x - point_t1.x) +
                (Math.Pow(point_t2.y - point_t1.y, 2)) / (m * (point_t2.x - point_t1.x)) -
                2.0 * (point_t2.y + point_t1.y);
            return result;
        }

        private static int Get_max_r_ind(SortedSet<Point_t> set)
        {

            double max_r = double.MinValue;
            int result = 0;

            var prev = set.GetEnumerator();
            prev.MoveNext();
            var iter = prev;
            iter.MoveNext();

            for (int i = 0; i < set.Count - 1; i++)
            {
                double cur_r = get_r(prev.Current, iter.Current);
                if (cur_r > max_r)
                {
                    max_r = cur_r;
                    result = i;
                }
                prev = iter;
                iter.MoveNext();
            }

            return result;
        }

        static public Point_t[] Calc(Func_t func, double a, double b, ref Stop_t stop)
        {
            SortedSet<Point_t> set = new SortedSet<Point_t>
            {
                new Point_t(a, func.calc(a)),
                new Point_t(b, func.calc(b))
            };

            stop.cur_step = 2;

            Point_t p1, p2;
            double new_x;
            do
            {
                double M = GetM(set);
                if(M == 0)
                {
                    m = 1;
                }
                else
                {
                    m = r * M;
                }

                int Max_r_ind = Get_max_r_ind(set);
                p1 = set.ElementAt(Max_r_ind);
                p2 = set.ElementAt(Max_r_ind + 1);
                new_x = (p2.x + p1.x) / 2 - (p2.y - p1.y) / (2 * m);
                double new_y = func.calc(new_x);
                set.Add(new Point_t(new_x, new_y));
            } while (stop.need_calc(p1.x, p2.x));


            return set.ToArray();
        }

        private static double GetM(SortedSet<Point_t> set)
        {
            double result = 0;

            var prev = set.GetEnumerator();
            prev.MoveNext();
            var iter = prev;
            iter.MoveNext();

            for (int i = 0; i < set.Count - 1; i++)
            {
                double cur_M = Math.Abs(iter.Current.y - prev.Current.y) / 
                    (iter.Current.x - prev.Current.x);

                if(cur_M < 0)
                {
                    throw new Exception();
                }

                result = Math.Max(cur_M, result);
                prev = iter;
                iter.MoveNext();
            }

            return result;
        }
    }
}
