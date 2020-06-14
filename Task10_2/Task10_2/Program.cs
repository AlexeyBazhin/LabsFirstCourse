using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task10_2
{
    class Program
    {       
        static void Main(string[] args)
        {
            string outLine = "";
            bool falseInput = false;
            List<Element> firstPoly = new List<Element>();
            List<Element> secondPoly = new List<Element>();

            Input("FirstPolynomial.TXT", ref firstPoly, ref outLine, ref falseInput);

            if (falseInput)
            {
                Output(outLine);
                return;
            }

            Input("SecondPolynomial.TXT", ref secondPoly, ref outLine, ref falseInput);

            if (falseInput)
            {
                Output(outLine);
                return;
            }

            firstPoly.Sort();
            secondPoly.Sort();

            List<Element> finalPoly = new List<Element>();
            foreach (var item in firstPoly)
                finalPoly.Add(item);

            foreach (var item in secondPoly)
            {
                var element = firstPoly.Where(x => x.degree == item.degree);
                if (element.Count() != 0)
                {
                    Element elem = (Element)element.First();
                    element.First().coeff += item.coeff;
                }
                else
                    finalPoly.Add(item);                
            }

            finalPoly.Sort();

            foreach (var item in finalPoly)
                outLine += item.ToString() + "\n";

            Output(outLine);
        }

        static void Input(string filename, ref List<Element> poly, ref string outLine, ref bool falseInput)
        {
            string inLine;

            using (StreamReader sr = new StreamReader(filename))
            {
                while ((inLine = sr.ReadLine()) != null)
                {
                    string[] elemArgs = inLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    try
                    {
                        if (elemArgs.Length == 2)
                        {
                            int degree = Int32.Parse(elemArgs[0]);
                            int coeff = Int32.Parse(elemArgs[1]);

                            if (coeff != 0)
                            {
                                bool degreeRepeat = false;
                                foreach (var item in poly)
                                {
                                    if (degree == item.degree)
                                    {
                                        degreeRepeat = true;
                                        break;
                                    }
                                }

                                if (!degreeRepeat)
                                    poly.Add(new Element(degree, coeff));
                                else
                                {
                                    outLine = "Ошибка ввода! Одночлен с таким показателем степени уже был введен!";
                                    falseInput = true;
                                    return;
                                }

                            }
                        }
                        else
                        {
                            if (elemArgs.Length != 0)
                            {
                                outLine = "Ошибка ввода! Строка должна содержать 2 целых числа.";
                                falseInput = true;
                                return;
                            }
                        }
                    }
                    catch (FormatException e)
                    {
                        outLine = "Ошибка ввода! Вводите только целые числа.";
                        falseInput = true;
                        return;
                    }
                }
            }
        }

        static void Output(string outLine)
        {
            using (StreamWriter sw = new StreamWriter("OUTPUT.TXT"))
            {
                sw.Write(outLine);
            }
        }
    }
}
