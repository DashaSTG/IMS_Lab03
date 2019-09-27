using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, x;
            do
            {
                 x = int.Parse(Console.ReadLine());
                sum += x;
            } while (x != 0);
            Console.WriteLine($"сума = {sum}");
        }
    }
}
