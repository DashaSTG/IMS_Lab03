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
            Console.WriteLine("Введите значение p: ");
            double p;
            if (double.TryParse(Console.ReadLine(), out p))
            {

            }
            else
            {
                Console.WriteLine("Неверное значение!");
            }

            double startDistance = 10;
            double distance = 10;
            int k = 1;
            while (distance <= 200)
            {
                distance += startDistance * p / 100.0;
                k++;
                startDistance += startDistance * p / 100.0;
            }
            Console.WriteLine($"k = {k}, distance = {distance}");
        }
    }
}
