using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_3_WinForms_
{
    class Rib
    {
        public string beg;
        public string end;
        public Rib(string beg, string end)
        {
            this.beg = beg;
            this.end = end;
        }
        public override bool Equals(object obj)
        {
            Rib rib = (Rib)obj;
            return (this.beg == rib.beg && this.end == rib.end) ||
                   (this.beg == rib.end && this.end == rib.beg);
        }

        public override int GetHashCode()
        {
            return beg.Length + end.Length;
        }

    }
}
