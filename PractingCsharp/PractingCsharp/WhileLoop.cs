using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractingCsharp
{
    class WhileLoop
    {
        static void Main(string[] args)
        {
            int x = 10;

            while (x >= 0)
            {
                Console.WriteLine("x = " + x);
                x--; // = x-1;
            }
        }
    }
}
