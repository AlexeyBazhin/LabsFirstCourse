using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int argsCount = 3;            
            int[] vector = new int[(int) Math.Pow(2, argsCount)];//всего возможных комбинаций аргументов у функции 2^n
            int count = 1;
            Console.WriteLine("Все немонотонные Булевы функции от {0} аргументов (заданы вектором):\n", argsCount);
            for (int i = 0; i < Math.Pow(2, Math.Pow(2, argsCount)); i++)//всего возможных функций будет 2^(2^n)
            {
                string vectorStr = "";
                for (int j = 0; j < vector.Length; j++)
                    vectorStr += vector[j].ToString();

                if (!isMonotone(vectorStr))
                {
                    Console.WriteLine($"{count++}) " + vectorStr);
                }

                //if (!isMonotone(vector))
                //{
                //    Console.Write($"{count++}) ");
                //    PrintVector(vector);
                //}

                NextVector(ref vector);                              
            }

            Console.ReadKey();

        }

        //универсальный метод определения монотонности функции от n аргументов (сравниваются наборы значений).
        static bool isMonotone(string vectorStr)
        {
            string a = vectorStr.Substring(0, vectorStr.Length / 2);
            string b = vectorStr.Substring(vectorStr.Length / 2, vectorStr.Length / 2);

            for (int i = 0; i < a.Length; i++)
                if (a[i] > b[i])
                    return false;

            if (a.Length != 1)
                return isMonotone(a) && isMonotone(b);

            return true;
        }

        static void NextVector(ref int[] vector)
        {
            vector[vector.Length - 1]++;

            for (int i = vector.Length - 1; i >= 1; i--)
            {
                if (vector[i] == 2)
                {
                    vector[i] = 0;
                    vector[i - 1]++;
                }
                else
                    break;
            }
        }

        //(не используется)
        //метод решения для конкретного условия n = 3 (в основе лежит решение с помощью трехмерного куба)
        static bool isMonotone(int[] vector)
        {
            if (vector[0] == 1 &&
               (vector[1] == 0 || vector[2] == 0 || vector[4] == 0))
                return false;

            if (vector[1] == 1 &&
               (vector[3] == 0 || vector[5] == 0))
                return false;

            if (vector[2] == 1 &&
               (vector[3] == 0 || vector[6] == 0))
                return false;

            if (vector[3] == 1 && vector[7] == 0)
                return false;

            if (vector[4] == 1 &&
               (vector[5] == 0 || vector[6] == 0))
                return false;

            if (vector[5] == 1 && vector[7] == 0)
                return false;

            if (vector[6] == 1 && vector[7] == 0)
                return false;

            return true;
        }

        
        static void PrintVector(int[] currentVector)
        {
            for (int i = 0; i < currentVector.Length; i++)
            {
                Console.Write(currentVector[i]);
            }
            Console.WriteLine();
        }
    }
}
