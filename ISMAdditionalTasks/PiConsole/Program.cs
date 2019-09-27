using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение n: ");
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {

            }
            else
            {
                Console.WriteLine("Неверное значение!");
            }

            double result = 1, x = 0;

            for(int i = 1; i <= n; i++)
            {
                x = Math.Sqrt(0.5 + 0.5 * Math.Sqrt(x));
                result *= x;
            }
            double piViet = 2.0 / result;

            result = 1;
            for(int i = 1; i <= n; i += 2)
            {
                result *= (i * (i + 2.0)) / ((i + 1.0) * (i + 1.0));
            }
            double piWallis = 2 / result;

            result = 0;
            for (int i = 1; i <= n; i += 4)
            {
                result += 1.0 / i - 1.0 / (i + 2);
            }
            double piLeibniz = 4 * result;

            x = n * 2 - 1;
            for (double i = x - 2; i >= 1; i -= 2)
            {
                x = 2 + (Math.Pow(i, 2) / Math.Pow(x, 2));
            }
            x = x - 1;
            double piBrouncker = 4.0 / x;

            Console.WriteLine($"pi по формуле Виета = {piViet}\n" +
                $"pi по формуле Уоллиса = {piWallis}\n" +
                $"pi по формуле Лейбница = {piLeibniz}\n" +
                $"pi по формуле Брункера = {piBrouncker}");
        }
    }
}
