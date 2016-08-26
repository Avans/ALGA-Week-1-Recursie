using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALGA
{
    public class PyramidProblem
    {
        public static int triangular_number_recursive(int n)
        {
            if(n <= 0)
            {
                return 0;
            } else
            {
                return n + triangular_number_recursive(n - 1);
            }
        }

        public static int triangular_number_iterative(int n)
        {
            int triangle_number = 0;
            for(;n >= 0;n--)
            {
                triangle_number += n;
            }
            return triangle_number;
        }
    }
}
