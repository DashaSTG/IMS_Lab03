using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение n");
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {

            }
            else
            {
                Console.WriteLine("Неверное значение!");
            }

            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += Math.Pow(i, n-i+1);
            }
            Console.WriteLine($"результат = {result}");
        }
    }
}
