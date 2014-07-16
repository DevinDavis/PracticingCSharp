using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractingCsharp
{
    class Arrays
    {
        static void Main(string[] args)
        {   // Arrays always start with 0
            int[] a = { 10, 20, 30, 40, 50, 50 };

            Console.WriteLine(a[3]);
            a[4] = 45;
            Console.WriteLine(a[4]);

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a[" + i + "] = "+ a[i]);
            }
            Console.WriteLine("------------------------")
            foreach (int var in a)
            {
                Console.WriteLine(var);
            }
        }
    }
}
