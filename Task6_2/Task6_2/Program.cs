using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_2
{
    class Program
    {
        public static double mLimit;  //в формуле - M
        public static int n;          //в формуле - N
        public static bool isEqualN,  //критерий "в последовательности N элементов"
                           isGreaterM,//Критерий "элемент больше М"
                           isZero;    //Один из членов последовательности стал равен нулю, дальнейшие вычисления не возможны. Пример входных данных: 4, -8, 2

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\n_______________\n");
                double[] sequence = new double[3];
                sequence[0] = DoubleInput("первый член последовательности");
                sequence[1] = DoubleInput("второй член последовательности");
                sequence[2] = DoubleInput("третий член последовательности");

                mLimit = DoubleInput("ограничение по M");
                n = IntInput("кол-во элементов N", 4, Int32.MaxValue);

                Console.WriteLine("\n" + sequence[0]);
                Console.WriteLine(sequence[1]);
                Console.WriteLine(sequence[2]);

                isGreaterM = false;
                isEqualN = false;
                if (sequence[2] != 0)
                {
                    isZero = false;
                    GetSequence(ref sequence, n);
                }
                else
                {
                    isZero = true;
                }

                Console.WriteLine("\nПричина остановки: ");
                
                if (!isGreaterM && !isZero)
                {
                    Console.WriteLine("\nВ последовательности N элементов.");
                }
                else
                {
                    if (isGreaterM)
                    {
                        Console.WriteLine("\nПоследний элемент больше M.");
                    }

                    if (isZero)
                    {
                        Console.WriteLine("\nНевозможно вычислить следующий элемент, так как текущий равен нулю.");
                    }
                }

                Console.Write("\nНажмите ПРОБЕЛ, если желаете выйти из программы, либо другую клавишу, если хотите провести вычисления еще раз...");
            } while (Console.ReadKey().KeyChar != ' ');
        }
   
        //Рекурсивное получение последовательности
        static double GetSequence(ref double[] sequence, int i)
        {
            if (i != 4)
            {
                double temp = GetSequence(ref sequence, i - 1);
                sequence[0] = sequence[1];
                sequence[1] = sequence[2];
                sequence[2] = temp;
            }

            if (isZero || isGreaterM)
            {
                return 0;
            }

            
            if (sequence[2] == 0)
            {
                isZero = true;
                return 0;
            }

            double currentMember;
            currentMember = sequence[1] / sequence[2] + Math.Abs(sequence[0]);

            Console.WriteLine(currentMember);

            if (currentMember > mLimit)
            {
                isGreaterM = true;
                return 0;
            }

            return currentMember;           
        }

        //ввод вещественного числа
        static double DoubleInput(string info)
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

        //ввод целого числа
        static int IntInput(string info, int leftBorder, int rightBorder)
        {
            int n;
            Console.Write($"Введите {info}: ");
            while (!Int32.TryParse(Console.ReadLine(), out n)
                   || n < leftBorder || n > rightBorder)
            {
                Console.WriteLine($"Ошибка! Введите целое число в диапазоне от {leftBorder} до {rightBorder}.");
                Console.Write($"Введите {info}: ");
            }
            return n;
        }
    }
}
