using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOptimitation
{
    public struct Point_t : IComparable<Point_t>
    {
        public double x, y;
        public Point_t(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public int CompareTo(Point_t other)
        {
            if (x > other.x)
            {
                return 1;
            }
            else if (x < other.x) 
            {
                return -1;
            }
            return 0;
        }
    }
}
