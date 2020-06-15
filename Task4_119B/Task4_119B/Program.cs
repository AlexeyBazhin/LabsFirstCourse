using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_119B
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\n_______________\n");
                Console.WriteLine("Вычисление бесконечной суммы 1 / (i*(i+1)):");
                double
                    sum = 0,
                    nextTerm = 0,
                    eps = doubleInput("точность вычислений (эпсилон)");
                int i = 1;
                do
                {
                    nextTerm = 1.0 / (i * (i + 1));
                    sum += nextTerm;
                    i++;
                } while (eps <= Math.Abs(nextTerm));

                Console.WriteLine("Результат вычисленний с заданной точностью: " + sum);
                Console.Write("\nНажмите ПРОБЕЛ, если желаете выйти из программы, либо другую клавишу, если хотите провести вычисления еще раз...");                
            } while (Console.ReadKey().KeyChar != ' ');
        }
        
        //ввод вещественного числа большего 0
        static double doubleInput(string info)
        {
            double n;
            Console.Write($"Введите {info}: ");
            while (!Double.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine($"Ошибка! Введите действительное число в диапазоне от {0} до {Double.MaxValue}.");
                Console.Write($"Введите {info}: ");
            }
            return n;
        }
    }
}
