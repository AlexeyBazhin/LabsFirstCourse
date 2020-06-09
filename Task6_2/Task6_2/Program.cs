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
        public static bool isGreaterM,//Критерий "элемент больше М"
                           isZero;    //Один из членов последовательности стал равен нулю, дальнейшие вычисления не возможны. Пример входных данных: 4, -8, 2

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\n_______________\n");
                List<double> sequence = new List<double>();
                sequence.Add(DoubleInput("первый член последовательности"));
                sequence.Add(DoubleInput("второй член последовательности"));
                sequence.Add(DoubleInput("третий член последовательности"));

                mLimit = DoubleInput("ограничение по M");
                n = IntInput("кол-во элементов N", 4, Int32.MaxValue);

                isGreaterM = false;
                isZero = false;

                GetSequence(ref sequence, n - 1);
                //GetSequence(ref sequence, 3); отброшенный вариант реализации

                for (int i = 0; i < sequence.Count; i++)
                    Console.WriteLine($"{i + 1}) " + sequence[i]);

                Console.WriteLine("\nПричина остановки: ");

                if (sequence.Count == n)
                    Console.WriteLine("\nВ последовательности N элементов.");
                else
                {
                    if (isGreaterM)
                        Console.WriteLine("Последний элемент больше M.");

                    if (isZero)
                        Console.WriteLine("\nНевозможно вычислить следующий элемент, так как текущий равен нулю.");
                }

                Console.Write("\nНажмите ПРОБЕЛ, если желаете выйти из программы, либо другую клавишу, если хотите провести вычисления еще раз...");
            } while (Console.ReadKey().KeyChar != ' ');
        }


        //Данный вариант реализации рекурсивного получения последовательности был отброшен, так как мне показалась, что это не совсем "корректная" рекурсия. 
        //Метод, по сути, работает по принципу цикла с параметром, ничего не возвращает, только добавляет данные в список
        //static void GetSequence(ref List<double> sequence, int i)
        //{
        //    double currentMember = sequence[i - 2] / sequence[i - 1] + Math.Abs(sequence[i - 3]);
        //    sequence.Add(currentMember);

        //    if (currentMember == 0)
        //        isZero = true;

        //    if (currentMember > mLimit)
        //        isGreaterM = true;

        //    if (isZero || isGreaterM || i == n - 1)
        //        return;

        //    GetSequence(ref sequence, i + 1);
        //}

        static double GetSequence(ref List<double> sequence, int i)

        {
            if (sequence.Count > i)//если член последовательности уже вычислен
            {
                return sequence[i];
            }

            double
                numerator = GetSequence(ref sequence, i - 2),  //a(k - 1) числитель первого слагаемого в формуле пос-ти
                denominator = GetSequence(ref sequence, i - 1),//a(k - 2)знаменатель первого слагаемого в формуле пос-ти
                moduleTerm = GetSequence(ref sequence, i - 3); //a(k - 3) второе слагаемое, стоит под модулем

            if (isGreaterM || isZero) return 0;                //если в результате рекурсивных вычислений слагаемых какой-либо член последовательности стал равен 0 или больше М

            if (denominator == 0)
            {
                isZero = true;
                return 0;
            }

            double currentMember = numerator / denominator + Math.Abs(moduleTerm);
            sequence.Add(currentMember);
            isGreaterM = isGreaterM || currentMember > mLimit;
            return currentMember;
        }

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
