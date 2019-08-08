using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0601A2Felderrechnen
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte[] feld = new sbyte[10];
            Random zuf = new Random();
            int sum=0;
            sbyte min=127, max=0, avg=0;

            //        geht nicht, weil das foreach-element kein lvalue ist!
            //          foreach (sbyte f in feld)
            //              f = (sbyte)(zuf.Next(1,33));

            for (int i = 0; i < 10; i++)
            {
                feld[i] = (sbyte)(zuf.Next(1, 33));
            }

            foreach (var f in feld)
            {
                min = Math.Min(min, f);
                max = Math.Max(max, f);
                sum += f;
            }
            Console.WriteLine("Min={0} Max={1} Sum={2} Avg={3}", min, max, sum, sum / 10);


        }
    }
}
