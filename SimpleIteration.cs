using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOptimitation
{
    internal class SimpleIteration
    {

        private static double get_r(Point_t point_t1, Point_t point_t2)
        {
            return point_t2.x - point_t1.x;
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

            double x1, x2;
            double new_x;
            do
            {
                int Max_r_ind = Get_max_r_ind(set);
                x1 = set.ElementAt(Max_r_ind).x;
                x2 = set.ElementAt(Max_r_ind + 1).x;
                new_x = (x2 + x1) / 2;
                double new_y = func.calc(new_x);
                set.Add(new Point_t(new_x, new_y));
            } while (stop.need_calc(x1, x2));

           
           return set.ToArray();
        }

        
    }
}
