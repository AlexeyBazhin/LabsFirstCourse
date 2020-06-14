using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12_9_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = IntInput("количество элементов массива", 1, Int32.MaxValue);
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rnd.Next(1000);
                arr2[i] = arr1[i];
            }

            ulong comparisons = 0, swaps = 0;

            Console.WriteLine("\n\nНеупорядоченный массив:");            
            SelectionSort(arr1, out comparisons, out swaps);
            Console.WriteLine($"Сортировка простым выбором: сравнения:{comparisons}, пересылки: {swaps}");
            comparisons = 0; swaps = 0;
            QuickSort(ref arr2, 0, arr2.Length - 1, ref comparisons, ref swaps);
            Console.WriteLine($"Быстрая сортировка: сравнения:{comparisons}, пересылки: {swaps}");

            Console.WriteLine("\n\nУпорядоченный по возрастанию массив:");
            comparisons = 0; swaps = 0;
            SelectionSort(arr1, out comparisons, out swaps);
            Console.WriteLine($"Сортировка простым выбором: сравнения:{comparisons}, пересылки: {swaps}");
            comparisons = 0; swaps = 0;
            QuickSort(ref arr2, 0, arr2.Length - 1, ref comparisons, ref swaps);
            Console.WriteLine($"Быстрая сортировка: сравнения:{comparisons}, пересылки: {swaps}");

            Array.Reverse(arr1);
            Array.Reverse(arr2);

            Console.WriteLine("\n\nУпорядоченный по убыванию массив:");
            comparisons = 0; swaps = 0;
            SelectionSort(arr1, out comparisons, out swaps);
            Console.WriteLine($"Сортировка простым выбором: сравнения:{comparisons}, пересылки: {swaps}");
            comparisons = 0; swaps = 0;
            QuickSort(ref arr2, 0, arr2.Length - 1, ref comparisons, ref swaps);
            Console.WriteLine($"Быстрая сортировка: сравнения:{comparisons}, пересылки: {swaps}");

            Console.ReadKey();
        }

        static void SelectionSort(int[] arr, out ulong comparisons, out ulong swaps)
        {
            int min, temp;
            comparisons = 0;
            swaps = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    comparisons++;
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                    swaps++;
                }
            }
        }

        static void QuickSort(ref int[] arr, int left, int right, ref ulong swaps, ref ulong comparisons)
        {
            int i = left, j = right;            
            int pivot = arr[(i + j) / 2];

            do
            {
                while (arr[i] < pivot) i++;
                while (arr[j] > pivot) j--;
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                    swaps++;
                }
                comparisons++;
            } while (i <= j);

            if (left < j) QuickSort(ref arr, left, j, ref swaps, ref comparisons);
            if (right > i) QuickSort(ref arr, i, right, ref swaps, ref comparisons);
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
