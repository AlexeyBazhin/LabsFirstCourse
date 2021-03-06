﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_840
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            bool isCorrectWord = true;
            char[] alphabet = new char[2];
            alphabet[0] = '0';
            alphabet[1] = '1';
            string word = "";
            do
            {
                Console.WriteLine();
                PrintMenu();
                Console.Write("Введите пункт меню: ");                
                switch(Console.ReadKey().KeyChar)
                {
                    case '1':
                        Console.WriteLine("\n\nВведите последовательность: ");
                        word = Console.ReadLine();
                        foreach (var item in word)
                            if (item != alphabet[0] && item != alphabet[1])
                                isCorrectWord = false;
                        isCorrectWord = isCorrectWord && (word.Length > 0);
                        if (!isCorrectWord)
                            Console.WriteLine("Последовательность состоит не из бинарного алфавита!");
                        break;

                    case '2':
                        if (isCorrectWord)
                        {
                            Console.WriteLine("\n\nИзначальная последовательность:\n" + word);
                            word = Encrypt(word, alphabet);
                            Console.WriteLine("\nЗашифрованная последовательность:\n" + word);
                        }
                        else
                        {
                            Console.WriteLine("\n\nСначала введите бинарную последовательность!");
                        }
                        break;

                    case '3':
                        if (isCorrectWord)
                        {
                            Console.WriteLine("\n\nЗашифрованная последовательность:\n" + word);
                            word = Decrypt(word, alphabet);
                            Console.WriteLine("\nРасшифрованная последовательность:\n" + word);
                        }
                        else
                        {
                            Console.WriteLine("\n\nСначала введите бинарную последовательность!");
                        }
                        break;

                    case '4':
                        Console.Clear();
                        break;

                    case '0':
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("\n\nВведен неверный пункт меню!");
                        break;
                }
            } while (!exit);
        }

        //
        //Зашифровать последовательность
        //
        static string Encrypt(string word, char[] alphabet)
        {
            string encryptWord = word[0].ToString();

            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] == word[i - 1])
                    encryptWord += alphabet[1];
                else
                    encryptWord += alphabet[0];
            }

            return encryptWord;
        }
        //
        //Расшифровка последовательности
        //
        static string Decrypt(string word, char[] alphabet)
        {
            string decryptWord = word[0].ToString();

            for (int i = 1; i < word.Length; i++)
            {                
                if (word[i] == alphabet[1])
                    decryptWord += decryptWord[i - 1];
                else
                {
                    if (decryptWord[i - 1] == alphabet[0])
                        decryptWord += alphabet[1];
                    else
                        decryptWord += alphabet[0];
                }
            }
            return decryptWord;
        }
        //
        //Печать пользовательского меню
        //
        static void PrintMenu()
        {
            Console.WriteLine("1) Ввести новую последовательность");
            Console.WriteLine("2) Зашифровать последовательность");
            Console.WriteLine("3) Расшифровать последовательность");
            Console.WriteLine("4) Очистить консоль (данные сохраняются)");
            Console.WriteLine("0) Выйти из программы");
        }

    }
}
