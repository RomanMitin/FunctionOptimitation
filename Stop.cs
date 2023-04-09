using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOptimitation
{
    internal struct Stop_t
    {
        public UInt64 cur_step;
        public UInt64 max_step;
        public double eps;

        public Stop_t(UInt64 max_step, double eps)
        {
            this.cur_step = 0;
            this.max_step = max_step;
            this.eps = eps;
        }

        public bool need_calc(double x_prev, double x)
        {
            if(x - x_prev < eps)
                return false;

            if (++cur_step >= max_step)
                return false;
            return true;
        }

        public UInt64 reset()
        {
            UInt64 tmp = cur_step;
            cur_step = 0;
            return tmp;
        }
    }
}
