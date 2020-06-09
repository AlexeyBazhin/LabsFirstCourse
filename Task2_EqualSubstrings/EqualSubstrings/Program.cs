using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr;
            using (StreamReader sr = new StreamReader("INPUT.TXT"))
            {
                inputStr = sr.ReadLine();
            }

            int maxLength = 0;
            int i = 0;
            int charLastIndex;
            //Проходим по всем символам строки, кроме последнего, или пока кол-во оставшихся символов не станет меньше чем уже найденная максимальная длина.
            //У "текущего" символа ищем его самое последнее вхождение в строке. Если последнее вхождение не равно текущему, то подстроки, включающие эти индексы, будут равны.
            while (i < inputStr.Length - 1 && maxLength < inputStr.Length - i - 1)
            {
                charLastIndex = inputStr.LastIndexOf(inputStr[i]);
                if (charLastIndex != i && charLastIndex - i > maxLength)
                {
                    maxLength = charLastIndex - i;
                }                
                i++;
            }

            using (StreamWriter sw = new StreamWriter("OUTPUT.TXT"))
            {
                sw.Write(maxLength);
            }
        }
    }
}
