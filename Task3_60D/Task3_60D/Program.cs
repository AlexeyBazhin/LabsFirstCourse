using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_60D
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\n_______________\n");
                double
                    u,
                    x = doubleInput("координату по X"),
                    y = doubleInput("координату по Y");

                if (y > Math.Abs(x) && y * y + x * x < 1)
                {
                    u = Math.Sqrt(Math.Abs(x * x - 1));
                    Console.WriteLine("Точка входит в область");
                }
                else
                {
                    u = x + y;
                    Console.WriteLine("Точка не входит в область");
                }

                Console.WriteLine("u = " + u);
                Console.Write("\nНажмите ПРОБЕЛ, если желаете выйти из программы, либо другую клавишу, если хотите провести вычисления еще раз...");
            }while(Console.ReadKey().KeyChar != ' ');
            
        }

        //ввод вещественного числа
        static double doubleInput(string info)
        {
            double n;
            Console.Write($"Введите {info}: ");
            while (!Double.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine($"Ошибка! Введите действительное число в диапазоне от {Double.MinValue} до {Double.MaxValue}.");
                Console.Write($"Введите {info}: ");
            }
            return n;
        }
    }
}
