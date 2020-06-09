
//using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Pyatnashki
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int fieldSize = 0;
//            string moves = "";

//            using (StreamReader sr = new StreamReader("INPUT.TXT"))
//            {
//                fieldSize = Int32.Parse(sr.ReadLine());
//                moves = sr.ReadLine();
//            }

//            int[,] playingField = new int[fieldSize, fieldSize];

//            for (int i = 0; i < fieldSize; i++)
//                for (int j = 0; j < fieldSize; j++)
//                    playingField[i, j] = i * fieldSize + j + 1;

//            playingField[fieldSize - 1, fieldSize - 1] = 0;
//            int emptyCellRow = fieldSize - 1;
//            int emptyCellColumn = fieldSize - 1;


//            int strokeNumber = 0;
//            bool error = false;
//            string outputStr = "";
//            while (strokeNumber < moves.Length && !error)
//            {
//                switch (moves[strokeNumber])
//                {
//                    case 'U':
//                        {
//                            if (emptyCellRow != 0)
//                            {
//                                playingField[emptyCellRow, emptyCellColumn] = playingField[emptyCellRow - 1, emptyCellColumn];
//                                playingField[emptyCellRow - 1, emptyCellColumn] = 0;
//                                --emptyCellRow;
//                            }
//                            else
//                                error = true;
//                            break;
//                        }

//                    case 'D':
//                        {
//                            if (emptyCellRow != fieldSize - 1)
//                            {
//                                playingField[emptyCellRow, emptyCellColumn] = playingField[emptyCellRow + 1, emptyCellColumn];
//                                playingField[emptyCellRow + 1, emptyCellColumn] = 0;
//                                ++emptyCellRow;
//                            }
//                            else
//                                error = true;
//                            break;
//                        }

//                    case 'L':
//                        {
//                            if (emptyCellColumn != 0)
//                            {
//                                playingField[emptyCellRow, emptyCellColumn] = playingField[emptyCellRow, emptyCellColumn - 1];
//                                playingField[emptyCellRow, emptyCellColumn - 1] = 0;
//                                --emptyCellColumn;
//                            }
//                            else
//                                error = true;
//                            break;
//                        }

//                    case 'R':
//                        {
//                            if (emptyCellColumn != fieldSize - 1)
//                            {
//                                playingField[emptyCellRow, emptyCellColumn] = playingField[emptyCellRow, emptyCellColumn + 1];
//                                playingField[emptyCellRow, emptyCellColumn + 1] = 0;
//                                ++emptyCellColumn;
//                            }
//                            else
//                                error = true;
//                            break;
//                        }

//                    default:
//                        error = true;
//                        break;
//                }
//                strokeNumber++;
//            }

//            if (!error)
//                outputStr = FieldToText(playingField);
//            else
//                outputStr = "ERROR " + strokeNumber;

//            using (StreamWriter sw = new StreamWriter("OUTPUT.TXT"))
//            {
//                sw.Write(outputStr);
//            }
//        }
//        static string FieldToText(int[,] playingField)
//        {
//            string str = "";
//            for (int i = 0; i < playingField.GetLength(0); i++)
//            {
//                for (int j = 0; j < playingField.GetLength(1); j++)
//                {
//                    str += playingField[i, j] + " ";
//                }
//                str += "\n";
//            }
//            return str;
//        }
//        static int IntInput(int leftBorder, int rightBorder)
//        {
//            int n;
//            while (!Int32.TryParse(Console.ReadLine(), out n) ||
//                  n < leftBorder || n > rightBorder) { }
//            return n;
//        }

//    }
//}
