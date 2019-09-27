using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение n и k:");
            string[] number = Console.ReadLine().Split(' ');

            int n, k;
            if (int.TryParse(number[0], out n))
            {

            }
            else
            {
                Console.WriteLine("Неверное значение!");
            }

            if (int.TryParse(number[1], out k))
            {
            }
            else
            {
                Console.WriteLine("Неверное значение!");
            }

            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += Math.Pow(i, k);
            }
            Console.WriteLine($"результат = {result}");

        }
    }
}

