﻿using System;
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

            int k = 1;
            while (Math.Pow(3, k) <= n)
            {
                k++;
            }
            Console.WriteLine($"k = {k}");
        }
    }
}
