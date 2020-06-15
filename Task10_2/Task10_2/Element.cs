using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_2
{
    class Element: IComparable
    {
        public int degree;//показатель степени
        public int coeff;//коэффициент при одночлене
        public Element()
        {
            this.degree = 0;
            this.coeff = 0;
        }

        public Element(int degree, int coeff)
        {
            this.degree = degree;
            this.coeff = coeff;
        }

        public override string ToString()
        {
            return $"{degree} {coeff}";
        }

        public int CompareTo(object obj)
        {
            Element point = (Element)obj;
            if (this.degree > point.degree) return 1;
            if (this.degree < point.degree) return -1;
            return 0;
        }

        public override bool Equals(object obj)
        {
            Element point = (Element)obj;
            return (point.coeff == this.coeff) && (point.degree == this.degree);
        }

        public override int GetHashCode()
        {
            return degree + coeff;
        }
    }
}
