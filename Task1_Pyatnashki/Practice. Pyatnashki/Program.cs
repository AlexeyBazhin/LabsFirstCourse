using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyatnashki
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = 0;//размер игрового поля
            string moves = "";//набор команд, ходы

            using (StreamReader sr = new StreamReader("INPUT.TXT"))
            {
                fieldSize = Int32.Parse(sr.ReadLine());
                moves = sr.ReadLine();
            }

            int[,] playingField = new int[fieldSize, fieldSize];//игровое поле
            for (int i = 0; i < fieldSize; i++)                 //заполнение игрового поля
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    playingField[i, j] = i * fieldSize + j + 1;
                }
            }
            playingField[fieldSize - 1, fieldSize - 1] = 0;     //ячейка в правом нижнем углу является пустой (равна 0)


            string outputStr = "";//выводимая информация
            int failMove = 0;     //номер хода, на котором была допущена ошибка

            //если строка с ходами незаполнена или выполнить все команды нельзя
            if (moves == null || IsRealizible(ref playingField, moves, out failMove))
            {
                outputStr = FieldToString(playingField);
            }
            else
            {
                outputStr = "ERROR " + (failMove + 1);
            }

            using (StreamWriter sw = new StreamWriter("OUTPUT.TXT"))
            {
                sw.Write(outputStr);
            }
        }

        //изменение игрового поля, если с полученным набором команд это сделать невозможно, то возвращается false
        static bool IsRealizible(ref int[,] playingField, string moves, out int strokeNumber)
        {
            int fieldSize = playingField.GetLength(0);            

            int emptyRow = fieldSize - 1;//строка, на которой находится пустая ячейка
            int emptyCol = fieldSize - 1;//столбец, на котором находится пустая ячейка

            strokeNumber = 0;
            while (strokeNumber < moves.Length)
            {
                switch (moves[strokeNumber])
                {
                    case 'U':
                        if (emptyRow == 0)
                        {
                            return false;
                        }
                        playingField[emptyRow, emptyCol] = playingField[emptyRow - 1, emptyCol];
                        playingField[emptyRow - 1, emptyCol] = 0;
                        --emptyRow;
                        break;

                    case 'D':
                        if (emptyRow == fieldSize - 1)
                        {
                            return false;
                        }
                        playingField[emptyRow, emptyCol] = playingField[emptyRow + 1, emptyCol];
                        playingField[emptyRow + 1, emptyCol] = 0;
                        ++emptyRow;
                        break;

                    case 'L':
                        if (emptyCol == 0)
                        {
                            return false;
                        }
                        playingField[emptyRow, emptyCol] = playingField[emptyRow, emptyCol - 1];
                        playingField[emptyRow, emptyCol - 1] = 0;
                        --emptyCol;
                        break;

                    case 'R':
                        if (emptyCol == fieldSize - 1)
                        {
                            return false;
                        }
                        playingField[emptyRow, emptyCol] = playingField[emptyRow, emptyCol + 1];
                        playingField[emptyRow, emptyCol + 1] = 0;
                        ++emptyCol;
                        break;

                    default:
                        return false;
                }
                strokeNumber++;
            }
            return true;
        }

        //преобразование матрицы в строковый тип
        static string FieldToString(int[,] playingField)
        {
            string str = "";
            for (int i = 0; i < playingField.GetLength(0); i++)
            {
                for (int j = 0; j < playingField.GetLength(1); j++)
                {
                    str += playingField[i, j] + " ";
                }
                str += "\n";
            }
            return str;
        }

    }
}