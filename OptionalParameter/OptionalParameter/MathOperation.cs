using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class MathOperation
    {
        public int MathMethod(int x, int y = 2)
        {
            return x * y;
        }
    }
}
