using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class GenericsProblem
    {
        public float Max(float a,float b,float c)
        {
            return a>b&&a>c?a:b>c&&b>a?b:c;

        }
    }
}
