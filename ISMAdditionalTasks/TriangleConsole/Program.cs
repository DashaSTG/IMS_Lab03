using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координаты точки M (х, у) через пробел: ");
            string[] MLocation = Console.ReadLine().Split(' ');
            double x = double.Parse(MLocation[0]);
            double y = double.Parse(MLocation[1]);

            Console.Write("Введите координаты вершины А (х1, у1) через пробел: ");
            string[] ALocation = Console.ReadLine().Split(' ');
            double x1 = double.Parse(ALocation[0]);
            double y1 = double.Parse(ALocation[1]);

            Console.Write("Введите координаты вершины В (х2, у2) через пробел: ");
            string[] BLocation = Console.ReadLine().Split(' ');
            double x2 = double.Parse(BLocation[0]);
            double y2 = double.Parse(BLocation[1]);

            Console.Write("Введите координаты вершины С (х3, у3) через пробел: ");
            string[] CLocation = Console.ReadLine().Split(' ');
            double x3 = double.Parse(CLocation[0]);
            double y3= double.Parse(CLocation[1]);

            double a = (x1 - x) * (y2 - y1) - (x2 - x1) * (y1 - y);
            double b = (x2 - x) * (y3 - y2) - (x3 - x2) * (y2 - y);
            double c = (x3 - x) * (y1 - y3) - (x1 - x3) * (y3 - y);

            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
            {
                Console.WriteLine("Принадлежит треугольнику");
            }
            else
            {
                Console.WriteLine("Не принадлежит треугольнику");
            }


        }
    }
}
