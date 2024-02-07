using Problems;
using System;
using System.Collections;

namespace MainMeth
{



    class LogicalProgram 
    {
        public static void Main()
        {

            GenericsProblem problem = new GenericsProblem();
            Console.WriteLine(problem.Max<String>("a","b","c"));
        }

    }



}