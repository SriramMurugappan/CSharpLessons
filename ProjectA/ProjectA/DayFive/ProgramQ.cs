using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ProjectA.DayFive

{
    internal class ProgramQ
    {
        int v1 = 1000;
        
        public static void Dotask(int x)
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }
        
        public static void DoTaskA(int x) 
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }
        public static void TestOne()
        {
            int v1 = 1000;
            Console.WriteLine($"v1: {v1}");
            DoTaskA(v1);
            Console.WriteLine($"v1: {v1}");
            DoTaskA(v1);
            Console.WriteLine($"v1: {v1}");
        }

        
     
    }
}
