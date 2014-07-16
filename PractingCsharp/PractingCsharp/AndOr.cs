using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractingCsharp
{
    class AndOr
    {
        static void Main(string[] args)
        {
            int x = -10;
            int y = 20;
        
        if (x >= 0 && y >= 0)
        {
            Console.WriteLine("Both numbers are possitive");
        }
        else if (x >= 0 || y >= 0)
        {
            Console.WriteLine("atleast one number is positvie");
        }   
            else
                Console.WriteLine("Both numbers are negative");
        }
    }
}
