using Problems;
using System;

namespace MainMeth
{



    class LogicalProgram 
    {
        public static void Main()
        {
           
            GenericsProblem problem = new GenericsProblem();
            Console.WriteLine(problem.Max(5, 4, 3));
        }

    }



}