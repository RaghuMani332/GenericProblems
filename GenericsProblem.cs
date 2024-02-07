using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class GenericsProblem
    {
        public int Max(int a,int b,int c)
        {
            return a>b&&a>c?a:b>c&&b>a?b:c;
        }
    }
}
