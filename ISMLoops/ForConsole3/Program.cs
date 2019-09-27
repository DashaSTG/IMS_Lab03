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
            Console.WriteLine("Введите значение a и n:");
            string[] number = Console.ReadLine().Split(' ');
            double a;
            if (double.TryParse(number[0], out a))
            {

            }
            else
            {
                Console.WriteLine("Неверное значение!");
            }

            int n;
            if (int.TryParse(number[1], out n))
            {
            }
            else
            {
                Console.WriteLine("Неверное значение!");
            }

            double power = 1;
            for (int i = 1; i <= n; i++)
            {
                power *= a;
            }
            Console.WriteLine($"результат = {power}");

        }
    }
}

