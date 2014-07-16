using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractingCsharp
{
    class DoWhileLoop
    {
        static void Main(string[] args)
        {
            int x = 10;

            do
            {
                Console.WriteLine("x = " + x);
                x--;
            }   while(x < 0);
          }
    }
}
