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
        public T Max<T>(params T[] obj ) where T : IComparable<T>
        {
            if (obj == null || obj.Length == 0)
            {
                Console.WriteLine("invalid arguments");
                
            }

            T max = obj[0];
            for (int i = 1; i < obj.Length; i++)
            {
                if (obj[i].CompareTo(max) > 0)
                {
                    max = obj[i];
                }
            }
            return max;

        }
    }
}
