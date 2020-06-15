using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_401
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("_______________\n");
                int n = IntInput("порядок матрицы", 1, Int32.MaxValue);
                int i = 0, j = 0;

                if (n != 1)
                {
                    i = IntInput("строку для удаления", 1, n);
                    j = IntInput("столбец для удаления", 1, n);
                }

                int[,] matrix = new int[n, n];
                FillMatrix(ref matrix);
                Console.WriteLine("\nИсходная матрица:\n");
                Print(matrix);

                if (n != 1)
                {
                    DeleteRow(ref matrix, i - 1);
                    DeleteColumn(ref matrix, j - 1);
                }
                else
                {
                    matrix = new int[0,0];
                }

                Console.WriteLine("\nИзмененная матрица:\n");
                Print(matrix);
                Console.WriteLine("\nНажмите ПРОБЕЛ, если желаете выйти из программы, либо другую клавишу, если хотите провести вычисления еще раз...");
            }
            while(Console.ReadKey().KeyChar != ' ');
        }

        //удаление строки по индексу
        static void DeleteRow(ref int[,] matrix, int deleteIndex)
        {
            int[,] modifiedMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];

            for (int i = 0; i < deleteIndex; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    modifiedMatrix[i, j] = matrix[i, j];
                }
            }

            for (int i = deleteIndex + 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    modifiedMatrix[i - 1, j] = matrix[i, j];
                }
            }

            matrix = modifiedMatrix;
        }

        //удаление столбца по индексу
        static void DeleteColumn(ref int[,] matrix, int deleteIndex)
        {

            int[,] modifiedMatrix = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < deleteIndex; j++)
                {
                    modifiedMatrix[i, j] = matrix[i, j];
                }

                for (int j = deleteIndex + 1; j < matrix.GetLength(1); j++)
                {
                    modifiedMatrix[i, j - 1] = matrix[i, j];
                }
            }

            matrix = modifiedMatrix;
        }

        //заполнение матрицы с помощью ДСЧ
        static void FillMatrix(ref int[,] matrix)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(-50, 50);
                }
            }
        }

        //печать двумерного массива
        static void Print(int[,] matrix)
        {
            if (matrix.GetLength(0) == 0)
            {
                Console.WriteLine("Матрица стала пустой!");
                return;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0, 5}", matrix[i, j]));
                }
                Console.WriteLine();
            }
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
