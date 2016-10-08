using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCSTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //cw tab tab is snippet for Console.WriteLine
            Console.WriteLine();

            //Ctrl X gets rid of line

            
            
            //          ("{Place holders}", arguments)  -  This is a format string

            Console.WriteLine("Ints go from {0} to {1}", int.MinValue, int.MaxValue );

            int a = 1;
            int b = 2;
            Console.WriteLine(a == b); //Prints: False. Equality comparisons evaluate to a bool
            Console.WriteLine(a != b);
   
        }
    }
}
