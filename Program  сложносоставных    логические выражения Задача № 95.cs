using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program95
{
    internal class Program
    {
        static void Main()
        {
            ool result = (~0 == -1) && (~(-1) == 0);
            Console.WriteLine(result); // True
        }
    }
}

