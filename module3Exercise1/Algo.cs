using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3Exercise1
{
    public  class Algo
    {

        public  int FindGCDEuclid(int a, int b, out long time)
        {
            time = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (a == 0) return b;
            
            while (b != 0)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            sw.Stop();
            time = sw.ElapsedTicks;
            return a;

        }

        public  int FindGCDEuclid(int a, int b, int c, out long time)
        {
            int d = FindGCDEuclid(a, b, out time);
            int e = FindGCDEuclid(d, c, out time);
            return e;
        }

        public  int FindGCDEuclid(int a, int b, int c, int d, out long time)
        {
            int e = FindGCDEuclid(a, b, c, out time);
            int f = FindGCDEuclid(e, d, out time);
            return f;
        }

        public  int FindGCDEuclid(int a, int b, int c, int d,int e, out long time)
        {
            int f = FindGCDEuclid(a, b, c, d, out time);
            int g = FindGCDEuclid(f, e, out time);
            return g;
        }

    }
}
