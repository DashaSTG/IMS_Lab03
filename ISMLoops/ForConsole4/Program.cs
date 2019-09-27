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
            Console.WriteLine("Введите значение a и b:");
            string[] number = Console.ReadLine().Split(' ');

            int a, b;
            if (int.TryParse(number[0], out a))
            {

            }
            else
            {
                Console.WriteLine("Неверное значение!");
            }

            if (int.TryParse(number[1], out b))
            {
            }
            else
            {
                Console.WriteLine("Неверное значение!");
            }

            int result = 0;
            for (int i = a; i <= b; i++)
            {
                result += i*i;
            }
            Console.WriteLine($"результат = {result}");

        }
    }
}

