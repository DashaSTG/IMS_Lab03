using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonConsole_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double s = 0;
            int x1, x2, y1, y2;
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("x1 = ");

            x1 = int.Parse(Console.ReadLine());
            Console.Write("y1 = ");

            y1 = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine();

                Console.Write($"x{i} = ");
                x2 = int.Parse(Console.ReadLine());

                Console.Write($"y{i} = ");
                y2 = int.Parse(Console.ReadLine());

                s += (x1 + x2) * (y1 - y2);
                x1 = x2;
                y1 = y2;
            }

            s = Math.Abs(0.5 * s);
            Console.WriteLine($"\nПлощадь s = {s}");
        }
    }
}
