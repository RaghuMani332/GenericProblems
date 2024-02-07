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
        public String Max(String a,String  b,String c)
        {
            return a.CompareTo(b) > 0 && a.CompareTo(c) > 0 ? a : b.CompareTo(c) > 0 && b.CompareTo(a) > 0 ? b : c;
         //   return a>b&&a>c?a:b>c&&b>a?b:c;

        }
    }
}
